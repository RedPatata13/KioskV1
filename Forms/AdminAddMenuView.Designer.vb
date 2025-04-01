Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AdminAddMenuView
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
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ProductNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.CategoryComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
            Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.SupplierComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
            Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ProductDescriptionTextBox = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.CostTextBox = New Guna.UI2.WinForms.Guna2TextBox()
            Me.SellingTextBox = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.SelectImageButton = New Guna.UI2.WinForms.Guna2Button()
            Me.SaveButton = New Guna.UI2.WinForms.Guna2Button()
            Me.CancelButton = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.Guna2Panel1.SuspendLayout()
            CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(21, 19)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(176, 51)
            Me.Guna2HtmlLabel1.TabIndex = 5
            Me.Guna2HtmlLabel1.Text = "Add Menu"
            '
            'ProductNameTextBox
            '
            Me.ProductNameTextBox.BorderRadius = 15
            Me.ProductNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.ProductNameTextBox.DefaultText = ""
            Me.ProductNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.ProductNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ProductNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.ProductNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.ProductNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ProductNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.ProductNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ProductNameTextBox.Location = New System.Drawing.Point(21, 140)
            Me.ProductNameTextBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.ProductNameTextBox.Name = "ProductNameTextBox"
            Me.ProductNameTextBox.PlaceholderText = "Ex.: ""Hamburger"""
            Me.ProductNameTextBox.SelectedText = ""
            Me.ProductNameTextBox.Size = New System.Drawing.Size(366, 39)
            Me.ProductNameTextBox.TabIndex = 6
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins Medium", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(21, 184)
            Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(95, 33)
            Me.Guna2HtmlLabel2.TabIndex = 8
            Me.Guna2HtmlLabel2.Text = "Category"
            '
            'CategoryComboBox
            '
            Me.CategoryComboBox.BackColor = System.Drawing.Color.Transparent
            Me.CategoryComboBox.BorderRadius = 15
            Me.CategoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CategoryComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.CategoryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.CategoryComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.CategoryComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.CategoryComboBox.ItemHeight = 30
            Me.CategoryComboBox.Items.AddRange(New Object() {"Category1", "Category2", "Category3", "Category4"})
            Me.CategoryComboBox.Location = New System.Drawing.Point(21, 223)
            Me.CategoryComboBox.Margin = New System.Windows.Forms.Padding(2)
            Me.CategoryComboBox.Name = "CategoryComboBox"
            Me.CategoryComboBox.Size = New System.Drawing.Size(367, 36)
            Me.CategoryComboBox.TabIndex = 9
            '
            'Guna2HtmlLabel3
            '
            Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins Medium", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(21, 100)
            Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
            Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(146, 33)
            Me.Guna2HtmlLabel3.TabIndex = 10
            Me.Guna2HtmlLabel3.Text = "Product Name"
            '
            'SupplierComboBox
            '
            Me.SupplierComboBox.BackColor = System.Drawing.Color.Transparent
            Me.SupplierComboBox.BorderRadius = 15
            Me.SupplierComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.SupplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.SupplierComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SupplierComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SupplierComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.SupplierComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.SupplierComboBox.ItemHeight = 30
            Me.SupplierComboBox.Items.AddRange(New Object() {"Supplier1", "Supplier2", "Supplier3"})
            Me.SupplierComboBox.Location = New System.Drawing.Point(21, 297)
            Me.SupplierComboBox.Margin = New System.Windows.Forms.Padding(2)
            Me.SupplierComboBox.Name = "SupplierComboBox"
            Me.SupplierComboBox.Size = New System.Drawing.Size(367, 36)
            Me.SupplierComboBox.TabIndex = 11
            '
            'Guna2HtmlLabel4
            '
            Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins Medium", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(21, 258)
            Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
            Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(86, 33)
            Me.Guna2HtmlLabel4.TabIndex = 12
            Me.Guna2HtmlLabel4.Text = "Supplier"
            '
            'ProductDescriptionTextBox
            '
            Me.ProductDescriptionTextBox.BorderRadius = 15
            Me.ProductDescriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.ProductDescriptionTextBox.DefaultText = ""
            Me.ProductDescriptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.ProductDescriptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ProductDescriptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.ProductDescriptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.ProductDescriptionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ProductDescriptionTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.ProductDescriptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ProductDescriptionTextBox.Location = New System.Drawing.Point(21, 370)
            Me.ProductDescriptionTextBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.ProductDescriptionTextBox.Name = "ProductDescriptionTextBox"
            Me.ProductDescriptionTextBox.PlaceholderText = """Premium ham with cheese, tomatoes...."""
            Me.ProductDescriptionTextBox.SelectedText = ""
            Me.ProductDescriptionTextBox.Size = New System.Drawing.Size(366, 39)
            Me.ProductDescriptionTextBox.TabIndex = 13
            '
            'Guna2HtmlLabel5
            '
            Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins Medium", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(21, 331)
            Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
            Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(202, 33)
            Me.Guna2HtmlLabel5.TabIndex = 14
            Me.Guna2HtmlLabel5.Text = "Product Description"
            '
            'CostTextBox
            '
            Me.CostTextBox.BorderRadius = 15
            Me.CostTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.CostTextBox.DefaultText = ""
            Me.CostTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.CostTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.CostTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.CostTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.CostTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.CostTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.CostTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.CostTextBox.Location = New System.Drawing.Point(21, 474)
            Me.CostTextBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.CostTextBox.Name = "CostTextBox"
            Me.CostTextBox.PlaceholderText = "P0.00"
            Me.CostTextBox.SelectedText = ""
            Me.CostTextBox.Size = New System.Drawing.Size(177, 39)
            Me.CostTextBox.TabIndex = 15
            '
            'SellingTextBox
            '
            Me.SellingTextBox.BorderRadius = 15
            Me.SellingTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.SellingTextBox.DefaultText = ""
            Me.SellingTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.SellingTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.SellingTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.SellingTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.SellingTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SellingTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.SellingTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SellingTextBox.Location = New System.Drawing.Point(210, 474)
            Me.SellingTextBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.SellingTextBox.Name = "SellingTextBox"
            Me.SellingTextBox.PlaceholderText = "P0.00"
            Me.SellingTextBox.SelectedText = ""
            Me.SellingTextBox.Size = New System.Drawing.Size(177, 39)
            Me.SellingTextBox.TabIndex = 16
            '
            'Guna2HtmlLabel6
            '
            Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins Medium", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(21, 435)
            Me.Guna2HtmlLabel6.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
            Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(49, 33)
            Me.Guna2HtmlLabel6.TabIndex = 17
            Me.Guna2HtmlLabel6.Text = "Cost"
            '
            'Guna2HtmlLabel7
            '
            Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Poppins Medium", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(210, 435)
            Me.Guna2HtmlLabel7.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
            Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(71, 33)
            Me.Guna2HtmlLabel7.TabIndex = 18
            Me.Guna2HtmlLabel7.Text = "Selling"
            '
            'SelectImageButton
            '
            Me.SelectImageButton.BackColor = System.Drawing.Color.White
            Me.SelectImageButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SelectImageButton.BorderRadius = 15
            Me.SelectImageButton.BorderThickness = 1
            Me.SelectImageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.SelectImageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.SelectImageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.SelectImageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.SelectImageButton.FillColor = System.Drawing.Color.White
            Me.SelectImageButton.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SelectImageButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SelectImageButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SelectImageButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SelectImageButton.HoverState.ForeColor = System.Drawing.Color.White
            Me.SelectImageButton.Location = New System.Drawing.Point(583, 464)
            Me.SelectImageButton.Margin = New System.Windows.Forms.Padding(2)
            Me.SelectImageButton.Name = "SelectImageButton"
            Me.SelectImageButton.Size = New System.Drawing.Size(135, 37)
            Me.SelectImageButton.TabIndex = 19
            Me.SelectImageButton.Text = "Select image"
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
            Me.SaveButton.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SaveButton.ForeColor = System.Drawing.Color.White
            Me.SaveButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SaveButton.HoverState.FillColor = System.Drawing.Color.White
            Me.SaveButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SaveButton.Location = New System.Drawing.Point(709, 554)
            Me.SaveButton.Margin = New System.Windows.Forms.Padding(2)
            Me.SaveButton.Name = "SaveButton"
            Me.SaveButton.Size = New System.Drawing.Size(135, 37)
            Me.SaveButton.TabIndex = 20
            Me.SaveButton.Text = "Save"
            '
            'CancelButton
            '
            Me.CancelButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.CancelButton.BorderRadius = 15
            Me.CancelButton.BorderThickness = 1
            Me.CancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.CancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.CancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.CancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.CancelButton.FillColor = System.Drawing.Color.White
            Me.CancelButton.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CancelButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.CancelButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.CancelButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.CancelButton.HoverState.ForeColor = System.Drawing.Color.White
            Me.CancelButton.Location = New System.Drawing.Point(560, 554)
            Me.CancelButton.Margin = New System.Windows.Forms.Padding(2)
            Me.CancelButton.Name = "CancelButton"
            Me.CancelButton.Size = New System.Drawing.Size(135, 37)
            Me.CancelButton.TabIndex = 21
            Me.CancelButton.Text = "Cancel"
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(867, 81)
            Me.Guna2Panel1.TabIndex = 22
            '
            'Guna2PictureBox1
            '
            Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.Guna2PictureBox1.BorderRadius = 15
            Me.Guna2PictureBox1.FillColor = System.Drawing.Color.WhiteSmoke
            Me.Guna2PictureBox1.ImageRotate = 0!
            Me.Guna2PictureBox1.Location = New System.Drawing.Point(434, 100)
            Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
            Me.Guna2PictureBox1.Size = New System.Drawing.Size(410, 349)
            Me.Guna2PictureBox1.TabIndex = 7
            Me.Guna2PictureBox1.TabStop = False
            '
            'AdminAddMenuView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(867, 609)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Controls.Add(Me.CancelButton)
            Me.Controls.Add(Me.SaveButton)
            Me.Controls.Add(Me.SelectImageButton)
            Me.Controls.Add(Me.Guna2HtmlLabel7)
            Me.Controls.Add(Me.Guna2HtmlLabel6)
            Me.Controls.Add(Me.SellingTextBox)
            Me.Controls.Add(Me.CostTextBox)
            Me.Controls.Add(Me.Guna2HtmlLabel5)
            Me.Controls.Add(Me.ProductDescriptionTextBox)
            Me.Controls.Add(Me.Guna2HtmlLabel4)
            Me.Controls.Add(Me.SupplierComboBox)
            Me.Controls.Add(Me.Guna2HtmlLabel3)
            Me.Controls.Add(Me.CategoryComboBox)
            Me.Controls.Add(Me.Guna2HtmlLabel2)
            Me.Controls.Add(Me.Guna2PictureBox1)
            Me.Controls.Add(Me.ProductNameTextBox)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "AdminAddMenuView"
            Me.Text = "AdminAddMenuView"
            Me.Guna2Panel1.ResumeLayout(False)
            Me.Guna2Panel1.PerformLayout()
            CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ProductNameTextBox As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents CategoryComboBox As Guna.UI2.WinForms.Guna2ComboBox
        Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents SupplierComboBox As Guna.UI2.WinForms.Guna2ComboBox
        Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ProductDescriptionTextBox As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents CostTextBox As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents SellingTextBox As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents SelectImageButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents SaveButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents CancelButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    End Class

End Namespace