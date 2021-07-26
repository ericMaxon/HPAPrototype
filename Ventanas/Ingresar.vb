Public Class Ingresar


    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles txtLogCedula.MouseEnter
        If txtLogCedula.Text = "cedula 8-888-8888" Then
            txtLogCedula.Text = ""
            txtLogCedula.ForeColor = Color.Black
        End If
    End Sub


    Private Sub txtLogCedula_MouseLeave(sender As Object, e As EventArgs) Handles txtLogCedula.MouseLeave
        If txtLogCedula.Text = "" Then
            txtLogCedula.Text = "cedula 8-888-8888"
            txtLogCedula.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox2_MouseEnter(sender As Object, e As EventArgs) Handles txtLogTelef.MouseEnter, txtLogCedula.MouseEnter
        If txtLogTelef.Text = "Telefono 6564-8694" Then
            txtLogTelef.Text = ""
            txtLogTelef.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtLogTelef_MouseLeave(sender As Object, e As EventArgs) Handles txtLogTelef.MouseLeave
        If txtLogTelef.Text = "" Then
            txtLogTelef.Text = "Telefono 6564-8694"
            txtLogTelef.ForeColor = Color.Gray
        End If
    End Sub
End Class