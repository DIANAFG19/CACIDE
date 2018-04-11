Public Class Perfil
    Private Sub Perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mostramos toda la información del usuario en el textBox.
        tbInfoUsuario.Text += "Nombre Completo: " & nombre & vbNewLine
        tbInfoUsuario.Text += "Nombre de Usuario: " & user & vbNewLine
        tbInfoUsuario.Text += "Responsable del certificado: " & responsable & vbNewLine
        tbInfoUsuario.Text += "Empresa certificadora: " & empresa & vbNewLine
        tbInfoUsuario.Text += "Vigencia de certificado: " & vigencia
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class