Public Class frmListado
    Dim metodos As New metodosListado
    Private Sub frmListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        metodos.leerFichero(Me)

    End Sub
End Class