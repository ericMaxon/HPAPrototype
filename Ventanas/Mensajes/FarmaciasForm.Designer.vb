<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FarmaciasForm
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
        Me.SalirButton = New System.Windows.Forms.Button()
        Me.FarmaciasLabel = New System.Windows.Forms.Label()
        Me.CSSLabel1 = New System.Windows.Forms.Label()
        Me.CSSLabel = New System.Windows.Forms.Label()
        Me.ArrochaLabel = New System.Windows.Forms.Label()
        Me.JavilloLabel = New System.Windows.Forms.Label()
        Me.SazLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SalirButton
        '
        Me.SalirButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.SalirButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SalirButton.Location = New System.Drawing.Point(198, 263)
        Me.SalirButton.Name = "SalirButton"
        Me.SalirButton.Size = New System.Drawing.Size(75, 23)
        Me.SalirButton.TabIndex = 0
        Me.SalirButton.Text = "Salir"
        Me.SalirButton.UseVisualStyleBackColor = False
        '
        'FarmaciasLabel
        '
        Me.FarmaciasLabel.AutoSize = True
        Me.FarmaciasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FarmaciasLabel.Location = New System.Drawing.Point(176, 22)
        Me.FarmaciasLabel.Name = "FarmaciasLabel"
        Me.FarmaciasLabel.Size = New System.Drawing.Size(121, 25)
        Me.FarmaciasLabel.TabIndex = 1
        Me.FarmaciasLabel.Text = "Farmacias"
        '
        'CSSLabel1
        '
        Me.CSSLabel1.AutoSize = True
        Me.CSSLabel1.BackColor = System.Drawing.Color.White
        Me.CSSLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CSSLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CSSLabel1.Location = New System.Drawing.Point(169, 182)
        Me.CSSLabel1.Name = "CSSLabel1"
        Me.CSSLabel1.Size = New System.Drawing.Size(137, 18)
        Me.CSSLabel1.TabIndex = 2
        Me.CSSLabel1.Text = "CSS(Colon, Panama)"
        '
        'CSSLabel
        '
        Me.CSSLabel.AutoSize = True
        Me.CSSLabel.BackColor = System.Drawing.Color.White
        Me.CSSLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CSSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CSSLabel.Location = New System.Drawing.Point(158, 143)
        Me.CSSLabel.Name = "CSSLabel"
        Me.CSSLabel.Size = New System.Drawing.Size(153, 18)
        Me.CSSLabel.TabIndex = 3
        Me.CSSLabel.Text = "CSS (Calle 17, Panama)"
        '
        'ArrochaLabel
        '
        Me.ArrochaLabel.AutoSize = True
        Me.ArrochaLabel.BackColor = System.Drawing.Color.White
        Me.ArrochaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ArrochaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArrochaLabel.Location = New System.Drawing.Point(144, 106)
        Me.ArrochaLabel.Name = "ArrochaLabel"
        Me.ArrochaLabel.Size = New System.Drawing.Size(182, 18)
        Me.ArrochaLabel.TabIndex = 4
        Me.ArrochaLabel.Text = "Farmacias Arrocha (Albrook)"
        '
        'JavilloLabel
        '
        Me.JavilloLabel.AutoSize = True
        Me.JavilloLabel.BackColor = System.Drawing.Color.White
        Me.JavilloLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.JavilloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JavilloLabel.Location = New System.Drawing.Point(146, 70)
        Me.JavilloLabel.Name = "JavilloLabel"
        Me.JavilloLabel.Size = New System.Drawing.Size(180, 18)
        Me.JavilloLabel.TabIndex = 5
        Me.JavilloLabel.Text = "El Javillo (Calle 50, Panama)"
        '
        'SazLabel
        '
        Me.SazLabel.AutoSize = True
        Me.SazLabel.BackColor = System.Drawing.Color.White
        Me.SazLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SazLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SazLabel.Location = New System.Drawing.Point(144, 222)
        Me.SazLabel.Name = "SazLabel"
        Me.SazLabel.Size = New System.Drawing.Size(196, 18)
        Me.SazLabel.TabIndex = 6
        Me.SazLabel.Text = "Farmacia Saz (Colon, Panama)"
        '
        'FarmaciasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(461, 304)
        Me.Controls.Add(Me.SazLabel)
        Me.Controls.Add(Me.JavilloLabel)
        Me.Controls.Add(Me.ArrochaLabel)
        Me.Controls.Add(Me.CSSLabel)
        Me.Controls.Add(Me.CSSLabel1)
        Me.Controls.Add(Me.FarmaciasLabel)
        Me.Controls.Add(Me.SalirButton)
        Me.Name = "FarmaciasForm"
        Me.Text = "Farmacias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SalirButton As Button
    Friend WithEvents FarmaciasLabel As Label
    Friend WithEvents CSSLabel1 As Label
    Friend WithEvents CSSLabel As Label
    Friend WithEvents ArrochaLabel As Label
    Friend WithEvents JavilloLabel As Label
    Friend WithEvents SazLabel As Label
End Class
