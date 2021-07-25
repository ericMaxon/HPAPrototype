Imports System.Data.SqlClient
Namespace Controlador
    Public Module Funciones
        ' Obtiene la imagen de una url
        Public Function ObtenerImagenURL(ByVal url As String) As Image
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
        Public Function ObtenerUsuario(cedula As String, telefono As String) As Paciente
            Dim response As SqlDataReader
            Dim pacienteInfo As Paciente = Nothing
            Dim loader = New Loading()
            Using connection As New SqlConnection(My.MySettings.Default.DB_ProyectoFInal2021ConnectionString)
                connection.Open()
                loader.Show()
                Dim comm = New SqlCommand("sp_GetUserIdPAC", connection)
                comm.CommandType = CommandType.StoredProcedure
                comm.Parameters.AddWithValue("@Cedula", cedula)
                comm.Parameters.AddWithValue("@Telefono", telefono)
                Try
                    Dim existe = comm.ExecuteNonQuery()
                    If existe > 0 Then
                        response = comm.ExecuteReader
                        While response.Read
                            pacienteInfo = New Paciente(response("Cedula"), response("Nombre"), response("Telefono"), response("Correo"), response("Edad"))
                        End While
                    Else
                        loader.Hide()
                        Dim errForm = New ErrorForm("Error de inicio de sesion", "Usuario o contraseña erroneas")
                        errForm.Show()
                    End If
                Catch ex As Exception
                    loader.Hide()
                    Dim errForm = New ErrorForm("Error en la base de datos", "No se pudo ejecutar correctamente, contacte con soporte")
                    errForm.Show()
                End Try
                connection.Close()
                loader.Hide()
            End Using
            Return pacienteInfo
        End Function
        ' Edita el peso del usuario en la base de datos
        Public Sub EditarPeso(ceduser As String, peso As Double)
            Dim loader As New Loading
            Using connection As New SqlConnection(My.MySettings.Default.DB_ProyectoFInal2021ConnectionString)
                loader.Show()
                connection.Open()
                Dim comm As New SqlCommand("sp_EditPeso", connection)
                comm.CommandType = CommandType.StoredProcedure
                comm.Parameters.AddWithValue("@Cedula", ceduser)
                comm.Parameters.AddWithValue("@Peso", peso)
                Try
                    Dim respuesta = comm.ExecuteNonQuery
                    If respuesta Then
                        loader.Hide()
                        Dim exito As New CompraEForm("Actualizado")
                        exito.Show()
                    End If
                Catch ex As Exception
                    loader.Hide()
                    Dim errForm = New ErrorForm("Error en la base de datos", "No se pudo ejecutar correctamente, contacte con soporte")
                    errForm.Show()
                End Try
                connection.Close()
            End Using
        End Sub
        ' Busca las citas que tiene un usuario
        Public Function ObtenerCitas(cedula As String) As List(Of Cita)
            Dim response As SqlDataReader
            Dim citaPaciente As New List(Of Cita)
            Dim loader As New Loading
            Using connection As New SqlConnection(My.MySettings.Default.DB_ProyectoFInal2021ConnectionString)
                connection.Open()
                loader.Show()
                Dim comm = New SqlCommand("sp_GetUserCitasPAC", connection)
                comm.CommandType = CommandType.StoredProcedure
                comm.Parameters.AddWithValue("@Cedula", cedula)
                Try
                    Dim tieneCitas = comm.ExecuteNonQuery()
                    If tieneCitas > 0 Then
                        response = comm.ExecuteReader
                        While response.Read
                            citaPaciente.Add(
                                    New Cita(
                                             response("NombreDOC"),
                                             response("FechaDeCita"),
                                            response("Hora"),
                                                response("Motivo")
                                            ))
                        End While
                    End If
                Catch ex As Exception
                    loader.Hide()
                    Dim errForm = New ErrorForm("Error en la base de datos", "No se pudo ejecutar correctamente, contacte con soporte")
                    errForm.Show()
                End Try
                connection.Close()
                loader.Hide()
            End Using
            Return citaPaciente
        End Function
        ' Agregar una cita a la base de datos
        Public Sub AgregarCita(cedPac As String, cedDoc As String, fecha As String, hora As String, motivo As String)
            Dim affectedRow = 0
            Dim loader As New Loading()

            Using connection As New SqlConnection(My.MySettings.Default.DB_ProyectoFInal2021ConnectionString)
                connection.Open()
                loader.Show()
                Dim comm = New SqlCommand("sp_AddCitas", connection)
                comm.CommandType = CommandType.StoredProcedure
                comm.Parameters.AddWithValue("@CedulaPaciente", cedPac)
                comm.Parameters.AddWithValue("@CedulaDoctor", cedDoc)
                comm.Parameters.AddWithValue("@FechaCita", DateValue(fecha))
                comm.Parameters.AddWithValue("@Hora", TimeValue(hora))
                comm.Parameters.AddWithValue("Motivo", motivo)
                Try
                    affectedRow = comm.ExecuteNonQuery()
                    If affectedRow > 0 Then
                        comm.Parameters.Clear()
                        comm.CommandText = "sp_GetSelectedDoc"
                        comm.Parameters.AddWithValue("@Cedula", cedDoc)
                        Dim response = comm.ExecuteReader
                        Dim exito As New CitaAForm(fecha, hora, response("Nombre"))
                        loader.Hide()
                        exito.Show()
                    End If
                Catch ex As Exception
                    loader.Hide()
                    Dim errForm = New ErrorForm("Error", "Error en la base de datos")
                    errForm.Show()
                End Try
                loader.Hide()
                connection.Close()
            End Using
        End Sub
        ' Obtener doctores
        Public Function ObtenerDoctores() As List(Of Doctor)
            Dim lista As New List(Of Doctor)
            Dim loader As New Loading
            Using connection As New SqlConnection(My.MySettings.Default.DB_ProyectoFInal2021ConnectionString)
                connection.Open()
                loader.Show()
                Dim comm = New SqlCommand("sp_GetAllDoctors")
                Try
                    Dim response = comm.ExecuteReader
                    While response.Read
                        lista.Add(New Doctor(
                                      response("Cedula"),
                                      response("Nombre"),
                                      response("Telefono")
                                      ))
                    End While
                Catch ex As Exception
                    loader.Hide()
                    Dim errorForm = New ErrorForm("Error al ejecutar la consulta", ex.ToString)
                    errorForm.Show()
                    Return lista
                End Try
                connection.Close()
            End Using
            loader.Hide()
            Return lista
        End Function
    End Module
End Namespace
