Public Class Propietario
    Dim _DNI As String
    Dim _nombre As String
    Dim _apellido As String
    Dim _fechadenac As String

    Public Property DNI() As String
        Get
            Return _DNI
        End Get
        Set(ByVal Value As String)
            _DNI = Value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal Value As String)
            _nombre = Value
        End Set
    End Property

    Public Property apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal Value As String)
            _apellido = Value
        End Set
    End Property

    Public Property fechadenac() As String
        Get
            Return _fechadenac
        End Get
        Set(ByVal Value As String)
            _fechadenac = Value
        End Set
    End Property
End Class
