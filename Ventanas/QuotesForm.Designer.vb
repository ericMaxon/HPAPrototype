<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuotesForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSolicitarCita = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CITAS SCREEN"
        '
        'btnSolicitarCita
        '
        Me.btnSolicitarCita.BackColor = System.Drawing.Color.White
        Me.btnSolicitarCita.Location = New System.Drawing.Point(131, 48)
        Me.btnSolicitarCita.Name = "btnSolicitarCita"
        Me.btnSolicitarCita.Size = New System.Drawing.Size(143, 28)
        Me.btnSolicitarCita.TabIndex = 2
        Me.btnSolicitarCita.Text = "Solicitar Cita"
        Me.btnSolicitarCita.UseVisualStyleBackColor = False
        '
        'QuotesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(398, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSolicitarCita)
        Me.Controls.Add(Me.Label1)
        Me.Name = "QuotesForm"
        Me.Text = "QuotesForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSolicitarCita As Button
End Class
