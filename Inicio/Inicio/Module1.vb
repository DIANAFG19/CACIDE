Module Module1

    'Aquí declaramos las claves para poder acceder
    Public clavePrivada As String = "Usuario123"
    Public clavePublica As String = "Usuario321"

    Public imagen1 As Bitmap
    Public imagen2 As Bitmap
    Public imagen2b As Bitmap
    Public imagen3 As Bitmap
    Public estado_PB2 As Integer
    Public hallada_img2b As Boolean

    '
    Public name_img As String
    Public name_img2 As String
    Public name_archivo As String
    Public long_archivo As Long
    '
    Public num_pixeles As Long
    Public indice_pixel As Long
    Public indice_color As Short
    Public num_img As Byte
    Public offset As Integer
    '
    Public long_datos As Long
    Public indice_datos As Long

    Public clavebis As String
    Public indice_clave As Integer
    ' Fecha y hora
    Public fh_anho As Byte
    Public fh_mes As Byte
    Public fh_dia As Byte
    Public fh_hora As Byte
    Public fh_minuto As Byte
    Public fh_segundo As Byte
    'cabecera
    Public tipo_datos As Byte
    Public multiplicidad As Byte
    'Public num_img As Byte
    Public metodo As Byte

    Public Function GetBit(ByVal octeto As Byte, ByVal n As Byte) As Byte
        Dim rta As Byte
        Dim potencia As Byte = 2 ^ (n - 1)
        rta = octeto And potencia
        rta >>= (n - 1)
        Return rta
    End Function

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

    Public Sub IntercambiarBits(ByRef octeto As Byte, ByVal n1 As Byte, ByVal n2 As Byte)
        Dim bit1, bit2 As Byte
        bit1 = GetBit(octeto, n1)
        bit2 = GetBit(octeto, n2)
        If bit1 <> bit2 Then
            PutBit(octeto, n1, bit2)
            PutBit(octeto, n2, bit1)
        End If
    End Sub

    Public Function Modificar_clave(ByRef clave As String) As String
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

    Public Function cifrar(ByVal octeto As Byte) As Byte
        Dim rta As Byte
        rta = octeto Xor Asc(clavebis.Substring(indice_clave - 1, 1))
        IntercambiarBits(rta, 1, 4)
        IntercambiarBits(rta, 2, 3)
        IntercambiarBits(rta, 5, 8)
        IntercambiarBits(rta, 6, 7)
        IntercambiarBits(rta, 3, 6)
        rta = Complemento(rta)
        If indice_clave = clavebis.Length Then
            indice_clave = 1
        Else
            indice_clave = indice_clave + 1
        End If
        Return rta

    End Function

    Public Function Complemento(ByVal octeto As Byte) As Byte
        Dim rta, parteH, parteL As Byte

        parteH = octeto And &HF0
        parteL = octeto And &HF
        rta = parteH + (15 - parteL)
        Return rta

    End Function

    Public Function descifrar(ByVal octeto As Byte) As Byte
        Dim rta As Byte

        rta = Complemento(octeto)
        IntercambiarBits(rta, 3, 6)
        IntercambiarBits(rta, 6, 7)
        IntercambiarBits(rta, 5, 8)
        IntercambiarBits(rta, 2, 3)
        IntercambiarBits(rta, 1, 4)
        rta = rta Xor Asc(clavebis.Substring(indice_clave - 1, 1))

        If indice_clave = clavebis.Length Then
            indice_clave = 1
        Else
            indice_clave = indice_clave + 1
        End If
        Return rta

    End Function
    Public Function Extraer_nombre_file(ByRef ruta As String) As String
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

    Public Function str_Tamano_file(ByVal largo As Long) As String
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
End Module
