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
            Me.PendingRequestLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.TransactionDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            CType(Me.TransactionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Guna2Panel5.SuspendLayout()
            Me.Guna2Panel1.SuspendLayout()
            Me.Guna2Panel2.SuspendLayout()
            Me.Guna2Panel3.SuspendLayout()
            Me.Guna2Panel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'PendingRequestLabel
            '
            Me.PendingRequestLabel.BackColor = System.Drawing.Color.Transparent
            Me.PendingRequestLabel.Font = New System.Drawing.Font("Montserrat", 28.2!, System.Drawing.FontStyle.Bold)
            Me.PendingRequestLabel.Location = New System.Drawing.Point(26, 20)
            Me.PendingRequestLabel.Margin = New System.Windows.Forms.Padding(2)
            Me.PendingRequestLabel.Name = "PendingRequestLabel"
            Me.PendingRequestLabel.Size = New System.Drawing.Size(389, 61)
            Me.PendingRequestLabel.TabIndex = 9
            Me.PendingRequestLabel.Text = "Transaction History"
            '
            'TransactionDataGridView
            '
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
            Me.TransactionDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.TransactionDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.TransactionDataGridView.ColumnHeadersHeight = 40
            Me.TransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.TransactionDataGridView.ColumnHeadersVisible = False
            Me.TransactionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.TransactionDataGridView.DefaultCellStyle = DataGridViewCellStyle3
            Me.TransactionDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TransactionDataGridView.Location = New System.Drawing.Point(82, 164)
            Me.TransactionDataGridView.Name = "TransactionDataGridView"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.TransactionDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.TransactionDataGridView.RowHeadersVisible = False
            Me.TransactionDataGridView.ShowCellToolTips = False
            Me.TransactionDataGridView.Size = New System.Drawing.Size(1159, 665)
            Me.TransactionDataGridView.TabIndex = 10
            Me.TransactionDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.TransactionDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
            Me.TransactionDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
            Me.TransactionDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
            Me.TransactionDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
            Me.TransactionDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.TransactionDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TransactionDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TransactionDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.TransactionDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TransactionDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.TransactionDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.TransactionDataGridView.ThemeStyle.HeaderStyle.Height = 40
            Me.TransactionDataGridView.ThemeStyle.ReadOnly = False
            Me.TransactionDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.TransactionDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.TransactionDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TransactionDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.TransactionDataGridView.ThemeStyle.RowsStyle.Height = 22
            Me.TransactionDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TransactionDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            '
            'Column1
            '
            Me.Column1.HeaderText = "Batch ID"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            '
            'Column2
            '
            Me.Column2.HeaderText = "Order Details"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            '
            'Column3
            '
            Me.Column3.HeaderText = "Cost"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            '
            'Column4
            '
            Me.Column4.HeaderText = "Return"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            '
            'Column5
            '
            Me.Column5.HeaderText = "Date"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            '
            'Guna2Panel5
            '
            Me.Guna2Panel5.BorderColor = System.Drawing.Color.Transparent
            Me.Guna2Panel5.BorderRadius = 20
            Me.Guna2Panel5.BorderThickness = 1
            Me.Guna2Panel5.Controls.Add(Me.Guna2HtmlLabel2)
            Me.Guna2Panel5.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel5.Location = New System.Drawing.Point(82, 119)
            Me.Guna2Panel5.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2Panel5.Name = "Guna2Panel5"
            Me.Guna2Panel5.Size = New System.Drawing.Size(148, 40)
            Me.Guna2Panel5.TabIndex = 16
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(36, 5)
            Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(69, 30)
            Me.Guna2HtmlLabel2.TabIndex = 11
            Me.Guna2HtmlLabel2.Text = "Batch ID"
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.BorderColor = System.Drawing.Color.Transparent
            Me.Guna2Panel1.BorderRadius = 20
            Me.Guna2Panel1.BorderThickness = 1
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel1.Location = New System.Drawing.Point(234, 118)
            Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(505, 40)
            Me.Guna2Panel1.TabIndex = 17
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(202, 5)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(107, 30)
            Me.Guna2HtmlLabel1.TabIndex = 11
            Me.Guna2HtmlLabel1.Text = "Order Details"
            '
            'Guna2Panel2
            '
            Me.Guna2Panel2.BorderColor = System.Drawing.Color.Transparent
            Me.Guna2Panel2.BorderRadius = 20
            Me.Guna2Panel2.BorderThickness = 1
            Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel3)
            Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel2.Location = New System.Drawing.Point(743, 119)
            Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2Panel2.Name = "Guna2Panel2"
            Me.Guna2Panel2.Size = New System.Drawing.Size(148, 40)
            Me.Guna2Panel2.TabIndex = 18
            '
            'Guna2HtmlLabel3
            '
            Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(57, 5)
            Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
            Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(39, 30)
            Me.Guna2HtmlLabel3.TabIndex = 11
            Me.Guna2HtmlLabel3.Text = "Cost"
            '
            'Guna2Panel3
            '
            Me.Guna2Panel3.BorderColor = System.Drawing.Color.Transparent
            Me.Guna2Panel3.BorderRadius = 20
            Me.Guna2Panel3.BorderThickness = 1
            Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel4)
            Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel3.Location = New System.Drawing.Point(895, 118)
            Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2Panel3.Name = "Guna2Panel3"
            Me.Guna2Panel3.Size = New System.Drawing.Size(171, 40)
            Me.Guna2Panel3.TabIndex = 19
            '
            'Guna2HtmlLabel4
            '
            Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(57, 5)
            Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
            Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(55, 30)
            Me.Guna2HtmlLabel4.TabIndex = 11
            Me.Guna2HtmlLabel4.Text = "Return"
            '
            'Guna2Panel4
            '
            Me.Guna2Panel4.BorderColor = System.Drawing.Color.Transparent
            Me.Guna2Panel4.BorderRadius = 20
            Me.Guna2Panel4.BorderThickness = 1
            Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel5)
            Me.Guna2Panel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel4.Location = New System.Drawing.Point(1070, 119)
            Me.Guna2Panel4.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2Panel4.Name = "Guna2Panel4"
            Me.Guna2Panel4.Size = New System.Drawing.Size(171, 40)
            Me.Guna2Panel4.TabIndex = 20
            '
            'Guna2HtmlLabel5
            '
            Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(69, 5)
            Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
            Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(41, 30)
            Me.Guna2HtmlLabel5.TabIndex = 11
            Me.Guna2HtmlLabel5.Text = "Date"
            '
            'SupplierTransactionHistoryView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.ClientSize = New System.Drawing.Size(1321, 788)
            Me.Controls.Add(Me.Guna2Panel4)
            Me.Controls.Add(Me.Guna2Panel3)
            Me.Controls.Add(Me.Guna2Panel2)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Controls.Add(Me.Guna2Panel5)
            Me.Controls.Add(Me.TransactionDataGridView)
            Me.Controls.Add(Me.PendingRequestLabel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "SupplierTransactionHistoryView"
            Me.Text = "SupplierTransactionHistoryView"
            CType(Me.TransactionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Guna2Panel5.ResumeLayout(False)
            Me.Guna2Panel5.PerformLayout()
            Me.Guna2Panel1.ResumeLayout(False)
            Me.Guna2Panel1.PerformLayout()
            Me.Guna2Panel2.ResumeLayout(False)
            Me.Guna2Panel2.PerformLayout()
            Me.Guna2Panel3.ResumeLayout(False)
            Me.Guna2Panel3.PerformLayout()
            Me.Guna2Panel4.ResumeLayout(False)
            Me.Guna2Panel4.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Public WithEvents PendingRequestLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents TransactionDataGridView As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
        Public WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents Column2 As DataGridViewTextBoxColumn
        Friend WithEvents Column3 As DataGridViewTextBoxColumn
        Friend WithEvents Column4 As DataGridViewTextBoxColumn
        Friend WithEvents Column5 As DataGridViewTextBoxColumn
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Public WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
        Public WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
        Public WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
        Public WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace