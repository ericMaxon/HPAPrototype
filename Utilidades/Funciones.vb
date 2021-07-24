Imports System.Data.SqlClient
Namespace DateAndTime
    Module Funciones
        ' Obtiene la imagen de una url
        Function ObtenerImagenURL(ByVal url As String) As Image
            Dim imagen As Image = Nothing
            Try
                If Not String.IsNullOrWhiteSpace(url) Then
                    Dim request As Net.WebRequest = Net.WebRequest.Create(url.Trim)

                    Using response As Net.WebResponse = request.GetResponse
                        Using stream As IO.Stream = response.GetResponseStream
                            imagen = New Bitmap(Image.FromStream(stream))
                        End Using
                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show("Error", "URL erronea o ha vencido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            Return imagen
        End Function
        ' Busca en la base de datos si existe el usuario
        Function ObtenerUsuario(cedula As String, telefono As String) As Paciente
            Dim response As SqlDataReader
            Dim pacienteInfo As Paciente = Nothing
            Using connection As New SqlConnection(My.MySettings.Default.DB_ProyectoFInal2021ConnectionString)
                connection.Open()
                Dim comm = New SqlCommand("sp_GetUserIdPAC", connection)
                comm.CommandType = CommandType.StoredProcedure
                comm.Parameters.AddWithValue("@Cedula", cedula)
                comm.Parameters.AddWithValue("@Telefono", telefono)
                Dim existe = comm.ExecuteNonQuery()
                If existe > 0 Then
                    response = comm.ExecuteReader
                    While response.Read
                        pacienteInfo = New Paciente(response("Cedula"), response("Nombre"), response("Telefono"), response("Correo"), response("Edad"))
                    End While
                End If
                connection.Close()
            End Using
            Return pacienteInfo
        End Function
        ' Busca las citas que tiene un usuario
        Function ObtenerCitas(cedula As String) As List(Of Cita)
            Dim response As SqlDataReader
            Dim citaPaciente As List(Of Cita) = Nothing
            Using connection As New SqlConnection(My.MySettings.Default.DB_ProyectoFInal2021ConnectionString)
                connection.Open()
                Dim comm = New SqlCommand("sp_GetUserCitasPAC", connection)
                comm.CommandType = CommandType.StoredProcedure
                comm.Parameters.AddWithValue("@Cedula", cedula)
                Dim exise = comm.ExecuteNonQuery()
                If exise > 0 Then
                    response = comm.ExecuteReader
                    While response.Read
                        citaPaciente.Add(New Cita(
                                            response("NombreDOC"),
                                            response("FechaDeCita"),
                                            response("Hora"),
                                            response("Motivo")
                                        ))
                    End While
                End If
                connection.Close()
            End Using
            Return citaPaciente
        End Function
        ' Agregar una cita a la base de datos
        Function AgregarCita(cedPac As String, cedDoc As String, fecha As String, hora As String, motivo As String) As Integer
            Dim affectedRow = 0


            Using connection As New SqlConnection(My.MySettings.Default.DB_ProyectoFInal2021ConnectionString)
                connection.Open()
                Dim comm = New SqlCommand("sp_AddCitas", connection)
                comm.CommandType = CommandType.StoredProcedure
                comm.Parameters.AddWithValue("@CedulaPaciente", cedPac)
                comm.Parameters.AddWithValue("@CedulaDoctor", cedDoc)
                comm.Parameters.AddWithValue("@FechaCita", DateValue(fecha))
                comm.Parameters.AddWithValue("@Hora", TimeValue(hora))
                comm.Parameters.AddWithValue("Motivo", motivo)
                affectedRow = comm.ExecuteNonQuery()
            End Using
            Return affectedRow
        End Function

    End Module
End Namespace
