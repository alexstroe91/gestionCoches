Public Class frmAltas
    Dim metodos As New metodosAltas()
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        'se comprueba que no esten los campos vacios
        If metodos.comprobarVacios(Me) Then
            MessageBox.Show("Tienes que rellenar los campos obligatorios.")
            txtMatricula.Focus()
        Else
            metodos.introducirCocheDiccionario(Me)
        End If
    End Sub

End Class