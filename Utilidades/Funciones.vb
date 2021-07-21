Imports System
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
End Module
