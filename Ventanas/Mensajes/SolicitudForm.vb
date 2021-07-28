Public Class SolicitudForm


    Private Sub SolicitarButton_Click(sender As Object, e As EventArgs) Handles SolicitarButton.Click
        Dim index = cmbxDoctores.SelectedIndex
        If index >= 0 And IsNumeric(PesoBox.Text) Then
            SolicitarButton.Enabled = False
            Dim docElegido = App.doctores.Find(Function(doctor)
                                                   Return doctor.NombreProp.Equals(cmbxDoctores.Items(index).ToString)
                                               End Function)

            Dim respuesta = Controlador.AgregarCita(
                cedPac:=App.appUsuario.CedulaProp,
                cedDoc:=docElegido.CedulaProp,
                fecha:=dtpFecha.Value.Date,
                hora:=dtpHora.Value.TimeOfDay,
                motivo:=DescBox.Text,
                peso:=PesoBox.Text)
            If respuesta > 0 Then
                Me.Dispose()
            Else
                SolicitarButton.Enabled = True
            End If
        Else

            Dim errForm = New ErrorForm("Error", "Datos incompleto")
            errForm.Show()
        End If

    End Sub

    Private Sub SolicitudForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inserting values to cmbxDoctores
        App.doctores.ForEach(Sub(doctor)
                                 cmbxDoctores.Items.Add(doctor.NombreProp)
                             End Sub)
        Dim nombre = App.appUsuario.NombreProp.Split(" ")
        NombreBox.Text = nombre(0)
        ApellidoBox.Text = nombre(1)
        CedulaBox.Text = App.appUsuario.CedulaProp
        TelefonoBox.Text = App.appUsuario.TelefonoProp
        CorreoBox.Text = App.appUsuario.CorreoProp
        If App.appUsuario.PesoProp Then
            PesoBox.Text = App.appUsuario.PesoProp
        End If

    End Sub

    Private Sub cerrarBtn_Click(sender As Object, e As EventArgs) Handles cerrarBtn.Click
        Me.Dispose()
    End Sub
End Class