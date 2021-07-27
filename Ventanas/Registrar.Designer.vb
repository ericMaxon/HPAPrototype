<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxCedula = New System.Windows.Forms.TextBox()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.tbxApellido = New System.Windows.Forms.TextBox()
        Me.tbxTelefono = New System.Windows.Forms.TextBox()
        Me.tbxEdad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRegistrarse = New System.Windows.Forms.Button()
        Me.cmbxGenero = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxAltura = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbxCorreo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(146, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registrar"
        '
        'tbxCedula
        '
        Me.tbxCedula.Location = New System.Drawing.Point(114, 67)
        Me.tbxCedula.Name = "tbxCedula"
        Me.tbxCedula.Size = New System.Drawing.Size(147, 20)
        Me.tbxCedula.TabIndex = 2
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(114, 124)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(147, 20)
        Me.tbxNombre.TabIndex = 3
        '
        'tbxApellido
        '
        Me.tbxApellido.Location = New System.Drawing.Point(114, 184)
        Me.tbxApellido.Name = "tbxApellido"
        Me.tbxApellido.Size = New System.Drawing.Size(147, 20)
        Me.tbxApellido.TabIndex = 4
        '
        'tbxTelefono
        '
        Me.tbxTelefono.Location = New System.Drawing.Point(114, 244)
        Me.tbxTelefono.Name = "tbxTelefono"
        Me.tbxTelefono.Size = New System.Drawing.Size(145, 20)
        Me.tbxTelefono.TabIndex = 5
        '
        'tbxEdad
        '
        Me.tbxEdad.Location = New System.Drawing.Point(25, 306)
        Me.tbxEdad.Name = "tbxEdad"
        Me.tbxEdad.Size = New System.Drawing.Size(145, 20)
        Me.tbxEdad.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cédula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(111, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Teléfono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(113, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Edad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 339)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Género"
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.BackColor = System.Drawing.Color.White
        Me.btnRegistrarse.Location = New System.Drawing.Point(134, 394)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(95, 37)
        Me.btnRegistrarse.TabIndex = 10
        Me.btnRegistrarse.Text = "Registrar"
        Me.btnRegistrarse.UseVisualStyleBackColor = False
        '
        'cmbxGenero
        '
        Me.cmbxGenero.FormattingEnabled = True
        Me.cmbxGenero.Items.AddRange(New Object() {"Masculino", "Femenino", "No me identifico"})
        Me.cmbxGenero.Location = New System.Drawing.Point(27, 359)
        Me.cmbxGenero.Name = "cmbxGenero"
        Me.cmbxGenero.Size = New System.Drawing.Size(145, 21)
        Me.cmbxGenero.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(204, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Altura"
        '
        'tbxAltura
        '
        Me.tbxAltura.Location = New System.Drawing.Point(207, 306)
        Me.tbxAltura.Name = "tbxAltura"
        Me.tbxAltura.Size = New System.Drawing.Size(145, 20)
        Me.tbxAltura.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(204, 339)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Correo"
        '
        'tbxCorreo
        '
        Me.tbxCorreo.Location = New System.Drawing.Point(207, 358)
        Me.tbxCorreo.Name = "tbxCorreo"
        Me.tbxCorreo.Size = New System.Drawing.Size(145, 20)
        Me.tbxCorreo.TabIndex = 9
        '
        'Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(398, 461)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbxCorreo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbxAltura)
        Me.Controls.Add(Me.cmbxGenero)
        Me.Controls.Add(Me.btnRegistrarse)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxEdad)
        Me.Controls.Add(Me.tbxTelefono)
        Me.Controls.Add(Me.tbxApellido)
        Me.Controls.Add(Me.tbxNombre)
        Me.Controls.Add(Me.tbxCedula)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Registrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbxCedula As TextBox
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents tbxApellido As TextBox
    Friend WithEvents tbxTelefono As TextBox
    Friend WithEvents tbxEdad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRegistrarse As Button
    Friend WithEvents cmbxGenero As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxAltura As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbxCorreo As TextBox
End Class
