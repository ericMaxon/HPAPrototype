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
        Me.lblDoctor = New System.Windows.Forms.Label()
        Me.DoctorLabel = New System.Windows.Forms.Label()
        Me.FechaLabel = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        'lblDoctor
        '
        Me.lblDoctor.AutoSize = True
        Me.lblDoctor.Location = New System.Drawing.Point(267, 142)
        Me.lblDoctor.Name = "lblDoctor"
        Me.lblDoctor.Size = New System.Drawing.Size(39, 13)
        Me.lblDoctor.TabIndex = 3
        Me.lblDoctor.Text = "Label1"
        '
        'DoctorLabel
        '
        Me.DoctorLabel.AutoSize = True
        Me.DoctorLabel.Location = New System.Drawing.Point(203, 142)
        Me.DoctorLabel.Name = "DoctorLabel"
        Me.DoctorLabel.Size = New System.Drawing.Size(42, 13)
        Me.DoctorLabel.TabIndex = 4
        Me.DoctorLabel.Text = "Doctor:"
        '
        'FechaLabel
        '
        Me.FechaLabel.AutoSize = True
        Me.FechaLabel.Location = New System.Drawing.Point(118, 90)
        Me.FechaLabel.Name = "FechaLabel"
        Me.FechaLabel.Size = New System.Drawing.Size(40, 13)
        Me.FechaLabel.TabIndex = 5
        Me.FechaLabel.Text = "Fecha:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(194, 90)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(39, 13)
        Me.lblFecha.TabIndex = 6
        Me.lblFecha.Text = "Label2"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(343, 90)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(39, 13)
        Me.lblHora.TabIndex = 8
        Me.lblHora.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Hora:"
        '
        'CitaAForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(491, 277)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.FechaLabel)
        Me.Controls.Add(Me.DoctorLabel)
        Me.Controls.Add(Me.lblDoctor)
        Me.Controls.Add(Me.CitaALabel)
        Me.Controls.Add(Me.OkCitaAButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CitaAForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cita Agendada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OkCitaAButton As Button
    Friend WithEvents CitaALabel As Label
    Friend WithEvents lblDoctor As Label
    Friend WithEvents DoctorLabel As Label
    Friend WithEvents FechaLabel As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents Label4 As Label
End Class
