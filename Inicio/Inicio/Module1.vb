Module Module1

    Public imagen1 As Bitmap
    Public imagen2 As Bitmap
    Public imagen2b As Bitmap
    Public imagen3 As Bitmap
    Public estado_PB2 As Integer
    Public hallada_img2b As Boolean

    Public name_img As String
    Public name_img2 As String
    Public name_archivo As String
    Public long_archivo As Long

    Public num_pixeles As Long
    Public indice_pixel As Long
    Public indice_color As Short
    Public num_img As Byte
    Public offset As Integer

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
