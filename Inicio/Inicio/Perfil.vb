Public Class Perfil
    Private Sub Perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mostramos toda la información del usuario en el textBox.
        If Inicio.usuarioActivo = user Then
            tbInfoUsuario.Text += "Nombre Completo: " & nombre & vbNewLine
            tbInfoUsuario.Text += "Nombre de Usuario: " & user & vbNewLine
            tbInfoUsuario.Text += "Responsable del certificado: " & responsable & vbNewLine
            tbInfoUsuario.Text += "Empresa certificadora: " & empresa & vbNewLine
            tbInfoUsuario.Text += "Vigencia de certificado: " & vigencia
        ElseIf Inicio.usuarioActivo = user2 Then
            tbInfoUsuario.Text += "Nombre Completo: " & nombre2 & vbNewLine
            tbInfoUsuario.Text += "Nombre de Usuario: " & user2 & vbNewLine
            tbInfoUsuario.Text += "Responsable del certificado: " & responsable2 & vbNewLine
            tbInfoUsuario.Text += "Empresa certificadora: " & empresa2 & vbNewLine
            tbInfoUsuario.Text += "Vigencia de certificado: " & vigencia2
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class