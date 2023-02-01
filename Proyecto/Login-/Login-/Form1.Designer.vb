<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtcontraseña = New Guna.UI.WinForms.GunaTextBox()
        Me.txtusuario = New Guna.UI.WinForms.GunaTextBox()
        Me.btnacceder = New Guna.UI.WinForms.GunaButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(40, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtcontraseña
        '
        Me.txtcontraseña.BaseColor = System.Drawing.Color.White
        Me.txtcontraseña.BorderColor = System.Drawing.Color.Silver
        Me.txtcontraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcontraseña.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcontraseña.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcontraseña.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcontraseña.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcontraseña.Location = New System.Drawing.Point(25, 287)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(160, 30)
        Me.txtcontraseña.TabIndex = 2
        '
        'txtusuario
        '
        Me.txtusuario.BaseColor = System.Drawing.Color.White
        Me.txtusuario.BorderColor = System.Drawing.Color.Silver
        Me.txtusuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusuario.FocusedBaseColor = System.Drawing.Color.White
        Me.txtusuario.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusuario.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtusuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtusuario.Location = New System.Drawing.Point(25, 206)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusuario.Size = New System.Drawing.Size(160, 30)
        Me.txtusuario.TabIndex = 1
        '
        'btnacceder
        '
        Me.btnacceder.AnimationHoverSpeed = 0.07!
        Me.btnacceder.AnimationSpeed = 0.03!
        Me.btnacceder.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnacceder.BorderColor = System.Drawing.Color.Black
        Me.btnacceder.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnacceder.FocusedColor = System.Drawing.Color.Empty
        Me.btnacceder.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnacceder.ForeColor = System.Drawing.Color.White
        Me.btnacceder.Image = Nothing
        Me.btnacceder.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnacceder.Location = New System.Drawing.Point(248, 161)
        Me.btnacceder.Name = "btnacceder"
        Me.btnacceder.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnacceder.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnacceder.OnHoverForeColor = System.Drawing.Color.White
        Me.btnacceder.OnHoverImage = Nothing
        Me.btnacceder.OnPressedColor = System.Drawing.Color.Black
        Me.btnacceder.Size = New System.Drawing.Size(75, 42)
        Me.btnacceder.TabIndex = 3
        Me.btnacceder.Text = "Login"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 347)
        Me.Controls.Add(Me.btnacceder)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtcontraseña As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtusuario As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnacceder As Guna.UI.WinForms.GunaButton
End Class
