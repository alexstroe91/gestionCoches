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

        MessageBox.Show(CStr(dic.Count))
    End Sub

    'comprobar si estan vacios los campos de matricula marca y modelo
    Public Function comprobarVacios(frm As frmAltas) As Boolean
        With frm
            If .txtMatricula.Text Is "" Or .txtMarca.Text Is "" Or .txtModelo.Text Is "" Then
                Return True
            Else
                Return False
            End If
        End With
    End Function



End Class
