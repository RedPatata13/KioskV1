Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AdminAccountUserControl
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
            Me.DeleteButton = New Guna.UI2.WinForms.Guna2Button()
            Me.Edit = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.FirstNameField = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.LastNameField = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Password = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Email = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ContactNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.UIDField = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.FName_Field = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.LName_Field = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.PasswordField = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.EmailField = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ContactNumField = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Role = New Guna.UI2.WinForms.Guna2ComboBox()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.SuspendLayout()
            '
            'DeleteButton
            '
            Me.DeleteButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DeleteButton.BorderRadius = 15
            Me.DeleteButton.BorderThickness = 1
            Me.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.DeleteButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DeleteButton.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DeleteButton.ForeColor = System.Drawing.Color.White
            Me.DeleteButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DeleteButton.HoverState.FillColor = System.Drawing.Color.White
            Me.DeleteButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DeleteButton.Location = New System.Drawing.Point(968, 152)
            Me.DeleteButton.Margin = New System.Windows.Forms.Padding(2)
            Me.DeleteButton.Name = "DeleteButton"
            Me.DeleteButton.Size = New System.Drawing.Size(237, 51)
            Me.DeleteButton.TabIndex = 24
            Me.DeleteButton.Text = "Delete"
            '
            'Edit
            '
            Me.Edit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.Edit.BorderRadius = 15
            Me.Edit.BorderThickness = 1
            Me.Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.Edit.FillColor = System.Drawing.Color.White
            Me.Edit.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Edit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.Edit.HoverState.ForeColor = System.Drawing.Color.White
            Me.Edit.Location = New System.Drawing.Point(688, 152)
            Me.Edit.Margin = New System.Windows.Forms.Padding(2)
            Me.Edit.Name = "Edit"
            Me.Edit.Size = New System.Drawing.Size(256, 51)
            Me.Edit.TabIndex = 25
            Me.Edit.Text = "Edit"
            '
            'Guna2HtmlLabel3
            '
            Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(16, 24)
            Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
            Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(56, 48)
            Me.Guna2HtmlLabel3.TabIndex = 26
            Me.Guna2HtmlLabel3.Text = "UID:"
            '
            'FirstNameField
            '
            Me.FirstNameField.BackColor = System.Drawing.Color.Transparent
            Me.FirstNameField.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.FirstNameField.ForeColor = System.Drawing.SystemColors.ControlText
            Me.FirstNameField.Location = New System.Drawing.Point(16, 64)
            Me.FirstNameField.Margin = New System.Windows.Forms.Padding(2)
            Me.FirstNameField.Name = "FirstNameField"
            Me.FirstNameField.Size = New System.Drawing.Size(161, 48)
            Me.FirstNameField.TabIndex = 27
            Me.FirstNameField.Text = "First Name:"
            '
            'LastNameField
            '
            Me.LastNameField.BackColor = System.Drawing.Color.Transparent
            Me.LastNameField.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.LastNameField.ForeColor = System.Drawing.SystemColors.ControlText
            Me.LastNameField.Location = New System.Drawing.Point(16, 104)
            Me.LastNameField.Margin = New System.Windows.Forms.Padding(2)
            Me.LastNameField.Name = "LastNameField"
            Me.LastNameField.Size = New System.Drawing.Size(160, 48)
            Me.LastNameField.TabIndex = 28
            Me.LastNameField.Text = "Last Name:"
            '
            'Password
            '
            Me.Password.BackColor = System.Drawing.Color.Transparent
            Me.Password.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Password.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Password.Location = New System.Drawing.Point(688, 104)
            Me.Password.Margin = New System.Windows.Forms.Padding(2)
            Me.Password.Name = "Password"
            Me.Password.Size = New System.Drawing.Size(145, 48)
            Me.Password.TabIndex = 29
            Me.Password.Text = "Password:"
            '
            'Email
            '
            Me.Email.BackColor = System.Drawing.Color.Transparent
            Me.Email.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Email.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Email.Location = New System.Drawing.Point(688, 24)
            Me.Email.Margin = New System.Windows.Forms.Padding(2)
            Me.Email.Name = "Email"
            Me.Email.Size = New System.Drawing.Size(88, 48)
            Me.Email.TabIndex = 30
            Me.Email.Text = "Email: "
            '
            'ContactNumber
            '
            Me.ContactNumber.BackColor = System.Drawing.Color.Transparent
            Me.ContactNumber.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.ContactNumber.ForeColor = System.Drawing.SystemColors.ControlText
            Me.ContactNumber.Location = New System.Drawing.Point(688, 64)
            Me.ContactNumber.Margin = New System.Windows.Forms.Padding(2)
            Me.ContactNumber.Name = "ContactNumber"
            Me.ContactNumber.Size = New System.Drawing.Size(157, 48)
            Me.ContactNumber.TabIndex = 31
            Me.ContactNumber.Text = "Contact #: "
            '
            'UIDField
            '
            Me.UIDField.BackColor = System.Drawing.Color.Transparent
            Me.UIDField.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UIDField.ForeColor = System.Drawing.SystemColors.ControlText
            Me.UIDField.Location = New System.Drawing.Point(80, 24)
            Me.UIDField.Margin = New System.Windows.Forms.Padding(2)
            Me.UIDField.Name = "UIDField"
            Me.UIDField.Size = New System.Drawing.Size(147, 50)
            Me.UIDField.TabIndex = 32
            Me.UIDField.Text = "First Name"
            '
            'FName_Field
            '
            Me.FName_Field.BackColor = System.Drawing.Color.Transparent
            Me.FName_Field.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FName_Field.ForeColor = System.Drawing.SystemColors.ControlText
            Me.FName_Field.Location = New System.Drawing.Point(184, 64)
            Me.FName_Field.Margin = New System.Windows.Forms.Padding(2)
            Me.FName_Field.Name = "FName_Field"
            Me.FName_Field.Size = New System.Drawing.Size(147, 50)
            Me.FName_Field.TabIndex = 33
            Me.FName_Field.Text = "First Name"
            '
            'LName_Field
            '
            Me.LName_Field.BackColor = System.Drawing.Color.Transparent
            Me.LName_Field.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LName_Field.ForeColor = System.Drawing.SystemColors.ControlText
            Me.LName_Field.Location = New System.Drawing.Point(184, 104)
            Me.LName_Field.Margin = New System.Windows.Forms.Padding(2)
            Me.LName_Field.Name = "LName_Field"
            Me.LName_Field.Size = New System.Drawing.Size(147, 50)
            Me.LName_Field.TabIndex = 34
            Me.LName_Field.Text = "First Name"
            '
            'PasswordField
            '
            Me.PasswordField.BackColor = System.Drawing.Color.Transparent
            Me.PasswordField.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PasswordField.ForeColor = System.Drawing.SystemColors.ControlText
            Me.PasswordField.Location = New System.Drawing.Point(840, 104)
            Me.PasswordField.Margin = New System.Windows.Forms.Padding(2)
            Me.PasswordField.Name = "PasswordField"
            Me.PasswordField.Size = New System.Drawing.Size(147, 50)
            Me.PasswordField.TabIndex = 35
            Me.PasswordField.Text = "First Name"
            '
            'EmailField
            '
            Me.EmailField.BackColor = System.Drawing.Color.Transparent
            Me.EmailField.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.EmailField.ForeColor = System.Drawing.SystemColors.ControlText
            Me.EmailField.Location = New System.Drawing.Point(784, 24)
            Me.EmailField.Margin = New System.Windows.Forms.Padding(2)
            Me.EmailField.Name = "EmailField"
            Me.EmailField.Size = New System.Drawing.Size(147, 50)
            Me.EmailField.TabIndex = 36
            Me.EmailField.Text = "First Name"
            '
            'ContactNumField
            '
            Me.ContactNumField.BackColor = System.Drawing.Color.Transparent
            Me.ContactNumField.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ContactNumField.ForeColor = System.Drawing.SystemColors.ControlText
            Me.ContactNumField.Location = New System.Drawing.Point(848, 64)
            Me.ContactNumField.Margin = New System.Windows.Forms.Padding(2)
            Me.ContactNumField.Name = "ContactNumField"
            Me.ContactNumField.Size = New System.Drawing.Size(147, 50)
            Me.ContactNumField.TabIndex = 37
            Me.ContactNumField.Text = "First Name"
            '
            'Role
            '
            Me.Role.BackColor = System.Drawing.Color.Transparent
            Me.Role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.Role.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Role.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.Role.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.Role.ItemHeight = 30
            Me.Role.Items.AddRange(New Object() {"Active", "Staff", "Supplier", "Customer"})
            Me.Role.Location = New System.Drawing.Point(96, 152)
            Me.Role.Name = "Role"
            Me.Role.Size = New System.Drawing.Size(232, 36)
            Me.Role.TabIndex = 38
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(16, 144)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(70, 48)
            Me.Guna2HtmlLabel1.TabIndex = 39
            Me.Guna2HtmlLabel1.Text = "Role:"
            '
            'AdminAccountUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Controls.Add(Me.Role)
            Me.Controls.Add(Me.ContactNumField)
            Me.Controls.Add(Me.EmailField)
            Me.Controls.Add(Me.PasswordField)
            Me.Controls.Add(Me.LName_Field)
            Me.Controls.Add(Me.FName_Field)
            Me.Controls.Add(Me.UIDField)
            Me.Controls.Add(Me.ContactNumber)
            Me.Controls.Add(Me.Email)
            Me.Controls.Add(Me.Password)
            Me.Controls.Add(Me.LastNameField)
            Me.Controls.Add(Me.FirstNameField)
            Me.Controls.Add(Me.Guna2HtmlLabel3)
            Me.Controls.Add(Me.Edit)
            Me.Controls.Add(Me.DeleteButton)
            Me.Name = "AdminAccountUserControl"
            Me.Size = New System.Drawing.Size(1229, 220)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents DeleteButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Edit As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents FirstNameField As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents LastNameField As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Password As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Email As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ContactNumber As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents UIDField As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents FName_Field As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents LName_Field As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PasswordField As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents EmailField As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ContactNumField As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Role As Guna.UI2.WinForms.Guna2ComboBox
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace