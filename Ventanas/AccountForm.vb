Public Class AccountForm
    Private Sub AccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imc = Math.Round(App.appUsuario.PesoProp / Math.Pow(App.appUsuario.AlturaProp, 2), 2)
        imcLbl.Text = $"Usted tiene {Rango(imc)},con un indice de {imc}"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        App.Navegacion.Regresar(Me)
    End Sub
    Private Function Rango(imc As Double)
        If imc < 18.5 Then
            Return "Peso Bajo"
        End If
        If imc > 18.5 And imc < 25 Then
            Return "Peso Optimo"
        End If
        If imc > 25 And imc < 30 Then
            Return "Sobre peso"
        End If
        If imc > 29.99 Then
            Return "Obesidad"
        End If
        Return ""
    End Function
End Class