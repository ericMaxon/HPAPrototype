Public Class Login
    Public Navegacion As New Navegar(Me)
    Private Sub btnLogIngresar_Click(sender As Object, e As EventArgs) Handles btnLogIngresar.Click
        Navegacion.NavegarA(New Ingresar(Navegacion))
    End Sub

    Private Sub btnLogRegistrarse_Click(sender As Object, e As EventArgs) Handles btnLogRegistrarse.Click
        Navegacion.NavegarA(New Registrar(Navegacion))
    End Sub
End Class