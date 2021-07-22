<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CitaAForm
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
        Me.OkCitaAButton = New System.Windows.Forms.Button()
        Me.CitaALabel = New System.Windows.Forms.Label()
        Me.DateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DoctorLabel = New System.Windows.Forms.Label()
        Me.FechaLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OkCitaAButton
        '
        Me.OkCitaAButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.OkCitaAButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OkCitaAButton.Location = New System.Drawing.Point(209, 205)
        Me.OkCitaAButton.Name = "OkCitaAButton"
        Me.OkCitaAButton.Size = New System.Drawing.Size(75, 23)
        Me.OkCitaAButton.TabIndex = 0
        Me.OkCitaAButton.Text = "Ok"
        Me.OkCitaAButton.UseVisualStyleBackColor = False
        '
        'CitaALabel
        '
        Me.CitaALabel.AutoSize = True
        Me.CitaALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitaALabel.Location = New System.Drawing.Point(166, 21)
        Me.CitaALabel.Name = "CitaALabel"
        Me.CitaALabel.Size = New System.Drawing.Size(167, 25)
        Me.CitaALabel.TabIndex = 1
        Me.CitaALabel.Text = "Cita Agendada"
        '
        'DateTime
        '
        Me.DateTime.Location = New System.Drawing.Point(209, 84)
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Size = New System.Drawing.Size(200, 20)
        Me.DateTime.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(206, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'DoctorLabel
        '
        Me.DoctorLabel.AutoSize = True
        Me.DoctorLabel.Location = New System.Drawing.Point(130, 142)
        Me.DoctorLabel.Name = "DoctorLabel"
        Me.DoctorLabel.Size = New System.Drawing.Size(42, 13)
        Me.DoctorLabel.TabIndex = 4
        Me.DoctorLabel.Text = "Doctor:"
        '
        'FechaLabel
        '
        Me.FechaLabel.AutoSize = True
        Me.FechaLabel.Location = New System.Drawing.Point(130, 90)
        Me.FechaLabel.Name = "FechaLabel"
        Me.FechaLabel.Size = New System.Drawing.Size(40, 13)
        Me.FechaLabel.TabIndex = 5
        Me.FechaLabel.Text = "Fecha:"
        '
        'CitaAForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(491, 277)
        Me.Controls.Add(Me.FechaLabel)
        Me.Controls.Add(Me.DoctorLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTime)
        Me.Controls.Add(Me.CitaALabel)
        Me.Controls.Add(Me.OkCitaAButton)
        Me.Name = "CitaAForm"
        Me.Text = "Cita Agendada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OkCitaAButton As Button
    Friend WithEvents CitaALabel As Label
    Friend WithEvents DateTime As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DoctorLabel As Label
    Friend WithEvents FechaLabel As Label
End Class
