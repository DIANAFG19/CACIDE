Option Explicit On
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Public Class Descifrar

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
                    'Validamos que la imagen tenga algún texto dentro de ella.
                    If tipoDatos = 0 Then
                        tbInformacion.Text = tbInformacion.Text & vbNewLine & "   No hay información cifrada"
                        btnDescifrar.Enabled = False
                    Else
                        ' If tipoDatos = 1 Or tipoDatos = 3 Then
                        'tbInformacion.Text = tbInformacion.Text & vbNewLine & "  - Texto"
                        'End If
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

        indicePixel = 22
        indiceColor = 0
        If multiplicidad > 0 Then
        Else
            Call ConClave2()
            claveCambio = ModificarClave(claveGeneral)
            indiceClave = 1
            longTexto = LeerDato()
            octetoL = LeerDato()
            longTexto = (longTexto << 8) + octetoL
                For i = 1 To longTexto
                octeto = LeerDato()
                texto = texto & Chr(Module1.descifrar(octeto))
                Next
                tbTextoCifrado.Text = texto

        End If
    End Sub

    'Se lee la imagen, los bits con respecto al cifrado de fecha, clave y complemento
    Private Sub Leer()
        Dim octeto1, octeto2 As Byte
        octeto1 = LeerDatos(8)
        octeto2 = LeerDatos(8)
        If octeto1 <> Asc("F") Or octeto2 <> Asc("D") Then
            tipoDatos = 0
        Else
            tipoDatos = LeerDatos(2)
            multiplicidad = LeerDatos(2)
            anio = LeerDatos(7)
            mes = LeerDatos(4)
            dia = LeerDatos(5)
            hora = LeerDatos(6)
            minuto = LeerDatos(6)
            segundo = LeerDatos(6)
            numImg = LeerDatos(8)
            metodo = LeerDatos(1)
        End If
    End Sub

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



    Private Sub ConClave2()
        Dim i As Integer
        offset = 0
        For i = 1 To claveGeneral.Length
            offset = offset + Asc(claveGeneral.Substring(i - 1, 1)) Mod 20
        Next
        offset = offset Mod 20
    End Sub

    Private Function LeerDato() As Byte
        Dim rta As Byte
        rta = LeerDatos(8)
        Return rta
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
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