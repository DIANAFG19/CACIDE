Public Class Bienvenido
    Private Sub rbCifrar_CheckedChanged(sender As Object, e As EventArgs) Handles rbCifrar.CheckedChanged
        labelClave.Visible = False
        labelPrivada.Visible = True
        labelPublica.Visible = False
        tbClave.Enabled = True
        cbVerClave.Enabled = True
        btnEntrar.Enabled = True
    End Sub

    Private Sub rbDescifrar_CheckedChanged(sender As Object, e As EventArgs) Handles rbDescifrar.CheckedChanged
        labelClave.Visible = False
        labelPrivada.Visible = False
        labelPublica.Visible = True
        tbClave.Enabled = True
        cbVerClave.Enabled = True
        btnEntrar.Enabled = True
    End Sub

    Private Sub tbClave_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbVerClave_CheckedChanged(sender As Object, e As EventArgs) Handles cbVerClave.CheckedChanged
        If cbVerClave.Checked Then
            tbClave.UseSystemPasswordChar = False
        Else
            tbClave.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

End Class