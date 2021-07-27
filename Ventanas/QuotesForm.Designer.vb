<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuotesForm
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
        Me.btnSolicitarCita = New System.Windows.Forms.Button()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.dgvCitas = New System.Windows.Forms.DataGridView()
        Me.tbxClmCodCita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbxClmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbxClmNmDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbxColmHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_ProyectoFInal2021DataSet = New HPAPrototype.DB_ProyectoFInal2021DataSet()
        Me.CitasTableAdapter = New HPAPrototype.DB_ProyectoFInal2021DataSetTableAdapters.CitasTableAdapter()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_ProyectoFInal2021DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSolicitarCita
        '
        Me.btnSolicitarCita.BackColor = System.Drawing.Color.DarkGray
        Me.btnSolicitarCita.Location = New System.Drawing.Point(127, 56)
        Me.btnSolicitarCita.Name = "btnSolicitarCita"
        Me.btnSolicitarCita.Size = New System.Drawing.Size(143, 28)
        Me.btnSolicitarCita.TabIndex = 2
        Me.btnSolicitarCita.Text = "Solicitar Cita"
        Me.btnSolicitarCita.UseVisualStyleBackColor = False
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.BackColor = System.Drawing.Color.LightGray
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTitle.Location = New System.Drawing.Point(-1, -1)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(414, 43)
        Me.lblHeaderTitle.TabIndex = 15
        Me.lblHeaderTitle.Text = "Citas Screen"
        Me.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox5.BackgroundImage = Global.HPAPrototype.My.Resources.Resources.akar_icons_arrow_left
        Me.PictureBox5.Location = New System.Drawing.Point(23, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(48, 35)
        Me.PictureBox5.TabIndex = 17
        Me.PictureBox5.TabStop = False
        '
        'dgvCitas
        '
        Me.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCitas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tbxClmCodCita, Me.tbxClmFecha, Me.tbxClmNmDoc, Me.tbxColmHora})
        Me.dgvCitas.Location = New System.Drawing.Point(4, 147)
        Me.dgvCitas.Name = "dgvCitas"
        Me.dgvCitas.Size = New System.Drawing.Size(396, 46)
        Me.dgvCitas.TabIndex = 18
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
        'CitasBindingSource
        '
        Me.CitasBindingSource.DataMember = "Citas"
        Me.CitasBindingSource.DataSource = Me.DB_ProyectoFInal2021DataSet
        '
        'DB_ProyectoFInal2021DataSet
        '
        Me.DB_ProyectoFInal2021DataSet.DataSetName = "DB_ProyectoFInal2021DataSet"
        Me.DB_ProyectoFInal2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CitasTableAdapter
        '
        Me.CitasTableAdapter.ClearBeforeFill = True
        '
        'QuotesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.HPAPrototype.My.Resources.Resources.MicrosoftTeams_image__1_
        Me.ClientSize = New System.Drawing.Size(398, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvCitas)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.lblHeaderTitle)
        Me.Controls.Add(Me.btnSolicitarCita)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QuotesForm"
        Me.Text = "QuotesForm"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_ProyectoFInal2021DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSolicitarCita As Button
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents dgvCitas As DataGridView
    Friend WithEvents tbxClmCodCita As DataGridViewTextBoxColumn
    Friend WithEvents tbxClmFecha As DataGridViewTextBoxColumn
    Friend WithEvents tbxClmNmDoc As DataGridViewTextBoxColumn
    Friend WithEvents tbxColmHora As DataGridViewTextBoxColumn
    Friend WithEvents DB_ProyectoFInal2021DataSet As DB_ProyectoFInal2021DataSet
    Friend WithEvents CitasBindingSource As BindingSource
    Friend WithEvents CitasTableAdapter As DB_ProyectoFInal2021DataSetTableAdapters.CitasTableAdapter
End Class
