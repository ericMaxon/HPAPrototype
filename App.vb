Public Class App
    Public Shared appUsuario As Paciente
    Public Shared doctores As New List(Of Doctor)
    Public Shared medicamentos As New List(Of Medicamento)
    Public Shared Navegacion As Navegar
    Public Sub New(_usuario As Paciente)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        appUsuario = _usuario
        Navegacion = New Navegar(Me)
    End Sub
    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        appUsuario.CitasProp = Controlador.ObtenerCitas(appUsuario.CedulaProp)
        appUsuario.MedsProp = Controlador.ObtenerMedicantosUsuario(appUsuario.CedulaProp)
        doctores = Controlador.ObtenerDoctores
        medicamentos = Controlador.ObtenerMeds
        btnHome_Click(Me, EventArgs.Empty)
    End Sub
#Region "Funciones auxiliares del app"
    Public Sub IrA(Of pantallaANavegar As {Form, New})() ' As {Form, New} agregar esto cuando crees las pantallas
        Dim pantalla As Form
        pantalla = pnlMain.Controls.OfType(Of pantallaANavegar).FirstOrDefault() ' Buscar si esta instanciada esta pantalla
        ' Si no existe la pantalla creamos una nueva
        If IsNothing(pantalla) Then
            pantalla = New pantallaANavegar
            'Estilizando la vista para que se acople a la pantalla principal
            pantalla.TopLevel = False
            pantalla.FormBorderStyle = FormBorderStyle.None
            pantalla.Dock = DockStyle.Fill
            ' Añadiendola al panel principal
            pnlMain.Controls.Add(pantalla)
            pnlMain.Tag = pantalla
            ' Mostrando la pantalla
            pantalla.Show()
            pantalla.BringToFront()
            Navegacion.AgregarPantalla(pantalla)
        Else
            pnlMain.Controls.Remove(pantalla)
            pantalla = New pantallaANavegar
            'Estilizando la vista para que se acople a la pantalla principal
            pantalla.TopLevel = False
            pantalla.FormBorderStyle = FormBorderStyle.None
            pantalla.Dock = DockStyle.Fill
            ' Añadiendola al panel principal
            pnlMain.Controls.Add(pantalla)
            pnlMain.Tag = pantalla
            ' Mostrando la pantalla
            pantalla.Show()
            pantalla.BringToFront()
            Navegacion.AgregarPantalla(pantalla)
        End If
    End Sub
#End Region

#Region "App navigation"
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        IrA(Of HomeForm)()
    End Sub

    Private Sub btnCitas_Click(sender As Object, e As EventArgs) Handles btnCitas.Click
        IrA(Of QuotesForm)()
    End Sub

    Private Sub btnMedicamentos_Click(sender As Object, e As EventArgs) Handles btnMedicamentos.Click
        IrA(Of MedsForm)()
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click

        IrA(Of AccountForm)()
    End Sub
#End Region

#Region "Funciones propias del 'cel' "
    Private Sub btnCelHome_Click(sender As Object, e As EventArgs) Handles btnCelHome.Click
        Application.Exit()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        FinalizarForm.Show()
    End Sub

#End Region

End Class
