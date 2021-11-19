<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltas
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPlazas = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPlazas = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.lblAñadido = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(179, 97)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtPlazas)
        Me.Panel1.Controls.Add(Me.txtColor)
        Me.Panel1.Controls.Add(Me.txtModelo)
        Me.Panel1.Controls.Add(Me.txtMarca)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtMatricula)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 172)
        Me.Panel1.TabIndex = 53
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(256, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(160, 16)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "* campos obligatorios"
        '
        'txtPlazas
        '
        Me.txtPlazas.Location = New System.Drawing.Point(100, 141)
        Me.txtPlazas.MaxLength = 30
        Me.txtPlazas.Name = "txtPlazas"
        Me.txtPlazas.Size = New System.Drawing.Size(100, 20)
        Me.txtPlazas.TabIndex = 36
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(101, 109)
        Me.txtColor.MaxLength = 30
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColor.TabIndex = 35
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(100, 78)
        Me.txtModelo.MaxLength = 30
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(100, 20)
        Me.txtModelo.TabIndex = 34
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(100, 46)
        Me.txtMarca.MaxLength = 30
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(100, 20)
        Me.txtMarca.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Matricula*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Marca*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Modelo*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Color"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Plazas"
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(100, 14)
        Me.txtMatricula.MaxLength = 30
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(115, 20)
        Me.txtMatricula.TabIndex = 23
        Me.txtMatricula.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(137, 225)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 56
        Me.btnSalir.TabStop = False
        Me.btnSalir.Text = "Salir"
        '
        'btnAñadir
        '
        Me.btnAñadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadir.Location = New System.Drawing.Point(43, 225)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(75, 23)
        Me.btnAñadir.TabIndex = 54
        Me.btnAñadir.TabStop = False
        Me.btnAñadir.Text = "AÑADIR"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblPlazas)
        Me.Panel2.Controls.Add(Me.lblColor)
        Me.Panel2.Controls.Add(Me.lblModelo)
        Me.Panel2.Controls.Add(Me.lblMarca)
        Me.Panel2.Controls.Add(Me.lblMatricula)
        Me.Panel2.Location = New System.Drawing.Point(49, 278)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(349, 183)
        Me.Panel2.TabIndex = 57
        Me.Panel2.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Matricula"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Marca"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Modelo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Color"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 16)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Plazas"
        '
        'lblPlazas
        '
        Me.lblPlazas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlazas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlazas.Location = New System.Drawing.Point(211, 152)
        Me.lblPlazas.Name = "lblPlazas"
        Me.lblPlazas.Size = New System.Drawing.Size(120, 23)
        Me.lblPlazas.TabIndex = 45
        Me.lblPlazas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblColor
        '
        Me.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(211, 115)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(120, 23)
        Me.lblColor.TabIndex = 44
        Me.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModelo
        '
        Me.lblModelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(211, 83)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(120, 23)
        Me.lblModelo.TabIndex = 43
        Me.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMarca
        '
        Me.lblMarca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(211, 48)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(120, 23)
        Me.lblMarca.TabIndex = 42
        Me.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMatricula
        '
        Me.lblMatricula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.Location = New System.Drawing.Point(211, 12)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(120, 23)
        Me.lblMatricula.TabIndex = 41
        Me.lblMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAñadido
        '
        Me.lblAñadido.AutoSize = True
        Me.lblAñadido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAñadido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAñadido.Location = New System.Drawing.Point(236, 197)
        Me.lblAñadido.Name = "lblAñadido"
        Me.lblAñadido.Size = New System.Drawing.Size(199, 16)
        Me.lblAñadido.TabIndex = 38
        Me.lblAñadido.Text = "Coche introducido con éxito"
        Me.lblAñadido.Visible = False
        '
        'frmAltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 473)
        Me.Controls.Add(Me.lblAñadido)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmAltas"
        Me.Text = "ALTAS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents txtPlazas As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAñadir As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPlazas As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblModelo As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblMatricula As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblAñadido As Label
End Class
