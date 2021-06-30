<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class App
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App))
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.pnlTopUI = New System.Windows.Forms.Panel()
        Me.pnlTabs = New System.Windows.Forms.Panel()
        Me.pnlBtnCitas = New System.Windows.Forms.Panel()
        Me.btnCitas = New System.Windows.Forms.Button()
        Me.pnlBtnMed = New System.Windows.Forms.Panel()
        Me.btnMedicamentos = New System.Windows.Forms.Button()
        Me.pnlBtnAccount = New System.Windows.Forms.Panel()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.pnlBtnHome = New System.Windows.Forms.Panel()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.pnlBttmUI = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnRecents = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCelHome = New System.Windows.Forms.Button()
        Me.pnlCelGoBack = New System.Windows.Forms.Panel()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.pnlContainer.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlTabs.SuspendLayout()
        Me.pnlBtnCitas.SuspendLayout()
        Me.pnlBtnMed.SuspendLayout()
        Me.pnlBtnAccount.SuspendLayout()
        Me.pnlBtnHome.SuspendLayout()
        Me.pnlBttmUI.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlCelGoBack.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlContainer.Controls.Add(Me.pnlMain)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(269, 540)
        Me.pnlContainer.TabIndex = 0
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Controls.Add(Me.pnlTopUI)
        Me.pnlMain.Controls.Add(Me.pnlTabs)
        Me.pnlMain.Controls.Add(Me.pnlBttmUI)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(269, 540)
        Me.pnlMain.TabIndex = 2
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 28)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(269, 58)
        Me.pnlHeader.TabIndex = 1
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTitle.Location = New System.Drawing.Point(75, 0)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(120, 58)
        Me.lblHeaderTitle.TabIndex = 1
        Me.lblHeaderTitle.Text = "NOMBRE EMPRESA"
        Me.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTopUI
        '
        Me.pnlTopUI.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlTopUI.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopUI.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopUI.Name = "pnlTopUI"
        Me.pnlTopUI.Size = New System.Drawing.Size(269, 28)
        Me.pnlTopUI.TabIndex = 4
        '
        'pnlTabs
        '
        Me.pnlTabs.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.pnlTabs.Controls.Add(Me.pnlBtnCitas)
        Me.pnlTabs.Controls.Add(Me.pnlBtnMed)
        Me.pnlTabs.Controls.Add(Me.pnlBtnAccount)
        Me.pnlTabs.Controls.Add(Me.pnlBtnHome)
        Me.pnlTabs.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTabs.Location = New System.Drawing.Point(0, 421)
        Me.pnlTabs.Name = "pnlTabs"
        Me.pnlTabs.Size = New System.Drawing.Size(269, 67)
        Me.pnlTabs.TabIndex = 1
        '
        'pnlBtnCitas
        '
        Me.pnlBtnCitas.Controls.Add(Me.btnCitas)
        Me.pnlBtnCitas.Location = New System.Drawing.Point(75, 6)
        Me.pnlBtnCitas.Name = "pnlBtnCitas"
        Me.pnlBtnCitas.Size = New System.Drawing.Size(57, 58)
        Me.pnlBtnCitas.TabIndex = 2
        '
        'btnCitas
        '
        Me.btnCitas.BackgroundImage = CType(resources.GetObject("btnCitas.BackgroundImage"), System.Drawing.Image)
        Me.btnCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCitas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCitas.FlatAppearance.BorderSize = 0
        Me.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCitas.Location = New System.Drawing.Point(0, 0)
        Me.btnCitas.Name = "btnCitas"
        Me.btnCitas.Size = New System.Drawing.Size(57, 58)
        Me.btnCitas.TabIndex = 2
        Me.btnCitas.UseVisualStyleBackColor = True
        '
        'pnlBtnMed
        '
        Me.pnlBtnMed.Controls.Add(Me.btnMedicamentos)
        Me.pnlBtnMed.Location = New System.Drawing.Point(138, 6)
        Me.pnlBtnMed.Name = "pnlBtnMed"
        Me.pnlBtnMed.Size = New System.Drawing.Size(57, 58)
        Me.pnlBtnMed.TabIndex = 1
        '
        'btnMedicamentos
        '
        Me.btnMedicamentos.BackgroundImage = CType(resources.GetObject("btnMedicamentos.BackgroundImage"), System.Drawing.Image)
        Me.btnMedicamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMedicamentos.FlatAppearance.BorderSize = 0
        Me.btnMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedicamentos.Location = New System.Drawing.Point(0, 0)
        Me.btnMedicamentos.Name = "btnMedicamentos"
        Me.btnMedicamentos.Size = New System.Drawing.Size(57, 58)
        Me.btnMedicamentos.TabIndex = 1
        Me.btnMedicamentos.UseVisualStyleBackColor = True
        '
        'pnlBtnAccount
        '
        Me.pnlBtnAccount.Controls.Add(Me.btnAccount)
        Me.pnlBtnAccount.Location = New System.Drawing.Point(201, 6)
        Me.pnlBtnAccount.Name = "pnlBtnAccount"
        Me.pnlBtnAccount.Size = New System.Drawing.Size(57, 58)
        Me.pnlBtnAccount.TabIndex = 3
        '
        'btnAccount
        '
        Me.btnAccount.BackgroundImage = CType(resources.GetObject("btnAccount.BackgroundImage"), System.Drawing.Image)
        Me.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Location = New System.Drawing.Point(0, 0)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(57, 58)
        Me.btnAccount.TabIndex = 3
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'pnlBtnHome
        '
        Me.pnlBtnHome.Controls.Add(Me.btnHome)
        Me.pnlBtnHome.Location = New System.Drawing.Point(12, 6)
        Me.pnlBtnHome.Name = "pnlBtnHome"
        Me.pnlBtnHome.Size = New System.Drawing.Size(57, 58)
        Me.pnlBtnHome.TabIndex = 0
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), System.Drawing.Image)
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Location = New System.Drawing.Point(0, 0)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(57, 58)
        Me.btnHome.TabIndex = 0
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'pnlBttmUI
        '
        Me.pnlBttmUI.BackColor = System.Drawing.Color.Silver
        Me.pnlBttmUI.Controls.Add(Me.Panel3)
        Me.pnlBttmUI.Controls.Add(Me.Panel2)
        Me.pnlBttmUI.Controls.Add(Me.pnlCelGoBack)
        Me.pnlBttmUI.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBttmUI.Location = New System.Drawing.Point(0, 488)
        Me.pnlBttmUI.Name = "pnlBttmUI"
        Me.pnlBttmUI.Size = New System.Drawing.Size(269, 52)
        Me.pnlBttmUI.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnRecents)
        Me.Panel3.Location = New System.Drawing.Point(166, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(54, 46)
        Me.Panel3.TabIndex = 7
        '
        'btnRecents
        '
        Me.btnRecents.BackgroundImage = CType(resources.GetObject("btnRecents.BackgroundImage"), System.Drawing.Image)
        Me.btnRecents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRecents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRecents.FlatAppearance.BorderSize = 0
        Me.btnRecents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecents.Location = New System.Drawing.Point(0, 0)
        Me.btnRecents.Name = "btnRecents"
        Me.btnRecents.Size = New System.Drawing.Size(54, 46)
        Me.btnRecents.TabIndex = 2
        Me.btnRecents.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCelHome)
        Me.Panel2.Location = New System.Drawing.Point(106, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(54, 46)
        Me.Panel2.TabIndex = 6
        '
        'btnCelHome
        '
        Me.btnCelHome.BackgroundImage = CType(resources.GetObject("btnCelHome.BackgroundImage"), System.Drawing.Image)
        Me.btnCelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCelHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCelHome.FlatAppearance.BorderSize = 0
        Me.btnCelHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCelHome.Location = New System.Drawing.Point(0, 0)
        Me.btnCelHome.Name = "btnCelHome"
        Me.btnCelHome.Size = New System.Drawing.Size(54, 46)
        Me.btnCelHome.TabIndex = 1
        Me.btnCelHome.UseVisualStyleBackColor = True
        '
        'pnlCelGoBack
        '
        Me.pnlCelGoBack.Controls.Add(Me.btnGoBack)
        Me.pnlCelGoBack.Location = New System.Drawing.Point(46, 3)
        Me.pnlCelGoBack.Name = "pnlCelGoBack"
        Me.pnlCelGoBack.Size = New System.Drawing.Size(54, 46)
        Me.pnlCelGoBack.TabIndex = 5
        '
        'btnGoBack
        '
        Me.btnGoBack.BackgroundImage = CType(resources.GetObject("btnGoBack.BackgroundImage"), System.Drawing.Image)
        Me.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGoBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGoBack.FlatAppearance.BorderSize = 0
        Me.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoBack.Location = New System.Drawing.Point(0, 0)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(54, 46)
        Me.btnGoBack.TabIndex = 0
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 540)
        Me.Controls.Add(Me.pnlContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "App"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlTabs.ResumeLayout(False)
        Me.pnlBtnCitas.ResumeLayout(False)
        Me.pnlBtnMed.ResumeLayout(False)
        Me.pnlBtnAccount.ResumeLayout(False)
        Me.pnlBtnHome.ResumeLayout(False)
        Me.pnlBttmUI.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnlCelGoBack.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContainer As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlTabs As Panel
    Friend WithEvents pnlBtnCitas As Panel
    Friend WithEvents btnCitas As Button
    Friend WithEvents pnlBtnMed As Panel
    Friend WithEvents btnMedicamentos As Button
    Friend WithEvents pnlBtnAccount As Panel
    Friend WithEvents btnAccount As Button
    Friend WithEvents pnlBtnHome As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnRecents As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents pnlTopUI As Panel
    Friend WithEvents pnlBttmUI As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCelHome As Button
    Friend WithEvents pnlCelGoBack As Panel
    Friend WithEvents btnGoBack As Button
End Class
