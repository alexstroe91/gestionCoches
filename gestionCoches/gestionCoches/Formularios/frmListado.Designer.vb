<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListado
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
        Me.dgvListadoCoches = New System.Windows.Forms.DataGridView()
        Me.Plazas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvListadoCoches, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListadoCoches
        '
        Me.dgvListadoCoches.AllowUserToAddRows = False
        Me.dgvListadoCoches.AllowUserToDeleteRows = False
        Me.dgvListadoCoches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoCoches.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Matricula, Me.Marca, Me.Modelo, Me.Color, Me.Plazas})
        Me.dgvListadoCoches.Location = New System.Drawing.Point(0, 0)
        Me.dgvListadoCoches.Name = "dgvListadoCoches"
        Me.dgvListadoCoches.ReadOnly = True
        Me.dgvListadoCoches.Size = New System.Drawing.Size(555, 286)
        Me.dgvListadoCoches.TabIndex = 0
        '
        'Plazas
        '
        Me.Plazas.HeaderText = "Plazas"
        Me.Plazas.Name = "Plazas"
        Me.Plazas.ReadOnly = True
        '
        'Color
        '
        Me.Color.HeaderText = "Color"
        Me.Color.Name = "Color"
        Me.Color.ReadOnly = True
        '
        'Modelo
        '
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        '
        'Matricula
        '
        Me.Matricula.HeaderText = "Matricula"
        Me.Matricula.Name = "Matricula"
        Me.Matricula.ReadOnly = True
        '
        'frmListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 286)
        Me.Controls.Add(Me.dgvListadoCoches)
        Me.Name = "frmListado"
        Me.Text = "frmListado"
        CType(Me.dgvListadoCoches, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvListadoCoches As DataGridView
    Friend WithEvents Matricula As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Modelo As DataGridViewTextBoxColumn
    Friend WithEvents Color As DataGridViewTextBoxColumn
    Friend WithEvents Plazas As DataGridViewTextBoxColumn
End Class
