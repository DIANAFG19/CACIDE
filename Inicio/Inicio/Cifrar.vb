Option Explicit On
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Public Class Cifrar
    Private Sub cbVerClave_CheckedChanged(sender As Object, e As EventArgs)
        If cbVerClave.Checked Then
            tbClave.UseSystemPasswordChar = False
        Else
            tbClave.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnCargarImagen_Click(sender As Object, e As EventArgs)
        Dim nombre As String
        Dim bitspp1, bitspp2 As Short

        Using OpenFileDialog1 As New OpenFileDialog()
            With OpenFileDialog1
                .CheckFileExists = True
                .ShowReadOnly = False
                .Filter = "Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png|Imagen BMP (*.bmp)|*.bmp"
                .FilterIndex = 1
                If .ShowDialog = DialogResult.OK Then
                    btnGuardar.Enabled = False
                    pbImagenCifrada.Image = Nothing
                    'txtArchivo.Text = ""
                    tbTextoCifrar.Text = ""
                    'txtTamImg.Text = ""
                    'txtTamImg.Refresh()
                    imagen1 = New Bitmap(.FileName)

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
End Class