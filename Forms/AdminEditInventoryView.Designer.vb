Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AdminEditInventoryView
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
            Me._cancelButton = New Guna.UI2.WinForms.Guna2Button()
            Me._saveButton = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me._quantityField = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
            Me._suppliers = New Guna.UI2.WinForms.Guna2ComboBox()
            Me._prodNameField = New Guna.UI2.WinForms.Guna2TextBox()
            Me._productID = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me._statuses = New Guna.UI2.WinForms.Guna2ComboBox()
            Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            '_cancelButton
            '
            Me._cancelButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me._cancelButton.BorderRadius = 15
            Me._cancelButton.BorderThickness = 1
            Me._cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me._cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me._cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me._cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me._cancelButton.FillColor = System.Drawing.Color.White
            Me._cancelButton.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._cancelButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me._cancelButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me._cancelButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me._cancelButton.HoverState.ForeColor = System.Drawing.Color.White
            Me._cancelButton.Location = New System.Drawing.Point(860, 762)
            Me._cancelButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me._cancelButton.Name = "_cancelButton"
            Me._cancelButton.Size = New System.Drawing.Size(189, 51)
            Me._cancelButton.TabIndex = 33
            Me._cancelButton.Text = "Cancel"
            '
            '_saveButton
            '
            Me._saveButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me._saveButton.BorderRadius = 15
            Me._saveButton.BorderThickness = 1
            Me._saveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me._saveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me._saveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me._saveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me._saveButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me._saveButton.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._saveButton.ForeColor = System.Drawing.Color.White
            Me._saveButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me._saveButton.HoverState.FillColor = System.Drawing.Color.White
            Me._saveButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me._saveButton.Location = New System.Drawing.Point(1068, 762)
            Me._saveButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me._saveButton.Name = "_saveButton"
            Me._saveButton.Size = New System.Drawing.Size(189, 51)
            Me._saveButton.TabIndex = 32
            Me._saveButton.Text = "Save"
            '
            'Guna2HtmlLabel5
            '
            Me.Guna2HtmlLabel5.AutoSize = False
            Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(680, 179)
            Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
            Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(182, 49)
            Me.Guna2HtmlLabel5.TabIndex = 31
            Me.Guna2HtmlLabel5.Text = "Supplier"
            '
            'Guna2HtmlLabel4
            '
            Me.Guna2HtmlLabel4.AutoSize = False
            Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(59, 409)
            Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
            Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(360, 49)
            Me.Guna2HtmlLabel4.TabIndex = 30
            Me.Guna2HtmlLabel4.Text = "Quantity"
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.AutoSize = False
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(59, 286)
            Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(382, 49)
            Me.Guna2HtmlLabel2.TabIndex = 29
            Me.Guna2HtmlLabel2.Text = "Product Name"
            '
            'Guna2HtmlLabel3
            '
            Me.Guna2HtmlLabel3.AutoSize = False
            Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(59, 179)
            Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
            Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(382, 49)
            Me.Guna2HtmlLabel3.TabIndex = 28
            Me.Guna2HtmlLabel3.Text = "Product ID"
            '
            '_quantityField
            '
            Me._quantityField.BorderRadius = 15
            Me._quantityField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._quantityField.DefaultText = ""
            Me._quantityField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me._quantityField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._quantityField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._quantityField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._quantityField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._quantityField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me._quantityField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._quantityField.Location = New System.Drawing.Point(59, 462)
            Me._quantityField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me._quantityField.Name = "_quantityField"
            Me._quantityField.PlaceholderText = "100"
            Me._quantityField.SelectedText = ""
            Me._quantityField.Size = New System.Drawing.Size(510, 49)
            Me._quantityField.TabIndex = 27
            '
            'Guna2DateTimePicker1
            '
            Me.Guna2DateTimePicker1.Checked = True
            Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.White
            Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
            Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(59, 114)
            Me.Guna2DateTimePicker1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
            Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
            Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
            Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(240, 44)
            Me.Guna2DateTimePicker1.TabIndex = 26
            Me.Guna2DateTimePicker1.Value = New Date(2025, 3, 27, 20, 51, 23, 297)
            '
            '_suppliers
            '
            Me._suppliers.BackColor = System.Drawing.Color.Transparent
            Me._suppliers.BorderRadius = 15
            Me._suppliers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me._suppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me._suppliers.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._suppliers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._suppliers.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me._suppliers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
            Me._suppliers.ItemHeight = 30
            Me._suppliers.Items.AddRange(New Object() {"Gentle House", "NEPS", "Belobog Constructions", "Victoria Housekeeping", "Sons of Calydon"})
            Me._suppliers.Location = New System.Drawing.Point(680, 232)
            Me._suppliers.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me._suppliers.Name = "_suppliers"
            Me._suppliers.Size = New System.Drawing.Size(511, 36)
            Me._suppliers.TabIndex = 25
            '
            '_prodNameField
            '
            Me._prodNameField.BorderRadius = 15
            Me._prodNameField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._prodNameField.DefaultText = ""
            Me._prodNameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me._prodNameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._prodNameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._prodNameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._prodNameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._prodNameField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me._prodNameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._prodNameField.Location = New System.Drawing.Point(59, 347)
            Me._prodNameField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me._prodNameField.Name = "_prodNameField"
            Me._prodNameField.PlaceholderText = "Ex.: ""Hamburger"""
            Me._prodNameField.SelectedText = ""
            Me._prodNameField.Size = New System.Drawing.Size(510, 49)
            Me._prodNameField.TabIndex = 24
            '
            '_productID
            '
            Me._productID.BorderRadius = 15
            Me._productID.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._productID.DefaultText = ""
            Me._productID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me._productID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._productID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._productID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._productID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._productID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me._productID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._productID.Location = New System.Drawing.Point(59, 232)
            Me._productID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me._productID.Name = "_productID"
            Me._productID.PlaceholderText = "102PDR"
            Me._productID.SelectedText = ""
            Me._productID.Size = New System.Drawing.Size(510, 49)
            Me._productID.TabIndex = 23
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(1040, 95)
            Me.Guna2Panel1.TabIndex = 34
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.AutoSize = False
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 28.2!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(29, 24)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(429, 61)
            Me.Guna2HtmlLabel1.TabIndex = 6
            Me.Guna2HtmlLabel1.Text = "Edit Inventory"
            '
            '_statuses
            '
            Me._statuses.BackColor = System.Drawing.Color.Transparent
            Me._statuses.BorderRadius = 15
            Me._statuses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me._statuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me._statuses.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._statuses.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._statuses.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me._statuses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
            Me._statuses.ItemHeight = 30
            Me._statuses.Items.AddRange(New Object() {"Active", "Inactive", "Out of Stock"})
            Me._statuses.Location = New System.Drawing.Point(680, 347)
            Me._statuses.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me._statuses.Name = "_statuses"
            Me._statuses.Size = New System.Drawing.Size(511, 36)
            Me._statuses.TabIndex = 35
            '
            'Guna2HtmlLabel6
            '
            Me.Guna2HtmlLabel6.AutoSize = False
            Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(680, 286)
            Me.Guna2HtmlLabel6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
            Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(191, 49)
            Me.Guna2HtmlLabel6.TabIndex = 36
            Me.Guna2HtmlLabel6.Text = "Status"
            '
            'AdminEditInventoryView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1040, 640)
            Me.Controls.Add(Me.Guna2HtmlLabel6)
            Me.Controls.Add(Me._statuses)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Controls.Add(Me._cancelButton)
            Me.Controls.Add(Me._saveButton)
            Me.Controls.Add(Me.Guna2HtmlLabel5)
            Me.Controls.Add(Me.Guna2HtmlLabel4)
            Me.Controls.Add(Me.Guna2HtmlLabel2)
            Me.Controls.Add(Me.Guna2HtmlLabel3)
            Me.Controls.Add(Me._quantityField)
            Me.Controls.Add(Me.Guna2DateTimePicker1)
            Me.Controls.Add(Me._suppliers)
            Me.Controls.Add(Me._prodNameField)
            Me.Controls.Add(Me._productID)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Name = "AdminEditInventoryView"
            Me.Text = "AdminEditInventoryView"
            Me.Guna2Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents _cancelButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents _saveButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents _quantityField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
        Friend WithEvents _suppliers As Guna.UI2.WinForms.Guna2ComboBox
        Friend WithEvents _prodNameField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents _productID As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents _statuses As Guna.UI2.WinForms.Guna2ComboBox
        Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace