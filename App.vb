Public Class App

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB_ProyectoFInal2021DataSet.Medicamentos' Puede moverla o quitarla según sea necesario.
        Me.MedicamentosTableAdapter.Fill(Me.DB_ProyectoFInal2021DataSet.Medicamentos)
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
        Else
            pantalla.BringToFront()
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

#End Region
End Class
