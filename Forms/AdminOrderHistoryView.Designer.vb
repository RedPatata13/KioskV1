Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AdminOrderHistoryView
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
            Me.OrderHistoryDataGrid = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.SupplyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            CType(Me.OrderHistoryDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'OrderHistoryDataGrid
            '
            Me.OrderHistoryDataGrid.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.OrderHistoryDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins SemiBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.OrderHistoryDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.OrderHistoryDataGrid.ColumnHeadersHeight = 4
            Me.OrderHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.OrderHistoryDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplyID, Me.ProductName})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.OrderHistoryDataGrid.DefaultCellStyle = DataGridViewCellStyle3
            Me.OrderHistoryDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.OrderHistoryDataGrid.Location = New System.Drawing.Point(109, 147)
            Me.OrderHistoryDataGrid.Name = "OrderHistoryDataGrid"
            Me.OrderHistoryDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.OrderHistoryDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.OrderHistoryDataGrid.RowHeadersVisible = False
            Me.OrderHistoryDataGrid.RowHeadersWidth = 51
            Me.OrderHistoryDataGrid.RowTemplate.Height = 24
            Me.OrderHistoryDataGrid.Size = New System.Drawing.Size(1545, 839)
            Me.OrderHistoryDataGrid.TabIndex = 5
            Me.OrderHistoryDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.OrderHistoryDataGrid.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OrderHistoryDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
            Me.OrderHistoryDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.OrderHistoryDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.OrderHistoryDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.OrderHistoryDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.OrderHistoryDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.OrderHistoryDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.OrderHistoryDataGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OrderHistoryDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.OrderHistoryDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.OrderHistoryDataGrid.ThemeStyle.HeaderStyle.Height = 4
            Me.OrderHistoryDataGrid.ThemeStyle.ReadOnly = False
            Me.OrderHistoryDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.OrderHistoryDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.OrderHistoryDataGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OrderHistoryDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.OrderHistoryDataGrid.ThemeStyle.RowsStyle.Height = 24
            Me.OrderHistoryDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.OrderHistoryDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 28.2!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(40, 44)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(335, 75)
            Me.Guna2HtmlLabel1.TabIndex = 9
            Me.Guna2HtmlLabel1.Text = "Order History"
            '
            'AdminOrderHistoryView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1761, 1080)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Controls.Add(Me.OrderHistoryDataGrid)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "AdminOrderHistoryView"
            Me.Text = "AdminOrderHistory"
            CType(Me.OrderHistoryDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents OrderHistoryDataGrid As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents SupplyID As DataGridViewTextBoxColumn
        Friend WithEvents ProductName As DataGridViewTextBoxColumn
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace