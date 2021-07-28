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
        Me.javilloBtn = New System.Windows.Forms.Button()
        Me.arrochaBtn = New System.Windows.Forms.Button()
        Me.css17Btn = New System.Windows.Forms.Button()
        Me.cssColonBtn = New System.Windows.Forms.Button()
        Me.sazBtn = New System.Windows.Forms.Button()
        Me.medLbl = New System.Windows.Forms.Label()
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
        Me.FarmaciasLabel.Location = New System.Drawing.Point(77, 9)
        Me.FarmaciasLabel.Name = "FarmaciasLabel"
        Me.FarmaciasLabel.Size = New System.Drawing.Size(346, 25)
        Me.FarmaciasLabel.TabIndex = 1
        Me.FarmaciasLabel.Text = "Seleccione la farmacia de retiro"
        '
        'javilloBtn
        '
        Me.javilloBtn.AutoSize = True
        Me.javilloBtn.Location = New System.Drawing.Point(157, 79)
        Me.javilloBtn.Name = "javilloBtn"
        Me.javilloBtn.Size = New System.Drawing.Size(171, 23)
        Me.javilloBtn.TabIndex = 7
        Me.javilloBtn.Tag = "5000"
        Me.javilloBtn.Text = "El Javillo (Calle 50, Panama)"
        Me.javilloBtn.UseVisualStyleBackColor = True
        '
        'arrochaBtn
        '
        Me.arrochaBtn.AutoSize = True
        Me.arrochaBtn.Location = New System.Drawing.Point(157, 115)
        Me.arrochaBtn.Margin = New System.Windows.Forms.Padding(10)
        Me.arrochaBtn.Name = "arrochaBtn"
        Me.arrochaBtn.Size = New System.Drawing.Size(171, 23)
        Me.arrochaBtn.TabIndex = 8
        Me.arrochaBtn.Tag = "5002"
        Me.arrochaBtn.Text = "Farmacias Arrocha (Albrook)"
        Me.arrochaBtn.UseVisualStyleBackColor = True
        '
        'css17Btn
        '
        Me.css17Btn.AutoSize = True
        Me.css17Btn.Location = New System.Drawing.Point(157, 151)
        Me.css17Btn.Name = "css17Btn"
        Me.css17Btn.Size = New System.Drawing.Size(171, 23)
        Me.css17Btn.TabIndex = 9
        Me.css17Btn.Tag = "5004"
        Me.css17Btn.Text = "CSS (Calle 17, Panama)"
        Me.css17Btn.UseVisualStyleBackColor = True
        '
        'cssColonBtn
        '
        Me.cssColonBtn.AutoSize = True
        Me.cssColonBtn.Location = New System.Drawing.Point(157, 187)
        Me.cssColonBtn.Margin = New System.Windows.Forms.Padding(10)
        Me.cssColonBtn.Name = "cssColonBtn"
        Me.cssColonBtn.Size = New System.Drawing.Size(171, 23)
        Me.cssColonBtn.TabIndex = 10
        Me.cssColonBtn.Tag = "5006"
        Me.cssColonBtn.Text = "CSS (Colon, Panama)"
        Me.cssColonBtn.UseVisualStyleBackColor = True
        '
        'sazBtn
        '
        Me.sazBtn.AutoSize = True
        Me.sazBtn.Location = New System.Drawing.Point(157, 223)
        Me.sazBtn.Name = "sazBtn"
        Me.sazBtn.Size = New System.Drawing.Size(171, 23)
        Me.sazBtn.TabIndex = 11
        Me.sazBtn.Tag = "5008"
        Me.sazBtn.Text = "Farmacia Saz (Colon, Panama)"
        Me.sazBtn.UseVisualStyleBackColor = True
        '
        'medLbl
        '
        Me.medLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medLbl.Location = New System.Drawing.Point(77, 47)
        Me.medLbl.Name = "medLbl"
        Me.medLbl.Size = New System.Drawing.Size(346, 25)
        Me.medLbl.TabIndex = 12
        Me.medLbl.Text = "Medicamento"
        Me.medLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FarmaciasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(461, 304)
        Me.ControlBox = False
        Me.Controls.Add(Me.medLbl)
        Me.Controls.Add(Me.sazBtn)
        Me.Controls.Add(Me.cssColonBtn)
        Me.Controls.Add(Me.css17Btn)
        Me.Controls.Add(Me.arrochaBtn)
        Me.Controls.Add(Me.javilloBtn)
        Me.Controls.Add(Me.FarmaciasLabel)
        Me.Controls.Add(Me.SalirButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FarmaciasForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Farmacias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SalirButton As Button
    Friend WithEvents FarmaciasLabel As Label
    Friend WithEvents javilloBtn As Button
    Friend WithEvents arrochaBtn As Button
    Friend WithEvents css17Btn As Button
    Friend WithEvents cssColonBtn As Button
    Friend WithEvents sazBtn As Button
    Friend WithEvents medLbl As Label
End Class
