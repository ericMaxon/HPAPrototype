Imports Microsoft.VisualBasic

Public Class Recetado

    Private Codigo As Integer
    Private cantidad As Integer
    Private dosis As String

    Public Sub New(_codigo As Integer, _cantidad As Integer, _dosis As String)
        Codigo = _codigo
        cantidad = _cantidad
        dosis = _dosis
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

    Public Property DosisProp As String
        Get
            Return dosis
        End Get
        Set(value As String)
            dosis = value
        End Set
    End Property
End Class
