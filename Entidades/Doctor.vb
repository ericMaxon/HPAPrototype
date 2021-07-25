Public Class Doctor
    Private Cedula As String
    Private Nombre As String
    Private Telefono As String

    Public Sub New(_Cedula As String, _Nombre As String, _Telefono As String)
        Cedula = _Cedula
        Nombre = _Nombre
        Telefono = _Telefono
    End Sub

    Public Property CedulaProp As String
        Get
            Return Cedula
        End Get
        Set(value As String)
            Cedula = value
        End Set
    End Property

    Public Property NombreProp As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property TelefonoProp As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
        End Set
    End Property
End Class
