Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CustomerOrderListView
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
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.YourOrderListLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.TopBar = New Guna.UI2.WinForms.Guna2Panel()
            Me.OrderListLogo = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.OrdersPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.Buttons = New Guna.UI2.WinForms.Guna2Panel()
            Me.StartOverButton = New Guna.UI2.WinForms.Guna2Button()
            Me.OrderMoreButton = New Guna.UI2.WinForms.Guna2Button()
            Me.OrderListFlowLayout = New System.Windows.Forms.FlowLayoutPanel()
            Me.OrderListPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
            Me.TotalPriceLabel = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.CheckOutButton = New Guna.UI2.WinForms.Guna2Button()
            Me.OrderDetailsDGV = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.TopBar.SuspendLayout()
            CType(Me.OrderListLogo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.OrdersPanel.SuspendLayout()
            Me.Buttons.SuspendLayout()
            Me.OrderListPanel.SuspendLayout()
            Me.Guna2Panel3.SuspendLayout()
            Me.Guna2Panel2.SuspendLayout()
            CType(Me.OrderDetailsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'YourOrderListLbl
            '
            Me.YourOrderListLbl.AutoSize = False
            Me.YourOrderListLbl.BackColor = System.Drawing.Color.Transparent
            Me.YourOrderListLbl.Font = New System.Drawing.Font("Montserrat", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.YourOrderListLbl.Location = New System.Drawing.Point(120, 24)
            Me.YourOrderListLbl.Name = "YourOrderListLbl"
            Me.YourOrderListLbl.Size = New System.Drawing.Size(197, 51)
            Me.YourOrderListLbl.TabIndex = 39
            Me.YourOrderListLbl.Text = "Your Order"
            '
            'TopBar
            '
            Me.TopBar.Controls.Add(Me.OrderListLogo)
            Me.TopBar.Controls.Add(Me.YourOrderListLbl)
            Me.TopBar.Dock = System.Windows.Forms.DockStyle.Top
            Me.TopBar.Location = New System.Drawing.Point(0, 0)
            Me.TopBar.Name = "TopBar"
            Me.TopBar.Size = New System.Drawing.Size(1370, 97)
            Me.TopBar.TabIndex = 41
            '
            'OrderListLogo
            '
            Me.OrderListLogo.BackColor = System.Drawing.Color.Transparent
            Me.OrderListLogo.ImageRotate = 0!
            Me.OrderListLogo.Location = New System.Drawing.Point(3, 3)
            Me.OrderListLogo.Name = "OrderListLogo"
            Me.OrderListLogo.Size = New System.Drawing.Size(106, 93)
            Me.OrderListLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.OrderListLogo.TabIndex = 40
            Me.OrderListLogo.TabStop = False
            Me.OrderListLogo.UseTransparentBackground = True
            '
            'OrdersPanel
            '
            Me.OrdersPanel.Controls.Add(Me.Buttons)
            Me.OrdersPanel.Controls.Add(Me.OrderListFlowLayout)
            Me.OrdersPanel.Controls.Add(Me.OrderListPanel)
            Me.OrdersPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OrdersPanel.Location = New System.Drawing.Point(0, 97)
            Me.OrdersPanel.Name = "OrdersPanel"
            Me.OrdersPanel.Size = New System.Drawing.Size(1370, 652)
            Me.OrdersPanel.TabIndex = 42
            '
            'Buttons
            '
            Me.Buttons.BackColor = System.Drawing.Color.White
            Me.Buttons.Controls.Add(Me.StartOverButton)
            Me.Buttons.Controls.Add(Me.OrderMoreButton)
            Me.Buttons.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Buttons.Location = New System.Drawing.Point(0, 506)
            Me.Buttons.Name = "Buttons"
            Me.Buttons.Size = New System.Drawing.Size(1007, 146)
            Me.Buttons.TabIndex = 2
            '
            'StartOverButton
            '
            Me.StartOverButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.StartOverButton.BorderRadius = 15
            Me.StartOverButton.BorderThickness = 1
            Me.StartOverButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.StartOverButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.StartOverButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.StartOverButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.StartOverButton.FillColor = System.Drawing.Color.White
            Me.StartOverButton.Font = New System.Drawing.Font("Poppins SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.StartOverButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.StartOverButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.StartOverButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.StartOverButton.HoverState.ForeColor = System.Drawing.Color.White
            Me.StartOverButton.Location = New System.Drawing.Point(208, 48)
            Me.StartOverButton.Margin = New System.Windows.Forms.Padding(2)
            Me.StartOverButton.Name = "StartOverButton"
            Me.StartOverButton.Size = New System.Drawing.Size(318, 50)
            Me.StartOverButton.TabIndex = 27
            Me.StartOverButton.Text = "Start over"
            '
            'OrderMoreButton
            '
            Me.OrderMoreButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.OrderMoreButton.BorderRadius = 15
            Me.OrderMoreButton.BorderThickness = 1
            Me.OrderMoreButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.OrderMoreButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.OrderMoreButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.OrderMoreButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.OrderMoreButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.OrderMoreButton.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OrderMoreButton.ForeColor = System.Drawing.Color.White
            Me.OrderMoreButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.OrderMoreButton.HoverState.FillColor = System.Drawing.Color.White
            Me.OrderMoreButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.OrderMoreButton.Location = New System.Drawing.Point(544, 48)
            Me.OrderMoreButton.Margin = New System.Windows.Forms.Padding(2)
            Me.OrderMoreButton.Name = "OrderMoreButton"
            Me.OrderMoreButton.Size = New System.Drawing.Size(318, 50)
            Me.OrderMoreButton.TabIndex = 21
            Me.OrderMoreButton.Text = "Order more"
            '
            'OrderListFlowLayout
            '
            Me.OrderListFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OrderListFlowLayout.Location = New System.Drawing.Point(0, 0)
            Me.OrderListFlowLayout.Name = "OrderListFlowLayout"
            Me.OrderListFlowLayout.Size = New System.Drawing.Size(1007, 652)
            Me.OrderListFlowLayout.TabIndex = 1
            '
            'OrderListPanel
            '
            Me.OrderListPanel.BackColor = System.Drawing.Color.Transparent
            Me.OrderListPanel.BorderColor = System.Drawing.Color.Black
            Me.OrderListPanel.BorderRadius = 15
            Me.OrderListPanel.BorderThickness = 2
            Me.OrderListPanel.Controls.Add(Me.Guna2Panel3)
            Me.OrderListPanel.Controls.Add(Me.Guna2Panel2)
            Me.OrderListPanel.Controls.Add(Me.OrderDetailsDGV)
            Me.OrderListPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.OrderListPanel.FillColor = System.Drawing.Color.Transparent
            Me.OrderListPanel.Location = New System.Drawing.Point(1007, 0)
            Me.OrderListPanel.Name = "OrderListPanel"
            Me.OrderListPanel.Size = New System.Drawing.Size(363, 652)
            Me.OrderListPanel.TabIndex = 0
            '
            'Guna2Panel3
            '
            Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel3.Controls.Add(Me.Label3)
            Me.Guna2Panel3.Controls.Add(Me.Label2)
            Me.Guna2Panel3.Controls.Add(Me.Label1)
            Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel3.Name = "Guna2Panel3"
            Me.Guna2Panel3.Size = New System.Drawing.Size(363, 82)
            Me.Guna2Panel3.TabIndex = 1
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(204, 47)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(43, 28)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Qty"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(276, 47)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(57, 28)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Price"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(143, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(74, 34)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Items"
            '
            'Guna2Panel2
            '
            Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel2.Controls.Add(Me.TotalPriceLabel)
            Me.Guna2Panel2.Controls.Add(Me.Label4)
            Me.Guna2Panel2.Controls.Add(Me.CheckOutButton)
            Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Guna2Panel2.Location = New System.Drawing.Point(0, 509)
            Me.Guna2Panel2.Name = "Guna2Panel2"
            Me.Guna2Panel2.Size = New System.Drawing.Size(363, 143)
            Me.Guna2Panel2.TabIndex = 0
            '
            'TotalPriceLabel
            '
            Me.TotalPriceLabel.AutoSize = True
            Me.TotalPriceLabel.Font = New System.Drawing.Font("Poppins Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TotalPriceLabel.Location = New System.Drawing.Point(228, 9)
            Me.TotalPriceLabel.Name = "TotalPriceLabel"
            Me.TotalPriceLabel.Size = New System.Drawing.Size(123, 34)
            Me.TotalPriceLabel.TabIndex = 23
            Me.TotalPriceLabel.Text = "PHP256.00"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Poppins Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(30, 9)
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
            Me.CheckOutButton.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckOutButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.CheckOutButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.CheckOutButton.HoverState.FillColor = System.Drawing.Color.White
            Me.CheckOutButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.CheckOutButton.Location = New System.Drawing.Point(23, 45)
            Me.CheckOutButton.Margin = New System.Windows.Forms.Padding(2)
            Me.CheckOutButton.Name = "CheckOutButton"
            Me.CheckOutButton.Size = New System.Drawing.Size(318, 50)
            Me.CheckOutButton.TabIndex = 22
            Me.CheckOutButton.Text = "Complete Order"
            '
            'OrderDetailsDGV
            '
            Me.OrderDetailsDGV.AllowUserToAddRows = False
            Me.OrderDetailsDGV.AllowUserToDeleteRows = False
            Me.OrderDetailsDGV.AllowUserToResizeColumns = False
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
            Me.OrderDetailsDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            Me.OrderDetailsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.OrderDetailsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.OrderDetailsDGV.ColumnHeadersHeight = 4
            Me.OrderDetailsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.OrderDetailsDGV.ColumnHeadersVisible = False
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.OrderDetailsDGV.DefaultCellStyle = DataGridViewCellStyle8
            Me.OrderDetailsDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.OrderDetailsDGV.Location = New System.Drawing.Point(3, 88)
            Me.OrderDetailsDGV.Name = "OrderDetailsDGV"
            Me.OrderDetailsDGV.ReadOnly = True
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.OrderDetailsDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.OrderDetailsDGV.RowHeadersVisible = False
            Me.OrderDetailsDGV.RowHeadersWidth = 45
            Me.OrderDetailsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.WhiteSmoke
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText
            Me.OrderDetailsDGV.RowsDefaultCellStyle = DataGridViewCellStyle10
            Me.OrderDetailsDGV.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.OrderDetailsDGV.Size = New System.Drawing.Size(357, 413)
            Me.OrderDetailsDGV.TabIndex = 23
            Me.OrderDetailsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.OrderDetailsDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
            Me.OrderDetailsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
            Me.OrderDetailsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
            Me.OrderDetailsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
            Me.OrderDetailsDGV.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.OrderDetailsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.OrderDetailsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.OrderDetailsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.OrderDetailsDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OrderDetailsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.OrderDetailsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.OrderDetailsDGV.ThemeStyle.HeaderStyle.Height = 4
            Me.OrderDetailsDGV.ThemeStyle.ReadOnly = True
            Me.OrderDetailsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.OrderDetailsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.OrderDetailsDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OrderDetailsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.OrderDetailsDGV.ThemeStyle.RowsStyle.Height = 22
            Me.OrderDetailsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.OrderDetailsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            '
            'CustomerOrderListView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1370, 749)
            Me.Controls.Add(Me.OrdersPanel)
            Me.Controls.Add(Me.TopBar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "CustomerOrderListView"
            Me.Text = "CustomerOrderListPage"
            Me.TopBar.ResumeLayout(False)
            CType(Me.OrderListLogo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.OrdersPanel.ResumeLayout(False)
            Me.Buttons.ResumeLayout(False)
            Me.OrderListPanel.ResumeLayout(False)
            Me.Guna2Panel3.ResumeLayout(False)
            Me.Guna2Panel3.PerformLayout()
            Me.Guna2Panel2.ResumeLayout(False)
            Me.Guna2Panel2.PerformLayout()
            CType(Me.OrderDetailsDGV, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents YourOrderListLbl As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents OrderListLogo As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents TopBar As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents OrdersPanel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Buttons As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents OrderListFlowLayout As FlowLayoutPanel
        Friend WithEvents OrderListPanel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents OrderMoreButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents CheckOutButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents OrderDetailsDGV As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Label3 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents TotalPriceLabel As Label
        Friend WithEvents StartOverButton As Guna.UI2.WinForms.Guna2Button
    End Class


End Namespace