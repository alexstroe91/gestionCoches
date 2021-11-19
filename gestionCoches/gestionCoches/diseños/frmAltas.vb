Public Class frmAltas
    Dim metodos As New metodosAltas()
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        'se comprueba que no esten los campos vacios
        If metodos.comprobarVacios(Me) Then
            MessageBox.Show("Tienes que rellenar los campos obligatorios.")
            txtMatricula.Focus()
        Else
            If metodos.introducirCocheDiccionario(Me) Then
                metodos.vaciarCampos(Me)
                lblAñadido.Visible = True
            End If
        End If
    End Sub

    Private Sub txt_textChanged(sender As Object, e As EventArgs) Handles txtMatricula.TextChanged, txtMarca.TextChanged, txtModelo.TextChanged, txtColor.TextChanged, txtPlazas.TextChanged
        lblAñadido.Visible = False

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


End Class