Imports System.IO

Public Class metodosListado

    Public Sub leerFichero(frm As frmListado)
        Dim sr As New StreamReader(".\DatosAlmacenadosCoches\coches.txt")
        Dim ch As New coche
        Dim linea As String = Nothing
        Do While Not sr.EndOfStream
            linea = sr.ReadLine
            ch.Matricula = Split(linea, ";")(0)
            ch.Marca = Split(linea, ";")(1)
            ch.Modelo = Split(linea, ";")(2)
            ch.Color = Split(linea, ";")(3)
            ch.NumPlazas = CInt(Split(linea, ";")(4))

            frm.dgvListadoCoches.Rows.Add(ch.Matricula, ch.Marca, ch.Modelo, ch.Color, ch.NumPlazas)
        Loop
        sr.Close()
    End Sub

End Class
