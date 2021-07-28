Public Class Registrar
    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        tbxCedula.ReadOnly = True
        tbxNombre.ReadOnly = True
        tbxApellido.ReadOnly = True
        tbxTelefono.ReadOnly = True
        tbxEdad.ReadOnly = True
        btnRegistrarse.Enabled = True
        tbxAltura.ReadOnly = True
        Dim nombre = $"{tbxNombre.Text} {tbxApellido.Text}"
        Dim GeneroIndex = cmbxGenero.SelectedIndex
        If IsNumeric(tbxEdad.Text) And IsNumeric(tbxAltura.Text) And GeneroIndex > 0 Then
            Dim newUser As New Paciente(
                    Cedula:=tbxCedula.Text,
                    Nombre:=nombre,
                    Telefono:=tbxTelefono.Text,
                    Correo:=tbxCorreo.Text,
                    Edad:=tbxEdad.Text,
                    Altura:=tbxAltura.Text,
                    Genero:=cmbxGenero.Items(GeneroIndex).ToString
                )
            Dim seInserto = Controlador.RegistrarUsuario(newUser)
            If seInserto Then
                Dim exito As New CompraEForm("Se ha registrado correctamente")
                Dim MainApp As New App(newUser)
                Me.Hide()
                MainApp.Show()
                exito.Show()
                exito.BringToFront()
            End If
        End If
    End Sub
End Class