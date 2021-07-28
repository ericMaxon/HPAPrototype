Public Class MedsForm

    Private Sub MedsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To App.medicamentos.Count - 1
            Dim med = App.medicamentos(i)
            If btnComprarOrlistat.Tag = med.CodigoProp Then
                orlisatLbl1.Text = med.NombreProp
                orlisatBox.Text = $"Contenido: {med.CantXPaqueteProp} {med.UnidadProp}"
                orlisatPBox.Image = Controlador.ObtenerImagenURL(med.ImagenProp)
            End If
            If btnComprarBupro.Tag = med.CodigoProp Then
                buproLbl.Text = med.NombreProp
                buproBox.Text = $"Contenido: {med.CantXPaqueteProp} {med.UnidadProp}"
                buproPBox.Image = Controlador.ObtenerImagenURL(med.ImagenProp)
            End If
            If btnComprarNalt.Tag = med.CodigoProp Then
                naltrLbl.Text = med.NombreProp
                naltrxeBox.Text = $"Contenido: {med.CantXPaqueteProp} {med.UnidadProp}"
                naltrexPBox.Image = Controlador.ObtenerImagenURL(med.ImagenProp)
            End If
            If btnComprarFente.Tag = med.CodigoProp Then
                fentLbl.Text = med.NombreProp
                fenterBox.Text = $"Contenido: {med.CantXPaqueteProp} {med.UnidadProp}"
                fenterPBox.Image = Controlador.ObtenerImagenURL(med.ImagenProp)
            End If
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnComprarOrlistat.Click
        MedicamentoSeleccionado(btnComprarOrlistat.Tag, orlisatLbl1.Text)
    End Sub

    Private Sub btnComprarBupro_Click(sender As Object, e As EventArgs) Handles btnComprarBupro.Click
        MedicamentoSeleccionado(btnComprarBupro.Tag, buproLbl.Text)
    End Sub

    Private Sub btnComprarNalt_Click(sender As Object, e As EventArgs) Handles btnComprarNalt.Click
        MedicamentoSeleccionado(btnComprarNalt.Tag, naltrLbl.Text)
    End Sub

    Private Sub btnComprarFente_Click(sender As Object, e As EventArgs) Handles btnComprarFente.Click
        MedicamentoSeleccionado(btnComprarFente.Tag, fentLbl.Text)
    End Sub

    Private Sub MedicamentoSeleccionado(codMed As Integer, nombre As String)
        Dim farmacia = New FarmaciasForm(codMed, nombre)
        farmacia.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        App.Navegacion.Regresar(Me)
    End Sub
End Class