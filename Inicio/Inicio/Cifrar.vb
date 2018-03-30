Option Explicit On
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Public Class Cifrar

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim nombre As String
        Dim bitspp1, bitspp2 As Short

        Using OpenFileDialog1 As New OpenFileDialog()
            With OpenFileDialog1
                .CheckFileExists = True
                .ShowReadOnly = False
                '.Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
                .Filter = "Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png|Imagen BMP (*.bmp)|*.bmp"
                .FilterIndex = 1
                If .ShowDialog = DialogResult.OK Then
                    btnGuardar.Enabled = False
                    pbImagenCifrada.Image = Nothing
                    tbTextoCifrar.Text = ""
                    tbTamImagen.Text = ""
                    tbTamImagen.Refresh()
                    imagen1 = New Bitmap(.FileName)
                    'imagen2 = New Bitmap(.FileName)
                    '----------------------------
                    imagen2 = New Bitmap(imagen1.Width, imagen1.Height, PixelFormat.Format24bppRgb)
                    imagen2.SetResolution(imagen1.HorizontalResolution, imagen1.VerticalResolution)
                    Dim g As Graphics = Graphics.FromImage(imagen2)
                    g.DrawImage(imagen1, 0, 0)
                    '------------------------
                    imagen2b = New Bitmap(imagen1.Width, imagen1.Height, PixelFormat.Format24bppRgb)
                    imagen2b.SetResolution(imagen1.HorizontalResolution, imagen1.VerticalResolution)
                    Dim g2 As Graphics = Graphics.FromImage(imagen2b)
                    g2.DrawImage(imagen1, 0, 0)
                    '------------------------
                    bitspp1 = imagen1.GetPixelFormatSize(imagen1.PixelFormat)
                    bitspp2 = imagen2.GetPixelFormatSize(imagen2.PixelFormat)
                    If imagen1.Width * imagen1.Width < 100 Then
                        MsgBox("Error: " & Chr(13) & "    La imagen tiene muy pocos píxeles")
                    Else
                        If bitspp2 < 24 Then
                            MsgBox("    (" & bitspp2 & " bits por píxel) " & Chr(13) & "    La imagen debe tener, al menos, 24 bpp")
                        Else
                            ' Mostramos la imagen en el control PictureBox
                            name_img = .FileName
                            nombre = Extraer_nombre_file(.FileName)
                            pbImagen.ImageLocation = .FileName
                            num_pixeles = imagen1.Width * imagen1.Height
                            tbInformacion.Text = "Nombre: " & nombre & vbNewLine
                            tbInformacion.Text = tbInformacion.Text & "Tamaño: " & imagen1.Width & "x" & imagen1.Height & Chr(13)
                            tbInformacion.Text = tbInformacion.Text & "       (" & bitspp1 & " bits/pixel)" & Chr(13)
                            tbInformacion.Text = tbInformacion.Text & "       (" & str_Tamano_file(FileSystem.FileLen(.FileName)) & ")" & Chr(13) & Chr(13)
                            tbInformacion.Text = tbInformacion.Text & "Capacidad para encriptar:" & Chr(13)
                            tbInformacion.Text = tbInformacion.Text & "  Normal: " & str_Tamano_file(Int(3 * (imagen1.Width * imagen1.Height - 21) / 8)) & Chr(13)
                            tbInformacion.Text = tbInformacion.Text & "  Fuerte:   " & str_Tamano_file(Int(1 * (imagen1.Width * imagen1.Height - 21) / 8)) & Chr(13)
                            tbInformacion.SelectionStart = 8
                            tbInformacion.SelectionLength = nombre.Length
                            tbInformacion.SelectionColor = Color.Blue
                        End If
                    End If
                End If
            End With
        End Using
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
        Inicio.Show()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        tbTextoCifrar.Text = ""
        tbInformacion.Text = ""
        pbImagen.ImageLocation = ""
        pbImagen.Refresh()
        pbImagenCifrada.ImageLocation = ""
        tbTamImagen.Text = ""
        estado_PB2 = 0
        hallada_img2b = False
        pbImagenCifrada.Image = Nothing
        btnGuardar.Enabled = False
    End Sub

    Private Sub btnCifrar_Click(sender As Object, e As EventArgs) Handles btnCifrar.Click
        If Comprobar_entrada() Then
            imagen2 = imagen1.Clone
            indice_pixel = 1
            indice_color = 0
            num_img = 1
            long_datos = 0
            long_datos = long_datos + 2 + tbTextoCifrar.TextLength  ' en bytes
            indice_datos = 0 ' bytes escritos (sin cabeceras)
            If HaySitio() Then
                Cursor = System.Windows.Forms.Cursors.WaitCursor
                Call Hallar_fecha_hora()
                Call Hallar_offset()
                Call Escribir_cabecera()
                clavebis = Modificar_clave(clavePrivada)
                indice_clave = 1
                indice_datos = 0 ' bytes escritos (sin cabeceras)
                Call Escribir_texto()
                'MsgBox("num datos=" & long_datos & vbNewLine & "ind_datos=" & indice_datos)
                pbImagenCifrada.Image = imagen2
                btnGuardar.Enabled = True
                'btnEnviar.Visible = True
                'btnEliminar.Visible = True
                Cursor = System.Windows.Forms.Cursors.Default
                btnGuardar.Focus()
                estado_PB2 = 1
                hallada_img2b = False
            Else
                MsgBox("La imagen no tiene píxeles suficientes para enviar el mensaje (" & str_Tamano_file(long_datos) & ")", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Function Comprobar_entrada() As Boolean
        Dim rta As Boolean
        Dim mensaje As String = "Errores:"
        rta = True

        If pbImagen.ImageLocation = "" Then
            mensaje = mensaje & Chr(13) & "  - Antes debes cargar una imagen"
            btnCargar.Focus()
            rta = False
        End If
        If tbTextoCifrar.TextLength = 0 Then
            mensaje = mensaje & Chr(13) & "  - No hay texto a encriptar"
            tbTextoCifrar.Focus()
            rta = False
        End If
        If Not (rta) Then
            MsgBox(mensaje)
        End If
        Return rta
    End Function

    Private Function HaySitio() As Boolean
        Dim rta As Boolean = True
        If ((long_datos - indice_datos) * 8 + 63) > num_pixeles Then
            rta = False
        End If
        Return rta
    End Function

    Private Sub Hallar_fecha_hora()
        'MsgBox(Today.Year & Today.Month & Today.Day & TimeOfDay.Hour & TimeOfDay.Minute & TimeOfDay.Second)
        fh_anho = Today.Year - 2000
        fh_mes = Today.Month
        fh_dia = Today.Day
        fh_hora = TimeOfDay.Hour
        fh_minuto = TimeOfDay.Minute
        fh_segundo = TimeOfDay.Second
    End Sub

    Private Sub Hallar_offset()
        Dim i As Integer
        offset = 0
        For i = 1 To clavePrivada.Length
            offset = offset + Asc(clavePrivada.Substring(i - 1, 1)) Mod 20
        Next
        offset = offset Mod 20
    End Sub

    Private Sub Escribir_cabecera()
        Dim dato1 As Byte = 0
        Dim dato2 As Byte = 0
        'MsgBox("F=" & Asc("F"))
        Call Escribir_dato_m1(Asc("F"), 8)
        Call Escribir_dato_m1(Asc("D"), 8)
        dato1 = dato1 + 1
        Call Escribir_dato_m1(dato1, 2)
        dato2 = 0
        If HaySitio() Then
            If num_img > 1 Then
                dato2 = 2
            End If
        Else
            dato2 = 1
        End If
        Call Escribir_dato_m1(dato2, 2)
        Call Escribir_dato_m1(fh_anho, 7)
        Call Escribir_dato_m1(fh_mes, 4)
        Call Escribir_dato_m1(fh_dia, 5)
        Call Escribir_dato_m1(fh_hora, 6)
        Call Escribir_dato_m1(fh_minuto, 6)
        Call Escribir_dato_m1(fh_segundo, 6)
        Call Escribir_dato_m1(num_img, 8)
        Call Escribir_dato_m1(0, 1) ' metodo normal
    End Sub

    Private Sub Escribir_texto()
        Dim largoH, largoL As Byte
        Dim i As Integer
        largoL = tbTextoCifrar.TextLength And &HFF
        largoH = tbTextoCifrar.TextLength >> 8
        Call Escribir_dato(largoH)
        Call Escribir_dato(largoL)
        indice_datos = indice_datos + 2
        For i = 1 To tbTextoCifrar.TextLength
            Call Escribir_dato(Module1.cifrar(Asc(tbTextoCifrar.Text.Substring(i - 1, 1))))
            indice_datos = indice_datos + 1
        Next
    End Sub

    Private Sub Escribir_dato_m1(ByVal dato As Byte, ByVal nbits As Short)
        Dim i As Short
        Dim fila, columna As Integer
        Dim bit As Byte
        Dim MyColor As Color
        Dim num_color As Byte
        If (num_pixeles - indice_pixel) < 3 Then
            MsgBox("Error: No hay píxeles suficientes")
            Call Reinicio()
        Else
            For i = nbits To 1 Step -1
                columna = Int((indice_pixel - 1) / imagen1.Width)
                fila = (indice_pixel - 1) Mod imagen1.Width
                'MsgBox("fila=" & fila & ", columna=" & columna)
                bit = GetBit(dato, i)
                MyColor = imagen2.GetPixel(fila, columna)
                Select Case indice_color
                    Case 0
                        num_color = MyColor.R
                        PutBit(num_color, 1, bit)
                        imagen2.SetPixel(fila, columna, Color.FromArgb(num_color, MyColor.G, MyColor.B))
                        indice_color = indice_color + 1
                    Case 1
                        num_color = MyColor.G
                        PutBit(num_color, 1, bit)
                        imagen2.SetPixel(fila, columna, Color.FromArgb(MyColor.R, num_color, MyColor.B))
                        indice_color = indice_color + 1
                    Case 2
                        num_color = MyColor.B
                        PutBit(num_color, 1, bit)
                        imagen2.SetPixel(fila, columna, Color.FromArgb(MyColor.R, MyColor.G, num_color))
                        indice_color = 0
                        indice_pixel = indice_pixel + 1
                End Select
            Next
        End If
    End Sub

    Private Sub Escribir_dato(ByVal dato As Byte)
        Call Escribir_dato_m1(dato, 8)
    End Sub

    Private Sub Reinicio()
        tbTextoCifrar.Text = ""
        tbInformacion.Text = ""
        pbImagen.ImageLocation = ""
        pbImagen.Refresh()
        pbImagenCifrada.ImageLocation = ""
        tbTamImagen.Text = ""
        pbImagenCifrada.Image = Nothing
        btnGuardar.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim saveFileDialog1 As New SaveFileDialog
        Dim fi As New FileInfo(name_img)
        Try
            saveFileDialog1.DefaultExt = "jpg"
            If estado_PB2 = 2 Then
                saveFileDialog1.FileName = fi.Name.Substring(0, fi.Name.Length - 4) & "-fd1b"
            Else
                saveFileDialog1.FileName = fi.Name.Substring(0, fi.Name.Length - 4) & "-fd1"
            End If
            'saveFileDialog1.FileName = fi.Name.Substring(0, fi.Name.Length - 4) & "-fd1"
            saveFileDialog1.Filter = "Imagen PNG (*.png)|*.png"
            saveFileDialog1.RestoreDirectory = True
            saveFileDialog1.Title = "Guardar como..."
            If (saveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                If estado_PB2 = 2 Then
                    imagen2b.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)
                Else
                    imagen2.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)
                End If
                'imagen2.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)
                name_img2 = saveFileDialog1.FileName
                tbTamImagen.Text = Extraer_nombre_file(name_img2) & " (" & str_Tamano_file(FileSystem.FileLen(name_img2)) & ")"
                MsgBox("Imagen guardada", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class