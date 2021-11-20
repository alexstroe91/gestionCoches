Public Class frmPrincipal
    Dim metodos As New metodosPrincipal

    Private Sub btnAltas_Click(sender As Object, e As EventArgs) Handles btnAltas.Click
        Dim frm As New frmAltas
        frm.Show()
    End Sub

    Private Sub btnListado_Click(sender As Object, e As EventArgs) Handles btnListado.Click
        Dim frm As New frmListado
        frm.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim metodosAltas As New metodosAltas
        metodos.cargarDiccionario(metodosAltas.dic)
    End Sub
End Class
