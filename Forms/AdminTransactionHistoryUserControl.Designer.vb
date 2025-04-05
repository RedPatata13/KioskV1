<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminTransactionHistoryUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CashierID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TransactionHistoryDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.OrderID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ItemTransactionDataGrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.SupplyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ItemTransactionDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(48, 40)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(127, 48)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Cashier : "
        '
        'CashierID
        '
        Me.CashierID.BackColor = System.Drawing.Color.Transparent
        Me.CashierID.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
        Me.CashierID.Location = New System.Drawing.Point(234, 40)
        Me.CashierID.Name = "CashierID"
        Me.CashierID.Size = New System.Drawing.Size(203, 48)
        Me.CashierID.TabIndex = 1
        Me.CashierID.Text = "Sample Name"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(48, 121)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(84, 48)
        Me.Guna2HtmlLabel3.TabIndex = 2
        Me.Guna2HtmlLabel3.Text = "Date : "
        '
        'TransactionHistoryDate
        '
        Me.TransactionHistoryDate.BorderRadius = 10
        Me.TransactionHistoryDate.Checked = True
        Me.TransactionHistoryDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.TransactionHistoryDate.FillColor = System.Drawing.Color.White
        Me.TransactionHistoryDate.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.TransactionHistoryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.TransactionHistoryDate.Location = New System.Drawing.Point(234, 120)
        Me.TransactionHistoryDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TransactionHistoryDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.TransactionHistoryDate.Name = "TransactionHistoryDate"
        Me.TransactionHistoryDate.Size = New System.Drawing.Size(267, 49)
        Me.TransactionHistoryDate.TabIndex = 3
        Me.TransactionHistoryDate.Value = New Date(2025, 4, 5, 23, 15, 48, 407)
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(48, 214)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(132, 48)
        Me.Guna2HtmlLabel4.TabIndex = 4
        Me.Guna2HtmlLabel4.Text = "Order ID : "
        '
        'OrderID
        '
        Me.OrderID.BackColor = System.Drawing.Color.Transparent
        Me.OrderID.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
        Me.OrderID.Location = New System.Drawing.Point(234, 214)
        Me.OrderID.Name = "OrderID"
        Me.OrderID.Size = New System.Drawing.Size(233, 48)
        Me.OrderID.TabIndex = 5
        Me.OrderID.Text = "Sample Order ID "
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(48, 308)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(82, 48)
        Me.Guna2HtmlLabel6.TabIndex = 6
        Me.Guna2HtmlLabel6.Text = "Items"
        '
        'ItemTransactionDataGrid
        '
        Me.ItemTransactionDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ItemTransactionDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins SemiBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemTransactionDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ItemTransactionDataGrid.ColumnHeadersHeight = 20
        Me.ItemTransactionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ItemTransactionDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplyID, Me.ProductName})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemTransactionDataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.ItemTransactionDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemTransactionDataGrid.Location = New System.Drawing.Point(48, 371)
        Me.ItemTransactionDataGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.ItemTransactionDataGrid.Name = "ItemTransactionDataGrid"
        Me.ItemTransactionDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemTransactionDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ItemTransactionDataGrid.RowHeadersVisible = False
        Me.ItemTransactionDataGrid.RowHeadersWidth = 51
        Me.ItemTransactionDataGrid.RowTemplate.Height = 24
        Me.ItemTransactionDataGrid.Size = New System.Drawing.Size(570, 467)
        Me.ItemTransactionDataGrid.TabIndex = 7
        Me.ItemTransactionDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.ItemTransactionDataGrid.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemTransactionDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ItemTransactionDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemTransactionDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ItemTransactionDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ItemTransactionDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemTransactionDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemTransactionDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ItemTransactionDataGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemTransactionDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ItemTransactionDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ItemTransactionDataGrid.ThemeStyle.HeaderStyle.Height = 20
        Me.ItemTransactionDataGrid.ThemeStyle.ReadOnly = False
        Me.ItemTransactionDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.ItemTransactionDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ItemTransactionDataGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemTransactionDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ItemTransactionDataGrid.ThemeStyle.RowsStyle.Height = 24
        Me.ItemTransactionDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemTransactionDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        'AdminTransactionHistoryUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ItemTransactionDataGrid)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.OrderID)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.TransactionHistoryDate)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.CashierID)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Name = "AdminTransactionHistoryUserControl"
        Me.Size = New System.Drawing.Size(676, 878)
        CType(Me.ItemTransactionDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CashierID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TransactionHistoryDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents OrderID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ItemTransactionDataGrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents SupplyID As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
End Class
