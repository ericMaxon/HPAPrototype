Public Class AccountForm
    Private Sub AccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imcLbl.Text = App.appUsuario.PesoProp / App.appUsuario.AlturaProp
    End Sub

    Private Sub btnMeds_Click(sender As Object, e As EventArgs) Handles btnMeds.Click
        'Controlador.ObtenerMedsUsuario(App.appUsuario.CedulaProp)
        ' Abrir ventana para ver los medicamentos
    End Sub
End Class