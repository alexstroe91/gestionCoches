Public Class frmPrincipal
    Dim metodos As New metodosAltas

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAltas_Click(sender As Object, e As EventArgs) Handles btnAltas.Click
        Dim frm As New frmAltas
        frm.Show()
    End Sub
End Class
