Public Class frmAltas
    Dim metodos As New metodosAltas()
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        If metodos.comprobarVacios(Me) Then
            MessageBox.Show("Tienes que rellenar los campos obligatorios.")
            txtMatricula.Focus()
        End If
    End Sub

End Class