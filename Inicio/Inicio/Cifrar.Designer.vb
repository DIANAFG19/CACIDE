<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cifrar
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
        Me.components = New System.ComponentModel.Container()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbTextoCifrar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCifrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pbImagenCifrada = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.tbInformacion = New System.Windows.Forms.TextBox()
        Me.tbTamImagen = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagenCifrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbTextoCifrar)
        Me.GroupBox2.Location = New System.Drawing.Point(352, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 183)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'tbTextoCifrar
        '
        Me.tbTextoCifrar.AcceptsReturn = True
        Me.tbTextoCifrar.Location = New System.Drawing.Point(5, 39)
        Me.tbTextoCifrar.Multiline = True
        Me.tbTextoCifrar.Name = "tbTextoCifrar"
        Me.tbTextoCifrar.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbTextoCifrar.Size = New System.Drawing.Size(284, 132)
        Me.tbTextoCifrar.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Texto a Cifrar:"
        '
        'btnCifrar
        '
        Me.btnCifrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCifrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCifrar.Location = New System.Drawing.Point(435, 197)
        Me.btnCifrar.Name = "btnCifrar"
        Me.btnCifrar.Size = New System.Drawing.Size(103, 27)
        Me.btnCifrar.TabIndex = 22
        Me.btnCifrar.Text = "Cifrar"
        Me.btnCifrar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.tbTamImagen)
        Me.Panel2.Controls.Add(Me.tbInformacion)
        Me.Panel2.Controls.Add(Me.btnCargar)
        Me.Panel2.Controls.Add(Me.pbImagen)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.btnCifrar)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(665, 241)
        Me.Panel2.TabIndex = 33
        '
        'pbImagen
        '
        Me.pbImagen.BackColor = System.Drawing.Color.White
        Me.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImagen.Location = New System.Drawing.Point(7, 7)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(195, 183)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 29
        Me.pbImagen.TabStop = False
        '
        'btnCargar
        '
        Me.btnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.Location = New System.Drawing.Point(34, 196)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(124, 26)
        Me.btnCargar.TabIndex = 30
        Me.btnCargar.Text = "Cargar Imagen"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(237, 352)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(103, 25)
        Me.btnLimpiar.TabIndex = 25
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(247, 287)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(83, 41)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar Imagen"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'pbImagenCifrada
        '
        Me.pbImagenCifrada.BackColor = System.Drawing.Color.White
        Me.pbImagenCifrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImagenCifrada.Location = New System.Drawing.Point(19, 259)
        Me.pbImagenCifrada.Name = "pbImagenCifrada"
        Me.pbImagenCifrada.Size = New System.Drawing.Size(195, 183)
        Me.pbImagenCifrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagenCifrada.TabIndex = 1
        Me.pbImagenCifrada.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(237, 405)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(103, 25)
        Me.btnSalir.TabIndex = 26
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'tbInformacion
        '
        Me.tbInformacion.Location = New System.Drawing.Point(208, 23)
        Me.tbInformacion.Multiline = True
        Me.tbInformacion.Name = "tbInformacion"
        Me.tbInformacion.Size = New System.Drawing.Size(138, 129)
        Me.tbInformacion.TabIndex = 31
        '
        'tbTamImagen
        '
        Me.tbTamImagen.Location = New System.Drawing.Point(208, 158)
        Me.tbTamImagen.Name = "tbTamImagen"
        Me.tbTamImagen.Size = New System.Drawing.Size(138, 20)
        Me.tbTamImagen.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(364, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 183)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Texto Cifrado en la imagen:"
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.Location = New System.Drawing.Point(5, 39)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(284, 132)
        Me.TextBox1.TabIndex = 3
        '
        'Cifrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 451)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbImagenCifrada)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Cifrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cifrar"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagenCifrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTextoCifrar As TextBox
    Friend WithEvents btnCifrar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbTamImagen As TextBox
    Friend WithEvents tbInformacion As TextBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents pbImagenCifrada As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
