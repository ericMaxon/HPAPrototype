<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErrorForm))
        Me.OkInvButton = New System.Windows.Forms.Button()
        Me.errLabel = New System.Windows.Forms.Label()
        Me.errLblMsg = New System.Windows.Forms.Label()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.pbErr = New System.Windows.Forms.PictureBox()
        Me.pnlMsg = New System.Windows.Forms.Panel()
        Me.pnlBtn = New System.Windows.Forms.Panel()
        Me.pnlTitle.SuspendLayout()
        CType(Me.pbErr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMsg.SuspendLayout()
        Me.pnlBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'OkInvButton
        '
        Me.OkInvButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.OkInvButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OkInvButton.Location = New System.Drawing.Point(132, 3)
        Me.OkInvButton.Name = "OkInvButton"
        Me.OkInvButton.Size = New System.Drawing.Size(75, 23)
        Me.OkInvButton.TabIndex = 0
        Me.OkInvButton.Text = "Ok"
        Me.OkInvButton.UseVisualStyleBackColor = False
        '
        'errLabel
        '
        Me.errLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errLabel.Location = New System.Drawing.Point(0, 0)
        Me.errLabel.Margin = New System.Windows.Forms.Padding(114, 15, 115, 0)
        Me.errLabel.Name = "errLabel"
        Me.errLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.errLabel.Size = New System.Drawing.Size(337, 30)
        Me.errLabel.TabIndex = 1
        Me.errLabel.Text = "ERROR"
        Me.errLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'errLblMsg
        '
        Me.errLblMsg.BackColor = System.Drawing.Color.Transparent
        Me.errLblMsg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.errLblMsg.Location = New System.Drawing.Point(0, 0)
        Me.errLblMsg.Name = "errLblMsg"
        Me.errLblMsg.Size = New System.Drawing.Size(337, 63)
        Me.errLblMsg.TabIndex = 2
        Me.errLblMsg.Text = "MSG"
        Me.errLblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Transparent
        Me.pnlTitle.Controls.Add(Me.pbErr)
        Me.pnlTitle.Controls.Add(Me.errLabel)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(337, 65)
        Me.pnlTitle.TabIndex = 3
        '
        'pbErr
        '
        Me.pbErr.Image = CType(resources.GetObject("pbErr.Image"), System.Drawing.Image)
        Me.pbErr.Location = New System.Drawing.Point(155, 33)
        Me.pbErr.Name = "pbErr"
        Me.pbErr.Size = New System.Drawing.Size(32, 32)
        Me.pbErr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbErr.TabIndex = 3
        Me.pbErr.TabStop = False
        '
        'pnlMsg
        '
        Me.pnlMsg.BackColor = System.Drawing.Color.Transparent
        Me.pnlMsg.Controls.Add(Me.errLblMsg)
        Me.pnlMsg.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMsg.Location = New System.Drawing.Point(0, 65)
        Me.pnlMsg.Name = "pnlMsg"
        Me.pnlMsg.Size = New System.Drawing.Size(337, 63)
        Me.pnlMsg.TabIndex = 4
        '
        'pnlBtn
        '
        Me.pnlBtn.BackColor = System.Drawing.Color.Transparent
        Me.pnlBtn.Controls.Add(Me.OkInvButton)
        Me.pnlBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBtn.Location = New System.Drawing.Point(0, 131)
        Me.pnlBtn.Name = "pnlBtn"
        Me.pnlBtn.Size = New System.Drawing.Size(337, 37)
        Me.pnlBtn.TabIndex = 5
        '
        'ErrorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(337, 168)
        Me.Controls.Add(Me.pnlBtn)
        Me.Controls.Add(Me.pnlMsg)
        Me.Controls.Add(Me.pnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ErrorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario Bajo"
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        CType(Me.pbErr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMsg.ResumeLayout(False)
        Me.pnlBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OkInvButton As Button
    Friend WithEvents errLabel As Label
    Friend WithEvents errLblMsg As Label
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents pnlMsg As Panel
    Friend WithEvents pnlBtn As Panel
    Friend WithEvents pbErr As PictureBox
End Class
