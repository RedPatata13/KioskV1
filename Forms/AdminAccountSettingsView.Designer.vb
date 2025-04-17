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
            Me._editUser = New Guna.UI2.WinForms.Guna2Button()
            Me.AddAccountButton = New Guna.UI2.WinForms.Guna2Button()
            Me.SearchUser = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.AccountsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.AccountsDataGridView.Location = New System.Drawing.Point(24, 176)
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
            Me.AccountsDataGridView.Size = New System.Drawing.Size(1088, 626)
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
            '_editUser
            '
            Me._editUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me._editUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me._editUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me._editUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me._editUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            Me._editUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me._editUser.ForeColor = System.Drawing.Color.White
            Me._editUser.Location = New System.Drawing.Point(1120, 216)
            Me._editUser.Name = "_editUser"
            Me._editUser.Size = New System.Drawing.Size(180, 32)
            Me._editUser.TabIndex = 9
            Me._editUser.Text = "Edit User"
            '
            'AddAccountButton
            '
            Me.AddAccountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.AddAccountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.AddAccountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.AddAccountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.AddAccountButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.AddAccountButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.AddAccountButton.ForeColor = System.Drawing.Color.White
            Me.AddAccountButton.Location = New System.Drawing.Point(1120, 176)
            Me.AddAccountButton.Name = "AddAccountButton"
            Me.AddAccountButton.Size = New System.Drawing.Size(180, 32)
            Me.AddAccountButton.TabIndex = 10
            Me.AddAccountButton.Text = "Add User"
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
            'Column1
            '
            Me.Column1.HeaderText = "Column1"
            Me.Column1.Name = "Column1"
            '
            'AdminAccountSettingsView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1321, 878)
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
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents AccountsDataGridView As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents _editUser As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents AddAccountButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents SearchUser As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
    End Class

End Namespace