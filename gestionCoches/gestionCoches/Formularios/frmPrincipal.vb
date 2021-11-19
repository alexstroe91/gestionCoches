Public Class frmPrincipal
    Dim metodos As New metodosAltas

    Private Sub btnAltas_Click(sender As Object, e As EventArgs) Handles btnAltas.Click
        Dim frm As New frmAltas
        frm.Show()
    End Sub

    Private Sub btnListado_Click(sender As Object, e As EventArgs) Handles btnListado.Click
        Dim frm As New frmListado
        frm.Show()
    End Sub
End Class
