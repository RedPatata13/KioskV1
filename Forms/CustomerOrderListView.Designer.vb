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
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.OrdersPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.Buttons = New Guna.UI2.WinForms.Guna2Panel()
            Me.SelectImageButton = New Guna.UI2.WinForms.Guna2Button()
            Me.SaveButton = New Guna.UI2.WinForms.Guna2Button()
            Me.OrderListFlowLayout = New System.Windows.Forms.FlowLayoutPanel()
            Me.OrderListPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ProductQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ProductPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.ViewOrderButton = New Guna.UI2.WinForms.Guna2Button()
            Me.OrderListLogo = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.Guna2Panel1.SuspendLayout()
            Me.OrdersPanel.SuspendLayout()
            Me.Buttons.SuspendLayout()
            Me.OrderListPanel.SuspendLayout()
            CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Guna2Panel3.SuspendLayout()
            Me.Guna2Panel2.SuspendLayout()
            CType(Me.OrderListLogo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'YourOrderListLbl
            '
            Me.YourOrderListLbl.AutoSize = False
            Me.YourOrderListLbl.BackColor = System.Drawing.Color.Transparent
            Me.YourOrderListLbl.Font = New System.Drawing.Font("Montserrat", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.YourOrderListLbl.Location = New System.Drawing.Point(115, 26)
            Me.YourOrderListLbl.Name = "YourOrderListLbl"
            Me.YourOrderListLbl.Size = New System.Drawing.Size(478, 51)
            Me.YourOrderListLbl.TabIndex = 39
            Me.YourOrderListLbl.Text = "Your Order"
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me.OrderListLogo)
            Me.Guna2Panel1.Controls.Add(Me.YourOrderListLbl)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(1370, 97)
            Me.Guna2Panel1.TabIndex = 41
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
            Me.Buttons.Controls.Add(Me.SelectImageButton)
            Me.Buttons.Controls.Add(Me.SaveButton)
            Me.Buttons.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Buttons.Location = New System.Drawing.Point(0, 557)
            Me.Buttons.Name = "Buttons"
            Me.Buttons.Size = New System.Drawing.Size(1007, 95)
            Me.Buttons.TabIndex = 2
            '
            'SelectImageButton
            '
            Me.SelectImageButton.BackColor = System.Drawing.Color.Transparent
            Me.SelectImageButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SelectImageButton.BorderRadius = 15
            Me.SelectImageButton.BorderThickness = 1
            Me.SelectImageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.SelectImageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.SelectImageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.SelectImageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.SelectImageButton.FillColor = System.Drawing.Color.White
            Me.SelectImageButton.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SelectImageButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SelectImageButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SelectImageButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SelectImageButton.HoverState.ForeColor = System.Drawing.Color.White
            Me.SelectImageButton.Location = New System.Drawing.Point(23, 24)
            Me.SelectImageButton.Margin = New System.Windows.Forms.Padding(2)
            Me.SelectImageButton.Name = "SelectImageButton"
            Me.SelectImageButton.Size = New System.Drawing.Size(318, 50)
            Me.SelectImageButton.TabIndex = 22
            Me.SelectImageButton.Text = "Start Over"
            '
            'SaveButton
            '
            Me.SaveButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SaveButton.BorderRadius = 15
            Me.SaveButton.BorderThickness = 1
            Me.SaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.SaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.SaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.SaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.SaveButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SaveButton.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SaveButton.ForeColor = System.Drawing.Color.White
            Me.SaveButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SaveButton.HoverState.FillColor = System.Drawing.Color.White
            Me.SaveButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SaveButton.Location = New System.Drawing.Point(357, 24)
            Me.SaveButton.Margin = New System.Windows.Forms.Padding(2)
            Me.SaveButton.Name = "SaveButton"
            Me.SaveButton.Size = New System.Drawing.Size(318, 50)
            Me.SaveButton.TabIndex = 21
            Me.SaveButton.Text = "Order more"
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
            Me.OrderListPanel.Controls.Add(Me.Guna2DataGridView1)
            Me.OrderListPanel.Controls.Add(Me.Guna2Panel3)
            Me.OrderListPanel.Controls.Add(Me.Guna2Panel2)
            Me.OrderListPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.OrderListPanel.FillColor = System.Drawing.Color.Transparent
            Me.OrderListPanel.Location = New System.Drawing.Point(1007, 0)
            Me.OrderListPanel.Name = "OrderListPanel"
            Me.OrderListPanel.Size = New System.Drawing.Size(363, 652)
            Me.OrderListPanel.TabIndex = 0
            '
            'Guna2DataGridView1
            '
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
            Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.Guna2DataGridView1.ColumnHeadersHeight = 4
            Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.Guna2DataGridView1.ColumnHeadersVisible = False
            Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductName, Me.ProductQuantity, Me.ProductPrice})
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
            Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Guna2DataGridView1.Location = New System.Drawing.Point(3, 88)
            Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Guna2DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.Guna2DataGridView1.RowHeadersVisible = False
            Me.Guna2DataGridView1.RowHeadersWidth = 45
            Me.Guna2DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle10
            Me.Guna2DataGridView1.Size = New System.Drawing.Size(357, 413)
            Me.Guna2DataGridView1.TabIndex = 23
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
            Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
            Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
            Me.Guna2Panel3.TabIndex = 1
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
            Me.Guna2Panel2.Controls.Add(Me.Label7)
            Me.Guna2Panel2.Controls.Add(Me.Label6)
            Me.Guna2Panel2.Controls.Add(Me.Label5)
            Me.Guna2Panel2.Controls.Add(Me.Label4)
            Me.Guna2Panel2.Controls.Add(Me.ViewOrderButton)
            Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Guna2Panel2.Location = New System.Drawing.Point(0, 506)
            Me.Guna2Panel2.Name = "Guna2Panel2"
            Me.Guna2Panel2.Size = New System.Drawing.Size(363, 146)
            Me.Guna2Panel2.TabIndex = 0
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
            'ViewOrderButton
            '
            Me.ViewOrderButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.ViewOrderButton.BorderRadius = 15
            Me.ViewOrderButton.BorderThickness = 1
            Me.ViewOrderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.ViewOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.ViewOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.ViewOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.ViewOrderButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.ViewOrderButton.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ViewOrderButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.ViewOrderButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.ViewOrderButton.HoverState.FillColor = System.Drawing.Color.White
            Me.ViewOrderButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.ViewOrderButton.Location = New System.Drawing.Point(23, 75)
            Me.ViewOrderButton.Margin = New System.Windows.Forms.Padding(2)
            Me.ViewOrderButton.Name = "ViewOrderButton"
            Me.ViewOrderButton.Size = New System.Drawing.Size(318, 50)
            Me.ViewOrderButton.TabIndex = 22
            Me.ViewOrderButton.Text = "Complete Order"
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
            'CustomerOrderListView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1370, 749)
            Me.Controls.Add(Me.OrdersPanel)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "CustomerOrderListView"
            Me.Text = "CustomerOrderListPage"
            Me.Guna2Panel1.ResumeLayout(False)
            Me.OrdersPanel.ResumeLayout(False)
            Me.Buttons.ResumeLayout(False)
            Me.OrderListPanel.ResumeLayout(False)
            CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Guna2Panel3.ResumeLayout(False)
            Me.Guna2Panel3.PerformLayout()
            Me.Guna2Panel2.ResumeLayout(False)
            Me.Guna2Panel2.PerformLayout()
            CType(Me.OrderListLogo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents YourOrderListLbl As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents OrderListLogo As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents OrdersPanel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Buttons As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents OrderListFlowLayout As FlowLayoutPanel
        Friend WithEvents OrderListPanel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents SaveButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents SelectImageButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents ViewOrderButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Label3 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents ProductName As DataGridViewTextBoxColumn
        Friend WithEvents ProductQuantity As DataGridViewTextBoxColumn
        Friend WithEvents ProductPrice As DataGridViewTextBoxColumn
        Friend WithEvents Label4 As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents Label5 As Label
    End Class


End Namespace