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
                    response = comm.ExecuteReader
                    If response.HasRows Then
                        While response.Read
                            pacienteInfo = New Paciente(Cedula:=response("Cedula"),
                                                        Nombre:=response("Nombre"),
                                                        Telefono:=response("Telefono"),
                                                        Correo:=response("Correo"),
                                                        Edad:=response("Edad"),
                                                        Peso:=response("Peso"),
                                                        Altura:=response("Altura"),
                                                        Genero:=response("Genero")
                                            )
                        End While
                    Else
                        Dim errForm = New ErrorForm("Error de inicio de sesion", "Usuario o contraseña erroneas")
                        errForm.Show()
                    End If
                Catch ex As Exception
                    Dim errForm = New ErrorForm("Error en la base de datos", "No se pudo ejecutar correctamente, contacte con soporte")
                    errForm.Show()
                End Try
                connection.Close()
                loader.Hide()
            End Using
            Return pacienteInfo
        End Function
        Public Function RegistrarUsuario(pacienteInfo As Paciente) As Integer
            '@Cedula = '',
            '@Nombre = '',
            '@Telefono = '',
            '@Correo = '',
            '@Edad = ,
            '@Altura = ,
            '@Peso
            Dim response As SqlDataReader
            Dim loader = New Loading()
            Using connection As New SqlConnection(My.MySettings.Default.DB_ProyectoFInal2021ConnectionString)
                connection.Open()
                loader.Show()
                Dim comm = New SqlCommand("sp_AddNewUser_Patient", connection)
                comm.CommandType = CommandType.StoredProcedure
                comm.Parameters.AddWithValue("@Cedula", pacienteInfo.CedulaProp)
                comm.Parameters.AddWithValue("@Telefono", pacienteInfo.TelefonoProp)
                comm.Parameters.AddWithValue("@Nombre", pacienteInfo.NombreProp)
                comm.Parameters.AddWithValue("@Edad", pacienteInfo.EdadProp)
                comm.Parameters.AddWithValue("@Correo", pacienteInfo.CorreoProp)
                comm.Parameters.AddWithValue("@Altura", pacienteInfo.AlturaProp)
                comm.Parameters.AddWithValue("@Peso", pacienteInfo.PesoProp)
                comm.Parameters.AddWithValue("@Genero", pacienteInfo.GeneroProp)
                Try
                    Dim respuesta = comm.ExecuteNonQuery
                    loader.Hide()
                    Return respuesta
                Catch ex As Exception
                    loader.Hide()
                    Dim errForm = New ErrorForm("Error en la base de datos", "No se pudo ejecutar correctamente, contacte con soporte")
                    errForm.Show()
                    connection.Close()
                End Try
            End Using
            Return 0
        End Function
        ' Edita el peso del usuario en la base de datos
        Public Function EditarPeso(ceduser As String, peso As Double) As Integer
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
                    loader.Hide()
                    Return respuesta
                Catch ex As Exception
                    loader.Hide()
                    Dim errForm = New ErrorForm("Error en la base de datos", "No se pudo ejecutar correctamente, contacte con soporte")
                    errForm.Show()

                End Try
                connection.Close()
            End Using
            Return 0
        End Function
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
                    response = comm.ExecuteReader
                    If response.HasRows Then ' Si tiene citas agregala a la lista sino retorna vacio
                        While response.Read
                            citaPaciente.Add(
                                    New Cita(
                                            response("NombreDOC").ToString,
                                            response("FechaDeCita").ToString,
                                            response("Hora").ToString,
                                            response("Motivo").ToString
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
        Public Sub AgregarCita(cedPac As String, cedDoc As String, fecha As Date, hora As TimeSpan, motivo As String)
            Dim affectedRow = 0
            Dim loader As New Loading()

            Using connection As New SqlConnection(My.MySettings.Default.DB_ProyectoFInal2021ConnectionString)
                connection.Open()
                loader.Show()
                Dim comm = New SqlCommand("sp_AddCitas", connection)
                comm.CommandType = CommandType.StoredProcedure
                comm.Parameters.AddWithValue("@CedulaPaciente", cedPac)
                comm.Parameters.AddWithValue("@CedulaDoctor", cedDoc)
                comm.Parameters.AddWithValue("@FechaCita", fecha)
                comm.Parameters.AddWithValue("@Hora", hora.ToString)
                comm.Parameters.AddWithValue("Motivo", motivo)
                Try
                    affectedRow = comm.ExecuteNonQuery()
                    If affectedRow > 0 Then
                        comm.Parameters.Clear()
                        comm.CommandText = "sp_GetSelectedDoc"
                        comm.Parameters.AddWithValue("@Cedula", cedDoc)
                        Dim response = comm.ExecuteReader
                        If response.HasRows Then
                            While response.Read
                                Dim exito As New CitaAForm(fecha, hora.ToString, response("Nombre"))
                                loader.Hide()
                                exito.Show()
                            End While
                        End If
                    Else
                        loader.Hide()
                        Dim errForm = New ErrorForm("Error", "Error no se pudo agregar la cita")
                        errForm.Show()
                    End If
                Catch ex As Exception
                    loader.Hide()
                    Dim errForm = New ErrorForm("Error", $"Error en la base de datos, {ex.Message}")
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
                Dim comm = New SqlCommand("sp_GetAllDoctors", connection)
                Try
                    Dim response = comm.ExecuteReader
                    If response.HasRows Then
                        While response.Read
                            lista.Add(New Doctor(
                                      response("Cedula"),
                                      response("Nombre"),
                                      response("Telefono")
                                      ))
                        End While
                    Else
                        loader.Hide()
                        Dim errorForm = New ErrorForm("Error al ejecutar la consulta", "error db")
                        errorForm.Show()
                    End If
                Catch ex As Exception
                    Return lista
                End Try
                connection.Close()
            End Using
            loader.Hide()
            Return lista
        End Function
        ' Resumen:
        '   Calcula la altura justa segun el tipo de elemento que se haya analizado.
        ' Parametros:
        '       inivalue: Valor inicial o base del elemento a calcular la altura para mostrar.
        '       elemento: Elemento de windows form al cual de antemano se hizo una evaluacion y 
        '                 se llego a una conclusion para obtener su altura perfecta o justa.
        Public Function CalcularPerfectHeight(ByVal iniValue As Integer, Optional ByVal elemento As String = "")
            If elemento = "datagridview" Then
                Return iniValue * 30
            End If
            Return iniValue
        End Function
    End Module
End Namespace
