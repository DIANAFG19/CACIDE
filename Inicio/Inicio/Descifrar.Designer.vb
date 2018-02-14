<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Descifrar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbClave = New System.Windows.Forms.TextBox()
        Me.cbVerClave = New System.Windows.Forms.CheckBox()
        Me.gbClave = New System.Windows.Forms.GroupBox()
        Me.gbClave.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese una contraseña de seguridad:"
        '
        'tbClave
        '
        Me.tbClave.Location = New System.Drawing.Point(207, 18)
        Me.tbClave.Name = "tbClave"
        Me.tbClave.Size = New System.Drawing.Size(193, 20)
        Me.tbClave.TabIndex = 1
        '
        'cbVerClave
        '
        Me.cbVerClave.AutoSize = True
        Me.cbVerClave.Location = New System.Drawing.Point(9, 51)
        Me.cbVerClave.Name = "cbVerClave"
        Me.cbVerClave.Size = New System.Drawing.Size(98, 17)
        Me.cbVerClave.TabIndex = 2
        Me.cbVerClave.Text = "Ver contraseña"
        Me.cbVerClave.UseVisualStyleBackColor = True
        '
        'gbClave
        '
        Me.gbClave.Controls.Add(Me.Label1)
        Me.gbClave.Controls.Add(Me.cbVerClave)
        Me.gbClave.Controls.Add(Me.tbClave)
        Me.gbClave.Location = New System.Drawing.Point(23, 27)
        Me.gbClave.Name = "gbClave"
        Me.gbClave.Size = New System.Drawing.Size(553, 66)
        Me.gbClave.TabIndex = 3
        Me.gbClave.TabStop = False
        Me.gbClave.Text = "Contraseña de Seguridad"
        '
        'Descifrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 357)
        Me.Controls.Add(Me.gbClave)
        Me.Name = "Descifrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descifrar"
        Me.gbClave.ResumeLayout(False)
        Me.gbClave.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbClave As TextBox
    Friend WithEvents cbVerClave As CheckBox
    Friend WithEvents gbClave As GroupBox
End Class
