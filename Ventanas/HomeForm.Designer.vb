<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
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
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCitas = New System.Windows.Forms.DataGridView()
        Me.tbxClmCodCita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbxClmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbxClmNmDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbxColmHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvMeds = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDosis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMeds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.BackColor = System.Drawing.Color.LightGray
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTitle.Location = New System.Drawing.Point(-1, -6)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(414, 43)
        Me.lblHeaderTitle.TabIndex = 2
        Me.lblHeaderTitle.Text = "Menú principal "
        Me.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Citas"
        '
        'dgvCitas
        '
        Me.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCitas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tbxClmCodCita, Me.tbxClmFecha, Me.tbxClmNmDoc, Me.tbxColmHora})
        Me.dgvCitas.Location = New System.Drawing.Point(3, 140)
        Me.dgvCitas.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvCitas.Name = "dgvCitas"
        Me.dgvCitas.Size = New System.Drawing.Size(402, 48)
        Me.dgvCitas.TabIndex = 19
        '
        'tbxClmCodCita
        '
        Me.tbxClmCodCita.Frozen = True
        Me.tbxClmCodCita.HeaderText = "CodCita"
        Me.tbxClmCodCita.Name = "tbxClmCodCita"
        Me.tbxClmCodCita.ReadOnly = True
        '
        'tbxClmFecha
        '
        Me.tbxClmFecha.Frozen = True
        Me.tbxClmFecha.HeaderText = "Fecha"
        Me.tbxClmFecha.Name = "tbxClmFecha"
        Me.tbxClmFecha.ReadOnly = True
        '
        'tbxClmNmDoc
        '
        Me.tbxClmNmDoc.Frozen = True
        Me.tbxClmNmDoc.HeaderText = "Doctor"
        Me.tbxClmNmDoc.Name = "tbxClmNmDoc"
        Me.tbxClmNmDoc.ReadOnly = True
        '
        'tbxColmHora
        '
        Me.tbxColmHora.Frozen = True
        Me.tbxColmHora.HeaderText = "Hora"
        Me.tbxColmHora.Name = "tbxColmHora"
        Me.tbxColmHora.ReadOnly = True
        '
        'dgvMeds
        '
        Me.dgvMeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMeds.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvNombre, Me.dgvCantidad, Me.dgvDosis})
        Me.dgvMeds.Location = New System.Drawing.Point(8, 307)
        Me.dgvMeds.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvMeds.Name = "dgvMeds"
        Me.dgvMeds.Size = New System.Drawing.Size(397, 61)
        Me.dgvMeds.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 24)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Medicamentos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(108, 445)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Ingreso de peso diario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvNombre
        '
        Me.dgvNombre.HeaderText = "Nombre"
        Me.dgvNombre.Name = "dgvNombre"
        Me.dgvNombre.ReadOnly = True
        Me.dgvNombre.Width = 115
        '
        'dgvCantidad
        '
        Me.dgvCantidad.HeaderText = "Cantidad"
        Me.dgvCantidad.Name = "dgvCantidad"
        Me.dgvCantidad.ReadOnly = True
        Me.dgvCantidad.Width = 115
        '
        'dgvDosis
        '
        Me.dgvDosis.HeaderText = "Dosis"
        Me.dgvDosis.Name = "dgvDosis"
        Me.dgvDosis.ReadOnly = True
        Me.dgvDosis.Width = 115
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.HPAPrototype.My.Resources.Resources.MicrosoftTeams_image__1_
        Me.ClientSize = New System.Drawing.Size(414, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvMeds)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvCitas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHeaderTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HomeForm"
        Me.Text = "HomeForm"
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMeds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvCitas As DataGridView
    Friend WithEvents tbxClmCodCita As DataGridViewTextBoxColumn
    Friend WithEvents tbxClmFecha As DataGridViewTextBoxColumn
    Friend WithEvents tbxClmNmDoc As DataGridViewTextBoxColumn
    Friend WithEvents tbxColmHora As DataGridViewTextBoxColumn
    Friend WithEvents dgvMeds As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvNombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvCantidad As DataGridViewTextBoxColumn
    Friend WithEvents dgvDosis As DataGridViewTextBoxColumn
End Class
