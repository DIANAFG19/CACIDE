<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.cbVerClave = New System.Windows.Forms.CheckBox()
        Me.labelPrivada = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-1, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(347, 26)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "NOTA: Sólo tienes tres intentos para poder ingresar, después de estos,  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "se desh" &
    "abilitará todo el formulario y tendras que reiniciar la aplicación."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbUsuario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbPass)
        Me.GroupBox1.Controls.Add(Me.cbVerClave)
        Me.GroupBox1.Controls.Add(Me.labelPrivada)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 160)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'tbUsuario
        '
        Me.tbUsuario.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuario.Location = New System.Drawing.Point(9, 36)
        Me.tbUsuario.MaxLength = 15
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(270, 26)
        Me.tbUsuario.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Usuario:"
        '
        'tbPass
        '
        Me.tbPass.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPass.Location = New System.Drawing.Point(9, 91)
        Me.tbPass.MaxLength = 20
        Me.tbPass.Name = "tbPass"
        Me.tbPass.Size = New System.Drawing.Size(270, 26)
        Me.tbPass.TabIndex = 1
        Me.tbPass.UseSystemPasswordChar = True
        '
        'cbVerClave
        '
        Me.cbVerClave.AutoSize = True
        Me.cbVerClave.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVerClave.Location = New System.Drawing.Point(12, 123)
        Me.cbVerClave.Name = "cbVerClave"
        Me.cbVerClave.Size = New System.Drawing.Size(102, 23)
        Me.cbVerClave.TabIndex = 2
        Me.cbVerClave.Text = "Ver Clave"
        Me.cbVerClave.UseVisualStyleBackColor = True
        '
        'labelPrivada
        '
        Me.labelPrivada.AutoSize = True
        Me.labelPrivada.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPrivada.Location = New System.Drawing.Point(8, 69)
        Me.labelPrivada.Name = "labelPrivada"
        Me.labelPrivada.Size = New System.Drawing.Size(99, 19)
        Me.labelPrivada.TabIndex = 4
        Me.labelPrivada.Text = "Contraseña:"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.OrangeRed
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Location = New System.Drawing.Point(192, 225)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 42)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.OrangeRed
        Me.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.Color.Black
        Me.btnEntrar.Location = New System.Drawing.Point(44, 225)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(90, 42)
        Me.btnEntrar.TabIndex = 3
        Me.btnEntrar.Text = "ENTRAR"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.label1.Location = New System.Drawing.Point(19, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(300, 39)
        Me.label1.TabIndex = 21
        Me.label1.Text = "CON ALIMENTOS"
        '
        'Inicio
        '
        Me.AcceptButton = Me.btnEntrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(337, 316)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.label1)
        Me.Name = "Inicio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CACIDE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbPass As TextBox
    Friend WithEvents cbVerClave As CheckBox
    Friend WithEvents labelPrivada As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEntrar As Button
    Private WithEvents label1 As Label
End Class
