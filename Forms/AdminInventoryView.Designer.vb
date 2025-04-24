Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AdminInventoryView
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminInventoryView))
            Me.InventoryDataGrid = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.SupplyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ViewChangesButton = New Guna.UI2.WinForms.Guna2Button()
            Me.RequestSupplyButton = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            CType(Me.InventoryDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Guna2Panel7.SuspendLayout()
            Me.Guna2Panel6.SuspendLayout()
            Me.Guna2Panel5.SuspendLayout()
            Me.Guna2Panel4.SuspendLayout()
            Me.Guna2Panel3.SuspendLayout()
            Me.Guna2Panel2.SuspendLayout()
            Me.Guna2Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'InventoryDataGrid
            '
            Me.InventoryDataGrid.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.InventoryDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins SemiBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.InventoryDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.InventoryDataGrid.ColumnHeadersHeight = 4
            Me.InventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.InventoryDataGrid.ColumnHeadersVisible = False
            Me.InventoryDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplyID, Me.ProductName})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.InventoryDataGrid.DefaultCellStyle = DataGridViewCellStyle3
            Me.InventoryDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.InventoryDataGrid.Location = New System.Drawing.Point(49, 184)
            Me.InventoryDataGrid.Margin = New System.Windows.Forms.Padding(2)
            Me.InventoryDataGrid.Name = "InventoryDataGrid"
            Me.InventoryDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.InventoryDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.InventoryDataGrid.RowHeadersVisible = False
            Me.InventoryDataGrid.RowHeadersWidth = 51
            Me.InventoryDataGrid.RowTemplate.Height = 24
            Me.InventoryDataGrid.Size = New System.Drawing.Size(1190, 637)
            Me.InventoryDataGrid.TabIndex = 4
            Me.InventoryDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.InventoryDataGrid.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.InventoryDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
            Me.InventoryDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.InventoryDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.InventoryDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.InventoryDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.InventoryDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.InventoryDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.InventoryDataGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.InventoryDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.InventoryDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.InventoryDataGrid.ThemeStyle.HeaderStyle.Height = 4
            Me.InventoryDataGrid.ThemeStyle.ReadOnly = False
            Me.InventoryDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.InventoryDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.InventoryDataGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.InventoryDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.InventoryDataGrid.ThemeStyle.RowsStyle.Height = 24
            Me.InventoryDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.InventoryDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
            Me.Guna2HtmlLabel1.AutoSize = False
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 28.2!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(16, 16)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(466, 52)
            Me.Guna2HtmlLabel1.TabIndex = 9
            Me.Guna2HtmlLabel1.Text = "Inventory Batches"
            '
            'ViewChangesButton
            '
            Me.ViewChangesButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ViewChangesButton.BorderRadius = 15
            Me.ViewChangesButton.BorderThickness = 1
            Me.ViewChangesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.ViewChangesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.ViewChangesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.ViewChangesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.ViewChangesButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ViewChangesButton.Font = New System.Drawing.Font("Poppins", 10.8!)
            Me.ViewChangesButton.ForeColor = System.Drawing.Color.White
            Me.ViewChangesButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ViewChangesButton.HoverState.FillColor = System.Drawing.Color.White
            Me.ViewChangesButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ViewChangesButton.Location = New System.Drawing.Point(971, 73)
            Me.ViewChangesButton.Name = "ViewChangesButton"
            Me.ViewChangesButton.Size = New System.Drawing.Size(189, 51)
            Me.ViewChangesButton.TabIndex = 10
            Me.ViewChangesButton.Text = "View Deductions"
            '
            'RequestSupplyButton
            '
            Me.RequestSupplyButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.RequestSupplyButton.BorderRadius = 15
            Me.RequestSupplyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.RequestSupplyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.RequestSupplyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.RequestSupplyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.RequestSupplyButton.FillColor = System.Drawing.Color.White
            Me.RequestSupplyButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.RequestSupplyButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.RequestSupplyButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.RequestSupplyButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.RequestSupplyButton.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            Me.RequestSupplyButton.Image = CType(resources.GetObject("RequestSupplyButton.Image"), System.Drawing.Image)
            Me.RequestSupplyButton.ImageSize = New System.Drawing.Size(40, 40)
            Me.RequestSupplyButton.Location = New System.Drawing.Point(1180, 73)
            Me.RequestSupplyButton.Margin = New System.Windows.Forms.Padding(2)
            Me.RequestSupplyButton.Name = "RequestSupplyButton"
            Me.RequestSupplyButton.Size = New System.Drawing.Size(41, 45)
            Me.RequestSupplyButton.TabIndex = 3
            '
            'Guna2Panel7
            '
            Me.Guna2Panel7.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel7.BorderRadius = 15
            Me.Guna2Panel7.Controls.Add(Me.Guna2HtmlLabel8)
            Me.Guna2Panel7.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel7.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel7.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel7.Location = New System.Drawing.Point(1045, 139)
            Me.Guna2Panel7.Name = "Guna2Panel7"
            Me.Guna2Panel7.Size = New System.Drawing.Size(185, 40)
            Me.Guna2Panel7.TabIndex = 20
            '
            'Guna2HtmlLabel8
            '
            Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(50, 7)
            Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
            Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(91, 30)
            Me.Guna2HtmlLabel8.TabIndex = 13
            Me.Guna2HtmlLabel8.Text = "Expiry Date"
            '
            'Guna2Panel6
            '
            Me.Guna2Panel6.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel6.BorderRadius = 15
            Me.Guna2Panel6.Controls.Add(Me.Guna2HtmlLabel7)
            Me.Guna2Panel6.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel6.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel6.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel6.Location = New System.Drawing.Point(874, 139)
            Me.Guna2Panel6.Name = "Guna2Panel6"
            Me.Guna2Panel6.Size = New System.Drawing.Size(165, 40)
            Me.Guna2Panel6.TabIndex = 21
            '
            'Guna2HtmlLabel7
            '
            Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(29, 7)
            Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
            Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(119, 30)
            Me.Guna2HtmlLabel7.TabIndex = 13
            Me.Guna2HtmlLabel7.Text = "Received Date"
            '
            'Guna2Panel5
            '
            Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel5.BorderRadius = 15
            Me.Guna2Panel5.Controls.Add(Me.Guna2HtmlLabel6)
            Me.Guna2Panel5.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel5.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel5.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel5.Location = New System.Drawing.Point(712, 139)
            Me.Guna2Panel5.Name = "Guna2Panel5"
            Me.Guna2Panel5.Size = New System.Drawing.Size(156, 40)
            Me.Guna2Panel5.TabIndex = 22
            '
            'Guna2HtmlLabel6
            '
            Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(45, 5)
            Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
            Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(72, 30)
            Me.Guna2HtmlLabel6.TabIndex = 13
            Me.Guna2HtmlLabel6.Text = "Unit cost"
            '
            'Guna2Panel4
            '
            Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel4.BorderRadius = 15
            Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel5)
            Me.Guna2Panel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel4.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel4.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel4.Location = New System.Drawing.Point(557, 139)
            Me.Guna2Panel4.Name = "Guna2Panel4"
            Me.Guna2Panel4.Size = New System.Drawing.Size(149, 40)
            Me.Guna2Panel4.TabIndex = 23
            '
            'Guna2HtmlLabel5
            '
            Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(37, 5)
            Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
            Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(89, 30)
            Me.Guna2HtmlLabel5.TabIndex = 13
            Me.Guna2HtmlLabel5.Text = "Remaining"
            '
            'Guna2Panel3
            '
            Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel3.BorderRadius = 15
            Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel4)
            Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel3.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel3.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel3.Location = New System.Drawing.Point(391, 139)
            Me.Guna2Panel3.Name = "Guna2Panel3"
            Me.Guna2Panel3.Size = New System.Drawing.Size(160, 40)
            Me.Guna2Panel3.TabIndex = 19
            '
            'Guna2HtmlLabel4
            '
            Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(39, 7)
            Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
            Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(77, 30)
            Me.Guna2HtmlLabel4.TabIndex = 13
            Me.Guna2HtmlLabel4.Text = "Received"
            '
            'Guna2Panel2
            '
            Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel2.BorderRadius = 15
            Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel3)
            Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel2.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel2.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel2.Location = New System.Drawing.Point(220, 139)
            Me.Guna2Panel2.Name = "Guna2Panel2"
            Me.Guna2Panel2.Size = New System.Drawing.Size(165, 40)
            Me.Guna2Panel2.TabIndex = 18
            '
            'Guna2HtmlLabel3
            '
            Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(54, 5)
            Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
            Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(58, 30)
            Me.Guna2HtmlLabel3.TabIndex = 13
            Me.Guna2HtmlLabel3.Text = "Item ID"
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel1.BorderRadius = 15
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel9)
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
            Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel1.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel1.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel1.Location = New System.Drawing.Point(49, 139)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(165, 40)
            Me.Guna2Panel1.TabIndex = 17
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(30, 7)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(3, 2)
            Me.Guna2HtmlLabel2.TabIndex = 13
            '
            'Guna2HtmlLabel9
            '
            Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(39, 5)
            Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
            Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(69, 30)
            Me.Guna2HtmlLabel9.TabIndex = 14
            Me.Guna2HtmlLabel9.Text = "Batch ID"
            '
            'AdminInventoryView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1321, 878)
            Me.Controls.Add(Me.Guna2Panel7)
            Me.Controls.Add(Me.Guna2Panel6)
            Me.Controls.Add(Me.Guna2Panel5)
            Me.Controls.Add(Me.Guna2Panel4)
            Me.Controls.Add(Me.Guna2Panel3)
            Me.Controls.Add(Me.Guna2Panel2)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Controls.Add(Me.ViewChangesButton)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Controls.Add(Me.InventoryDataGrid)
            Me.Controls.Add(Me.RequestSupplyButton)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "AdminInventoryView"
            Me.Text = "AdminInventory"
            CType(Me.InventoryDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Guna2Panel7.ResumeLayout(False)
            Me.Guna2Panel7.PerformLayout()
            Me.Guna2Panel6.ResumeLayout(False)
            Me.Guna2Panel6.PerformLayout()
            Me.Guna2Panel5.ResumeLayout(False)
            Me.Guna2Panel5.PerformLayout()
            Me.Guna2Panel4.ResumeLayout(False)
            Me.Guna2Panel4.PerformLayout()
            Me.Guna2Panel3.ResumeLayout(False)
            Me.Guna2Panel3.PerformLayout()
            Me.Guna2Panel2.ResumeLayout(False)
            Me.Guna2Panel2.PerformLayout()
            Me.Guna2Panel1.ResumeLayout(False)
            Me.Guna2Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents RequestSupplyButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents InventoryDataGrid As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents SupplyID As DataGridViewTextBoxColumn
        Friend WithEvents ProductName As DataGridViewTextBoxColumn
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ViewChangesButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace