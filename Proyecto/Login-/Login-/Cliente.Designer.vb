<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txtnombre = New Guna.UI.WinForms.GunaTextBox()
        Me.txtapellido = New Guna.UI.WinForms.GunaTextBox()
        Me.txtdireccion = New Guna.UI.WinForms.GunaTextBox()
        Me.txtTelefono = New Guna.UI.WinForms.GunaTextBox()
        Me.btn_insertar = New Guna.UI.WinForms.GunaButton()
        Me.txtid = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Candara Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(27, 63)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(59, 18)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Nombre"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Candara Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(31, 118)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(58, 18)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Apellido"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Candara Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(27, 182)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(67, 18)
        Me.GunaLabel3.TabIndex = 2
        Me.GunaLabel3.Text = "Direccion"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Candara Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(27, 241)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(62, 18)
        Me.GunaLabel4.TabIndex = 3
        Me.GunaLabel4.Text = "Telefono"
        '
        'txtnombre
        '
        Me.txtnombre.BaseColor = System.Drawing.Color.White
        Me.txtnombre.BorderColor = System.Drawing.Color.Silver
        Me.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnombre.FocusedBaseColor = System.Drawing.Color.White
        Me.txtnombre.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnombre.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtnombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtnombre.Location = New System.Drawing.Point(111, 63)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnombre.Size = New System.Drawing.Size(160, 30)
        Me.txtnombre.TabIndex = 2
        '
        'txtapellido
        '
        Me.txtapellido.BaseColor = System.Drawing.Color.White
        Me.txtapellido.BorderColor = System.Drawing.Color.Silver
        Me.txtapellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtapellido.FocusedBaseColor = System.Drawing.Color.White
        Me.txtapellido.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtapellido.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtapellido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtapellido.Location = New System.Drawing.Point(111, 118)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtapellido.Size = New System.Drawing.Size(160, 30)
        Me.txtapellido.TabIndex = 3
        '
        'txtdireccion
        '
        Me.txtdireccion.BaseColor = System.Drawing.Color.White
        Me.txtdireccion.BorderColor = System.Drawing.Color.Silver
        Me.txtdireccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdireccion.FocusedBaseColor = System.Drawing.Color.White
        Me.txtdireccion.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdireccion.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtdireccion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdireccion.Location = New System.Drawing.Point(111, 170)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdireccion.Size = New System.Drawing.Size(160, 30)
        Me.txtdireccion.TabIndex = 4
        '
        'txtTelefono
        '
        Me.txtTelefono.BaseColor = System.Drawing.Color.White
        Me.txtTelefono.BorderColor = System.Drawing.Color.Silver
        Me.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefono.FocusedBaseColor = System.Drawing.Color.White
        Me.txtTelefono.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefono.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTelefono.Location = New System.Drawing.Point(111, 229)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.Size = New System.Drawing.Size(160, 30)
        Me.txtTelefono.TabIndex = 5
        '
        'btn_insertar
        '
        Me.btn_insertar.AnimationHoverSpeed = 0.07!
        Me.btn_insertar.AnimationSpeed = 0.03!
        Me.btn_insertar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_insertar.BorderColor = System.Drawing.Color.Black
        Me.btn_insertar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_insertar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_insertar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_insertar.ForeColor = System.Drawing.Color.White
        Me.btn_insertar.Image = Nothing
        Me.btn_insertar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_insertar.Location = New System.Drawing.Point(353, 19)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_insertar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_insertar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_insertar.OnHoverImage = Nothing
        Me.btn_insertar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_insertar.Size = New System.Drawing.Size(74, 42)
        Me.btn_insertar.TabIndex = 8
        Me.btn_insertar.Text = "Agregar"
        '
        'txtid
        '
        Me.txtid.BaseColor = System.Drawing.Color.White
        Me.txtid.BorderColor = System.Drawing.Color.Silver
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.FocusedBaseColor = System.Drawing.Color.White
        Me.txtid.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtid.Location = New System.Drawing.Point(111, 12)
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.Size = New System.Drawing.Size(160, 30)
        Me.txtid.TabIndex = 1
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Candara Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(27, 24)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(20, 18)
        Me.GunaLabel5.TabIndex = 11
        Me.GunaLabel5.Text = "Id"
        '
        'GunaDataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GunaDataGridView1.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(303, 161)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(441, 177)
        Me.GunaDataGridView1.TabIndex = 12
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 361)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtnombre As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtapellido As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtdireccion As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtTelefono As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btn_insertar As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
End Class
