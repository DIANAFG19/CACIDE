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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbTextoCifrar = New System.Windows.Forms.TextBox()
        Me.btnCifrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbImagenCifrada = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tbInformacion = New System.Windows.Forms.RichTextBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbImagenCifrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.GroupBox2.Location = New System.Drawing.Point(7, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 161)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
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
        'tbTextoCifrar
        '
        Me.tbTextoCifrar.AcceptsReturn = True
        Me.tbTextoCifrar.Location = New System.Drawing.Point(5, 39)
        Me.tbTextoCifrar.MaxLength = 1000
        Me.tbTextoCifrar.Multiline = True
        Me.tbTextoCifrar.Name = "tbTextoCifrar"
        Me.tbTextoCifrar.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbTextoCifrar.Size = New System.Drawing.Size(373, 109)
        Me.tbTextoCifrar.TabIndex = 3
        '
        'btnCifrar
        '
        Me.btnCifrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCifrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCifrar.Location = New System.Drawing.Point(433, 26)
        Me.btnCifrar.Name = "btnCifrar"
        Me.btnCifrar.Size = New System.Drawing.Size(103, 27)
        Me.btnCifrar.TabIndex = 2
        Me.btnCifrar.Text = "Cifrar"
        Me.btnCifrar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.pbImagenCifrada)
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Controls.Add(Me.tbInformacion)
        Me.Panel2.Controls.Add(Me.btnCargar)
        Me.Panel2.Controls.Add(Me.pbImagen)
        Me.Panel2.Location = New System.Drawing.Point(3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(568, 242)
        Me.Panel2.TabIndex = 33
        '
        'pbImagenCifrada
        '
        Me.pbImagenCifrada.BackColor = System.Drawing.Color.White
        Me.pbImagenCifrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImagenCifrada.Location = New System.Drawing.Point(358, 13)
        Me.pbImagenCifrada.Name = "pbImagenCifrada"
        Me.pbImagenCifrada.Size = New System.Drawing.Size(195, 183)
        Me.pbImagenCifrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagenCifrada.TabIndex = 1
        Me.pbImagenCifrada.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(404, 204)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(104, 24)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar Imagen"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'tbInformacion
        '
        Me.tbInformacion.BackColor = System.Drawing.Color.White
        Me.tbInformacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbInformacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbInformacion.ForeColor = System.Drawing.Color.Black
        Me.tbInformacion.Location = New System.Drawing.Point(221, 42)
        Me.tbInformacion.Name = "tbInformacion"
        Me.tbInformacion.ReadOnly = True
        Me.tbInformacion.Size = New System.Drawing.Size(124, 129)
        Me.tbInformacion.TabIndex = 33
        Me.tbInformacion.Text = ""
        '
        'btnCargar
        '
        Me.btnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.Location = New System.Drawing.Point(39, 202)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(124, 26)
        Me.btnCargar.TabIndex = 0
        Me.btnCargar.Text = "Cargar Imagen"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'pbImagen
        '
        Me.pbImagen.BackColor = System.Drawing.Color.White
        Me.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImagen.Location = New System.Drawing.Point(12, 13)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(195, 183)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 29
        Me.pbImagen.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(433, 74)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(103, 25)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(433, 122)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(103, 25)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnCifrar)
        Me.Panel1.Location = New System.Drawing.Point(3, 250)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 176)
        Me.Panel1.TabIndex = 34
        '
        'Cifrar
        '
        Me.AcceptButton = Me.btnCifrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(581, 434)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Cifrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cifrar"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.pbImagenCifrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents btnCargar As Button
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents pbImagenCifrada As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbInformacion As RichTextBox
End Class
