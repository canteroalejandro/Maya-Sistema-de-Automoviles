Public Class Automovil
    Dim _patente As String
    Dim _DNI As String
    Dim _marca As String
    Dim _modelo As String
    Dim _ano As String
    Dim _codciudad As String

    Public Property patente() As String
        Get
            Return _patente
        End Get
        Set(ByVal Value As String)
            _patente = Value
        End Set
    End Property

    Public Property DNI() As String
        Get
            Return _DNI
        End Get
        Set(ByVal Value As String)
            _DNI = Value
        End Set
    End Property

    Public Property marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal Value As String)
            _marca = Value
        End Set
    End Property

    Public Property modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal Value As String)
            _modelo = Value
        End Set
    End Property

    Public Property ano() As String
        Get
            Return _ano
        End Get
        Set(ByVal Value As String)
            _ano = Value
        End Set
    End Property

    Public Property codciudad() As String
        Get
            Return _codciudad
        End Get
        Set(ByVal Value As String)
            _codciudad = Value
        End Set
    End Property
End Class
