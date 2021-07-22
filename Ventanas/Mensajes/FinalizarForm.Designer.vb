<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalizarForm
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
        Me.NoButton = New System.Windows.Forms.Button()
        Me.SiButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FinalizarLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NoButton
        '
        Me.NoButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoButton.Location = New System.Drawing.Point(104, 114)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(75, 23)
        Me.NoButton.TabIndex = 0
        Me.NoButton.Text = "No"
        Me.NoButton.UseVisualStyleBackColor = False
        '
        'SiButton
        '
        Me.SiButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SiButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiButton.Location = New System.Drawing.Point(332, 114)
        Me.SiButton.Name = "SiButton"
        Me.SiButton.Size = New System.Drawing.Size(75, 23)
        Me.SiButton.TabIndex = 1
        Me.SiButton.Text = "Si"
        Me.SiButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "¿Esta seguro que desea cerrar sesion?"
        '
        'FinalizarLabel
        '
        Me.FinalizarLabel.AutoSize = True
        Me.FinalizarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalizarLabel.Location = New System.Drawing.Point(170, 18)
        Me.FinalizarLabel.Name = "FinalizarLabel"
        Me.FinalizarLabel.Size = New System.Drawing.Size(189, 25)
        Me.FinalizarLabel.TabIndex = 3
        Me.FinalizarLabel.Text = "Finalizar Sesion "
        '
        'FinalizarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(520, 168)
        Me.Controls.Add(Me.FinalizarLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SiButton)
        Me.Controls.Add(Me.NoButton)
        Me.Name = "FinalizarForm"
        Me.Text = "Finalizar Sesion "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NoButton As Button
    Friend WithEvents SiButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FinalizarLabel As Label
End Class
