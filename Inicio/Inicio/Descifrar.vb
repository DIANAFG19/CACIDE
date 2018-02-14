Option Explicit On
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Public Class Descifrar
    Private Sub cbVerClave_CheckedChanged(sender As Object, e As EventArgs) Handles cbVerClave.CheckedChanged
        If cbVerClave.Checked Then
            tbClave.UseSystemPasswordChar = False
        Else
            tbClave.UseSystemPasswordChar = True
        End If
    End Sub
End Class