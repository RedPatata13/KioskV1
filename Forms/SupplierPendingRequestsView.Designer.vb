Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SupplierPendingRequestsView
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
            Me.PendingRequestLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Guna2Panel5.SuspendLayout()
            Me.Guna2Panel1.SuspendLayout()
            Me.Guna2Panel2.SuspendLayout()
            Me.Guna2Panel6.SuspendLayout()
            Me.SuspendLayout()
            '
            'PendingRequestLabel
            '
            Me.PendingRequestLabel.BackColor = System.Drawing.Color.Transparent
            Me.PendingRequestLabel.Font = New System.Drawing.Font("Montserrat", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PendingRequestLabel.Location = New System.Drawing.Point(15, 11)
            Me.PendingRequestLabel.Margin = New System.Windows.Forms.Padding(2)
            Me.PendingRequestLabel.Name = "PendingRequestLabel"
            Me.PendingRequestLabel.Size = New System.Drawing.Size(303, 54)
            Me.PendingRequestLabel.TabIndex = 8
            Me.PendingRequestLabel.Text = "Pending Request"
            '
            'Guna2DataGridView1
            '
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
            Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.Guna2DataGridView1.ColumnHeadersHeight = 40
            Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
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
            Me.Guna2DataGridView1.RowHeadersVisible = False
            Me.Guna2DataGridView1.Size = New System.Drawing.Size(825, 458)
            Me.Guna2DataGridView1.TabIndex = 9
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
            Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40
            Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            '
            'Column1
            '
            Me.Column1.HeaderText = "Request ID"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Column1.Width = 206
            '
            'Column2
            '
            Me.Column2.HeaderText = "Date"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Column2.Width = 207
            '
            'Column3
            '
            Me.Column3.HeaderText = "Product"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 206
            '
            'Column4
            '
            Me.Column4.HeaderText = "Quantity"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 206
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(59, 5)
            Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(87, 30)
            Me.Guna2HtmlLabel2.TabIndex = 11
            Me.Guna2HtmlLabel2.Text = "Request ID"
            '
            'Guna2HtmlLabel3
            '
            Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(78, 5)
            Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
            Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(41, 30)
            Me.Guna2HtmlLabel3.TabIndex = 11
            Me.Guna2HtmlLabel3.Text = "Date"
            '
            'Guna2Panel5
            '
            Me.Guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Guna2Panel5.BorderRadius = 20
            Me.Guna2Panel5.BorderThickness = 1
            Me.Guna2Panel5.Controls.Add(Me.Guna2HtmlLabel2)
            Me.Guna2Panel5.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel5.Location = New System.Drawing.Point(15, 70)
            Me.Guna2Panel5.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2Panel5.Name = "Guna2Panel5"
            Me.Guna2Panel5.Size = New System.Drawing.Size(200, 40)
            Me.Guna2Panel5.TabIndex = 15
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.BorderColor = System.Drawing.Color.Transparent
            Me.Guna2Panel1.BorderRadius = 20
            Me.Guna2Panel1.BorderThickness = 1
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
            Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel1.Location = New System.Drawing.Point(219, 70)
            Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(200, 40)
            Me.Guna2Panel1.TabIndex = 16
            '
            'Guna2Panel2
            '
            Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Guna2Panel2.BorderRadius = 20
            Me.Guna2Panel2.BorderThickness = 1
            Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel6)
            Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel2.Location = New System.Drawing.Point(423, 70)
            Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2Panel2.Name = "Guna2Panel2"
            Me.Guna2Panel2.Size = New System.Drawing.Size(200, 40)
            Me.Guna2Panel2.TabIndex = 16
            '
            'Guna2HtmlLabel6
            '
            Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(67, 5)
            Me.Guna2HtmlLabel6.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
            Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(65, 30)
            Me.Guna2HtmlLabel6.TabIndex = 11
            Me.Guna2HtmlLabel6.Text = "Product"
            '
            'Guna2Panel6
            '
            Me.Guna2Panel6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Guna2Panel6.BorderRadius = 20
            Me.Guna2Panel6.BorderThickness = 1
            Me.Guna2Panel6.Controls.Add(Me.Guna2HtmlLabel7)
            Me.Guna2Panel6.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel6.Location = New System.Drawing.Point(627, 70)
            Me.Guna2Panel6.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2Panel6.Name = "Guna2Panel6"
            Me.Guna2Panel6.Size = New System.Drawing.Size(200, 40)
            Me.Guna2Panel6.TabIndex = 17
            '
            'Guna2HtmlLabel7
            '
            Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(67, 5)
            Me.Guna2HtmlLabel7.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
            Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(72, 30)
            Me.Guna2HtmlLabel7.TabIndex = 11
            Me.Guna2HtmlLabel7.Text = "Quantity"
            '
            'SupplierPendingRequestView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(851, 570)
            Me.Controls.Add(Me.Guna2Panel6)
            Me.Controls.Add(Me.Guna2Panel2)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Controls.Add(Me.Guna2Panel5)
            Me.Controls.Add(Me.Guna2DataGridView1)
            Me.Controls.Add(Me.PendingRequestLabel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "SupplierPendingRequestView"
            Me.Text = "SupplierPendingRequest"
            CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Guna2Panel5.ResumeLayout(False)
            Me.Guna2Panel5.PerformLayout()
            Me.Guna2Panel1.ResumeLayout(False)
            Me.Guna2Panel1.PerformLayout()
            Me.Guna2Panel2.ResumeLayout(False)
            Me.Guna2Panel2.PerformLayout()
            Me.Guna2Panel6.ResumeLayout(False)
            Me.Guna2Panel6.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Public WithEvents PendingRequestLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents Column2 As DataGridViewTextBoxColumn
        Friend WithEvents Column3 As DataGridViewTextBoxColumn
        Friend WithEvents Column4 As DataGridViewTextBoxColumn
        Public WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Public WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
        Public WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
        Public WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace