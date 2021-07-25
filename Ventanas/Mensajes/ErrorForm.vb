Public Class ErrorForm
    Public Sub New(titulo As String, msg As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        errLabel.Text = titulo
        errLblMsg.Text = msg
    End Sub
    Private Sub OkInvButton_Click(sender As Object, e As EventArgs) Handles OkInvButton.Click
        Me.Dispose()
    End Sub

    Public Sub Mensaje(msg As String)
        errLblMsg.Text = msg
    End Sub
    Public Sub Titulo(titulo As String)
        errLabel.Text = titulo
    End Sub
End Class