Public Class Inicio

    Public intentos As Int16 = 1
    Public usuarioActivo As String

    Private Sub cbVerClave_CheckedChanged(sender As Object, e As EventArgs) Handles cbVerClave.CheckedChanged
        'Mostrar clave o no.
        If cbVerClave.Checked Then
            tbPass.UseSystemPasswordChar = False
        Else
            tbPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        'Condicion que los intentos sea menor a 3 para seguridad.
        If intentos < 3 Then
            'Validamos que los campos no se encuentren vacios.
            If tbUsuario.Text = "" Or tbPass.Text = "" Then
                MsgBox("Ingrese usuario y/o contraseña.")
                'Validamos que exista el usuario.
            ElseIf tbUsuario.Text = user Or tbUsuario.Text = user2 Then
                'Validamos que la contraseña corresponda a ese usuario.
                usuarioActivo = tbUsuario.Text
                If tbPass.Text = claveGeneral Then
                    Bienvenido.Show()
                    tbUsuario.Clear()
                    tbPass.Clear()
                Else
                    'En caso de que no coincida, mostrar error.
                    MsgBox("Contraseña incorrecta.")
                End If
            Else
                'Si no es lo anterior, le decimos al usuario que no esta registrado.
                MsgBox("Usted no esta registrado.")
            End If
        Else
            'En caso de superar los intentos, deshabilitamos todo el formulario y sólo le permitimos salir.
            MsgBox("Haz desperdiciado tus 3 intentos.")
            tbUsuario.Enabled = False
            tbPass.Enabled = False
            cbVerClave.Enabled = False
            btnEntrar.Enabled = False
        End If
        intentos += 1
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
