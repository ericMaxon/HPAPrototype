Public Class Farmacia

    Private Codigo As Integer
    Private cantidad As Integer
    Private cantPaquete As Integer
    Private unidad As String

    Public Sub New(_codigo As Integer, _cantidad As Integer, _unidad As String, _cantPaquete As Integer)
        Codigo = _codigo
        cantidad = _cantidad
        unidad = _unidad
        cantPaquete = _cantPaquete
    End Sub

    Public Property CodigoProp As Integer
        Get
            Return Codigo
        End Get
        Set(value As Integer)
            Codigo = value
        End Set
    End Property

    Public Property CantidadProp As Integer
        Get
            Return cantidad
        End Get
        Set(value As Integer)
            cantidad = value
        End Set
    End Property

    Public Property unidadProp As String
        Get
            Return unidad
        End Get
        Set(value As String)
            unidad = value
        End Set
    End Property

    Public Property CantPaqueteProp As Integer
        Get
            Return cantPaquete
        End Get
        Set(value As Integer)
            cantPaquete = value
        End Set
    End Property
End Class
