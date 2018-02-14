Public Class Inicio
    Private Sub btnCifrar_Click(sender As Object, e As EventArgs) Handles btnCifrar.Click
        Cifrar.Show()
    End Sub

    Private Sub btnDescifrar_Click(sender As Object, e As EventArgs) Handles btnDescifrar.Click
        Descifrar.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
