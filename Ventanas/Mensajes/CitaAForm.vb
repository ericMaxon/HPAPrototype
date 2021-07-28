Public Class CitaAForm

    Public Sub New(fecha As String, hora As String, nombreDoc As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lblFecha.Text = fecha
        lblHora.Text = hora
        lblDoctor.Text = nombreDoc
    End Sub

    Private Sub OkCitaAButton_Click(sender As Object, e As EventArgs) Handles OkCitaAButton.Click
        Me.Dispose()
    End Sub

End Class