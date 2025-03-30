Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AdminInventoryView
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
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminInventoryView))
            Me.InventoryDataGrid = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.SupplyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.RequestSupplyButton = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            CType(Me.InventoryDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'InventoryDataGrid
            '
            Me.InventoryDataGrid.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.InventoryDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Poppins SemiBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.InventoryDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.InventoryDataGrid.ColumnHeadersHeight = 4
            Me.InventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.InventoryDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplyID, Me.ProductName})
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.InventoryDataGrid.DefaultCellStyle = DataGridViewCellStyle7
            Me.InventoryDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.InventoryDataGrid.Location = New System.Drawing.Point(25, 142)
            Me.InventoryDataGrid.Name = "InventoryDataGrid"
            Me.InventoryDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.InventoryDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
            Me.InventoryDataGrid.RowHeadersVisible = False
            Me.InventoryDataGrid.RowHeadersWidth = 51
            Me.InventoryDataGrid.RowTemplate.Height = 24
            Me.InventoryDataGrid.Size = New System.Drawing.Size(1100, 564)
            Me.InventoryDataGrid.TabIndex = 4
            Me.InventoryDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.InventoryDataGrid.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.InventoryDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
            Me.InventoryDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.InventoryDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.InventoryDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.InventoryDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.InventoryDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.InventoryDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.InventoryDataGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.InventoryDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.InventoryDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.InventoryDataGrid.ThemeStyle.HeaderStyle.Height = 4
            Me.InventoryDataGrid.ThemeStyle.ReadOnly = False
            Me.InventoryDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.InventoryDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.InventoryDataGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.InventoryDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.InventoryDataGrid.ThemeStyle.RowsStyle.Height = 24
            Me.InventoryDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.InventoryDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
            'RequestSupplyButton
            '
            Me.RequestSupplyButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.RequestSupplyButton.BorderRadius = 15
            Me.RequestSupplyButton.BorderThickness = 1
            Me.RequestSupplyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.RequestSupplyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.RequestSupplyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.RequestSupplyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.RequestSupplyButton.FillColor = System.Drawing.Color.White
            Me.RequestSupplyButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.RequestSupplyButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.RequestSupplyButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.RequestSupplyButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.RequestSupplyButton.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            Me.RequestSupplyButton.Image = CType(resources.GetObject("RequestSupplyButton.Image"), System.Drawing.Image)
            Me.RequestSupplyButton.ImageSize = New System.Drawing.Size(40, 40)
            Me.RequestSupplyButton.Location = New System.Drawing.Point(1061, 63)
            Me.RequestSupplyButton.Name = "RequestSupplyButton"
            Me.RequestSupplyButton.Size = New System.Drawing.Size(55, 55)
            Me.RequestSupplyButton.TabIndex = 3
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(28, 35)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(205, 64)
            Me.Guna2HtmlLabel1.TabIndex = 9
            Me.Guna2HtmlLabel1.Text = "Inventory"
            '
            'AdminInventoryView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1156, 749)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Controls.Add(Me.InventoryDataGrid)
            Me.Controls.Add(Me.RequestSupplyButton)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "AdminInventoryView"
            Me.Text = "AdminInventory"
            CType(Me.InventoryDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents RequestSupplyButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents InventoryDataGrid As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents SupplyID As DataGridViewTextBoxColumn
        Friend WithEvents ProductName As DataGridViewTextBoxColumn
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace