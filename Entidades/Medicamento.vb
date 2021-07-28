Imports Microsoft.VisualBasic

Public Class Medicamento

    Private Codigo As Integer
    Private cantidad As Integer
    Private canPaquete As Integer
    Private unidad As String

    Public Sub New(_codigo As Integer, _cantidad As Integer, _cantPaquete As Integer, _unidad As String)
        Codigo = _codigo
        cantidad = _cantidad
        cantPaquete = _cantPaquete
        unidad = _unidad
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

    Public Property CanPaqueteProp As Integer
        Get
            Return canPaquete
        End Get
        Set(value As Integer)
            canPaquete = value
        End Set
    End Property

    Public Property UnidadProp As String
        Get
            Return unidad
        End Get
        Set(value As String)
            unidad = value
        End Set
    End Property
End Class
