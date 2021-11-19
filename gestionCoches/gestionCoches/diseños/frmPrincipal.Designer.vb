<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.btnAltas = New System.Windows.Forms.Button()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAltas
        '
        Me.btnAltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltas.Location = New System.Drawing.Point(93, 22)
        Me.btnAltas.Name = "btnAltas"
        Me.btnAltas.Size = New System.Drawing.Size(123, 52)
        Me.btnAltas.TabIndex = 0
        Me.btnAltas.Text = "ALTAS"
        Me.btnAltas.UseVisualStyleBackColor = True
        '
        'btnListado
        '
        Me.btnListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListado.Location = New System.Drawing.Point(93, 110)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(123, 52)
        Me.btnListado.TabIndex = 1
        Me.btnListado.Text = "LISTADO"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 193)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnAltas)
        Me.Name = "frmPrincipal"
        Me.Text = "Gestion coches"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAltas As Button
    Friend WithEvents btnListado As Button
End Class
