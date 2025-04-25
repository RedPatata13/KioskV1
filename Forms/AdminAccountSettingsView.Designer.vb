Namespace KioskV0.Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AdminAccountSettingsView
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminAccountSettingsView))
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.AccountsDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me._editUser = New Guna.UI2.WinForms.Guna2Button()
            Me.AddAccountButton = New Guna.UI2.WinForms.Guna2Button()
            Me.SearchUser = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            CType(Me.AccountsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Guna2Panel1.SuspendLayout()
            Me.Guna2Panel2.SuspendLayout()
            Me.Guna2Panel3.SuspendLayout()
            Me.Guna2Panel4.SuspendLayout()
            Me.Guna2Panel5.SuspendLayout()
            Me.Guna2Panel6.SuspendLayout()
            Me.Guna2Panel7.SuspendLayout()
            Me.SuspendLayout()
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 28.2!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(16, 16)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(347, 61)
            Me.Guna2HtmlLabel1.TabIndex = 8
            Me.Guna2HtmlLabel1.Text = "Account Settings"
            '
            'AccountsDataGridView
            '
            Me.AccountsDataGridView.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.AccountsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins SemiBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.AccountsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.AccountsDataGridView.ColumnHeadersHeight = 40
            Me.AccountsDataGridView.ColumnHeadersVisible = False
            Me.AccountsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.AccountsDataGridView.DefaultCellStyle = DataGridViewCellStyle3
            Me.AccountsDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.AccountsDataGridView.Location = New System.Drawing.Point(16, 232)
            Me.AccountsDataGridView.Margin = New System.Windows.Forms.Padding(2)
            Me.AccountsDataGridView.Name = "AccountsDataGridView"
            Me.AccountsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.AccountsDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.AccountsDataGridView.RowHeadersVisible = False
            Me.AccountsDataGridView.RowHeadersWidth = 51
            Me.AccountsDataGridView.RowTemplate.Height = 24
            Me.AccountsDataGridView.Size = New System.Drawing.Size(1262, 563)
            Me.AccountsDataGridView.TabIndex = 6
            Me.AccountsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.AccountsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AccountsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
            Me.AccountsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.AccountsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.AccountsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.AccountsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.AccountsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.AccountsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.AccountsDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AccountsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.AccountsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.AccountsDataGridView.ThemeStyle.HeaderStyle.Height = 40
            Me.AccountsDataGridView.ThemeStyle.ReadOnly = False
            Me.AccountsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.AccountsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.AccountsDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AccountsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.AccountsDataGridView.ThemeStyle.RowsStyle.Height = 24
            Me.AccountsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.AccountsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            '
            'Column1
            '
            Me.Column1.HeaderText = "Column1"
            Me.Column1.Name = "Column1"
            '
            '_editUser
            '
            Me._editUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me._editUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me._editUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me._editUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me._editUser.FillColor = System.Drawing.Color.Transparent
            Me._editUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me._editUser.ForeColor = System.Drawing.Color.White
            Me._editUser.Image = CType(resources.GetObject("_editUser.Image"), System.Drawing.Image)
            Me._editUser.ImageSize = New System.Drawing.Size(40, 40)
            Me._editUser.Location = New System.Drawing.Point(1138, 112)
            Me._editUser.Name = "_editUser"
            Me._editUser.Size = New System.Drawing.Size(62, 45)
            Me._editUser.TabIndex = 9
            '
            'AddAccountButton
            '
            Me.AddAccountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.AddAccountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.AddAccountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.AddAccountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.AddAccountButton.FillColor = System.Drawing.Color.Transparent
            Me.AddAccountButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.AddAccountButton.ForeColor = System.Drawing.Color.White
            Me.AddAccountButton.Image = CType(resources.GetObject("AddAccountButton.Image"), System.Drawing.Image)
            Me.AddAccountButton.ImageSize = New System.Drawing.Size(40, 40)
            Me.AddAccountButton.Location = New System.Drawing.Point(1206, 112)
            Me.AddAccountButton.Name = "AddAccountButton"
            Me.AddAccountButton.Size = New System.Drawing.Size(62, 45)
            Me.AddAccountButton.TabIndex = 10
            '
            'SearchUser
            '
            Me.SearchUser.BorderRadius = 15
            Me.SearchUser.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.SearchUser.DefaultText = ""
            Me.SearchUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.SearchUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.SearchUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.SearchUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.SearchUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.SearchUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SearchUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.SearchUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SearchUser.IconLeft = CType(resources.GetObject("SearchUser.IconLeft"), System.Drawing.Image)
            Me.SearchUser.IconLeftOffset = New System.Drawing.Point(10, 0)
            Me.SearchUser.IconLeftSize = New System.Drawing.Size(25, 25)
            Me.SearchUser.Location = New System.Drawing.Point(24, 112)
            Me.SearchUser.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.SearchUser.Name = "SearchUser"
            Me.SearchUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.SearchUser.PlaceholderText = "Search for User"
            Me.SearchUser.SelectedText = ""
            Me.SearchUser.Size = New System.Drawing.Size(301, 45)
            Me.SearchUser.TabIndex = 11
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel1.BorderRadius = 15
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
            Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel1.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel1.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel1.Location = New System.Drawing.Point(27, 176)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(165, 40)
            Me.Guna2Panel1.TabIndex = 12
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(30, 7)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(87, 30)
            Me.Guna2HtmlLabel2.TabIndex = 13
            Me.Guna2HtmlLabel2.Text = "First Name"
            '
            'Guna2HtmlLabel3
            '
            Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(40, 7)
            Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
            Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(87, 30)
            Me.Guna2HtmlLabel3.TabIndex = 13
            Me.Guna2HtmlLabel3.Text = "Last Name"
            '
            'Guna2Panel2
            '
            Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel2.BorderRadius = 15
            Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel3)
            Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel2.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel2.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel2.Location = New System.Drawing.Point(198, 176)
            Me.Guna2Panel2.Name = "Guna2Panel2"
            Me.Guna2Panel2.Size = New System.Drawing.Size(165, 40)
            Me.Guna2Panel2.TabIndex = 14
            '
            'Guna2Panel3
            '
            Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel3.BorderRadius = 15
            Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel4)
            Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel3.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel3.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel3.Location = New System.Drawing.Point(369, 176)
            Me.Guna2Panel3.Name = "Guna2Panel3"
            Me.Guna2Panel3.Size = New System.Drawing.Size(179, 40)
            Me.Guna2Panel3.TabIndex = 15
            '
            'Guna2HtmlLabel4
            '
            Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(45, 7)
            Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
            Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(85, 30)
            Me.Guna2HtmlLabel4.TabIndex = 13
            Me.Guna2HtmlLabel4.Text = "Username"
            '
            'Guna2Panel4
            '
            Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel4.BorderRadius = 15
            Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel5)
            Me.Guna2Panel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel4.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel4.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel4.Location = New System.Drawing.Point(554, 176)
            Me.Guna2Panel4.Name = "Guna2Panel4"
            Me.Guna2Panel4.Size = New System.Drawing.Size(176, 40)
            Me.Guna2Panel4.TabIndex = 16
            '
            'Guna2HtmlLabel5
            '
            Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(46, 7)
            Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
            Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(68, 30)
            Me.Guna2HtmlLabel5.TabIndex = 13
            Me.Guna2HtmlLabel5.Text = "Contact"
            '
            'Guna2Panel5
            '
            Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel5.BorderRadius = 15
            Me.Guna2Panel5.Controls.Add(Me.Guna2HtmlLabel6)
            Me.Guna2Panel5.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel5.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel5.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel5.Location = New System.Drawing.Point(736, 176)
            Me.Guna2Panel5.Name = "Guna2Panel5"
            Me.Guna2Panel5.Size = New System.Drawing.Size(180, 40)
            Me.Guna2Panel5.TabIndex = 16
            '
            'Guna2HtmlLabel6
            '
            Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(59, 7)
            Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
            Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(46, 30)
            Me.Guna2HtmlLabel6.TabIndex = 13
            Me.Guna2HtmlLabel6.Text = "Email"
            '
            'Guna2Panel6
            '
            Me.Guna2Panel6.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel6.BorderRadius = 15
            Me.Guna2Panel6.Controls.Add(Me.Guna2HtmlLabel7)
            Me.Guna2Panel6.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel6.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel6.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel6.Location = New System.Drawing.Point(922, 176)
            Me.Guna2Panel6.Name = "Guna2Panel6"
            Me.Guna2Panel6.Size = New System.Drawing.Size(165, 40)
            Me.Guna2Panel6.TabIndex = 16
            '
            'Guna2HtmlLabel7
            '
            Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(63, 3)
            Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
            Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(37, 30)
            Me.Guna2HtmlLabel7.TabIndex = 13
            Me.Guna2HtmlLabel7.Text = "Role"
            '
            'Guna2Panel7
            '
            Me.Guna2Panel7.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel7.BorderRadius = 15
            Me.Guna2Panel7.Controls.Add(Me.Guna2HtmlLabel8)
            Me.Guna2Panel7.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel7.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel7.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel7.Location = New System.Drawing.Point(1093, 176)
            Me.Guna2Panel7.Name = "Guna2Panel7"
            Me.Guna2Panel7.Size = New System.Drawing.Size(185, 40)
            Me.Guna2Panel7.TabIndex = 16
            '
            'Guna2HtmlLabel8
            '
            Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(56, 7)
            Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
            Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(68, 30)
            Me.Guna2HtmlLabel8.TabIndex = 13
            Me.Guna2HtmlLabel8.Text = "Address"
            '
            'AdminAccountSettingsView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1321, 878)
            Me.Controls.Add(Me.Guna2Panel7)
            Me.Controls.Add(Me.Guna2Panel6)
            Me.Controls.Add(Me.Guna2Panel5)
            Me.Controls.Add(Me.Guna2Panel4)
            Me.Controls.Add(Me.Guna2Panel3)
            Me.Controls.Add(Me.Guna2Panel2)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Controls.Add(Me.SearchUser)
            Me.Controls.Add(Me.AddAccountButton)
            Me.Controls.Add(Me._editUser)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Controls.Add(Me.AccountsDataGridView)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "AdminAccountSettingsView"
            Me.Text = "AdminAccountSettings"
            CType(Me.AccountsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Guna2Panel1.ResumeLayout(False)
            Me.Guna2Panel1.PerformLayout()
            Me.Guna2Panel2.ResumeLayout(False)
            Me.Guna2Panel2.PerformLayout()
            Me.Guna2Panel3.ResumeLayout(False)
            Me.Guna2Panel3.PerformLayout()
            Me.Guna2Panel4.ResumeLayout(False)
            Me.Guna2Panel4.PerformLayout()
            Me.Guna2Panel5.ResumeLayout(False)
            Me.Guna2Panel5.PerformLayout()
            Me.Guna2Panel6.ResumeLayout(False)
            Me.Guna2Panel6.PerformLayout()
            Me.Guna2Panel7.ResumeLayout(False)
            Me.Guna2Panel7.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents AccountsDataGridView As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents _editUser As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents AddAccountButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents SearchUser As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace