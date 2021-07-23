Imports System.Data.SqlClient
Public Class Controlador
    Private conn As SqlConnection
    Private command As SqlCommand
    Private adap As SqlDataAdapter

    Public Sub New()
        Dim connString = My.MySettings.Default.DB_ProyectoFInal2021ConnectionString
        conn = New SqlConnection(connString)
        command = New SqlCommand()
    End Sub
    ' Obtencion de la data del db
    Public Function obtenerDatos(query As String) As SqlDataReader
        conn.Open()
        command.CommandText = query
        command.Connection = conn
        Dim response = command.ExecuteReader
        Return response
    End Function
    ' Obtencion de las filas afectadas segun el query
    Public Function NonQuery(query As String) As Integer
        conn.Open()
        command.CommandText = query
        command.Connection = conn
        Dim affectedRows = command.ExecuteNonQuery
        Return affectedRows
    End Function

End Class
