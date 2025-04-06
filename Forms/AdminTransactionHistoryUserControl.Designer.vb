Namespace KioskV0.Forms
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
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.TransactionCashierID = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.TransactionOrderID = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ItemTransactionDataGrid = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.SupplyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.TransactionHistoryDateAndTime = New Guna.UI2.WinForms.Guna2HtmlLabel()
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
            'TransactionCashierID
            '
            Me.TransactionCashierID.BackColor = System.Drawing.Color.Transparent
            Me.TransactionCashierID.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.TransactionCashierID.Location = New System.Drawing.Point(234, 40)
            Me.TransactionCashierID.Name = "TransactionCashierID"
            Me.TransactionCashierID.Size = New System.Drawing.Size(203, 48)
            Me.TransactionCashierID.TabIndex = 1
            Me.TransactionCashierID.Text = "Sample Name"
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
            'TransactionOrderID
            '
            Me.TransactionOrderID.BackColor = System.Drawing.Color.Transparent
            Me.TransactionOrderID.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.TransactionOrderID.Location = New System.Drawing.Point(234, 214)
            Me.TransactionOrderID.Name = "TransactionOrderID"
            Me.TransactionOrderID.Size = New System.Drawing.Size(233, 48)
            Me.TransactionOrderID.TabIndex = 5
            Me.TransactionOrderID.Text = "Sample Order ID "
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
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.ItemTransactionDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Poppins SemiBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.ItemTransactionDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.ItemTransactionDataGrid.ColumnHeadersHeight = 20
            Me.ItemTransactionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.ItemTransactionDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplyID, Me.ProductName})
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.ItemTransactionDataGrid.DefaultCellStyle = DataGridViewCellStyle7
            Me.ItemTransactionDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ItemTransactionDataGrid.Location = New System.Drawing.Point(48, 371)
            Me.ItemTransactionDataGrid.Margin = New System.Windows.Forms.Padding(2)
            Me.ItemTransactionDataGrid.Name = "ItemTransactionDataGrid"
            Me.ItemTransactionDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.ItemTransactionDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
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
            'TransactionHistoryDateAndTime
            '
            Me.TransactionHistoryDateAndTime.BackColor = System.Drawing.Color.Transparent
            Me.TransactionHistoryDateAndTime.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.TransactionHistoryDateAndTime.Location = New System.Drawing.Point(234, 121)
            Me.TransactionHistoryDateAndTime.Name = "TransactionHistoryDateAndTime"
            Me.TransactionHistoryDateAndTime.Size = New System.Drawing.Size(185, 48)
            Me.TransactionHistoryDateAndTime.TabIndex = 8
            Me.TransactionHistoryDateAndTime.Text = "Sample Date"
            '
            'AdminTransactionHistoryUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.Controls.Add(Me.TransactionHistoryDateAndTime)
            Me.Controls.Add(Me.ItemTransactionDataGrid)
            Me.Controls.Add(Me.Guna2HtmlLabel6)
            Me.Controls.Add(Me.TransactionOrderID)
            Me.Controls.Add(Me.Guna2HtmlLabel4)
            Me.Controls.Add(Me.Guna2HtmlLabel3)
            Me.Controls.Add(Me.TransactionCashierID)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Name = "AdminTransactionHistoryUserControl"
            Me.Size = New System.Drawing.Size(676, 878)
            CType(Me.ItemTransactionDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents TransactionCashierID As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents TransactionOrderID As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ItemTransactionDataGrid As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents SupplyID As DataGridViewTextBoxColumn
        Friend WithEvents ProductName As DataGridViewTextBoxColumn
        Friend WithEvents TransactionHistoryDateAndTime As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace