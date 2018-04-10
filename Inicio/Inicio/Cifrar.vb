Option Explicit On
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Public Class Cifrar

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim nombre As String
        Dim bitspp1, bitspp2 As Short
        'Nos permitirá abrir una imagen desde la PC
        Using OpenFileDialog1 As New OpenFileDialog()
            With OpenFileDialog1
                .CheckFileExists = True
                .ShowReadOnly = False
                'Permite imagénes del tipo JPG, PNG o JPEG
                .Filter = "Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png|Imagen JPEG (*.jpeg)|*.jpeg"
                .FilterIndex = 1
                If .ShowDialog = DialogResult.OK Then
                    'Cuando muestre la imagen, habilitamos lo siguiente:
                    btnGuardar.Enabled = False
                    pbImagenCifrada.Image = Nothing
                    tbTextoCifrar.Text = ""
                    tbTamImagen.Text = ""
                    tbTamImagen.Refresh()
                    'Creamos un bitmap para la imagen
                    imagen1 = New Bitmap(.FileName)
                    'El segundo bitmap contendra información de la imagen
                    imagen2 = New Bitmap(imagen1.Width, imagen1.Height, PixelFormat.Format24bppRgb)
                    imagen2.SetResolution(imagen1.HorizontalResolution, imagen1.VerticalResolution)
                    'Convertimos a la imagen en un grafico
                    Dim g As Graphics = Graphics.FromImage(imagen2)
                    g.DrawImage(imagen1, 0, 0)
                    'Tomamos los pixeles de las imagenes (imagen original vs imagen dibujada).
                    bitspp1 = imagen1.GetPixelFormatSize(imagen1.PixelFormat)
                    bitspp2 = imagen2.GetPixelFormatSize(imagen2.PixelFormat)
                    'La imagen debe tener minimo 100 píxeles de area para poder cifrar.
                    If imagen1.Width * imagen1.Width < 100 Then
                        MsgBox("Error: " & Chr(13) & "    La imagen tiene muy pocos píxeles")
                    Else
                        'La imagen debe tener al menos de 24 pixeles.
                        If bitspp2 < 24 Then
                            MsgBox("    (" & bitspp2 & " bits por píxel) " & Chr(13) & "    La imagen debe tener minimo 24 bits por pixel para poder cifrar.")
                        Else
                            ' Mostramos un poco de información de la imagen.
                            nombreImg = .FileName
                            nombre = ExtraerNombre(.FileName)
                            pbImagen.ImageLocation = .FileName
                            numPixImg = imagen1.Width * imagen1.Height
                            tbInformacion.Text = "Nombre: " & nombre & vbNewLine
                            tbInformacion.Text = tbInformacion.Text & "Tamaño: " & imagen1.Width & "x" & imagen1.Height & Chr(13) & vbNewLine
                            tbInformacion.Text = tbInformacion.Text & " (" & bitspp1 & " bits/pixel)" & Chr(13)
                        End If
                    End If
                End If
            End With
        End Using
    End Sub

    Private Sub btnCifrar_Click(sender As Object, e As EventArgs) Handles btnCifrar.Click
        If ComprobarCampos() Then
            'Clonamos la imagen uno (la imagen 2 es la que se va a cifrar).
            imagen2 = imagen1.Clone
            'Tomamos los carácteres del texto que se va a cifrar.
            longDatos = longDatos + 2 + tbTextoCifrar.TextLength
            'Verificamos que el texto cabe dentro de la imagen, según los pixeles.
            If PuedeCifrar() Then
                Cursor = System.Windows.Forms.Cursors.WaitCursor
                'Cifrar con la fecha y hora
                Call ConFechaHora()
                'Cifrar con la clave publica
                Call ConClave()
                'Complemntar con dos letras que nos ayudan a trabajar sobre el cifrado.
                Call ConComplemento()
                'Auí se modificará la clave para el cifrado.
                claveCambio = ModificarClave(claveGeneral)
                indiceClave = 1
                indiceDatos = 0 ' bytes escritos (sin cabeceras)
                'Escribimos el texto dentro de la imagen
                Call EscribirTexto()
                'Mostramos la imagen ya cifrada
                pbImagenCifrada.Image = imagen2
                btnGuardar.Enabled = True
                Cursor = System.Windows.Forms.Cursors.Default
                btnGuardar.Focus()
            Else
                'En caso de no cumplir con el tamaño, mandar un mensaje de error.
                MsgBox("La imagen no tiene píxeles suficientes para enviar el mensaje (" & tamanoImg(longDatos) & ")", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim saveFileDialog1 As New SaveFileDialog
        Dim fi As New FileInfo(nombreImg)
        Try
            saveFileDialog1.DefaultExt = "jpg"
            If estado_PB2 = 2 Then
                saveFileDialog1.FileName = fi.Name.Substring(0, fi.Name.Length - 4) & ""
            Else
                saveFileDialog1.FileName = fi.Name.Substring(0, fi.Name.Length - 4) & ""
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
                tbTamImagen.Text = ExtraerNombre(name_img2) & " (" & tamanoImg(FileSystem.FileLen(name_img2)) & ")"
                MsgBox("Imagen guardada", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
        Inicio.Show()
    End Sub

    'Creamos una función para poder comprobar que hay una imagen y hay texto para cifrar dentro de la imagen.
    Private Function ComprobarCampos() As Boolean
        Dim comprobar As Boolean
        Dim mensaje As String = "Errores: "
        comprobar = True
        If pbImagen.ImageLocation = "" Then
            mensaje = mensaje & Chr(13) & "  - Antes debes cargar una imagen"
            btnCargar.Focus()
            comprobar = False
        End If
        If tbTextoCifrar.TextLength = 0 Then
            mensaje = mensaje & Chr(13) & "  - No hay texto a encriptar"
            tbTextoCifrar.Focus()
            comprobar = False
        End If
        If Not (comprobar) Then
            MsgBox(mensaje)
        End If
        Return comprobar
    End Function

    'Funcion que comprueba que la longitud de caracteres se puede cifrar dentro de la imagen.
    Private Function PuedeCifrar() As Boolean
        Dim comprueba As Boolean = True
        If ((longDatos - indiceDatos) * 8 + 63) > numPixImg Then
            comprueba = False
        End If
        Return comprueba
    End Function



    Private Sub ConClave()
        Dim i As Integer
        offset = 0
        For i = 1 To claveGeneral.Length
            offset = offset + Asc(claveGeneral.Substring(i - 1, 1)) Mod 20
        Next
        offset = offset Mod 20
    End Sub

    Private Sub ConFechaHora()
        'MsgBox(Today.Year & Today.Month & Today.Day & TimeOfDay.Hour & TimeOfDay.Minute & TimeOfDay.Second)
        fh_anho = Today.Year - 2000
        fh_mes = Today.Month
        fh_dia = Today.Day
        fh_hora = TimeOfDay.Hour
        fh_minuto = TimeOfDay.Minute
        fh_segundo = TimeOfDay.Second
    End Sub

    Private Sub ConComplemento()
        Dim dato1 As Byte = 0
        Dim dato2 As Byte = 0
        'MsgBox("F=" & Asc("F"))
        Call Escribir_dato_m1(Asc("F"), 8)
        Call Escribir_dato_m1(Asc("D"), 8)
        dato1 = dato1 + 1
        Call Escribir_dato_m1(dato1, 2)
        dato2 = 0
        If PuedeCifrar() Then
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



    Private Sub EscribirTexto()
        Dim largoH, largoL As Byte
        Dim i As Integer
        largoL = tbTextoCifrar.TextLength And &HFF
        largoH = tbTextoCifrar.TextLength >> 8
        Call Escribir_dato(largoH)
        Call Escribir_dato(largoL)
        indiceDatos = indiceDatos + 2
        For i = 1 To tbTextoCifrar.TextLength
            Call Escribir_dato(Module1.cifrar(Asc(tbTextoCifrar.Text.Substring(i - 1, 1))))
            indiceDatos = indiceDatos + 1
        Next
    End Sub

    Private Sub Escribir_dato_m1(ByVal dato As Byte, ByVal nbits As Short)
        Dim i As Short
        Dim fila, columna As Integer
        Dim bit As Byte
        Dim MyColor As Color
        Dim num_color As Byte
        If (numPixImg - indicePixel) < 3 Then
            MsgBox("Error: No hay píxeles suficientes")
            Call Reinicio()
        Else
            For i = nbits To 1 Step -1
                columna = Int((indicePixel - 1) / imagen1.Width)
                fila = (indicePixel - 1) Mod imagen1.Width
                'MsgBox("fila=" & fila & ", columna=" & columna)
                bit = GetBit(dato, i)
                MyColor = imagen2.GetPixel(fila, columna)
                Select Case indiceColor
                    Case 0
                        num_color = MyColor.R
                        PutBit(num_color, 1, bit)
                        imagen2.SetPixel(fila, columna, Color.FromArgb(num_color, MyColor.G, MyColor.B))
                        indiceColor = indiceColor + 1
                    Case 1
                        num_color = MyColor.G
                        PutBit(num_color, 1, bit)
                        imagen2.SetPixel(fila, columna, Color.FromArgb(MyColor.R, num_color, MyColor.B))
                        indiceColor = indiceColor + 1
                    Case 2
                        num_color = MyColor.B
                        PutBit(num_color, 1, bit)
                        imagen2.SetPixel(fila, columna, Color.FromArgb(MyColor.R, MyColor.G, num_color))
                        indiceColor = 0
                        indicePixel = indicePixel + 1
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

End Class