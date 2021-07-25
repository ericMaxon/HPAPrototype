Public Class Cita
    Private NombreDOC As String
    Private FechaDeCita As String
    Private Hora As String
    Private Motivo As String

    Public Sub New(_NombreDOC As String, _FechaDeCita As String, _Hora As String, _Motivo As String)
        NombreDOC = _NombreDOC
        FechaDeCita = _FechaDeCita
        Hora = _Hora
        Motivo = _Motivo
    End Sub

    Public Property NombreDOCProp As String
        Get
            Return NombreDOC
        End Get
        Set(value As String)
            NombreDOC = value
        End Set
    End Property

    Public Property FechaDeCitaProp As String
        Get
            Return FechaDeCita
        End Get
        Set(value As String)
            FechaDeCita = value
        End Set
    End Property

    Public Property HoraProp As String
        Get
            Return Hora
        End Get
        Set(value As String)
            Hora = value
        End Set
    End Property

    Public Property MotivoProp As String
        Get
            Return Motivo
        End Get
        Set(value As String)
            Motivo = value
        End Set
    End Property
End Class
