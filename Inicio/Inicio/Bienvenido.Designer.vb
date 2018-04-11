<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bienvenido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnDescifrar = New System.Windows.Forms.Button()
        Me.btnCifrar = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDescifrar
        '
        Me.btnDescifrar.BackColor = System.Drawing.Color.OrangeRed
        Me.btnDescifrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDescifrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDescifrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDescifrar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescifrar.ForeColor = System.Drawing.Color.Black
        Me.btnDescifrar.Location = New System.Drawing.Point(173, 87)
        Me.btnDescifrar.Name = "btnDescifrar"
        Me.btnDescifrar.Size = New System.Drawing.Size(95, 42)
        Me.btnDescifrar.TabIndex = 1
        Me.btnDescifrar.Text = "DESCIFRAR"
        Me.btnDescifrar.UseVisualStyleBackColor = False
        '
        'btnCifrar
        '
        Me.btnCifrar.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCifrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCifrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCifrar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCifrar.ForeColor = System.Drawing.Color.Black
        Me.btnCifrar.Location = New System.Drawing.Point(28, 87)
        Me.btnCifrar.Name = "btnCifrar"
        Me.btnCifrar.Size = New System.Drawing.Size(90, 42)
        Me.btnCifrar.TabIndex = 0
        Me.btnCifrar.Text = "CIFRAR"
        Me.btnCifrar.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.label1.Location = New System.Drawing.Point(17, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(266, 39)
        Me.label1.TabIndex = 26
        Me.label1.Text = "¡¡BIENVENIDO!!"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Location = New System.Drawing.Point(160, 162)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(128, 42)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "CERRAR SESIÓN"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnPerfil
        '
        Me.btnPerfil.BackColor = System.Drawing.Color.OrangeRed
        Me.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPerfil.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerfil.ForeColor = System.Drawing.Color.Black
        Me.btnPerfil.Location = New System.Drawing.Point(27, 162)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(90, 42)
        Me.btnPerfil.TabIndex = 2
        Me.btnPerfil.Text = "MI PERFIL"
        Me.btnPerfil.UseVisualStyleBackColor = False
        '
        'Bienvenido
        '
        Me.AcceptButton = Me.btnCifrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(312, 233)
        Me.Controls.Add(Me.btnPerfil)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnDescifrar)
        Me.Controls.Add(Me.btnCifrar)
        Me.Name = "Bienvenido"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDescifrar As Button
    Friend WithEvents btnCifrar As Button
    Private WithEvents label1 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnPerfil As Button
End Class
