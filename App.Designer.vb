<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class App
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App))
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
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
        Me.pnlRecentCel = New System.Windows.Forms.Panel()
        Me.btnRecents = New System.Windows.Forms.Button()
        Me.pnlHomeCel = New System.Windows.Forms.Panel()
        Me.btnCelHome = New System.Windows.Forms.Button()
        Me.pnlCelGoBack = New System.Windows.Forms.Panel()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.DB_ProyectoFInal2021DataSet = New HPAPrototype.DB_ProyectoFInal2021DataSet()
        Me.pnlContainer.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlTabs.SuspendLayout()
        Me.pnlBtnCitas.SuspendLayout()
        Me.pnlBtnMed.SuspendLayout()
        Me.pnlBtnAccount.SuspendLayout()
        Me.pnlBtnHome.SuspendLayout()
        Me.pnlBttmUI.SuspendLayout()
        Me.pnlRecentCel.SuspendLayout()
        Me.pnlHomeCel.SuspendLayout()
        Me.pnlCelGoBack.SuspendLayout()
        CType(Me.DB_ProyectoFInal2021DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlContainer.Controls.Add(Me.pnlMain)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(414, 729)
        Me.pnlContainer.TabIndex = 0
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.BackgroundImage = Global.HPAPrototype.My.Resources.Resources.MicrosoftTeams_image__1_
        Me.pnlMain.Controls.Add(Me.pnlTopUI)
        Me.pnlMain.Controls.Add(Me.pnlTabs)
        Me.pnlMain.Controls.Add(Me.pnlBttmUI)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(414, 729)
        Me.pnlMain.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(365, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(37, 33)
        Me.btnExit.TabIndex = 2
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlTopUI
        '
        Me.pnlTopUI.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlTopUI.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopUI.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopUI.Name = "pnlTopUI"
        Me.pnlTopUI.Size = New System.Drawing.Size(414, 28)
        Me.pnlTopUI.TabIndex = 4
        '
        'pnlTabs
        '
        Me.pnlTabs.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTabs.Controls.Add(Me.pnlBtnCitas)
        Me.pnlTabs.Controls.Add(Me.pnlBtnMed)
        Me.pnlTabs.Controls.Add(Me.pnlBtnAccount)
        Me.pnlTabs.Controls.Add(Me.pnlBtnHome)
        Me.pnlTabs.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTabs.Location = New System.Drawing.Point(0, 591)
        Me.pnlTabs.Name = "pnlTabs"
        Me.pnlTabs.Size = New System.Drawing.Size(414, 86)
        Me.pnlTabs.TabIndex = 1
        '
        'pnlBtnCitas
        '
        Me.pnlBtnCitas.Controls.Add(Me.btnCitas)
        Me.pnlBtnCitas.Location = New System.Drawing.Point(116, 6)
        Me.pnlBtnCitas.Name = "pnlBtnCitas"
        Me.pnlBtnCitas.Size = New System.Drawing.Size(73, 73)
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
        Me.btnCitas.Size = New System.Drawing.Size(73, 73)
        Me.btnCitas.TabIndex = 2
        Me.btnCitas.UseVisualStyleBackColor = True
        '
        'pnlBtnMed
        '
        Me.pnlBtnMed.Controls.Add(Me.btnMedicamentos)
        Me.pnlBtnMed.Location = New System.Drawing.Point(214, 6)
        Me.pnlBtnMed.Name = "pnlBtnMed"
        Me.pnlBtnMed.Size = New System.Drawing.Size(73, 73)
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
        Me.btnMedicamentos.Size = New System.Drawing.Size(73, 73)
        Me.btnMedicamentos.TabIndex = 1
        Me.btnMedicamentos.UseVisualStyleBackColor = True
        '
        'pnlBtnAccount
        '
        Me.pnlBtnAccount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlBtnAccount.Controls.Add(Me.btnAccount)
        Me.pnlBtnAccount.Location = New System.Drawing.Point(315, 6)
        Me.pnlBtnAccount.Name = "pnlBtnAccount"
        Me.pnlBtnAccount.Size = New System.Drawing.Size(73, 73)
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
        Me.btnAccount.Size = New System.Drawing.Size(73, 73)
        Me.btnAccount.TabIndex = 3
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'pnlBtnHome
        '
        Me.pnlBtnHome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBtnHome.Controls.Add(Me.btnHome)
        Me.pnlBtnHome.Location = New System.Drawing.Point(27, 6)
        Me.pnlBtnHome.Name = "pnlBtnHome"
        Me.pnlBtnHome.Size = New System.Drawing.Size(73, 73)
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
        Me.btnHome.Size = New System.Drawing.Size(73, 73)
        Me.btnHome.TabIndex = 0
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'pnlBttmUI
        '
        Me.pnlBttmUI.BackColor = System.Drawing.Color.Silver
        Me.pnlBttmUI.Controls.Add(Me.pnlRecentCel)
        Me.pnlBttmUI.Controls.Add(Me.pnlHomeCel)
        Me.pnlBttmUI.Controls.Add(Me.pnlCelGoBack)
        Me.pnlBttmUI.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBttmUI.Location = New System.Drawing.Point(0, 677)
        Me.pnlBttmUI.Name = "pnlBttmUI"
        Me.pnlBttmUI.Size = New System.Drawing.Size(414, 52)
        Me.pnlBttmUI.TabIndex = 0
        '
        'pnlRecentCel
        '
        Me.pnlRecentCel.Controls.Add(Me.btnRecents)
        Me.pnlRecentCel.Location = New System.Drawing.Point(246, 3)
        Me.pnlRecentCel.Name = "pnlRecentCel"
        Me.pnlRecentCel.Size = New System.Drawing.Size(54, 46)
        Me.pnlRecentCel.TabIndex = 7
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
        'pnlHomeCel
        '
        Me.pnlHomeCel.Controls.Add(Me.btnCelHome)
        Me.pnlHomeCel.Location = New System.Drawing.Point(170, 3)
        Me.pnlHomeCel.Name = "pnlHomeCel"
        Me.pnlHomeCel.Size = New System.Drawing.Size(54, 46)
        Me.pnlHomeCel.TabIndex = 6
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
        Me.pnlCelGoBack.Location = New System.Drawing.Point(88, 3)
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
        'DB_ProyectoFInal2021DataSet
        '
        Me.DB_ProyectoFInal2021DataSet.DataSetName = "DB_ProyectoFInal2021DataSet"
        Me.DB_ProyectoFInal2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 729)
        Me.Controls.Add(Me.pnlContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "App"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlTabs.ResumeLayout(False)
        Me.pnlBtnCitas.ResumeLayout(False)
        Me.pnlBtnMed.ResumeLayout(False)
        Me.pnlBtnAccount.ResumeLayout(False)
        Me.pnlBtnAccount.PerformLayout()
        Me.pnlBtnHome.ResumeLayout(False)
        Me.pnlBttmUI.ResumeLayout(False)
        Me.pnlRecentCel.ResumeLayout(False)
        Me.pnlHomeCel.ResumeLayout(False)
        Me.pnlCelGoBack.ResumeLayout(False)
        CType(Me.DB_ProyectoFInal2021DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContainer As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlTopUI As Panel
    Friend WithEvents pnlTabs As Panel
    Friend WithEvents pnlBtnCitas As Panel
    Friend WithEvents btnCitas As Button
    Friend WithEvents pnlBtnMed As Panel
    Friend WithEvents btnMedicamentos As Button
    Friend WithEvents pnlBtnAccount As Panel
    Friend WithEvents btnAccount As Button
    Friend WithEvents pnlBtnHome As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents pnlBttmUI As Panel
    Friend WithEvents pnlRecentCel As Panel
    Friend WithEvents btnRecents As Button
    Friend WithEvents pnlHomeCel As Panel
    Friend WithEvents btnCelHome As Button
    Friend WithEvents pnlCelGoBack As Panel
    Friend WithEvents btnGoBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents DB_ProyectoFInal2021DataSet As DB_ProyectoFInal2021DataSet
End Class
