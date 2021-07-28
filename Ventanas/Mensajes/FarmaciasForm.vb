Public Class FarmaciasForm
    Dim codProd
    Dim Inventarios As New List(Of Farmacia)
    Public Sub New(_codProd As Integer, _nombre As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        codProd = _codProd
        medLbl.Text = _nombre
        Inventarios = Controlador.ObtenerFarmacias(codProd)
    End Sub

    Private Sub javilloBtn_Click(sender As Object, e As EventArgs) Handles javilloBtn.Click
        FarmaciaSeleccionada(javilloBtn.Tag)
    End Sub

    Private Sub arrochaBtn_Click(sender As Object, e As EventArgs) Handles arrochaBtn.Click
        FarmaciaSeleccionada(arrochaBtn.Tag)
    End Sub

    Private Sub css17Btn_Click(sender As Object, e As EventArgs) Handles css17Btn.Click
        FarmaciaSeleccionada(css17Btn.Tag)
    End Sub

    Private Sub cssColonBtn_Click(sender As Object, e As EventArgs) Handles cssColonBtn.Click
        FarmaciaSeleccionada(cssColonBtn.Tag)
    End Sub

    Private Sub sazBtn_Click(sender As Object, e As EventArgs) Handles sazBtn.Click
        FarmaciaSeleccionada(sazBtn.Tag)
    End Sub

    Private Sub FarmaciaSeleccionada(codFarmacia As Integer)
        Dim tieneFarmacias = Inventarios.Find(Function(farmacia)
                                                  Return farmacia.CodigoProp = codFarmacia
                                              End Function)
        If Not IsNothing(tieneFarmacias) Then
            Dim existencias = Math.Round(tieneFarmacias.CantidadProp / tieneFarmacias.CantPaqueteProp)
            If existencias > tieneFarmacias.CantPaqueteProp Then
                Dim respuesta = Controlador.ActualizarFarmacia(tieneFarmacias.CodigoProp, codProd, tieneFarmacias.CantPaqueteProp)
                If respuesta > 0 Then
                    Dim exito = New CompraEForm("Compra Exitosa")
                    exito.Show()
                    SalirButton_Click(Me, EventArgs.Empty)
                End If
            Else
                Dim errorF = New ErrorForm($"No tenemos existencias del producto, tenemos {existencias}")
                errorF.Show()
            End If
        Else
            Dim errorF = New ErrorForm("No tenemos en esta farmacia")
            errorF.Show()
        End If
    End Sub

    Private Sub SalirButton_Click(sender As Object, e As EventArgs) Handles SalirButton.Click
        Me.Dispose()
    End Sub

    Private Sub FarmaciasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class