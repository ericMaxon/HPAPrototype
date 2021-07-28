Public Class HomeForm
    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim maxHeight = 107

        If App.appUsuario.CitasProp.Count > 3 Then
            dgvCitas.Height = maxHeight
        End If
        If App.appUsuario.MedsProp.Count > 3 Then
            dgvMeds.Height = maxHeight
        End If

        App.appUsuario.CitasProp.ForEach(Sub(cita)
                                             dgvCitas.Rows.Add(cita.CodigoProp, cita.FechaDeCitaProp, cita.NombreDOCProp, cita.HoraProp)
                                         End Sub)
        App.appUsuario.MedsProp.ForEach(Sub(med)
                                            dgvMeds.Rows.Add(med.NombreProp, med.CantidadProp, med.DosisProp)
                                        End Sub)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ingresoDiario As New PesoForm(App.appUsuario.CedulaProp)
        ingresoDiario.Show()
    End Sub
End Class