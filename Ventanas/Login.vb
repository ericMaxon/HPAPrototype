Public Class Login
    Dim Pesoform = New PesoForm("")

    Private Sub btnLogIngresar_Click(sender As Object, e As EventArgs) Handles btnLogIngresar.Click
        Me.Hide()
        Pesoform.Show()
    End Sub

    Private Sub btnLogRegistrarse_Click(sender As Object, e As EventArgs) Handles btnLogRegistrarse.Click
        Me.Hide()
        Registrar.Show()
    End Sub
End Class