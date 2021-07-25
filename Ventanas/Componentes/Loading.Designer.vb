<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading))
        Me.pnlLoading = New System.Windows.Forms.Panel()
        Me.loadingAnimation = New System.Windows.Forms.PictureBox()
        Me.pnlLoading.SuspendLayout()
        CType(Me.loadingAnimation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLoading
        '
        Me.pnlLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlLoading.Controls.Add(Me.loadingAnimation)
        Me.pnlLoading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoading.Location = New System.Drawing.Point(0, 0)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(398, 382)
        Me.pnlLoading.TabIndex = 0
        '
        'loadingAnimation
        '
        Me.loadingAnimation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loadingAnimation.Image = CType(resources.GetObject("loadingAnimation.Image"), System.Drawing.Image)
        Me.loadingAnimation.Location = New System.Drawing.Point(91, 87)
        Me.loadingAnimation.Name = "loadingAnimation"
        Me.loadingAnimation.Size = New System.Drawing.Size(200, 200)
        Me.loadingAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.loadingAnimation.TabIndex = 0
        Me.loadingAnimation.TabStop = False
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 382)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlLoading)
        Me.Name = "Loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Loading"
        Me.pnlLoading.ResumeLayout(False)
        Me.pnlLoading.PerformLayout()
        CType(Me.loadingAnimation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLoading As Panel
    Friend WithEvents loadingAnimation As PictureBox
End Class
