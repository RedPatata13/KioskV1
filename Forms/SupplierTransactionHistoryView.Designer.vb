Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SupplierTransactionHistoryView
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
            Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.BatchId = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.OrderDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Returnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Dates = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Guna2DataGridView1
            '
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.Guna2DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Guna2DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FloralWhite
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.Guna2DataGridView1.ColumnHeadersHeight = 30
            Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BatchId, Me.OrderDetails, Me.Cost, Me.Returnd, Me.Dates})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
            Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Guna2DataGridView1.Location = New System.Drawing.Point(15, 70)
            Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
            Me.Guna2DataGridView1.ReadOnly = True
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Guna2DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.Guna2DataGridView1.RowHeadersVisible = False
            Me.Guna2DataGridView1.Size = New System.Drawing.Size(825, 458)
            Me.Guna2DataGridView1.TabIndex = 8
            Me.Guna2DataGridView1.TabStop = False
            Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
            Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
            Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
            Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
            Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30
            Me.Guna2DataGridView1.ThemeStyle.ReadOnly = True
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            '
            'BatchId
            '
            Me.BatchId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.BatchId.Frozen = True
            Me.BatchId.HeaderText = "Batch ID"
            Me.BatchId.Name = "BatchId"
            Me.BatchId.ReadOnly = True
            Me.BatchId.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.BatchId.Width = 165
            '
            'OrderDetails
            '
            Me.OrderDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.OrderDetails.Frozen = True
            Me.OrderDetails.HeaderText = "Order Details"
            Me.OrderDetails.Name = "OrderDetails"
            Me.OrderDetails.ReadOnly = True
            Me.OrderDetails.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.OrderDetails.Width = 165
            '
            'Cost
            '
            Me.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.Cost.Frozen = True
            Me.Cost.HeaderText = "Cost"
            Me.Cost.Name = "Cost"
            Me.Cost.ReadOnly = True
            Me.Cost.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Cost.Width = 165
            '
            'Returnd
            '
            Me.Returnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.Returnd.Frozen = True
            Me.Returnd.HeaderText = "Return"
            Me.Returnd.Name = "Returnd"
            Me.Returnd.ReadOnly = True
            Me.Returnd.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Returnd.Width = 165
            '
            'Dates
            '
            Me.Dates.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.Dates.Frozen = True
            Me.Dates.HeaderText = "Date"
            Me.Dates.Name = "Dates"
            Me.Dates.ReadOnly = True
            Me.Dates.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Dates.Width = 165
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(14, 11)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(341, 54)
            Me.Guna2HtmlLabel1.TabIndex = 7
            Me.Guna2HtmlLabel1.Text = "Transaction History"
            '
            'SupplierTransactionHistoryView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(851, 570)
            Me.Controls.Add(Me.Guna2DataGridView1)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "SupplierTransactionHistoryView"
            Me.Text = "Form1"
            CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents BatchId As DataGridViewTextBoxColumn
        Friend WithEvents OrderDetails As DataGridViewTextBoxColumn
        Friend WithEvents Cost As DataGridViewTextBoxColumn
        Friend WithEvents Returnd As DataGridViewTextBoxColumn
        Friend WithEvents Dates As DataGridViewTextBoxColumn
        Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    End Class

End Namespace