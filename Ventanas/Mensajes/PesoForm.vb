Public Class PesoForm
    Dim cedulaUsuario As String
    Public Sub New(_cedulaUsuario As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        cedulaUsuario = _cedulaUsuario
    End Sub
    Private Sub IngresarButton_Click(sender As Object, e As EventArgs) Handles IngresarButton.Click
        If IsNumeric(PesoBox.Text) Then
            Controlador.EditarPeso(cedulaUsuario, peso:=PesoBox.Text)
        Else
            Dim errForm As New ErrorForm("Error", "Ingrese valores numericos")
            errForm.Show()
        End If
    End Sub

End Class