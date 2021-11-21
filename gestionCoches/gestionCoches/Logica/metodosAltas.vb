Imports System.IO

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

    Public Function introducirCocheDiccionario(frm As frmAltas) As Boolean
        'añado un nuevo elemento coche al diccionario y grabo esa linea en el txt
        Try
            With frm

                Dim numeroPlazas As Integer
                If .txtPlazas.Text Is "" Then
                    numeroPlazas = 0
                Else
                    numeroPlazas = CInt(.txtPlazas.Text)
                End If

                Dim coche As New coche(.txtMatricula.Text, .txtMarca.Text, .txtModelo.Text, .txtColor.Text, numeroPlazas)
                dic.Add(.txtMatricula.Text, coche)
                Dim linea As String = .txtMatricula.Text & ";" & .txtMarca.Text & ";" & .txtModelo.Text & ";" & .txtColor.Text & ";" & CStr(numeroPlazas)
                grabarEnFichero(linea)
            End With
            Return True
        Catch ex As Exception
            MessageBox.Show("--Error--: " & ex.Message)
            Return False
        End Try

    End Function

    Public Sub vaciarCampos(frm As frmAltas)
        With frm
            .txtMatricula.Text = ""
            .txtMarca.Text = ""
            .txtModelo.Text = ""
            .txtColor.Text = ""
            .txtPlazas.Text = ""
        End With
    End Sub

    Public Sub grabarEnFichero(linea As String)
        'escribimos en el archivo sin sobreescribir los datos ya almacenados con la opcion True
        Try
            Dim sw As New StreamWriter(".\DatosAlmacenadosCoches\coches.txt", True)
            sw.WriteLine(linea)
            sw.Close()
        Catch ex As Exception
            MessageBox.Show("--Error--: " & ex.Message)
        End Try

    End Sub

End Class
