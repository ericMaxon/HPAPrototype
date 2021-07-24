<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventarioBForm
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
        Me.OkInvButton = New System.Windows.Forms.Button()
        Me.InventarioLabel = New System.Windows.Forms.Label()
        Me.InvLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OkInvButton
        '
        Me.OkInvButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.OkInvButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OkInvButton.Location = New System.Drawing.Point(130, 123)
        Me.OkInvButton.Name = "OkInvButton"
        Me.OkInvButton.Size = New System.Drawing.Size(75, 23)
        Me.OkInvButton.TabIndex = 0
        Me.OkInvButton.Text = "Ok"
        Me.OkInvButton.UseVisualStyleBackColor = False
        '
        'InventarioLabel
        '
        Me.InventarioLabel.AutoSize = True
        Me.InventarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventarioLabel.Location = New System.Drawing.Point(116, 25)
        Me.InventarioLabel.Name = "InventarioLabel"
        Me.InventarioLabel.Size = New System.Drawing.Size(101, 24)
        Me.InventarioLabel.TabIndex = 1
        Me.InventarioLabel.Text = "Inventario"
        '
        'InvLabel
        '
        Me.InvLabel.AutoSize = True
        Me.InvLabel.Location = New System.Drawing.Point(77, 79)
        Me.InvLabel.Name = "InvLabel"
        Me.InvLabel.Size = New System.Drawing.Size(179, 13)
        Me.InvLabel.TabIndex = 2
        Me.InvLabel.Text = "No hay existencias de este producto"
        '
        'InventarioBForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(337, 168)
        Me.Controls.Add(Me.InvLabel)
        Me.Controls.Add(Me.InventarioLabel)
        Me.Controls.Add(Me.OkInvButton)
        Me.Name = "InventarioBForm"
        Me.Text = "Inventario Bajo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OkInvButton As Button
    Friend WithEvents InventarioLabel As Label
    Friend WithEvents InvLabel As Label
End Class
