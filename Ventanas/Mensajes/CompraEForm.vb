Public Class CompraEForm
    Public Sub New(titulo As String)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CompraELabel.Text = titulo
    End Sub
    Private Sub OkCompraEButton_Click(sender As Object, e As EventArgs) Handles OkCompraEButton.Click
        Me.Dispose()
    End Sub

End Class