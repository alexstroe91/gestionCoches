Public Class metodosAltas

    Public Shared dic As New Dictionary(Of String, coche)

    Public Sub cargar()
        Dim coche1 As New coche()
        coche1.Matricula = "1234ddd"
        coche1.Marca = "Kia"
        coche1.Modelo = "ceed"
        coche1.NumPlazas = 5
        Dim coche2 As New coche()
        coche2.Matricula = "1233yyy"
        coche2.Marca = "citr"
        coche2.Modelo = "pepe"
        coche2.NumPlazas = 5

        dic.Add("1234ddd", coche1)
        dic.Add("2222yyy", coche2)

        For Each ch In dic.Values

            MessageBox.Show(ch.Matricula)

        Next
    End Sub


End Class
