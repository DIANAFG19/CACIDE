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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbTamImagen = New System.Windows.Forms.RichTextBox()
        Me.tbInformacion = New System.Windows.Forms.RichTextBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.pbImagenCifrada = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMostrarClave = New System.Windows.Forms.CheckBox()
        Me.tbClave = New System.Windows.Forms.TextBox()
        Me.tbCarga = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbImagenCifrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 297)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 138)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Texto a Cifrar:"
        '
        'tbTextoCifrar
        '
        Me.tbTextoCifrar.AcceptsReturn = True
        Me.tbTextoCifrar.Location = New System.Drawing.Point(6, 34)
        Me.tbTextoCifrar.Multiline = True
        Me.tbTextoCifrar.Name = "tbTextoCifrar"
        Me.tbTextoCifrar.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbTextoCifrar.Size = New System.Drawing.Size(424, 98)
        Me.tbTextoCifrar.TabIndex = 3
        '
        'btnCifrar
        '
        Me.btnCifrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCifrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCifrar.Location = New System.Drawing.Point(10, 10)
        Me.btnCifrar.Name = "btnCifrar"
        Me.btnCifrar.Size = New System.Drawing.Size(103, 27)
        Me.btnCifrar.TabIndex = 22
        Me.btnCifrar.Text = "Cifrar"
        Me.btnCifrar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.tbTamImagen)
        Me.Panel1.Controls.Add(Me.tbInformacion)
        Me.Panel1.Controls.Add(Me.btnCargar)
        Me.Panel1.Controls.Add(Me.pbImagenCifrada)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.pbImagen)
        Me.Panel1.Location = New System.Drawing.Point(12, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(573, 233)
        Me.Panel1.TabIndex = 27
        '
        'tbTamImagen
        '
        Me.tbTamImagen.BackColor = System.Drawing.Color.White
        Me.tbTamImagen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbTamImagen.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbTamImagen.ForeColor = System.Drawing.Color.Black
        Me.tbTamImagen.Location = New System.Drawing.Point(217, 149)
        Me.tbTamImagen.Name = "tbTamImagen"
        Me.tbTamImagen.ReadOnly = True
        Me.tbTamImagen.Size = New System.Drawing.Size(138, 21)
        Me.tbTamImagen.TabIndex = 12
        Me.tbTamImagen.Text = ""
        '
        'tbInformacion
        '
        Me.tbInformacion.BackColor = System.Drawing.Color.White
        Me.tbInformacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbInformacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbInformacion.ForeColor = System.Drawing.Color.Black
        Me.tbInformacion.Location = New System.Drawing.Point(217, 25)
        Me.tbInformacion.Name = "tbInformacion"
        Me.tbInformacion.ReadOnly = True
        Me.tbInformacion.Size = New System.Drawing.Size(138, 122)
        Me.tbInformacion.TabIndex = 11
        Me.tbInformacion.Text = ""
        '
        'btnCargar
        '
        Me.btnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.Location = New System.Drawing.Point(42, 196)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(124, 26)
        Me.btnCargar.TabIndex = 1
        Me.btnCargar.Text = "Cargar Imagen"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'pbImagenCifrada
        '
        Me.pbImagenCifrada.BackColor = System.Drawing.Color.White
        Me.pbImagenCifrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImagenCifrada.Location = New System.Drawing.Point(370, 7)
        Me.pbImagenCifrada.Name = "pbImagenCifrada"
        Me.pbImagenCifrada.Size = New System.Drawing.Size(195, 183)
        Me.pbImagenCifrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagenCifrada.TabIndex = 1
        Me.pbImagenCifrada.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(448, 197)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(61, 26)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'pbImagen
        '
        Me.pbImagen.BackColor = System.Drawing.Color.White
        Me.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImagen.Location = New System.Drawing.Point(7, 7)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(195, 183)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 0
        Me.pbImagen.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(10, 53)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(103, 25)
        Me.btnLimpiar.TabIndex = 25
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 98)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(103, 25)
        Me.btnSalir.TabIndex = 26
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Clave Privada:"
        '
        'cbMostrarClave
        '
        Me.cbMostrarClave.AutoSize = True
        Me.cbMostrarClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMostrarClave.Location = New System.Drawing.Point(458, 23)
        Me.cbMostrarClave.Name = "cbMostrarClave"
        Me.cbMostrarClave.Size = New System.Drawing.Size(90, 17)
        Me.cbMostrarClave.TabIndex = 23
        Me.cbMostrarClave.Text = "Mostrar clave"
        Me.cbMostrarClave.UseVisualStyleBackColor = True
        '
        'tbClave
        '
        Me.tbClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbClave.Location = New System.Drawing.Point(121, 19)
        Me.tbClave.Name = "tbClave"
        Me.tbClave.Size = New System.Drawing.Size(321, 22)
        Me.tbClave.TabIndex = 21
        Me.tbClave.UseSystemPasswordChar = True
        '
        'tbCarga
        '
        Me.tbCarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCarga.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCarga.ForeColor = System.Drawing.Color.Blue
        Me.tbCarga.Location = New System.Drawing.Point(-4, 441)
        Me.tbCarga.Name = "tbCarga"
        Me.tbCarga.ReadOnly = True
        Me.tbCarga.Size = New System.Drawing.Size(601, 22)
        Me.tbCarga.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbMostrarClave)
        Me.GroupBox1.Controls.Add(Me.tbClave)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 56)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCifrar)
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.Controls.Add(Me.btnSalir)
        Me.GroupBox3.Location = New System.Drawing.Point(460, 297)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(121, 138)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        '
        'Cifrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 462)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tbCarga)
        Me.Name = "Cifrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cifrar"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbImagenCifrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTextoCifrar As TextBox
    Friend WithEvents btnCifrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbInformacion As RichTextBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents pbImagenCifrada As PictureBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbMostrarClave As CheckBox
    Friend WithEvents tbClave As TextBox
    Friend WithEvents tbCarga As TextBox
    Friend WithEvents tbTamImagen As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
