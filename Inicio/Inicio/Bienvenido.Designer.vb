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
        Me.labelClave = New System.Windows.Forms.Label()
        Me.labelPublica = New System.Windows.Forms.Label()
        Me.cbVerClave = New System.Windows.Forms.CheckBox()
        Me.labelPrivada = New System.Windows.Forms.Label()
        Me.rbDescifrar = New System.Windows.Forms.RadioButton()
        Me.rbCifrar = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbClave = New System.Windows.Forms.TextBox()
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
        Me.btnSalir.Location = New System.Drawing.Point(222, 209)
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
        Me.label1.Location = New System.Drawing.Point(60, 9)
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
        Me.btnEntrar.Location = New System.Drawing.Point(72, 209)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(90, 42)
        Me.btnEntrar.TabIndex = 14
        Me.btnEntrar.Text = "ENTRAR"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbClave)
        Me.GroupBox1.Controls.Add(Me.labelClave)
        Me.GroupBox1.Controls.Add(Me.labelPublica)
        Me.GroupBox1.Controls.Add(Me.cbVerClave)
        Me.GroupBox1.Controls.Add(Me.labelPrivada)
        Me.GroupBox1.Controls.Add(Me.rbDescifrar)
        Me.GroupBox1.Controls.Add(Me.rbCifrar)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 125)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "¿Qué desea hacer?"
        '
        'labelClave
        '
        Me.labelClave.AutoSize = True
        Me.labelClave.Location = New System.Drawing.Point(9, 62)
        Me.labelClave.Name = "labelClave"
        Me.labelClave.Size = New System.Drawing.Size(37, 13)
        Me.labelClave.TabIndex = 7
        Me.labelClave.Text = "Clave:"
        Me.labelClave.Visible = False
        '
        'labelPublica
        '
        Me.labelPublica.AutoSize = True
        Me.labelPublica.Location = New System.Drawing.Point(8, 62)
        Me.labelPublica.Name = "labelPublica"
        Me.labelPublica.Size = New System.Drawing.Size(75, 13)
        Me.labelPublica.TabIndex = 6
        Me.labelPublica.Text = "Clave Pública:"
        Me.labelPublica.Visible = False
        '
        'cbVerClave
        '
        Me.cbVerClave.AutoSize = True
        Me.cbVerClave.Enabled = False
        Me.cbVerClave.Location = New System.Drawing.Point(280, 92)
        Me.cbVerClave.Name = "cbVerClave"
        Me.cbVerClave.Size = New System.Drawing.Size(72, 17)
        Me.cbVerClave.TabIndex = 5
        Me.cbVerClave.Text = "Ver Clave"
        Me.cbVerClave.UseVisualStyleBackColor = True
        '
        'labelPrivada
        '
        Me.labelPrivada.AutoSize = True
        Me.labelPrivada.Location = New System.Drawing.Point(8, 62)
        Me.labelPrivada.Name = "labelPrivada"
        Me.labelPrivada.Size = New System.Drawing.Size(76, 13)
        Me.labelPrivada.TabIndex = 4
        Me.labelPrivada.Text = "Clave Privada:"
        Me.labelPrivada.Visible = False
        '
        'rbDescifrar
        '
        Me.rbDescifrar.AutoSize = True
        Me.rbDescifrar.Location = New System.Drawing.Point(183, 31)
        Me.rbDescifrar.Name = "rbDescifrar"
        Me.rbDescifrar.Size = New System.Drawing.Size(67, 17)
        Me.rbDescifrar.TabIndex = 1
        Me.rbDescifrar.TabStop = True
        Me.rbDescifrar.Text = "Descifrar"
        Me.rbDescifrar.UseVisualStyleBackColor = True
        '
        'rbCifrar
        '
        Me.rbCifrar.AutoSize = True
        Me.rbCifrar.Location = New System.Drawing.Point(78, 31)
        Me.rbCifrar.Name = "rbCifrar"
        Me.rbCifrar.Size = New System.Drawing.Size(49, 17)
        Me.rbCifrar.TabIndex = 0
        Me.rbCifrar.TabStop = True
        Me.rbCifrar.Text = "Cifrar"
        Me.rbCifrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(347, 26)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "NOTA: Sólo tienes tres intentos para poder ingresar, después de estos,  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "se desh" &
    "abilitará todo el formulario y tendras que reiniciar el ejecutable."
        '
        'tbClave
        '
        Me.tbClave.Enabled = False
        Me.tbClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbClave.Location = New System.Drawing.Point(6, 88)
        Me.tbClave.Name = "tbClave"
        Me.tbClave.Size = New System.Drawing.Size(268, 22)
        Me.tbClave.TabIndex = 22
        Me.tbClave.UseSystemPasswordChar = True
        '
        'Bienvenido
        '
        Me.AcceptButton = Me.btnEntrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(384, 313)
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
    Friend WithEvents rbDescifrar As RadioButton
    Friend WithEvents rbCifrar As RadioButton
    Friend WithEvents labelClave As Label
    Friend WithEvents labelPublica As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbClave As TextBox
End Class
