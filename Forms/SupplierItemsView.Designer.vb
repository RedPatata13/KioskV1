Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SupplierItemsView
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupplierItemsView))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.SearchUser = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            Me.SupplierItemsDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
            CType(Me.SupplierItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 28.2!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(28, 11)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(116, 61)
            Me.Guna2HtmlLabel1.TabIndex = 10
            Me.Guna2HtmlLabel1.Text = "Items"
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
            Me.SearchUser.Location = New System.Drawing.Point(992, 22)
            Me.SearchUser.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.SearchUser.Name = "SearchUser"
            Me.SearchUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.SearchUser.PlaceholderText = "Search for Item"
            Me.SearchUser.SelectedText = ""
            Me.SearchUser.Size = New System.Drawing.Size(301, 45)
            Me.SearchUser.TabIndex = 12
            '
            'Guna2Button1
            '
            Me.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2Button1.BorderRadius = 15
            Me.Guna2Button1.BorderThickness = 1
            Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2Button1.Font = New System.Drawing.Font("Poppins", 10.8!)
            Me.Guna2Button1.ForeColor = System.Drawing.Color.White
            Me.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.White
            Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2Button1.Location = New System.Drawing.Point(800, 22)
            Me.Guna2Button1.Name = "Guna2Button1"
            Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
            Me.Guna2Button1.TabIndex = 14
            Me.Guna2Button1.Text = "Show deleted items"
            '
            'SupplierItemsDataGridView
            '
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
            Me.SupplierItemsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.SupplierItemsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.SupplierItemsDataGridView.ColumnHeadersHeight = 4
            Me.SupplierItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.SupplierItemsDataGridView.DefaultCellStyle = DataGridViewCellStyle3
            Me.SupplierItemsDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SupplierItemsDataGridView.Location = New System.Drawing.Point(28, 89)
            Me.SupplierItemsDataGridView.Name = "SupplierItemsDataGridView"
            Me.SupplierItemsDataGridView.RowHeadersVisible = False
            Me.SupplierItemsDataGridView.Size = New System.Drawing.Size(1243, 698)
            Me.SupplierItemsDataGridView.TabIndex = 15
            Me.SupplierItemsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.SupplierItemsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
            Me.SupplierItemsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
            Me.SupplierItemsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
            Me.SupplierItemsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
            Me.SupplierItemsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.SupplierItemsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SupplierItemsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SupplierItemsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.SupplierItemsDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SupplierItemsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.SupplierItemsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.SupplierItemsDataGridView.ThemeStyle.HeaderStyle.Height = 4
            Me.SupplierItemsDataGridView.ThemeStyle.ReadOnly = False
            Me.SupplierItemsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.SupplierItemsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.SupplierItemsDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SupplierItemsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.SupplierItemsDataGridView.ThemeStyle.RowsStyle.Height = 22
            Me.SupplierItemsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SupplierItemsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            '
            'SupplierItemsView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1305, 839)
            Me.Controls.Add(Me.SupplierItemsDataGridView)
            Me.Controls.Add(Me.Guna2Button1)
            Me.Controls.Add(Me.SearchUser)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "SupplierItemsView"
            Me.Text = "SupplierItemsView"
            CType(Me.SupplierItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents SearchUser As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents SupplierItemsDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    End Class

End Namespace