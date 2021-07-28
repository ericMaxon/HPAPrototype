<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PesoForm
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
        Me.IngresarButton = New System.Windows.Forms.Button()
        Me.PesoLabel = New System.Windows.Forms.Label()
        Me.RegistroLabel = New System.Windows.Forms.Label()
        Me.PesoBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'IngresarButton
        '
        Me.IngresarButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.IngresarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IngresarButton.Location = New System.Drawing.Point(149, 130)
        Me.IngresarButton.Name = "IngresarButton"
        Me.IngresarButton.Size = New System.Drawing.Size(75, 23)
        Me.IngresarButton.TabIndex = 0
        Me.IngresarButton.Text = "Ingresar"
        Me.IngresarButton.UseVisualStyleBackColor = False
        '
        'PesoLabel
        '
        Me.PesoLabel.AutoSize = True
        Me.PesoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PesoLabel.Location = New System.Drawing.Point(97, 85)
        Me.PesoLabel.Name = "PesoLabel"
        Me.PesoLabel.Size = New System.Drawing.Size(47, 15)
        Me.PesoLabel.TabIndex = 1
        Me.PesoLabel.Text = "Peso: "
        '
        'RegistroLabel
        '
        Me.RegistroLabel.AutoSize = True
        Me.RegistroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistroLabel.Location = New System.Drawing.Point(61, 40)
        Me.RegistroLabel.Name = "RegistroLabel"
        Me.RegistroLabel.Size = New System.Drawing.Size(257, 25)
        Me.RegistroLabel.TabIndex = 2
        Me.RegistroLabel.Text = "Registro de peso diario"
        '
        'PesoBox
        '
        Me.PesoBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.PesoBox.Location = New System.Drawing.Point(174, 84)
        Me.PesoBox.Name = "PesoBox"
        Me.PesoBox.Size = New System.Drawing.Size(100, 20)
        Me.PesoBox.TabIndex = 3
        Me.PesoBox.Text = "Peso"
        Me.PesoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PesoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(388, 185)
        Me.ControlBox = False
        Me.Controls.Add(Me.PesoBox)
        Me.Controls.Add(Me.RegistroLabel)
        Me.Controls.Add(Me.PesoLabel)
        Me.Controls.Add(Me.IngresarButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PesoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IngresarButton As Button
    Friend WithEvents PesoLabel As Label
    Friend WithEvents RegistroLabel As Label
    Friend WithEvents PesoBox As TextBox
End Class
