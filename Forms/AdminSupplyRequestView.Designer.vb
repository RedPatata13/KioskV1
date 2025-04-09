Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AdminSupplyRequestView
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
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ID_Field = New Guna.UI2.WinForms.Guna2TextBox()
            Me.ProductNameField = New Guna.UI2.WinForms.Guna2TextBox()
            Me.SupplierField = New Guna.UI2.WinForms.Guna2ComboBox()
            Me.DatePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
            Me.QuantityField = New Guna.UI2.WinForms.Guna2TextBox()
            Me.NoteField = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ConfirmButton = New Guna.UI2.WinForms.Guna2Button()
            Me.CancelButton = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(1321, 81)
            Me.Guna2Panel1.TabIndex = 0
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.AutoSize = False
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(29, 18)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(266, 51)
            Me.Guna2HtmlLabel1.TabIndex = 6
            Me.Guna2HtmlLabel1.Text = "Supply Request"
            '
            'ID_Field
            '
            Me.ID_Field.BorderRadius = 15
            Me.ID_Field.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.ID_Field.DefaultText = ""
            Me.ID_Field.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.ID_Field.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ID_Field.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.ID_Field.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.ID_Field.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ID_Field.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.ID_Field.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ID_Field.Location = New System.Drawing.Point(59, 254)
            Me.ID_Field.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.ID_Field.Name = "ID_Field"
            Me.ID_Field.PlaceholderText = "102PDR"
            Me.ID_Field.SelectedText = ""
            Me.ID_Field.Size = New System.Drawing.Size(510, 49)
            Me.ID_Field.TabIndex = 7
            '
            'ProductNameField
            '
            Me.ProductNameField.BorderRadius = 15
            Me.ProductNameField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.ProductNameField.DefaultText = ""
            Me.ProductNameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.ProductNameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ProductNameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.ProductNameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.ProductNameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ProductNameField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.ProductNameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ProductNameField.Location = New System.Drawing.Point(59, 383)
            Me.ProductNameField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.ProductNameField.Name = "ProductNameField"
            Me.ProductNameField.PlaceholderText = "Ex.: ""Hamburger"""
            Me.ProductNameField.SelectedText = ""
            Me.ProductNameField.Size = New System.Drawing.Size(510, 49)
            Me.ProductNameField.TabIndex = 8
            '
            'SupplierField
            '
            Me.SupplierField.BackColor = System.Drawing.Color.Transparent
            Me.SupplierField.BorderRadius = 15
            Me.SupplierField.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.SupplierField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.SupplierField.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SupplierField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SupplierField.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.SupplierField.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.SupplierField.ItemHeight = 30
            Me.SupplierField.Location = New System.Drawing.Point(747, 254)
            Me.SupplierField.Margin = New System.Windows.Forms.Padding(2)
            Me.SupplierField.Name = "SupplierField"
            Me.SupplierField.Size = New System.Drawing.Size(511, 36)
            Me.SupplierField.TabIndex = 10
            '
            'DatePicker
            '
            Me.DatePicker.Checked = True
            Me.DatePicker.FillColor = System.Drawing.Color.White
            Me.DatePicker.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
            Me.DatePicker.Location = New System.Drawing.Point(59, 114)
            Me.DatePicker.Margin = New System.Windows.Forms.Padding(2)
            Me.DatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
            Me.DatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
            Me.DatePicker.Name = "DatePicker"
            Me.DatePicker.Size = New System.Drawing.Size(240, 44)
            Me.DatePicker.TabIndex = 11
            Me.DatePicker.Value = New Date(2025, 3, 27, 20, 51, 23, 297)
            '
            'QuantityField
            '
            Me.QuantityField.BorderRadius = 15
            Me.QuantityField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.QuantityField.DefaultText = ""
            Me.QuantityField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.QuantityField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.QuantityField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.QuantityField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.QuantityField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.QuantityField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.QuantityField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.QuantityField.Location = New System.Drawing.Point(59, 522)
            Me.QuantityField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.QuantityField.Name = "QuantityField"
            Me.QuantityField.PlaceholderText = "100"
            Me.QuantityField.SelectedText = ""
            Me.QuantityField.Size = New System.Drawing.Size(510, 49)
            Me.QuantityField.TabIndex = 12
            '
            'NoteField
            '
            Me.NoteField.BorderRadius = 15
            Me.NoteField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.NoteField.DefaultText = ""
            Me.NoteField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.NoteField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.NoteField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.NoteField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.NoteField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.NoteField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.NoteField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.NoteField.Location = New System.Drawing.Point(747, 383)
            Me.NoteField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.NoteField.Name = "NoteField"
            Me.NoteField.PlaceholderText = """Please divide into two boxes..."""
            Me.NoteField.SelectedText = ""
            Me.NoteField.Size = New System.Drawing.Size(510, 131)
            Me.NoteField.TabIndex = 13
            '
            'Guna2HtmlLabel3
            '
            Me.Guna2HtmlLabel3.AutoSize = False
            Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(59, 188)
            Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
            Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(148, 48)
            Me.Guna2HtmlLabel3.TabIndex = 15
            Me.Guna2HtmlLabel3.Text = "Product ID"
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.AutoSize = False
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(59, 318)
            Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(205, 48)
            Me.Guna2HtmlLabel2.TabIndex = 16
            Me.Guna2HtmlLabel2.Text = "Product Name"
            '
            'Guna2HtmlLabel4
            '
            Me.Guna2HtmlLabel4.AutoSize = False
            Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(59, 457)
            Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
            Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(125, 48)
            Me.Guna2HtmlLabel4.TabIndex = 17
            Me.Guna2HtmlLabel4.Text = "Quantity"
            '
            'Guna2HtmlLabel5
            '
            Me.Guna2HtmlLabel5.AutoSize = False
            Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(749, 188)
            Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
            Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(120, 48)
            Me.Guna2HtmlLabel5.TabIndex = 18
            Me.Guna2HtmlLabel5.Text = "Supplier"
            '
            'Guna2HtmlLabel6
            '
            Me.Guna2HtmlLabel6.AutoSize = False
            Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(749, 318)
            Me.Guna2HtmlLabel6.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
            Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(147, 48)
            Me.Guna2HtmlLabel6.TabIndex = 19
            Me.Guna2HtmlLabel6.Text = "Add notes"
            '
            'ConfirmButton
            '
            Me.ConfirmButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ConfirmButton.BorderRadius = 15
            Me.ConfirmButton.BorderThickness = 1
            Me.ConfirmButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.ConfirmButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.ConfirmButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.ConfirmButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.ConfirmButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ConfirmButton.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ConfirmButton.ForeColor = System.Drawing.Color.White
            Me.ConfirmButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ConfirmButton.HoverState.FillColor = System.Drawing.Color.White
            Me.ConfirmButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ConfirmButton.Location = New System.Drawing.Point(1072, 632)
            Me.ConfirmButton.Margin = New System.Windows.Forms.Padding(2)
            Me.ConfirmButton.Name = "ConfirmButton"
            Me.ConfirmButton.Size = New System.Drawing.Size(189, 51)
            Me.ConfirmButton.TabIndex = 23
            Me.ConfirmButton.Text = "Confirm"
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
            Me.CancelButton.Location = New System.Drawing.Point(872, 632)
            Me.CancelButton.Margin = New System.Windows.Forms.Padding(2)
            Me.CancelButton.Name = "CancelButton"
            Me.CancelButton.Size = New System.Drawing.Size(189, 51)
            Me.CancelButton.TabIndex = 24
            Me.CancelButton.Text = "Cancel"
            '
            'AdminSupplyRequestView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1321, 878)
            Me.Controls.Add(Me.CancelButton)
            Me.Controls.Add(Me.ConfirmButton)
            Me.Controls.Add(Me.Guna2HtmlLabel6)
            Me.Controls.Add(Me.Guna2HtmlLabel5)
            Me.Controls.Add(Me.Guna2HtmlLabel4)
            Me.Controls.Add(Me.Guna2HtmlLabel2)
            Me.Controls.Add(Me.Guna2HtmlLabel3)
            Me.Controls.Add(Me.NoteField)
            Me.Controls.Add(Me.QuantityField)
            Me.Controls.Add(Me.DatePicker)
            Me.Controls.Add(Me.SupplierField)
            Me.Controls.Add(Me.ProductNameField)
            Me.Controls.Add(Me.ID_Field)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "AdminSupplyRequestView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "StaffSupplyRequestView"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Guna2Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ID_Field As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents ProductNameField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents SupplierField As Guna.UI2.WinForms.Guna2ComboBox
        Friend WithEvents DatePicker As Guna.UI2.WinForms.Guna2DateTimePicker
        Friend WithEvents QuantityField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents NoteField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ConfirmButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents CancelButton As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace