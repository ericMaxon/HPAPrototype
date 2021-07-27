Public Class FarmaciasForm
    Dim codProd
    Dim Inventarios
    Public Sub New(_codProd As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        codProd = _codProd
    End Sub
    Private Sub FarmaciasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class