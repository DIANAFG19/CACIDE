Option Explicit On
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Public Class Descifrar

    'REFERENCIAS:
    'https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/strings/walkthrough-encrypting-and-decrypting-strings
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim nombre As String
        'Dim comienzo As Integer
        'Abrimos un openFileDialogn para buscar una imagen del equipo.
        Using OpenFileDialog1 As New OpenFileDialog()
            With OpenFileDialog1
                .CheckFileExists = True
                .ShowReadOnly = False
                'Filtramos imagenes .png que es como la que ciframos.
                .Filter = "Imagen PNG|*.png"
                .FilterIndex = 2
                If .ShowDialog = DialogResult.OK Then
                    ' Mostramos la imagen en el control PictureBox
                    pbImagenCifrada.ImageLocation = .FileName
                    'Creamos la imagen 3, que es la imagen cifrada.
                    imagen3 = New Bitmap(.FileName)
                    'Se extrae el nombre de la imagen.
                    nombre = ExtraerNombre(.FileName)
                    'Extraemos el número de píxeles de la imagen.
                    numPixImg = imagen3.Width * imagen3.Height
                    'Mostramos información de la imagen (nombre y tamaño).
                    tbInformacion.Text = "Nombre: " & nombre
                    tbInformacion.Text = tbInformacion.Text & vbNewLine & "Tamaño: " & imagen3.Width & "x" & imagen3.Height & Chr(13) & Chr(13)
                    indicePixel = 1
                    indiceColor = 0
                    Call Leer()
                    'Validamos que la imagen tenga algún texto dentro de ella y si no lo hay, enviamos un mensaje de error.
                    If tipoDatos = 0 Then
                        tbInformacion.Text = tbInformacion.Text & vbNewLine & "   No hay información cifrada"
                        btnDescifrar.Enabled = False
                    Else
                        btnDescifrar.Enabled = True
                    End If
                    tbInformacion.SelectionLength = nombre.Length
                    tbTextoCifrado.Text = ""
                End If
            End With
        End Using
    End Sub

    Private Sub btnDescifrar_Click(sender As Object, e As EventArgs) Handles btnDescifrar.Click
        Dim octeto, octetoL As Byte
        Dim longTexto As Integer
        Dim texto As String = ""
        'Son los pixeles que se usa en cada bit, quitando el complemento (F, D).
        indicePixel = 22
        indiceColor = 0
        'Mandamos a llamar al método para descifrar la clave dentro de la imagen.
        Call ConClave2()
        'Mandamos  a llamar al método ara modificar la clave (regresarla a su estado original).
        claveCambio = ModificarClave(claveGeneral)
        indiceClave = 1
        'Leemos el texto escrito en cifrar.
        longTexto = LeerDato()
        'Se divide en octetos para descifrar.
        octetoL = LeerDato()
        longTexto = (longTexto << 8) + octetoL
        For i = 1 To longTexto
            octeto = LeerDato()
            'El texto será igual a lo que se descifre.
            texto = texto & Chr(Module1.descifrar(octeto))
        Next
        'Mostramos el texto cifrado en el textbox de texto cifrado.
        tbTextoCifrado.Text = texto
    End Sub

    'Función para la inversa de la clave.
    Private Sub ConClave2()
        Dim i As Integer
        offset = 0
        For i = 1 To claveGeneral.Length
            offset = offset + Asc(claveGeneral.Substring(i - 1, 1)) Mod 20
        Next
        offset = offset Mod 20
    End Sub

    'Se lee la imagen, los bits con respecto al cifrado de fecha, clave y complemento
    Private Sub Leer()
        Dim octeto1, octeto2 As Byte
        octeto1 = LeerDatos(8)
        octeto2 = LeerDatos(8)
        'Estos son el complemento (F, D) y se usarón para cifrar.
        If octeto1 <> Asc("F") Or octeto2 <> Asc("D") Then
            tipoDatos = 0
        Else
            'comenzamos  a leer los datos
            tipoDatos = LeerDatos(2)
            anio = LeerDatos(7)
            mes = LeerDatos(4)
            dia = LeerDatos(5)
            hora = LeerDatos(6)
            minuto = LeerDatos(6)
            segundo = LeerDatos(6)
            numImg = LeerDatos(8)
        End If
    End Sub

    'Leemos todo lo que se encuentra en el texto dentro de la imagen:
    'El método es similar al de cifrado.
    Private Function LeerDatos(ByVal nbits As Short) As Byte
        Dim i As Short
        Dim fila, columna As Integer
        Dim bit As Byte
        Dim MyColor As Color
        Dim rta As Byte = 0
        If (numPixImg - indicePixel) < 3 Then
        Else
            For i = nbits To 1 Step -1
                columna = Int((indicePixel - 1) / imagen3.Width)
                fila = (indicePixel - 1) Mod imagen3.Width
                MyColor = imagen3.GetPixel(fila, columna)
                Select Case indiceColor
                    Case 0
                        bit = GetBit(MyColor.R, 1)
                        PutBit(rta, i, bit)
                        indiceColor = indiceColor + 1
                    Case 1
                        bit = GetBit(MyColor.G, 1)
                        PutBit(rta, i, bit)
                        indiceColor = indiceColor + 1
                    Case 2
                        bit = GetBit(MyColor.B, 1)
                        PutBit(rta, i, bit)
                        indiceColor = 0
                        indicePixel = indicePixel + 1
                End Select
            Next
        End If
        Return rta
    End Function

    'Funcion que redirecciona a leerDatos indicando el octeto
    Private Function LeerDato() As Byte
        Dim rta As Byte
        rta = LeerDatos(8)
        Return rta
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'Limpiamos todo el formulario.
        tbTextoCifrado.Text = ""
        tbInformacion.Text = ""
        pbImagenCifrada.ImageLocation = ""
        pbImagenCifrada.Refresh()
        pbImagenCifrada.Image = Nothing
        btnDescifrar.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

End Class