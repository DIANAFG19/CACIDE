<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Descifrar
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
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.tbInformacion = New System.Windows.Forms.RichTextBox()
        Me.pbImagenCifrada = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnDescifrar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbTextoCifrado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.pbImagenCifrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCargar
        '
        Me.btnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.Location = New System.Drawing.Point(25, 17)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(124, 26)
        Me.btnCargar.TabIndex = 0
        Me.btnCargar.Text = "Cargar Imagen"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'tbInformacion
        '
        Me.tbInformacion.BackColor = System.Drawing.Color.White
        Me.tbInformacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbInformacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbInformacion.ForeColor = System.Drawing.Color.Black
        Me.tbInformacion.Location = New System.Drawing.Point(25, 49)
        Me.tbInformacion.Name = "tbInformacion"
        Me.tbInformacion.ReadOnly = True
        Me.tbInformacion.Size = New System.Drawing.Size(124, 129)
        Me.tbInformacion.TabIndex = 11
        Me.tbInformacion.Text = ""
        '
        'pbImagenCifrada
        '
        Me.pbImagenCifrada.BackColor = System.Drawing.Color.White
        Me.pbImagenCifrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImagenCifrada.Location = New System.Drawing.Point(246, 8)
        Me.pbImagenCifrada.Name = "pbImagenCifrada"
        Me.pbImagenCifrada.Size = New System.Drawing.Size(195, 183)
        Me.pbImagenCifrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagenCifrada.TabIndex = 12
        Me.pbImagenCifrada.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.pbImagenCifrada)
        Me.Panel1.Controls.Add(Me.tbInformacion)
        Me.Panel1.Controls.Add(Me.btnCargar)
        Me.Panel1.Location = New System.Drawing.Point(9, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 201)
        Me.Panel1.TabIndex = 31
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(10, 94)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(103, 25)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(10, 53)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(103, 25)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnDescifrar
        '
        Me.btnDescifrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnDescifrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescifrar.Location = New System.Drawing.Point(10, 10)
        Me.btnDescifrar.Name = "btnDescifrar"
        Me.btnDescifrar.Size = New System.Drawing.Size(103, 27)
        Me.btnDescifrar.TabIndex = 1
        Me.btnDescifrar.Text = "Descifrar"
        Me.btnDescifrar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnDescifrar)
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.Controls.Add(Me.btnSalir)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 228)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(121, 138)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        '
        'tbTextoCifrado
        '
        Me.tbTextoCifrado.AcceptsReturn = True
        Me.tbTextoCifrado.Location = New System.Drawing.Point(6, 34)
        Me.tbTextoCifrado.Multiline = True
        Me.tbTextoCifrado.Name = "tbTextoCifrado"
        Me.tbTextoCifrado.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbTextoCifrado.Size = New System.Drawing.Size(357, 98)
        Me.tbTextoCifrado.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Texto Descifrado:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbTextoCifrado)
        Me.GroupBox2.Location = New System.Drawing.Point(136, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(369, 138)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'Descifrar
        '
        Me.AcceptButton = Me.btnDescifrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(516, 368)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Descifrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descifrar"
        CType(Me.pbImagenCifrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCargar As Button
    Friend WithEvents tbInformacion As RichTextBox
    Friend WithEvents pbImagenCifrada As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnDescifrar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tbTextoCifrado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
