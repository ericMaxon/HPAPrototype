<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedsForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnComprarOrlistat = New System.Windows.Forms.Button()
        Me.btnComprarBupropion = New System.Windows.Forms.Button()
        Me.btnComprarCaptopril = New System.Windows.Forms.Button()
        Me.btnComprarFente = New System.Windows.Forms.Button()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(47, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(47, 185)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(139, 86)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(47, 291)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(139, 75)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(46, 390)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(138, 73)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(251, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 32)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Orlistat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Precio: B/. 12.50"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(251, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 32)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Captopril" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Precio: B/. 12.50"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(251, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 32)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Bupropion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Precio: B/. 12.50"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(251, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 32)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fentermina" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Precio: B/. 12.50"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnComprarOrlistat
        '
        Me.btnComprarOrlistat.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnComprarOrlistat.FlatAppearance.BorderSize = 0
        Me.btnComprarOrlistat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComprarOrlistat.Location = New System.Drawing.Point(265, 147)
        Me.btnComprarOrlistat.Name = "btnComprarOrlistat"
        Me.btnComprarOrlistat.Size = New System.Drawing.Size(75, 23)
        Me.btnComprarOrlistat.TabIndex = 10
        Me.btnComprarOrlistat.Text = "Comprar"
        Me.btnComprarOrlistat.UseVisualStyleBackColor = False
        '
        'btnComprarBupropion
        '
        Me.btnComprarBupropion.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnComprarBupropion.FlatAppearance.BorderSize = 0
        Me.btnComprarBupropion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComprarBupropion.Location = New System.Drawing.Point(265, 343)
        Me.btnComprarBupropion.Name = "btnComprarBupropion"
        Me.btnComprarBupropion.Size = New System.Drawing.Size(75, 23)
        Me.btnComprarBupropion.TabIndex = 11
        Me.btnComprarBupropion.Text = "Comprar"
        Me.btnComprarBupropion.UseVisualStyleBackColor = False
        '
        'btnComprarCaptopril
        '
        Me.btnComprarCaptopril.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnComprarCaptopril.FlatAppearance.BorderSize = 0
        Me.btnComprarCaptopril.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComprarCaptopril.Location = New System.Drawing.Point(265, 248)
        Me.btnComprarCaptopril.Name = "btnComprarCaptopril"
        Me.btnComprarCaptopril.Size = New System.Drawing.Size(75, 23)
        Me.btnComprarCaptopril.TabIndex = 12
        Me.btnComprarCaptopril.Text = "Comprar"
        Me.btnComprarCaptopril.UseVisualStyleBackColor = False
        '
        'btnComprarFente
        '
        Me.btnComprarFente.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnComprarFente.FlatAppearance.BorderSize = 0
        Me.btnComprarFente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComprarFente.Location = New System.Drawing.Point(265, 440)
        Me.btnComprarFente.Name = "btnComprarFente"
        Me.btnComprarFente.Size = New System.Drawing.Size(75, 23)
        Me.btnComprarFente.TabIndex = 13
        Me.btnComprarFente.Text = "Comprar"
        Me.btnComprarFente.UseVisualStyleBackColor = False
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.BackColor = System.Drawing.Color.LightGray
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTitle.Location = New System.Drawing.Point(-2, -7)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(414, 43)
        Me.lblHeaderTitle.TabIndex = 14
        Me.lblHeaderTitle.Text = "Medicamentos"
        Me.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox5.BackgroundImage = Global.HPAPrototype.My.Resources.Resources.akar_icons_arrow_left
        Me.PictureBox5.Location = New System.Drawing.Point(31, 1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(48, 35)
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'MedsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.HPAPrototype.My.Resources.Resources.MicrosoftTeams_image__1_
        Me.ClientSize = New System.Drawing.Size(398, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.lblHeaderTitle)
        Me.Controls.Add(Me.btnComprarFente)
        Me.Controls.Add(Me.btnComprarCaptopril)
        Me.Controls.Add(Me.btnComprarBupropion)
        Me.Controls.Add(Me.btnComprarOrlistat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MedsForm"
        Me.Text = "MedsForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnComprarOrlistat As Button
    Friend WithEvents btnComprarBupropion As Button
    Friend WithEvents btnComprarCaptopril As Button
    Friend WithEvents btnComprarFente As Button
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents PictureBox5 As PictureBox
End Class
