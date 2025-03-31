﻿Namespace KioskV0.Forms

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
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminAccountSettingsView))
            Me.AccountsDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.SupplyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.AddAccountButton = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.AddItemButton = New System.Windows.Forms.Button()
            Me.AddUser = New System.Windows.Forms.Button()
            Me.EditInventory = New System.Windows.Forms.Button()
            CType(Me.AccountsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'AccountsDataGridView
            '
            Me.AccountsDataGridView.AllowUserToResizeRows = False
            DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.AccountsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Poppins SemiBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.AccountsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
            Me.AccountsDataGridView.ColumnHeadersHeight = 4
            Me.AccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.AccountsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplyID, Me.ProductName})
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.AccountsDataGridView.DefaultCellStyle = DataGridViewCellStyle15
            Me.AccountsDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.AccountsDataGridView.Location = New System.Drawing.Point(16, 96)
            Me.AccountsDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.AccountsDataGridView.Name = "AccountsDataGridView"
            Me.AccountsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.AccountsDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
            Me.AccountsDataGridView.RowHeadersVisible = False
            Me.AccountsDataGridView.RowHeadersWidth = 51
            Me.AccountsDataGridView.RowTemplate.Height = 24
            Me.AccountsDataGridView.Size = New System.Drawing.Size(825, 488)
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
            Me.AccountsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.AccountsDataGridView.ThemeStyle.HeaderStyle.Height = 4
            Me.AccountsDataGridView.ThemeStyle.ReadOnly = False
            Me.AccountsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.AccountsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.AccountsDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AccountsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.AccountsDataGridView.ThemeStyle.RowsStyle.Height = 24
            Me.AccountsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.AccountsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            '
            'SupplyID
            '
            Me.SupplyID.HeaderText = "ID"
            Me.SupplyID.MinimumWidth = 6
            Me.SupplyID.Name = "SupplyID"
            '
            'ProductName
            '
            Me.ProductName.HeaderText = "Product"
            Me.ProductName.MinimumWidth = 6
            Me.ProductName.Name = "ProductName"
            '
            'AddAccountButton
            '
            Me.AddAccountButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddAccountButton.BorderRadius = 15
            Me.AddAccountButton.BorderThickness = 1
            Me.AddAccountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.AddAccountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.AddAccountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.AddAccountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.AddAccountButton.FillColor = System.Drawing.Color.White
            Me.AddAccountButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.AddAccountButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddAccountButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddAccountButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddAccountButton.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            Me.AddAccountButton.Image = CType(resources.GetObject("AddAccountButton.Image"), System.Drawing.Image)
            Me.AddAccountButton.ImageSize = New System.Drawing.Size(40, 40)
            Me.AddAccountButton.Location = New System.Drawing.Point(790, 36)
            Me.AddAccountButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.AddAccountButton.Name = "AddAccountButton"
            Me.AddAccountButton.Size = New System.Drawing.Size(41, 45)
            Me.AddAccountButton.TabIndex = 7
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(21, 28)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(293, 51)
            Me.Guna2HtmlLabel1.TabIndex = 8
            Me.Guna2HtmlLabel1.Text = "Account Settings"
            '
            'AddItemButton
            '
            Me.AddItemButton.Location = New System.Drawing.Point(936, 136)
            Me.AddItemButton.Name = "AddItemButton"
            Me.AddItemButton.Size = New System.Drawing.Size(75, 23)
            Me.AddItemButton.TabIndex = 9
            Me.AddItemButton.Text = "AddItem"
            Me.AddItemButton.UseVisualStyleBackColor = True
            '
            'AddUser
            '
            Me.AddUser.Location = New System.Drawing.Point(936, 160)
            Me.AddUser.Name = "AddUser"
            Me.AddUser.Size = New System.Drawing.Size(75, 23)
            Me.AddUser.TabIndex = 10
            Me.AddUser.Text = "AddUser"
            Me.AddUser.UseVisualStyleBackColor = True
            '
            'EditInventory
            '
            Me.EditInventory.Location = New System.Drawing.Point(936, 184)
            Me.EditInventory.Name = "EditInventory"
            Me.EditInventory.Size = New System.Drawing.Size(75, 23)
            Me.EditInventory.TabIndex = 11
            Me.EditInventory.Text = "EditInventory"
            Me.EditInventory.UseVisualStyleBackColor = True
            '
            'AdminAccountSettingsView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1079, 609)
            Me.Controls.Add(Me.EditInventory)
            Me.Controls.Add(Me.AddUser)
            Me.Controls.Add(Me.AddItemButton)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Controls.Add(Me.AddAccountButton)
            Me.Controls.Add(Me.AccountsDataGridView)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Name = "AdminAccountSettingsView"
            Me.Text = "AdminAccountSettings"
            CType(Me.AccountsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents AccountsDataGridView As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents SupplyID As DataGridViewTextBoxColumn
        Friend WithEvents ProductName As DataGridViewTextBoxColumn
        Friend WithEvents AddAccountButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents AddItemButton As Button
        Friend WithEvents AddUser As Button
        Friend WithEvents EditInventory As Button
    End Class

End Namespace