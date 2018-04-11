Public Class Bienvenido
    Private Sub Bienvenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCifrar_Click(sender As Object, e As EventArgs) Handles btnCifrar.Click
        Cifrar.Show()
    End Sub

    Private Sub btnDescifrar_Click(sender As Object, e As EventArgs) Handles btnDescifrar.Click
        Descifrar.Show()
    End Sub

    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        Perfil.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

End Class