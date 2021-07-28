<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.imcLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnMeds = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CUENTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Condición Física"
        '
        'imcLbl
        '
        Me.imcLbl.AutoSize = True
        Me.imcLbl.BackColor = System.Drawing.Color.Transparent
        Me.imcLbl.Location = New System.Drawing.Point(147, 60)
        Me.imcLbl.Name = "imcLbl"
        Me.imcLbl.Size = New System.Drawing.Size(39, 13)
        Me.imcLbl.TabIndex = 3
        Me.imcLbl.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-3, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Síntomas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(339, 105)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = resources.GetString("Label5.Text")
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tratamientos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(137, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 60)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "- Alimentación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Ejercicio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Gastrectomía Bascular" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Bypass Gástrico"
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.BackColor = System.Drawing.Color.LightGray
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTitle.Location = New System.Drawing.Point(0, -3)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(414, 43)
        Me.lblHeaderTitle.TabIndex = 8
        Me.lblHeaderTitle.Text = "Cuenta"
        Me.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.BackgroundImage = Global.HPAPrototype.My.Resources.Resources.akar_icons_arrow_left
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 35)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.imcLbl)
        Me.Panel1.Location = New System.Drawing.Point(25, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 74)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(25, 180)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(351, 145)
        Me.Panel2.TabIndex = 12
        '
        'btnMeds
        '
        Me.btnMeds.BackColor = System.Drawing.Color.DarkGray
        Me.btnMeds.Location = New System.Drawing.Point(132, 472)
        Me.btnMeds.Name = "btnMeds"
        Me.btnMeds.Size = New System.Drawing.Size(143, 28)
        Me.btnMeds.TabIndex = 14
        Me.btnMeds.Text = "Mis Medicamentos"
        Me.btnMeds.UseVisualStyleBackColor = False
        '
        'AccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.HPAPrototype.My.Resources.Resources.MicrosoftTeams_image__1_
        Me.ClientSize = New System.Drawing.Size(414, 563)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnMeds)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHeaderTitle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(414, 563)
        Me.MinimumSize = New System.Drawing.Size(414, 500)
        Me.Name = "AccountForm"
        Me.Text = "v"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents imcLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnMeds As Button
End Class
