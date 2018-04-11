Module Module1

    'Aquí declaramos a dos usuario para poder acceder
    Public nombre As String = "Esteban Perez Hernandez"
    Public user As String = "EstebanPeHe"
    Public responsable As String = "Ing. Juan Navarrete Martinez"
    Public empresa As String = "Con Alimentos"
    Public vigencia As String = "09/04/2019"

    Public nombre2 As String = "Monica Osorio Soto"
    Public user2 As String = "MonicaOsSo"
    Public responsable2 As String = "Ing. Veronica Capdeville Sosa"
    Public empresa2 As String = "Con Alimentos"
    Public vigencia2 As String = "10/12/2018"

    'Clave para cifrar y descifrar, es general.
    Public claveGeneral As String = "CACIDE182"

    'Variables para usar en el formulario cifrado.
    Public imagen1 As Bitmap
    Public imagen2 As Bitmap
    Public nombreImg As String
    Public numPixImg As Long
    Public indicePixel As Long = 1
    Public indiceColor As Short = 0
    Public longDatos As Long = 0
    Public indiceDatos As Long = 0

    'Variables que se usan dentro del cifrado.
    Public claveCambio As String
    Public indiceClave As Integer
    Public numImg As Byte
    Public offset As Integer

    'Variables para guardar la imagen 
    Public nombreImgCi As String
    Public tipoDatos As Byte

    'Variables a usar en la función de cifrar con feche y hora actual.
    Public anio As Byte
    Public mes As Byte
    Public dia As Byte
    Public hora As Byte
    Public minuto As Byte
    Public segundo As Byte

    'Variables usadan en el formulario descrifrado
    Public imagen3 As Bitmap

    'Método para obtener el nombre de la imagen y poder mostrarlo.
    Public Function ExtraerNombre(ByRef ruta As String) As String
        Dim i As Integer
        Dim rta As String
        For i = ruta.Length - 1 To 0 Step -1
            If ruta.Substring(i, 1) = "\" Or ruta.Substring(i, 1) = "/" Then
                Exit For
            End If
        Next
        rta = ruta.Substring(i + 1, ruta.Length - i - 1)
        Return rta
    End Function

    'Método para cifrar la clave dentro de la imagen junto con el texto.
    Public Function ModificarClave(ByRef clave As String) As String
        Dim clave2 As String = ""
        Dim clave3 As String = ""
        Dim i As Integer
        For i = 1 To Int(clave.Length / 2)
            clave2 = clave2 + clave.Substring(Int(clave.Length / 2) - i, 1)
        Next
        If (clave.Length / 2) <> Int(clave.Length / 2) Then
            clave2 = clave2 + clave.Substring(Int(clave.Length / 2), 1)
        End If
        For i = clave.Length - 1 To Int((clave.Length + 1) / 2) Step -1
            clave2 = clave2 + clave.Substring(i, 1)
        Next
        For i = 1 To clave2.Length
            Select Case (i Mod 3)
                Case 0
                    clave3 = clave3 + clave2.Substring(i - 1, 1)
                Case 1
                    clave3 = clave3 + clave2.Substring(i - 1, 1)
                Case 2
                    clave3 = clave3 + clave2.Substring(i - 1, 1)
            End Select
        Next
        Return clave3
    End Function

    'Tomamos el tamaño de la imagen
    Public Function tamanoImg(ByVal largo As Long) As String
        Dim rta As String = ""
        If (largo / 1024) > 1024 Then
            rta = Math.Round(((largo / 1024) / 1024), 2).ToString() & " Mb"
        Else
            If (largo / 1024) > 1 Then
                rta = Math.Round((largo / 1024), 2).ToString() & " KB"
            Else
                rta = largo & " Bytes"
            End If
        End If
        Return rta
    End Function

    'Método para cifrar la imagen intercambiando bits.
    Public Function cifrar(ByVal octeto As Byte) As Byte
        Dim rta As Byte
        rta = octeto Xor Asc(claveCambio.Substring(indiceClave - 1, 1))
        IntercambiarBits(rta, 1, 4)
        IntercambiarBits(rta, 2, 3)
        IntercambiarBits(rta, 5, 8)
        IntercambiarBits(rta, 6, 7)
        IntercambiarBits(rta, 3, 6)
        rta = Complemento(rta)
        If indiceClave = claveCambio.Length Then
            indiceClave = 1
        Else
            indiceClave = indiceClave + 1
        End If
        Return rta
    End Function

    'Método para tomar los bits de la imagen.
    Public Function GetBit(ByVal octeto As Byte, ByVal n As Byte) As Byte
        Dim rta As Byte
        Dim potencia As Byte = 2 ^ (n - 1)
        rta = octeto And potencia
        rta >>= (n - 1)
        Return rta
    End Function

    'Método para poner los bits en la imagen
    Public Sub PutBit(ByRef octeto As Byte, ByVal n As Byte, ByVal bit As Byte)
        Dim mascara As Byte
        If bit = 0 Then
            mascara = (2 ^ 8 - 1) - 2 ^ (n - 1)
            octeto = octeto And mascara
        Else
            mascara = 2 ^ (n - 1)
            octeto = octeto Or mascara
        End If
    End Sub

    'Método para mezclar los bits y hacer el cifrado.
    Public Sub IntercambiarBits(ByRef octeto As Byte, ByVal n1 As Byte, ByVal n2 As Byte)
        Dim bit1, bit2 As Byte
        bit1 = GetBit(octeto, n1)
        bit2 = GetBit(octeto, n2)
        If bit1 <> bit2 Then
            PutBit(octeto, n1, bit2)
            PutBit(octeto, n2, bit1)
        End If
    End Sub

    'Función para descrifrar con el complemento e intercambio de bits.
    Public Function descifrar(ByVal octeto As Byte) As Byte
        Dim rta As Byte
        rta = Complemento(octeto)
        IntercambiarBits(rta, 3, 6)
        IntercambiarBits(rta, 6, 7)
        IntercambiarBits(rta, 5, 8)
        IntercambiarBits(rta, 2, 3)
        IntercambiarBits(rta, 1, 4)
        rta = rta Xor Asc(claveCambio.Substring(indiceClave - 1, 1))
        If indiceClave = claveCambio.Length Then
            indiceClave = 1
        Else
            indiceClave = indiceClave + 1
        End If
        Return rta
    End Function

    'Método para los octetos del descifrado
    Public Function Complemento(ByVal octeto As Byte) As Byte
        Dim rta, parteH, parteL As Byte
        parteH = octeto And &HF0
        parteL = octeto And &HF
        rta = parteH + (15 - parteL)
        Return rta
    End Function

End Module
