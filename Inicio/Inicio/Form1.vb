Imports MySql.Data.MySqlClient 'Conectar a la base de datos (certificados digitales).

Public Class Inicio

    Dim adaptador As New MySqlDataAdapter
    Dim datos As DataSet
    Dim conn As New MySqlConnection
    Dim intentos As Int16 = 1

    Private Sub cbVerClave_CheckedChanged(sender As Object, e As EventArgs) Handles cbVerClave.CheckedChanged
        If cbVerClave.Checked Then
            tbPass.UseSystemPasswordChar = False
        Else
            tbPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim consulta As String
        Dim lista As Byte
        If intentos < 3 Then
            If tbUsuario.Text = "" Or tbPass.Text = "" Then
                MsgBox("Ingrese usuario y/o contraseña.")
            Else
                Try
                    'Conexión a la base de datos.
                    Dim conexion As String = ("server=198.91.81.6;database=sicudex1_conAlimentos; user id=sicudex1_DianaFG;password=dianafg123")
                    'Abrimos la Base de datos
                    conn.Open()
                    consulta = "SELECT * FROM usuario WHERE usuario = '" & tbUsuario.Text & "'"
                    adaptador = New MySqlDataAdapter(consulta, conexion)
                    datos = New DataSet
                    adaptador.Fill(datos, "usuario")
                    lista = datos.Tables("usuario").Rows.Count

                    If lista <> 0 Then
                        MsgBox("Ingreso correcto")
                        Cifrar.Show()
                    Else
                        MsgBox("Usuario no encontrado")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                tbUsuario.Clear()
                tbPass.Clear()
            End If
        Else
            MsgBox("Haz desperdiciado tus intentos.")
            tbUsuario.Enabled = False
            tbPass.Enabled = False
            btnEntrar.Enabled = False
        End If
        intentos += 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As New conexion
        s.Probarconexion()
    End Sub

    Public Class conexion
        Private MysqlCommand As New MySqlCommand
        Dim MysqlConnString As String = "server=198.91.81.6 ; userid=sicudex1_DianaFG ; password=dianafg123"
        Public MysqlConexion As MySqlConnection = New MySqlConnection(MysqlConnString)

        Public Sub Probarconexion()
            Try
                MysqlConexion.Open()
                MsgBox("la conexión fue exitosa")
                MysqlConexion.Close()
            Catch ex As Exception
                MsgBox("La conexión no fue exitosa")
            End Try
        End Sub
    End Class

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
