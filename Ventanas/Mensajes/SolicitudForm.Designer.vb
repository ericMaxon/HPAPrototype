<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SolicitudForm
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
        Me.SolicitarButton = New System.Windows.Forms.Button()
        Me.SolicitudLabel = New System.Windows.Forms.Label()
        Me.NombreBox = New System.Windows.Forms.TextBox()
        Me.ApellidoBox = New System.Windows.Forms.TextBox()
        Me.CedulaBox = New System.Windows.Forms.TextBox()
        Me.TelefonoBox = New System.Windows.Forms.TextBox()
        Me.CorreoBox = New System.Windows.Forms.TextBox()
        Me.DescBox = New System.Windows.Forms.TextBox()
        Me.DescLabel = New System.Windows.Forms.Label()
        Me.CorreoLabel = New System.Windows.Forms.Label()
        Me.TelefonoLabel = New System.Windows.Forms.Label()
        Me.CedulaLabel = New System.Windows.Forms.Label()
        Me.ApellidoLabel = New System.Windows.Forms.Label()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbxDoctores = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PesoBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'SolicitarButton
        '
        Me.SolicitarButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.SolicitarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SolicitarButton.Location = New System.Drawing.Point(241, 285)
        Me.SolicitarButton.Name = "SolicitarButton"
        Me.SolicitarButton.Size = New System.Drawing.Size(75, 23)
        Me.SolicitarButton.TabIndex = 12
        Me.SolicitarButton.Text = "Solicitar"
        Me.SolicitarButton.UseVisualStyleBackColor = False
        '
        'SolicitudLabel
        '
        Me.SolicitudLabel.AutoSize = True
        Me.SolicitudLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolicitudLabel.Location = New System.Drawing.Point(178, 9)
        Me.SolicitudLabel.Name = "SolicitudLabel"
        Me.SolicitudLabel.Size = New System.Drawing.Size(181, 25)
        Me.SolicitudLabel.TabIndex = 2
        Me.SolicitudLabel.Text = "Solicitud de cita"
        '
        'NombreBox
        '
        Me.NombreBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.NombreBox.Location = New System.Drawing.Point(80, 55)
        Me.NombreBox.Name = "NombreBox"
        Me.NombreBox.Size = New System.Drawing.Size(149, 20)
        Me.NombreBox.TabIndex = 3
        Me.NombreBox.Text = "Nombre"
        Me.NombreBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ApellidoBox
        '
        Me.ApellidoBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.ApellidoBox.Location = New System.Drawing.Point(346, 54)
        Me.ApellidoBox.Name = "ApellidoBox"
        Me.ApellidoBox.Size = New System.Drawing.Size(149, 20)
        Me.ApellidoBox.TabIndex = 4
        Me.ApellidoBox.Text = "Apellido"
        Me.ApellidoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CedulaBox
        '
        Me.CedulaBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CedulaBox.Location = New System.Drawing.Point(80, 95)
        Me.CedulaBox.Name = "CedulaBox"
        Me.CedulaBox.Size = New System.Drawing.Size(149, 20)
        Me.CedulaBox.TabIndex = 5
        Me.CedulaBox.Text = "Ej: 123-1234-1235"
        Me.CedulaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TelefonoBox
        '
        Me.TelefonoBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TelefonoBox.Location = New System.Drawing.Point(346, 99)
        Me.TelefonoBox.Name = "TelefonoBox"
        Me.TelefonoBox.Size = New System.Drawing.Size(149, 20)
        Me.TelefonoBox.TabIndex = 6
        Me.TelefonoBox.Text = "Ej: 123-1234"
        Me.TelefonoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CorreoBox
        '
        Me.CorreoBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CorreoBox.Location = New System.Drawing.Point(80, 132)
        Me.CorreoBox.Name = "CorreoBox"
        Me.CorreoBox.Size = New System.Drawing.Size(149, 20)
        Me.CorreoBox.TabIndex = 7
        Me.CorreoBox.Text = "Ej: user@domain.com"
        Me.CorreoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescBox
        '
        Me.DescBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.DescBox.Location = New System.Drawing.Point(346, 178)
        Me.DescBox.Name = "DescBox"
        Me.DescBox.Size = New System.Drawing.Size(149, 20)
        Me.DescBox.TabIndex = 9
        Me.DescBox.Text = "Descripcion de los Sintomas"
        Me.DescBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescLabel
        '
        Me.DescLabel.AutoSize = True
        Me.DescLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescLabel.Location = New System.Drawing.Point(253, 179)
        Me.DescLabel.Name = "DescLabel"
        Me.DescLabel.Size = New System.Drawing.Size(87, 15)
        Me.DescLabel.TabIndex = 9
        Me.DescLabel.Text = "Descripcion:"
        Me.DescLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CorreoLabel
        '
        Me.CorreoLabel.AutoSize = True
        Me.CorreoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorreoLabel.Location = New System.Drawing.Point(12, 133)
        Me.CorreoLabel.Name = "CorreoLabel"
        Me.CorreoLabel.Size = New System.Drawing.Size(54, 15)
        Me.CorreoLabel.TabIndex = 10
        Me.CorreoLabel.Text = "Correo:"
        Me.CorreoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TelefonoLabel
        '
        Me.TelefonoLabel.AutoSize = True
        Me.TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoLabel.Location = New System.Drawing.Point(253, 100)
        Me.TelefonoLabel.Name = "TelefonoLabel"
        Me.TelefonoLabel.Size = New System.Drawing.Size(67, 15)
        Me.TelefonoLabel.TabIndex = 11
        Me.TelefonoLabel.Text = "Telefono:"
        Me.TelefonoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CedulaLabel
        '
        Me.CedulaLabel.AutoSize = True
        Me.CedulaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CedulaLabel.Location = New System.Drawing.Point(12, 95)
        Me.CedulaLabel.Name = "CedulaLabel"
        Me.CedulaLabel.Size = New System.Drawing.Size(56, 15)
        Me.CedulaLabel.TabIndex = 12
        Me.CedulaLabel.Text = "Cedula:"
        Me.CedulaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ApellidoLabel
        '
        Me.ApellidoLabel.AutoSize = True
        Me.ApellidoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidoLabel.Location = New System.Drawing.Point(253, 56)
        Me.ApellidoLabel.Name = "ApellidoLabel"
        Me.ApellidoLabel.Size = New System.Drawing.Size(63, 15)
        Me.ApellidoLabel.TabIndex = 13
        Me.ApellidoLabel.Text = "Apellido:"
        Me.ApellidoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreLabel.Location = New System.Drawing.Point(12, 55)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(62, 15)
        Me.NombreLabel.TabIndex = 14
        Me.NombreLabel.Text = "Nombre:"
        Me.NombreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(253, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Doctor:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbxDoctores
        '
        Me.cmbxDoctores.FormattingEnabled = True
        Me.cmbxDoctores.Location = New System.Drawing.Point(346, 133)
        Me.cmbxDoctores.Name = "cmbxDoctores"
        Me.cmbxDoctores.Size = New System.Drawing.Size(147, 21)
        Me.cmbxDoctores.TabIndex = 8
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(77, 221)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(130, 20)
        Me.dtpFecha.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Hora:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtpHora
        '
        Me.dtpHora.CustomFormat = "H:m"
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHora.Location = New System.Drawing.Point(323, 219)
        Me.dtpHora.MinDate = New Date(2021, 7, 27, 0, 0, 0, 0)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.ShowUpDown = True
        Me.dtpHora.Size = New System.Drawing.Size(102, 20)
        Me.dtpHora.TabIndex = 11
        Me.dtpHora.Value = New Date(2021, 7, 27, 9, 58, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Peso:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PesoBox
        '
        Me.PesoBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.PesoBox.Location = New System.Drawing.Point(77, 179)
        Me.PesoBox.Name = "PesoBox"
        Me.PesoBox.Size = New System.Drawing.Size(149, 20)
        Me.PesoBox.TabIndex = 21
        Me.PesoBox.Text = "Ex. su peso en kg"
        Me.PesoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SolicitudForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(505, 332)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PesoBox)
        Me.Controls.Add(Me.dtpHora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cmbxDoctores)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NombreLabel)
        Me.Controls.Add(Me.ApellidoLabel)
        Me.Controls.Add(Me.CedulaLabel)
        Me.Controls.Add(Me.TelefonoLabel)
        Me.Controls.Add(Me.CorreoLabel)
        Me.Controls.Add(Me.DescLabel)
        Me.Controls.Add(Me.DescBox)
        Me.Controls.Add(Me.CorreoBox)
        Me.Controls.Add(Me.TelefonoBox)
        Me.Controls.Add(Me.CedulaBox)
        Me.Controls.Add(Me.ApellidoBox)
        Me.Controls.Add(Me.NombreBox)
        Me.Controls.Add(Me.SolicitudLabel)
        Me.Controls.Add(Me.SolicitarButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SolicitudForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SolicitarButton As Button
    Friend WithEvents SolicitudLabel As Label
    Friend WithEvents NombreBox As TextBox
    Friend WithEvents ApellidoBox As TextBox
    Friend WithEvents CedulaBox As TextBox
    Friend WithEvents TelefonoBox As TextBox
    Friend WithEvents CorreoBox As TextBox
    Friend WithEvents DescBox As TextBox
    Friend WithEvents DescLabel As Label
    Friend WithEvents CorreoLabel As Label
    Friend WithEvents TelefonoLabel As Label
    Friend WithEvents CedulaLabel As Label
    Friend WithEvents ApellidoLabel As Label
    Friend WithEvents NombreLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbxDoctores As ComboBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpHora As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents PesoBox As TextBox
End Class
