Imports System.IO

Public Class metodosPrincipal

    Public Sub cargarDiccionario(dic As Dictionary(Of String, coche))

        Try
            'creamos el flujo de lectura
            Dim sr As New StreamReader(".\DatosAlmacenadosCoches\coches.txt")
            'creamos un objeto coche y un string vacio
            Dim ch As New coche
            Dim linea As String = Nothing
            Do While Not sr.EndOfStream
                'mientras que no sea el final del fichero
                'a la variable "linea" le pasamos la linea que lee el SR del fichero
                linea = sr.ReadLine
                'despues la separamos con la funcion Split y lo que hacemos es pasarle cada elemento de la linea a los atributos del obj coche
                ch.Matricula = Split(linea, ";")(0)
                ch.Marca = Split(linea, ";")(1)
                ch.Modelo = Split(linea, ";")(2)
                ch.Color = Split(linea, ";")(3)
                ch.NumPlazas = CInt(Split(linea, ";")(4))

                'por ultimo añadimos lo leido al diccionario
                dic.Add(ch.Matricula, ch)
            Loop
            sr.Close()
        Catch ex As Exception
            MessageBox.Show("--Error-- : " & ex.Message)
        End Try

    End Sub



End Class
