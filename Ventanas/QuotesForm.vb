Public Class QuotesForm
    Private Sub QuotesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dgvCitas.Height = Me.dgvCitas.Height + Controlador.CalcularPerfectHeight(App.appUsuario.CitasProp.Count, "datagridview")
        Dim c = 1
        If App.appUsuario.CitasProp.Count Then
            App.appUsuario.CitasProp.ForEach(Sub(cita)

                                                 dgvCitas.Rows.Add(c, cita.FechaDeCitaProp, cita.NombreDOCProp, cita.HoraProp)
                                                 c += 1
                                             End Sub)
        End If
    End Sub

    Private Sub btnSolicitarCita_Click(sender As Object, e As EventArgs) Handles btnSolicitarCita.Click
        Dim Solicitar As New SolicitudForm
        Solicitar.Show()
    End Sub
End Class