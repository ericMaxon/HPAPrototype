Public Class QuotesForm
    Private Sub QuotesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dgvCitas.Height = Me.dgvCitas.Height + Controlador.CalcularPerfectHeight(App.appUsuario.CitasProp.Count, "datagridview")
        If App.appUsuario.CitasProp.Count Then
            App.appUsuario.CitasProp.ForEach(Sub(cita)
                                                 dgvCitas.Rows.Add(cita.CodigoProp, cita.FechaDeCitaProp, cita.NombreDOCProp, cita.HoraProp)
                                             End Sub)
        End If
    End Sub

    Private Sub btnSolicitarCita_Click(sender As Object, e As EventArgs) Handles btnSolicitarCita.Click
        Dim Solicitar As New SolicitudForm
        Solicitar.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        App.Navegacion.Regresar(Me)
    End Sub
End Class