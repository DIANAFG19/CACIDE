Public Class Inicio
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Bienvenido.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
