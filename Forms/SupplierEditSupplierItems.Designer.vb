Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SupplierEditSupplierItems
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupplierEditSupplierItems))
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me._label = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me._cancelButton = New Guna.UI2.WinForms.Guna2Button()
            Me._saveButton = New Guna.UI2.WinForms.Guna2Button()
            Me._itemNameField = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me._IDField = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.DescField = New Guna.UI2.WinForms.Guna2TextBox()
            Me.SupplieIdField = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me._label)
            Me.Guna2Panel1.Controls.Add(Me._cancelButton)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(1321, 95)
            Me.Guna2Panel1.TabIndex = 2
            '
            '_label
            '
            Me._label.AutoSize = False
            Me._label.BackColor = System.Drawing.Color.Transparent
            Me._label.Font = New System.Drawing.Font("Montserrat", 28.2!, System.Drawing.FontStyle.Bold)
            Me._label.Location = New System.Drawing.Point(76, 16)
            Me._label.Margin = New System.Windows.Forms.Padding(2)
            Me._label.Name = "_label"
            Me._label.Size = New System.Drawing.Size(94, 61)
            Me._label.TabIndex = 6
            Me._label.Text = "Edit Supplier Item"
            '
            '_cancelButton
            '
            Me._cancelButton.BorderColor = System.Drawing.Color.Transparent
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
            Me._cancelButton.Image = CType(resources.GetObject("_cancelButton.Image"), System.Drawing.Image)
            Me._cancelButton.ImageSize = New System.Drawing.Size(70, 70)
            Me._cancelButton.Location = New System.Drawing.Point(15, 19)
            Me._cancelButton.Margin = New System.Windows.Forms.Padding(2)
            Me._cancelButton.Name = "_cancelButton"
            Me._cancelButton.Size = New System.Drawing.Size(54, 51)
            Me._cancelButton.TabIndex = 30
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
            Me._saveButton.Location = New System.Drawing.Point(1027, 729)
            Me._saveButton.Margin = New System.Windows.Forms.Padding(2)
            Me._saveButton.Name = "_saveButton"
            Me._saveButton.Size = New System.Drawing.Size(189, 48)
            Me._saveButton.TabIndex = 29
            Me._saveButton.Text = "Save"
            '
            '_itemNameField
            '
            Me._itemNameField.BorderRadius = 15
            Me._itemNameField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._itemNameField.DefaultText = ""
            Me._itemNameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me._itemNameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._itemNameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._itemNameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._itemNameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._itemNameField.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._itemNameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._itemNameField.Location = New System.Drawing.Point(76, 319)
            Me._itemNameField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me._itemNameField.Name = "_itemNameField"
            Me._itemNameField.PlaceholderText = "Juan Dela Pou"
            Me._itemNameField.SelectedText = ""
            Me._itemNameField.Size = New System.Drawing.Size(510, 49)
            Me._itemNameField.TabIndex = 31
            '
            'Guna2HtmlLabel6
            '
            Me.Guna2HtmlLabel6.AutoSize = False
            Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(76, 265)
            Me.Guna2HtmlLabel6.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
            Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(376, 49)
            Me.Guna2HtmlLabel6.TabIndex = 32
            Me.Guna2HtmlLabel6.Text = "Name"
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.AutoSize = False
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(76, 145)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(36, 49)
            Me.Guna2HtmlLabel1.TabIndex = 33
            Me.Guna2HtmlLabel1.Text = "ID"
            '
            '_IDField
            '
            Me._IDField.BorderRadius = 15
            Me._IDField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._IDField.DefaultText = ""
            Me._IDField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me._IDField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._IDField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._IDField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._IDField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._IDField.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._IDField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._IDField.Location = New System.Drawing.Point(76, 199)
            Me._IDField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me._IDField.Name = "_IDField"
            Me._IDField.PlaceholderText = "Staff Name"
            Me._IDField.SelectedText = ""
            Me._IDField.Size = New System.Drawing.Size(510, 49)
            Me._IDField.TabIndex = 34
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.AutoSize = False
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(76, 383)
            Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(376, 49)
            Me.Guna2HtmlLabel2.TabIndex = 35
            Me.Guna2HtmlLabel2.Text = "Description"
            '
            'DescField
            '
            Me.DescField.BorderRadius = 15
            Me.DescField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.DescField.DefaultText = ""
            Me.DescField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.DescField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.DescField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.DescField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.DescField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DescField.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DescField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DescField.Location = New System.Drawing.Point(76, 449)
            Me.DescField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.DescField.Name = "DescField"
            Me.DescField.PlaceholderText = "Enter"
            Me.DescField.SelectedText = ""
            Me.DescField.Size = New System.Drawing.Size(510, 266)
            Me.DescField.TabIndex = 36
            Me.DescField.TextOffset = New System.Drawing.Point(0, -110)
            '
            'SupplieIdField
            '
            Me.SupplieIdField.BorderRadius = 15
            Me.SupplieIdField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.SupplieIdField.DefaultText = ""
            Me.SupplieIdField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.SupplieIdField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.SupplieIdField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.SupplieIdField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.SupplieIdField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SupplieIdField.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SupplieIdField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SupplieIdField.Location = New System.Drawing.Point(706, 199)
            Me.SupplieIdField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.SupplieIdField.Name = "SupplieIdField"
            Me.SupplieIdField.PlaceholderText = "Enter "
            Me.SupplieIdField.SelectedText = ""
            Me.SupplieIdField.Size = New System.Drawing.Size(510, 49)
            Me.SupplieIdField.TabIndex = 37
            '
            'Guna2HtmlLabel3
            '
            Me.Guna2HtmlLabel3.AutoSize = False
            Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(706, 145)
            Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
            Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(376, 49)
            Me.Guna2HtmlLabel3.TabIndex = 38
            Me.Guna2HtmlLabel3.Text = "Supplier ID"
            '
            'SupplierEditSupplierItems
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoScroll = True
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1321, 788)
            Me.Controls.Add(Me.Guna2HtmlLabel3)
            Me.Controls.Add(Me.SupplieIdField)
            Me.Controls.Add(Me.DescField)
            Me.Controls.Add(Me.Guna2HtmlLabel2)
            Me.Controls.Add(Me._IDField)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Controls.Add(Me.Guna2HtmlLabel6)
            Me.Controls.Add(Me._itemNameField)
            Me.Controls.Add(Me._saveButton)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "SupplierEditSupplierItems"
            Me.Text = "SupplierEditSupplierItems"
            Me.Guna2Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents _label As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents _cancelButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents _saveButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents _itemNameField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents _IDField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents DescField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents SupplieIdField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace