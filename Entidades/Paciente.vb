Imports System.Data.SqlClient
Public Class Paciente
    Private Cedula As String
    Private Nombre As String
    Private Telefono As String
    Private Correo As String
    Private Edad As Integer
    Private Altura As Double
    Private Peso As Double
    Private Citas As List(Of Cita)
    ' Cuando se registra el usuario
    Public Sub New(Cedula As String, Nombre As String, Telefono As String, Correo As String, Edad As Integer)
        Me.Cedula = Cedula
        Me.Nombre = Nombre
        Me.Telefono = Telefono
        Me.Correo = Correo
        Me.Edad = Edad
    End Sub
    ' Cuando el usuario tiene informacion en la base de datos
    Public Sub New(Cedula As String, Nombre As String, Telefono As String, Correo As String, Edad As Integer, Peso As Double, Altura As Double)
        Me.Cedula = Cedula
        Me.Nombre = Nombre
        Me.Telefono = Telefono
        Me.Correo = Correo
        Me.Edad = Edad
        Me.Peso = Peso
        Me.Altura = Altura
    End Sub

    Public Sub AñadeCita(_cita As Cita)
        Citas.Add(_cita)
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

    Public Property CorreoProp As String
        Get
            Return Correo
        End Get
        Set(value As String)
            Correo = value
        End Set
    End Property

    Public Property EdadProp As Integer
        Get
            Return Edad
        End Get
        Set(value As Integer)
            Edad = value
        End Set
    End Property

    Public Property AlturaProp As Double
        Get
            Return Altura
        End Get
        Set(value As Double)
            Altura = value
        End Set
    End Property

    Public Property PesoProp As Double
        Get
            Return Peso
        End Get
        Set(value As Double)
            Peso = value
        End Set
    End Property

    Public Property CitasProp As List(Of Cita)
        Get
            Return Citas
        End Get
        Set(value As List(Of Cita))
            Citas = value
        End Set
    End Property
End Class
