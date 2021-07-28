Public Class Medicamento
    Private Codigo As Integer
    Private Nombre As String
    Private Imagen As String
    Private CantXPaquete As Integer
    Private Unidad As String

    Public Sub New(_Codigo As Integer, _Nombre As String, _Imagen As String, _Cant As Integer, _Unidad As String)
        Codigo = _Codigo
        Nombre = _Nombre
        Imagen = _Imagen
        CantXPaquete = _Cant
        Unidad = _Unidad
    End Sub
    Public Property CodigoProp As Integer
        Get
            Return Codigo
        End Get
        Set(value As Integer)
            Codigo = value
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

    Public Property ImagenProp As String
        Get
            Return Imagen
        End Get
        Set(value As String)
            Imagen = value
        End Set
    End Property

    Public Property CantXPaqueteProp As Integer
        Get
            Return CantXPaquete
        End Get
        Set(value As Integer)
            CantXPaquete = value
        End Set
    End Property

    Public Property UnidadProp As String
        Get
            Return Unidad
        End Get
        Set(value As String)
            Unidad = value
        End Set
    End Property
End Class