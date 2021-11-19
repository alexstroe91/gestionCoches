Public Class coche

    Dim _matricula, _marca, _modelo, _color As String
    Dim _numPlazas As Integer

    Public Sub New()

    End Sub

    Public Sub New(_matricula As String, _marca As String, _modelo As String, _color As String, _numPlazas As Integer)
        Me._matricula = _matricula
        Me._marca = _marca
        Me._modelo = _modelo
        Me._color = _color
        Me._numPlazas = _numPlazas
    End Sub

    Public Property Color As String
        Get
            Return _color
        End Get
        Set(value As String)
            _color = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property Matricula As String
        Get
            Return _matricula
        End Get
        Set(value As String)
            _matricula = value
        End Set
    End Property

    Public Property Modelo As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property

    Public Property NumPlazas As Integer
        Get
            Return _numPlazas
        End Get
        Set(value As Integer)
            _numPlazas = value
        End Set
    End Property
End Class
