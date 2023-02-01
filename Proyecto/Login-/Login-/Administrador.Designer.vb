<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
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
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.txtid_prov = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txtTelefono_prov = New Guna.UI.WinForms.GunaTextBox()
        Me.txtdireccion_prov = New Guna.UI.WinForms.GunaTextBox()
        Me.txtnombre_prov = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.btnbuscar_Prov = New Guna.UI.WinForms.GunaButton()
        Me.btnbuscar_clie = New Guna.UI.WinForms.GunaButton()
        Me.txtid_cliente = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(627, 22)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(130, 42)
        Me.GunaButton1.TabIndex = 21
        Me.GunaButton1.Text = "Mostrar clientes"
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton3.Location = New System.Drawing.Point(479, 22)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Size = New System.Drawing.Size(130, 42)
        Me.GunaButton3.TabIndex = 22
        Me.GunaButton3.Text = "Mostrar Proveedores"
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
        Me.GunaDataGridView1.Location = New System.Drawing.Point(42, 217)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(706, 122)
        Me.GunaDataGridView1.TabIndex = 23
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
        'txtid_prov
        '
        Me.txtid_prov.BaseColor = System.Drawing.Color.White
        Me.txtid_prov.BorderColor = System.Drawing.Color.Silver
        Me.txtid_prov.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid_prov.FocusedBaseColor = System.Drawing.Color.White
        Me.txtid_prov.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid_prov.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtid_prov.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtid_prov.Location = New System.Drawing.Point(119, 12)
        Me.txtid_prov.Name = "txtid_prov"
        Me.txtid_prov.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid_prov.Size = New System.Drawing.Size(160, 30)
        Me.txtid_prov.TabIndex = 25
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Candara Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(25, 12)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(88, 18)
        Me.GunaLabel5.TabIndex = 33
        Me.GunaLabel5.Text = "Id Proveedor"
        '
        'txtTelefono_prov
        '
        Me.txtTelefono_prov.BaseColor = System.Drawing.Color.White
        Me.txtTelefono_prov.BorderColor = System.Drawing.Color.Silver
        Me.txtTelefono_prov.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefono_prov.FocusedBaseColor = System.Drawing.Color.White
        Me.txtTelefono_prov.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefono_prov.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTelefono_prov.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTelefono_prov.Location = New System.Drawing.Point(119, 165)
        Me.txtTelefono_prov.Name = "txtTelefono_prov"
        Me.txtTelefono_prov.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono_prov.Size = New System.Drawing.Size(160, 30)
        Me.txtTelefono_prov.TabIndex = 32
        '
        'txtdireccion_prov
        '
        Me.txtdireccion_prov.BaseColor = System.Drawing.Color.White
        Me.txtdireccion_prov.BorderColor = System.Drawing.Color.Silver
        Me.txtdireccion_prov.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdireccion_prov.FocusedBaseColor = System.Drawing.Color.White
        Me.txtdireccion_prov.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdireccion_prov.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtdireccion_prov.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdireccion_prov.Location = New System.Drawing.Point(119, 112)
        Me.txtdireccion_prov.Name = "txtdireccion_prov"
        Me.txtdireccion_prov.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdireccion_prov.Size = New System.Drawing.Size(160, 30)
        Me.txtdireccion_prov.TabIndex = 31
        '
        'txtnombre_prov
        '
        Me.txtnombre_prov.BaseColor = System.Drawing.Color.White
        Me.txtnombre_prov.BorderColor = System.Drawing.Color.Silver
        Me.txtnombre_prov.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnombre_prov.FocusedBaseColor = System.Drawing.Color.White
        Me.txtnombre_prov.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnombre_prov.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtnombre_prov.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtnombre_prov.Location = New System.Drawing.Point(119, 63)
        Me.txtnombre_prov.Name = "txtnombre_prov"
        Me.txtnombre_prov.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnombre_prov.Size = New System.Drawing.Size(160, 30)
        Me.txtnombre_prov.TabIndex = 27
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Candara Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(25, 177)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(62, 18)
        Me.GunaLabel4.TabIndex = 30
        Me.GunaLabel4.Text = "Telefono"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Candara Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(25, 124)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(67, 18)
        Me.GunaLabel3.TabIndex = 28
        Me.GunaLabel3.Text = "Direccion"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Candara Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(25, 67)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(34, 18)
        Me.GunaLabel1.TabIndex = 24
        Me.GunaLabel1.Text = "Tipo"
        '
        'GunaButton4
        '
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton4.ForeColor = System.Drawing.Color.White
        Me.GunaButton4.Image = Nothing
        Me.GunaButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton4.Location = New System.Drawing.Point(551, 86)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Size = New System.Drawing.Size(130, 42)
        Me.GunaButton4.TabIndex = 34
        Me.GunaButton4.Text = "Agregar"
        '
        'btnbuscar_Prov
        '
        Me.btnbuscar_Prov.AnimationHoverSpeed = 0.07!
        Me.btnbuscar_Prov.AnimationSpeed = 0.03!
        Me.btnbuscar_Prov.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnbuscar_Prov.BorderColor = System.Drawing.Color.Black
        Me.btnbuscar_Prov.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnbuscar_Prov.FocusedColor = System.Drawing.Color.Empty
        Me.btnbuscar_Prov.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnbuscar_Prov.ForeColor = System.Drawing.Color.White
        Me.btnbuscar_Prov.Image = Nothing
        Me.btnbuscar_Prov.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnbuscar_Prov.Location = New System.Drawing.Point(479, 153)
        Me.btnbuscar_Prov.Name = "btnbuscar_Prov"
        Me.btnbuscar_Prov.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnbuscar_Prov.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnbuscar_Prov.OnHoverForeColor = System.Drawing.Color.White
        Me.btnbuscar_Prov.OnHoverImage = Nothing
        Me.btnbuscar_Prov.OnPressedColor = System.Drawing.Color.Black
        Me.btnbuscar_Prov.Size = New System.Drawing.Size(130, 42)
        Me.btnbuscar_Prov.TabIndex = 35
        Me.btnbuscar_Prov.Text = "Buscar Proveedor"
        '
        'btnbuscar_clie
        '
        Me.btnbuscar_clie.AnimationHoverSpeed = 0.07!
        Me.btnbuscar_clie.AnimationSpeed = 0.03!
        Me.btnbuscar_clie.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnbuscar_clie.BorderColor = System.Drawing.Color.Black
        Me.btnbuscar_clie.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnbuscar_clie.FocusedColor = System.Drawing.Color.Empty
        Me.btnbuscar_clie.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnbuscar_clie.ForeColor = System.Drawing.Color.White
        Me.btnbuscar_clie.Image = Nothing
        Me.btnbuscar_clie.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnbuscar_clie.Location = New System.Drawing.Point(627, 153)
        Me.btnbuscar_clie.Name = "btnbuscar_clie"
        Me.btnbuscar_clie.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnbuscar_clie.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnbuscar_clie.OnHoverForeColor = System.Drawing.Color.White
        Me.btnbuscar_clie.OnHoverImage = Nothing
        Me.btnbuscar_clie.OnPressedColor = System.Drawing.Color.Black
        Me.btnbuscar_clie.Size = New System.Drawing.Size(130, 42)
        Me.btnbuscar_clie.TabIndex = 36
        Me.btnbuscar_clie.Text = "Buscar Cliente"
        '
        'txtid_cliente
        '
        Me.txtid_cliente.BaseColor = System.Drawing.Color.White
        Me.txtid_cliente.BorderColor = System.Drawing.Color.Silver
        Me.txtid_cliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid_cliente.FocusedBaseColor = System.Drawing.Color.White
        Me.txtid_cliente.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid_cliente.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtid_cliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtid_cliente.Location = New System.Drawing.Point(290, 55)
        Me.txtid_cliente.Name = "txtid_cliente"
        Me.txtid_cliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid_cliente.Size = New System.Drawing.Size(160, 30)
        Me.txtid_cliente.TabIndex = 37
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Candara Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(287, 22)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(66, 18)
        Me.GunaLabel2.TabIndex = 38
        Me.GunaLabel2.Text = "Id Cliente"
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 361)
        Me.Controls.Add(Me.txtid_cliente)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.btnbuscar_clie)
        Me.Controls.Add(Me.btnbuscar_Prov)
        Me.Controls.Add(Me.GunaButton4)
        Me.Controls.Add(Me.txtid_prov)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.txtTelefono_prov)
        Me.Controls.Add(Me.txtdireccion_prov)
        Me.Controls.Add(Me.txtnombre_prov)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.Controls.Add(Me.GunaButton3)
        Me.Controls.Add(Me.GunaButton1)
        Me.Name = "Administrador"
        Me.Text = "Administrador"
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents txtid_prov As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtTelefono_prov As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtdireccion_prov As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtnombre_prov As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnbuscar_Prov As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnbuscar_clie As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtid_cliente As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
End Class
