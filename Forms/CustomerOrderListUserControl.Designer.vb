Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CustomerOrderListUserControl
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
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.UCPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.CheckOutButton = New Guna.UI2.WinForms.Guna2Button()
            Me.OrderListDGV = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ProductQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ProductPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.UCPanel.SuspendLayout()
            Me.Guna2Panel2.SuspendLayout()
            CType(Me.OrderListDGV, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Guna2Panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'UCPanel
            '
            Me.UCPanel.BorderRadius = 15
            Me.UCPanel.BorderThickness = 2
            Me.UCPanel.Controls.Add(Me.Guna2Panel2)
            Me.UCPanel.Controls.Add(Me.OrderListDGV)
            Me.UCPanel.Controls.Add(Me.Guna2Panel3)
            Me.UCPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UCPanel.FillColor = System.Drawing.Color.White
            Me.UCPanel.Location = New System.Drawing.Point(0, 0)
            Me.UCPanel.Name = "UCPanel"
            Me.UCPanel.Size = New System.Drawing.Size(363, 652)
            Me.UCPanel.TabIndex = 0
            '
            'Guna2Panel2
            '
            Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel2.Controls.Add(Me.Label7)
            Me.Guna2Panel2.Controls.Add(Me.Label6)
            Me.Guna2Panel2.Controls.Add(Me.Label5)
            Me.Guna2Panel2.Controls.Add(Me.Label4)
            Me.Guna2Panel2.Controls.Add(Me.CheckOutButton)
            Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Guna2Panel2.Location = New System.Drawing.Point(0, 506)
            Me.Guna2Panel2.Name = "Guna2Panel2"
            Me.Guna2Panel2.Size = New System.Drawing.Size(363, 146)
            Me.Guna2Panel2.TabIndex = 25
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(245, 11)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(93, 28)
            Me.Label7.TabIndex = 25
            Me.Label7.Text = "PHP256.00"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(28, 11)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(82, 28)
            Me.Label6.TabIndex = 24
            Me.Label6.Text = "SubTotal"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Poppins Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(215, 39)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(123, 34)
            Me.Label5.TabIndex = 23
            Me.Label5.Text = "PHP256.00"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Poppins Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(27, 39)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(74, 34)
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "Items"
            '
            'CheckOutButton
            '
            Me.CheckOutButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.CheckOutButton.BorderRadius = 15
            Me.CheckOutButton.BorderThickness = 1
            Me.CheckOutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.CheckOutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.CheckOutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.CheckOutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.CheckOutButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.CheckOutButton.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckOutButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.CheckOutButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.CheckOutButton.HoverState.FillColor = System.Drawing.Color.White
            Me.CheckOutButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.CheckOutButton.Location = New System.Drawing.Point(0, 76)
            Me.CheckOutButton.Margin = New System.Windows.Forms.Padding(2)
            Me.CheckOutButton.Name = "CheckOutButton"
            Me.CheckOutButton.Size = New System.Drawing.Size(363, 69)
            Me.CheckOutButton.TabIndex = 22
            Me.CheckOutButton.Text = "Complete Order"
            Me.CheckOutButton.TextOffset = New System.Drawing.Point(0, 2)
            '
            'OrderListDGV
            '
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
            Me.OrderListDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.OrderListDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.OrderListDGV.ColumnHeadersHeight = 4
            Me.OrderListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.OrderListDGV.ColumnHeadersVisible = False
            Me.OrderListDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductName, Me.ProductQuantity, Me.ProductPrice})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.OrderListDGV.DefaultCellStyle = DataGridViewCellStyle3
            Me.OrderListDGV.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OrderListDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.OrderListDGV.Location = New System.Drawing.Point(0, 82)
            Me.OrderListDGV.Name = "OrderListDGV"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.OrderListDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.OrderListDGV.RowHeadersVisible = False
            Me.OrderListDGV.RowHeadersWidth = 45
            Me.OrderListDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
            Me.OrderListDGV.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.OrderListDGV.Size = New System.Drawing.Size(363, 570)
            Me.OrderListDGV.TabIndex = 24
            Me.OrderListDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.OrderListDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
            Me.OrderListDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
            Me.OrderListDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
            Me.OrderListDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
            Me.OrderListDGV.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.OrderListDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.OrderListDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.OrderListDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.OrderListDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OrderListDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.OrderListDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.OrderListDGV.ThemeStyle.HeaderStyle.Height = 4
            Me.OrderListDGV.ThemeStyle.ReadOnly = False
            Me.OrderListDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.OrderListDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.OrderListDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OrderListDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.OrderListDGV.ThemeStyle.RowsStyle.Height = 22
            Me.OrderListDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.OrderListDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            '
            'ProductName
            '
            Me.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.ProductName.FillWeight = 108.3917!
            Me.ProductName.HeaderText = ""
            Me.ProductName.Name = "ProductName"
            Me.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.ProductName.Width = 71
            '
            'ProductQuantity
            '
            Me.ProductQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.ProductQuantity.FillWeight = 69.78087!
            Me.ProductQuantity.HeaderText = ""
            Me.ProductQuantity.Name = "ProductQuantity"
            Me.ProductQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.ProductQuantity.Width = 46
            '
            'ProductPrice
            '
            Me.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.ProductPrice.FillWeight = 121.8274!
            Me.ProductPrice.HeaderText = ""
            Me.ProductPrice.Name = "ProductPrice"
            Me.ProductPrice.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.ProductPrice.Width = 80
            '
            'Guna2Panel3
            '
            Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel3.Controls.Add(Me.Label3)
            Me.Guna2Panel3.Controls.Add(Me.Label2)
            Me.Guna2Panel3.Controls.Add(Me.Label1)
            Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel3.Name = "Guna2Panel3"
            Me.Guna2Panel3.Size = New System.Drawing.Size(363, 82)
            Me.Guna2Panel3.TabIndex = 2
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(245, 47)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(43, 28)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Qty"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(294, 47)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(57, 28)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Price"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(143, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(72, 34)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Items"
            '
            'CustomerOrderListUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.UCPanel)
            Me.Name = "CustomerOrderListUserControl"
            Me.Size = New System.Drawing.Size(363, 652)
            Me.UCPanel.ResumeLayout(False)
            Me.Guna2Panel2.ResumeLayout(False)
            Me.Guna2Panel2.PerformLayout()
            CType(Me.OrderListDGV, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Guna2Panel3.ResumeLayout(False)
            Me.Guna2Panel3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents UCPanel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Label3 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents OrderListDGV As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents ProductName As DataGridViewTextBoxColumn
        Friend WithEvents ProductQuantity As DataGridViewTextBoxColumn
        Friend WithEvents ProductPrice As DataGridViewTextBoxColumn
        Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Label7 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents CheckOutButton As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace