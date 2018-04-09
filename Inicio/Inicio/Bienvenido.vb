Imports MySql.Data.MySqlClient 'Conectar a la base de datos (certificados digitales).

Public Class Bienvenido

    Dim adaptador As New MySqlDataAdapter
    Dim datos As DataSet
    Dim conn As New MySqlConnection

    Public intentos As Int16 = 1
    Public usuario As String

    Private Sub cbVerClave_CheckedChanged(sender As Object, e As EventArgs) Handles cbVerClave.CheckedChanged
        If cbVerClave.Checked Then
            tbPass.UseSystemPasswordChar = False
        Else
            tbPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If intentos < 3 Then
            usuario = tbUsuario.Text
            Dim contras As String = tbPass.Text
            If usuario <> "" And contras <> "" Then
                Ingreso(usuario, contras)
            Else

            End If

        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Public Sub Ingreso(usuario As String, contra As String)
        Dim consulta As String
        Dim lista As Byte
        Try
            'Conexión a la base de datos.
            Dim conexion As String = "server=198.91.81.6;database=sicudex1_conAlimentos; user id=sicudex1_DianaFG;password=dianafg123;port=3306"
            'Abrimos la Base de datos
            conn.Open()
            consulta = "SELECT * FROM usuario WHERE usuario = '" & usuario & "' AND clavePrivada = '" & contra & "'"
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

    End Sub


End Class