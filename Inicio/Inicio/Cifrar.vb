Option Explicit On
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Public Class Cifrar

    'MÉTODO DE DIBUJAR LA IMAGEN
    'REFERENCIAS: https://msdn.microsoft.com/es-es/library/system.drawing.graphics(v=vs.110).aspx
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
                indiceDatos = 0 ' bytes escritos.
                'Escribimos el texto dentro de la imagen.
                Call EscribirTexto()
                'Mostramos la imagen ya cifrada.
                pbImagenCifrada.Image = imagen2
                btnGuardar.Enabled = True
                Cursor = System.Windows.Forms.Cursors.Default
                btnGuardar.Focus()
            Else
                'En caso de no cumplir con el tamaño(en píxeles), mandar un mensaje de error.
                MsgBox("La imagen no tiene píxeles suficientes para enviar el mensaje (" & tamanoImg(longDatos) & ")", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim saveFileDialog1 As New SaveFileDialog
        Dim cide As New FileInfo(nombreImg)
        Try
            'Creamos un save dialig para poder guardar la iamgen en el equipo.
            saveFileDialog1.DefaultExt = "jpg"
            'Especificamos que se va aguardar con su nombre origina mas el -cide.
            saveFileDialog1.FileName = cide.Name.Substring(0, cide.Name.Length - 4) & "_cide"
            'Se va a guardar con la extension .png
            saveFileDialog1.Filter = "Imagen PNG (*.png)|*.png"
            saveFileDialog1.RestoreDirectory = True
            saveFileDialog1.Title = "Guardar como..."
            'Decimos que la imagen se ha guardado correctamente.
            If (saveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                imagen2.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)
                nombreImgCi = saveFileDialog1.FileName
                MsgBox("Imagen guardada.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Imagen guardada.", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Call Reinicio()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
        Inicio.Show()
    End Sub


    'REFERENCIAS: 
    'VISUAL BASIC .NET: https://docs.microsoft.com/en-us/dotnet/visual-basic/
    'Creamos una función para poder comprobar que hay una imagen y hay texto para cifrar dentro de la imagen.
    Private Function ComprobarCampos() As Boolean
        Dim comprobar As Boolean
        Dim mensaje As String = "Errores: "
        comprobar = True
        If pbImagen.ImageLocation = "" Then
            mensaje = mensaje & Chr(13) & "  - Antes debes cargar una imagen."
            btnCargar.Focus()
            comprobar = False
        End If
        If tbTextoCifrar.TextLength = 0 Then
            mensaje = mensaje & Chr(13) & "  - No hay texto a encriptar."
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

    'Empezamos el cifrado de la imagen tomando al texto que se desea cifrar.
    Private Sub EscribirTexto()
        Dim largoH, largoL As Byte
        Dim i As Integer
        largoL = tbTextoCifrar.TextLength And &HFF
        largoH = tbTextoCifrar.TextLength >> 8
        Call EscribirDato(largoH)
        Call EscribirDato(largoL)
        indiceDatos = indiceDatos + 2
        For i = 1 To tbTextoCifrar.TextLength
            Call EscribirDato(Module1.cifrar(Asc(tbTextoCifrar.Text.Substring(i - 1, 1))))
            indiceDatos = indiceDatos + 1
        Next
    End Sub

    'Lo usamos como referencia para poder mandar a llamar a la otra función.
    Private Sub EscribirDato(ByVal dato As Byte)
        Call EscribirDatoC(dato, 8)
    End Sub

    'Función para cifrar con la clave pública.
    Private Sub ConClave()
        Dim i As Integer
        offset = 0
        For i = 1 To claveGeneral.Length
            offset = offset + Asc(claveGeneral.Substring(i - 1, 1)) Mod 20
        Next
        offset = offset Mod 20
    End Sub

    'Funcion para cifrar con la fecha y hora actual.
    Private Sub ConFechaHora()
        anio = Today.Year - 2000
        mes = Today.Month
        dia = Today.Day
        hora = TimeOfDay.Hour
        minuto = TimeOfDay.Minute
        segundo = TimeOfDay.Second
    End Sub

    'Función para agregar dos letras de referencia para poder cifrar junto con la fecha.
    Private Sub ConComplemento()
        Dim dato1 As Byte = 0
        Dim dato2 As Byte = 0
        Call EscribirDatoC(Asc("F"), 8)
        Call EscribirDatoC(Asc("D"), 8)
        dato1 = dato1 + 1
        Call EscribirDatoC(dato1, 2)
        dato2 = 0
        If PuedeCifrar() Then
            If numImg > 1 Then
                dato2 = 2
            End If
        Else
            dato2 = 1
        End If
        Call EscribirDatoC(dato2, 2)
        Call EscribirDatoC(anio, 7)
        Call EscribirDatoC(mes, 4)
        Call EscribirDatoC(dia, 5)
        Call EscribirDatoC(hora, 6)
        Call EscribirDatoC(minuto, 6)
        Call EscribirDatoC(segundo, 6)
        Call EscribirDatoC(numImg, 8)
        Call EscribirDatoC(0, 1)
    End Sub

    'Se hace el cifrado ya en la imagen con la fecha, clave y texto.
    Private Sub EscribirDatoC(ByVal dato As Byte, ByVal nbits As Short)
        Dim i As Short
        Dim fila, columna As Integer
        Dim bit As Byte
        Dim MyColor As Color
        Dim numColor As Byte
        If (numPixImg - indicePixel) < 3 Then
            MsgBox("Error: No hay píxeles suficientes")
            Call Reinicio()
        Else
            For i = nbits To 1 Step -1
                columna = Int((indicePixel - 1) / imagen1.Width)
                fila = (indicePixel - 1) Mod imagen1.Width
                bit = GetBit(dato, i)
                MyColor = imagen2.GetPixel(fila, columna)
                Select Case indiceColor
                    Case 0
                        numColor = MyColor.R
                        PutBit(numColor, 1, bit)
                        imagen2.SetPixel(fila, columna, Color.FromArgb(numColor, MyColor.G, MyColor.B))
                        indiceColor = indiceColor + 1
                    Case 1
                        numColor = MyColor.G
                        PutBit(numColor, 1, bit)
                        imagen2.SetPixel(fila, columna, Color.FromArgb(MyColor.R, numColor, MyColor.B))
                        indiceColor = indiceColor + 1
                    Case 2
                        numColor = MyColor.B
                        PutBit(numColor, 1, bit)
                        imagen2.SetPixel(fila, columna, Color.FromArgb(MyColor.R, MyColor.G, numColor))
                        indiceColor = 0
                        indicePixel = indicePixel + 1
                End Select
            Next
        End If
    End Sub

    Private Sub Reinicio()
        tbTextoCifrar.Text = ""
        tbInformacion.Text = ""
        pbImagen.ImageLocation = ""
        pbImagen.Refresh()
        pbImagenCifrada.ImageLocation = ""
        pbImagenCifrada.Image = Nothing
        btnGuardar.Enabled = False
    End Sub

End Class