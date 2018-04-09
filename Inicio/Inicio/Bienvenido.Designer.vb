<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bienvenido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.cbVerClave = New System.Windows.Forms.CheckBox()
        Me.labelPrivada = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.OrangeRed
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("AR ESSENCE", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Location = New System.Drawing.Point(201, 256)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 42)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.label1.Font = New System.Drawing.Font("AR ESSENCE", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(40, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(271, 58)
        Me.label1.TabIndex = 13
        Me.label1.Text = "¡¡BIENVENIDO!!"
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.OrangeRed
        Me.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEntrar.Enabled = False
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEntrar.Font = New System.Drawing.Font("AR ESSENCE", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.Color.Black
        Me.btnEntrar.Location = New System.Drawing.Point(53, 256)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(90, 42)
        Me.btnEntrar.TabIndex = 14
        Me.btnEntrar.Text = "ENTRAR"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbUsuario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbPass)
        Me.GroupBox1.Controls.Add(Me.cbVerClave)
        Me.GroupBox1.Controls.Add(Me.labelPrivada)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 169)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'tbPass
        '
        Me.tbPass.Enabled = False
        Me.tbPass.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPass.Location = New System.Drawing.Point(9, 100)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.Size = New System.Drawing.Size(270, 26)
        Me.tbPass.TabIndex = 22
        Me.tbPass.UseSystemPasswordChar = True
        '
        'cbVerClave
        '
        Me.cbVerClave.AutoSize = True
        Me.cbVerClave.Enabled = False
        Me.cbVerClave.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVerClave.Location = New System.Drawing.Point(12, 132)
        Me.cbVerClave.Name = "cbVerClave"
        Me.cbVerClave.Size = New System.Drawing.Size(102, 23)
        Me.cbVerClave.TabIndex = 5
        Me.cbVerClave.Text = "Ver Clave"
        Me.cbVerClave.UseVisualStyleBackColor = True
        '
        'labelPrivada
        '
        Me.labelPrivada.AutoSize = True
        Me.labelPrivada.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPrivada.Location = New System.Drawing.Point(8, 78)
        Me.labelPrivada.Name = "labelPrivada"
        Me.labelPrivada.Size = New System.Drawing.Size(99, 19)
        Me.labelPrivada.TabIndex = 4
        Me.labelPrivada.Text = "Contraseña:"
        Me.labelPrivada.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(347, 26)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "NOTA: Sólo tienes tres intentos para poder ingresar, después de estos,  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "se desh" &
    "abilitará todo el formulario y tendras que reiniciar el ejecutable."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Usuario:"
        Me.Label3.Visible = False
        '
        'tbUsuario
        '
        Me.tbUsuario.Enabled = False
        Me.tbUsuario.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuario.Location = New System.Drawing.Point(11, 44)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(268, 26)
        Me.tbUsuario.TabIndex = 24
        Me.tbUsuario.UseSystemPasswordChar = True
        '
        'Bienvenido
        '
        Me.AcceptButton = Me.btnEntrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(346, 348)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.label1)
        Me.Name = "Bienvenido"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Private WithEvents label1 As Label
    Friend WithEvents btnEntrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbVerClave As CheckBox
    Friend WithEvents labelPrivada As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPass As TextBox
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents Label3 As Label
End Class
