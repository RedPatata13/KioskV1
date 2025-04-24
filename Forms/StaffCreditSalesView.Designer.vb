Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class StaffCreditSalesView
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
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.TransactionsDataGrid = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.TransactionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.StaffsName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DateAndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Change = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.TransactionsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 28.0!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(64, 30)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(253, 60)
            Me.Guna2HtmlLabel1.TabIndex = 12
            Me.Guna2HtmlLabel1.Text = "Transactions"
            '
            'TransactionsDataGrid
            '
            Me.TransactionsDataGrid.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.TransactionsDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.TransactionsDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.TransactionsDataGrid.ColumnHeadersHeight = 50
            Me.TransactionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.TransactionsDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionID, Me.StaffsName, Me.DateAndTime, Me.Quantity, Me.Amount, Me.Change})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.TransactionsDataGrid.DefaultCellStyle = DataGridViewCellStyle3
            Me.TransactionsDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TransactionsDataGrid.Location = New System.Drawing.Point(64, 128)
            Me.TransactionsDataGrid.Margin = New System.Windows.Forms.Padding(2)
            Me.TransactionsDataGrid.Name = "TransactionsDataGrid"
            Me.TransactionsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.TransactionsDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.TransactionsDataGrid.RowHeadersVisible = False
            Me.TransactionsDataGrid.RowHeadersWidth = 51
            Me.TransactionsDataGrid.RowTemplate.Height = 24
            Me.TransactionsDataGrid.Size = New System.Drawing.Size(1193, 668)
            Me.TransactionsDataGrid.TabIndex = 13
            Me.TransactionsDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.TransactionsDataGrid.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TransactionsDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
            Me.TransactionsDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TransactionsDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.TransactionsDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.TransactionsDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TransactionsDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TransactionsDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.TransactionsDataGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Poppins", 14.0!)
            Me.TransactionsDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
            Me.TransactionsDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.TransactionsDataGrid.ThemeStyle.HeaderStyle.Height = 50
            Me.TransactionsDataGrid.ThemeStyle.ReadOnly = False
            Me.TransactionsDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.TransactionsDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.TransactionsDataGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins", 14.0!)
            Me.TransactionsDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.TransactionsDataGrid.ThemeStyle.RowsStyle.Height = 24
            Me.TransactionsDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TransactionsDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            '
            'TransactionID
            '
            Me.TransactionID.HeaderText = "Transaction ID"
            Me.TransactionID.Name = "TransactionID"
            '
            'StaffsName
            '
            Me.StaffsName.HeaderText = "Staffs Name"
            Me.StaffsName.Name = "StaffsName"
            '
            'DateAndTime
            '
            Me.DateAndTime.HeaderText = "Date & Time"
            Me.DateAndTime.Name = "DateAndTime"
            '
            'Quantity
            '
            Me.Quantity.HeaderText = "Quantity"
            Me.Quantity.Name = "Quantity"
            '
            'Amount
            '
            Me.Amount.HeaderText = "Amount"
            Me.Amount.Name = "Amount"
            '
            'Change
            '
            Me.Change.HeaderText = "Change"
            Me.Change.Name = "Change"
            '
            'StaffCreditSalesView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1305, 788)
            Me.Controls.Add(Me.TransactionsDataGrid)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "StaffCreditSalesView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "StaffCreditSales"
            CType(Me.TransactionsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents TransactionsDataGrid As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents TransactionID As DataGridViewTextBoxColumn
        Friend WithEvents StaffsName As DataGridViewTextBoxColumn
        Friend WithEvents DateAndTime As DataGridViewTextBoxColumn
        Friend WithEvents Quantity As DataGridViewTextBoxColumn
        Friend WithEvents Amount As DataGridViewTextBoxColumn
        Friend WithEvents Change As DataGridViewTextBoxColumn
    End Class

End Namespace