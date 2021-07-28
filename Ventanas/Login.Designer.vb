<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogIngresar = New System.Windows.Forms.Button()
        Me.btnLogRegistrarse = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(131, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnLogIngresar
        '
        Me.btnLogIngresar.BackColor = System.Drawing.Color.White
        Me.btnLogIngresar.Location = New System.Drawing.Point(131, 271)
        Me.btnLogIngresar.Name = "btnLogIngresar"
        Me.btnLogIngresar.Size = New System.Drawing.Size(138, 43)
        Me.btnLogIngresar.TabIndex = 1
        Me.btnLogIngresar.Text = "Ingresar"
        Me.btnLogIngresar.UseVisualStyleBackColor = False
        '
        'btnLogRegistrarse
        '
        Me.btnLogRegistrarse.BackColor = System.Drawing.Color.White
        Me.btnLogRegistrarse.Location = New System.Drawing.Point(131, 341)
        Me.btnLogRegistrarse.Name = "btnLogRegistrarse"
        Me.btnLogRegistrarse.Size = New System.Drawing.Size(138, 43)
        Me.btnLogRegistrarse.TabIndex = 2
        Me.btnLogRegistrarse.Text = "Registrarse"
        Me.btnLogRegistrarse.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(398, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLogRegistrarse)
        Me.Controls.Add(Me.btnLogIngresar)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogIngresar As Button
    Friend WithEvents btnLogRegistrarse As Button
End Class
