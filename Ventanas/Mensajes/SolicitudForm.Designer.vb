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
        Me.SuspendLayout()
        '
        'SolicitarButton
        '
        Me.SolicitarButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.SolicitarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SolicitarButton.Location = New System.Drawing.Point(194, 282)
        Me.SolicitarButton.Name = "SolicitarButton"
        Me.SolicitarButton.Size = New System.Drawing.Size(75, 23)
        Me.SolicitarButton.TabIndex = 1
        Me.SolicitarButton.Text = "Solicitar"
        Me.SolicitarButton.UseVisualStyleBackColor = False
        '
        'SolicitudLabel
        '
        Me.SolicitudLabel.AutoSize = True
        Me.SolicitudLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolicitudLabel.Location = New System.Drawing.Point(178, 9)
        Me.SolicitudLabel.Name = "SolicitudLabel"
        Me.SolicitudLabel.Size = New System.Drawing.Size(103, 25)
        Me.SolicitudLabel.TabIndex = 2
        Me.SolicitudLabel.Text = "Solicitud"
        '
        'NombreBox
        '
        Me.NombreBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.NombreBox.Location = New System.Drawing.Point(216, 54)
        Me.NombreBox.Name = "NombreBox"
        Me.NombreBox.Size = New System.Drawing.Size(149, 20)
        Me.NombreBox.TabIndex = 3
        Me.NombreBox.Text = "Nombre"
        Me.NombreBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ApellidoBox
        '
        Me.ApellidoBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.ApellidoBox.Location = New System.Drawing.Point(216, 92)
        Me.ApellidoBox.Name = "ApellidoBox"
        Me.ApellidoBox.Size = New System.Drawing.Size(149, 20)
        Me.ApellidoBox.TabIndex = 4
        Me.ApellidoBox.Text = "Apellido"
        Me.ApellidoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CedulaBox
        '
        Me.CedulaBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CedulaBox.Location = New System.Drawing.Point(216, 128)
        Me.CedulaBox.Name = "CedulaBox"
        Me.CedulaBox.Size = New System.Drawing.Size(149, 20)
        Me.CedulaBox.TabIndex = 5
        Me.CedulaBox.Text = "Ej: 123-1234-1235"
        Me.CedulaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TelefonoBox
        '
        Me.TelefonoBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TelefonoBox.Location = New System.Drawing.Point(216, 166)
        Me.TelefonoBox.Name = "TelefonoBox"
        Me.TelefonoBox.Size = New System.Drawing.Size(149, 20)
        Me.TelefonoBox.TabIndex = 6
        Me.TelefonoBox.Text = "Ej: 123-1234"
        Me.TelefonoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CorreoBox
        '
        Me.CorreoBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CorreoBox.Location = New System.Drawing.Point(216, 204)
        Me.CorreoBox.Name = "CorreoBox"
        Me.CorreoBox.Size = New System.Drawing.Size(149, 20)
        Me.CorreoBox.TabIndex = 7
        Me.CorreoBox.Text = "Ej: user@domain.com"
        Me.CorreoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescBox
        '
        Me.DescBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.DescBox.Location = New System.Drawing.Point(216, 240)
        Me.DescBox.Name = "DescBox"
        Me.DescBox.Size = New System.Drawing.Size(149, 20)
        Me.DescBox.TabIndex = 8
        Me.DescBox.Text = "Descripcion de los Sintomas"
        Me.DescBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescLabel
        '
        Me.DescLabel.AutoSize = True
        Me.DescLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescLabel.Location = New System.Drawing.Point(108, 240)
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
        Me.CorreoLabel.Location = New System.Drawing.Point(141, 204)
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
        Me.TelefonoLabel.Location = New System.Drawing.Point(128, 169)
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
        Me.CedulaLabel.Location = New System.Drawing.Point(139, 129)
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
        Me.ApellidoLabel.Location = New System.Drawing.Point(132, 93)
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
        Me.NombreLabel.Location = New System.Drawing.Point(133, 55)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(62, 15)
        Me.NombreLabel.TabIndex = 14
        Me.NombreLabel.Text = "Nombre:"
        Me.NombreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SolicitudForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(505, 332)
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
        Me.Name = "SolicitudForm"
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
End Class
