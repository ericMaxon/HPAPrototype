<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompraEForm
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
        Me.OkCompraEButton = New System.Windows.Forms.Button()
        Me.CompraELabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OkCompraEButton
        '
        Me.OkCompraEButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.OkCompraEButton.FlatAppearance.BorderSize = 0
        Me.OkCompraEButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OkCompraEButton.Location = New System.Drawing.Point(127, 20)
        Me.OkCompraEButton.Name = "OkCompraEButton"
        Me.OkCompraEButton.Size = New System.Drawing.Size(75, 23)
        Me.OkCompraEButton.TabIndex = 0
        Me.OkCompraEButton.Text = "Ok"
        Me.OkCompraEButton.UseVisualStyleBackColor = False
        '
        'CompraELabel
        '
        Me.CompraELabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompraELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompraELabel.Location = New System.Drawing.Point(0, 0)
        Me.CompraELabel.Name = "CompraELabel"
        Me.CompraELabel.Size = New System.Drawing.Size(337, 58)
        Me.CompraELabel.TabIndex = 1
        Me.CompraELabel.Text = "Compra Exitosa"
        Me.CompraELabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CompraELabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(337, 58)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.OkCompraEButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(337, 65)
        Me.Panel2.TabIndex = 3
        '
        'CompraEForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(337, 157)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CompraEForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra Exitosa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OkCompraEButton As Button
    Friend WithEvents CompraELabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
