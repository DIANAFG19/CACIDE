<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImagenCifrada
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
        Me.pbImagenCifrada = New System.Windows.Forms.PictureBox()
        CType(Me.pbImagenCifrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbImagenCifrada
        '
        Me.pbImagenCifrada.BackColor = System.Drawing.Color.White
        Me.pbImagenCifrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImagenCifrada.Location = New System.Drawing.Point(34, 34)
        Me.pbImagenCifrada.Name = "pbImagenCifrada"
        Me.pbImagenCifrada.Size = New System.Drawing.Size(195, 146)
        Me.pbImagenCifrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagenCifrada.TabIndex = 14
        Me.pbImagenCifrada.TabStop = False
        '
        'ImagenCifrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 403)
        Me.Controls.Add(Me.pbImagenCifrada)
        Me.Name = "ImagenCifrada"
        Me.Text = "ImagenCifrada"
        CType(Me.pbImagenCifrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbImagenCifrada As PictureBox
End Class
