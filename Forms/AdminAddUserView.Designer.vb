Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AdminAddUserView
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
            Me._label = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me._roles = New Guna.UI2.WinForms.Guna2ComboBox()
            Me._userNameField = New Guna.UI2.WinForms.Guna2TextBox()
            Me._passwordField = New Guna.UI2.WinForms.Guna2TextBox()
            Me._confirmPasswordField = New Guna.UI2.WinForms.Guna2TextBox()
            Me._firstNameField = New Guna.UI2.WinForms.Guna2TextBox()
            Me._emailField = New Guna.UI2.WinForms.Guna2TextBox()
            Me._lastNameField = New Guna.UI2.WinForms.Guna2TextBox()
            Me._contactNumField = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me._cancelButton = New Guna.UI2.WinForms.Guna2Button()
            Me._saveButton = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me._label)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(1321, 95)
            Me.Guna2Panel1.TabIndex = 1
            '
            '_label
            '
            Me._label.AutoSize = False
            Me._label.BackColor = System.Drawing.Color.Transparent
            Me._label.Font = New System.Drawing.Font("Montserrat", 28.2!, System.Drawing.FontStyle.Bold)
            Me._label.Location = New System.Drawing.Point(28, 21)
            Me._label.Margin = New System.Windows.Forms.Padding(2)
            Me._label.Name = "_label"
            Me._label.Size = New System.Drawing.Size(196, 61)
            Me._label.TabIndex = 6
            Me._label.Text = "Add User"
            '
            '_roles
            '
            Me._roles.BackColor = System.Drawing.Color.Transparent
            Me._roles.BorderRadius = 15
            Me._roles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me._roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me._roles.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._roles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._roles.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me._roles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
            Me._roles.ItemHeight = 30
            Me._roles.Items.AddRange(New Object() {"Admin", "Staff", "Supplier", "Customer"})
            Me._roles.Location = New System.Drawing.Point(59, 166)
            Me._roles.Margin = New System.Windows.Forms.Padding(2)
            Me._roles.Name = "_roles"
            Me._roles.Size = New System.Drawing.Size(511, 36)
            Me._roles.TabIndex = 11
            '
            '_userNameField
            '
            Me._userNameField.BorderRadius = 15
            Me._userNameField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._userNameField.DefaultText = ""
            Me._userNameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me._userNameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._userNameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._userNameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._userNameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._userNameField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me._userNameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._userNameField.Location = New System.Drawing.Point(59, 273)
            Me._userNameField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me._userNameField.Name = "_userNameField"
            Me._userNameField.PlaceholderText = "StaffName123"
            Me._userNameField.SelectedText = ""
            Me._userNameField.Size = New System.Drawing.Size(510, 49)
            Me._userNameField.TabIndex = 12
            '
            '_passwordField
            '
            Me._passwordField.BorderRadius = 15
            Me._passwordField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._passwordField.DefaultText = ""
            Me._passwordField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me._passwordField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._passwordField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._passwordField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._passwordField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._passwordField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me._passwordField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._passwordField.Location = New System.Drawing.Point(59, 398)
            Me._passwordField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me._passwordField.Name = "_passwordField"
            Me._passwordField.PlaceholderText = "********"
            Me._passwordField.SelectedText = ""
            Me._passwordField.Size = New System.Drawing.Size(510, 49)
            Me._passwordField.TabIndex = 13
            '
            '_confirmPasswordField
            '
            Me._confirmPasswordField.BorderRadius = 15
            Me._confirmPasswordField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._confirmPasswordField.DefaultText = ""
            Me._confirmPasswordField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me._confirmPasswordField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._confirmPasswordField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._confirmPasswordField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._confirmPasswordField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._confirmPasswordField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me._confirmPasswordField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._confirmPasswordField.Location = New System.Drawing.Point(59, 512)
            Me._confirmPasswordField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me._confirmPasswordField.Name = "_confirmPasswordField"
            Me._confirmPasswordField.PlaceholderText = "********"
            Me._confirmPasswordField.SelectedText = ""
            Me._confirmPasswordField.Size = New System.Drawing.Size(510, 49)
            Me._confirmPasswordField.TabIndex = 14
            '
            '_firstNameField
            '
            Me._firstNameField.BorderRadius = 15
            Me._firstNameField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._firstNameField.DefaultText = ""
            Me._firstNameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me._firstNameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._firstNameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._firstNameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._firstNameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._firstNameField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me._firstNameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._firstNameField.Location = New System.Drawing.Point(740, 166)
            Me._firstNameField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me._firstNameField.Name = "_firstNameField"
            Me._firstNameField.PlaceholderText = "Juan"
            Me._firstNameField.SelectedText = ""
            Me._firstNameField.Size = New System.Drawing.Size(510, 49)
            Me._firstNameField.TabIndex = 15
            '
            '_emailField
            '
            Me._emailField.BorderRadius = 15
            Me._emailField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._emailField.DefaultText = ""
            Me._emailField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me._emailField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._emailField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._emailField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._emailField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._emailField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me._emailField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._emailField.Location = New System.Drawing.Point(740, 398)
            Me._emailField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me._emailField.Name = "_emailField"
            Me._emailField.PlaceholderText = "staffname@gmail.com"
            Me._emailField.SelectedText = ""
            Me._emailField.Size = New System.Drawing.Size(510, 49)
            Me._emailField.TabIndex = 16
            '
            '_lastNameField
            '
            Me._lastNameField.BorderRadius = 15
            Me._lastNameField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._lastNameField.DefaultText = ""
            Me._lastNameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me._lastNameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._lastNameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._lastNameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._lastNameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._lastNameField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me._lastNameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._lastNameField.Location = New System.Drawing.Point(740, 273)
            Me._lastNameField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me._lastNameField.Name = "_lastNameField"
            Me._lastNameField.PlaceholderText = "Dela Cruz"
            Me._lastNameField.SelectedText = ""
            Me._lastNameField.Size = New System.Drawing.Size(510, 49)
            Me._lastNameField.TabIndex = 17
            '
            '_contactNumField
            '
            Me._contactNumField.BorderRadius = 15
            Me._contactNumField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._contactNumField.DefaultText = ""
            Me._contactNumField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me._contactNumField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._contactNumField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._contactNumField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me._contactNumField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._contactNumField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me._contactNumField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me._contactNumField.Location = New System.Drawing.Point(740, 512)
            Me._contactNumField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me._contactNumField.Name = "_contactNumField"
            Me._contactNumField.PlaceholderText = "09*********"
            Me._contactNumField.SelectedText = ""
            Me._contactNumField.Size = New System.Drawing.Size(510, 49)
            Me._contactNumField.TabIndex = 18
            '
            'Guna2HtmlLabel3
            '
            Me.Guna2HtmlLabel3.AutoSize = False
            Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(59, 114)
            Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
            Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(406, 49)
            Me.Guna2HtmlLabel3.TabIndex = 19
            Me.Guna2HtmlLabel3.Text = "Select your role"
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.AutoSize = False
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(59, 219)
            Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(439, 49)
            Me.Guna2HtmlLabel2.TabIndex = 20
            Me.Guna2HtmlLabel2.Text = "Username"
            '
            'Guna2HtmlLabel4
            '
            Me.Guna2HtmlLabel4.AutoSize = False
            Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(59, 336)
            Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
            Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(286, 49)
            Me.Guna2HtmlLabel4.TabIndex = 21
            Me.Guna2HtmlLabel4.Text = "Password"
            '
            'Guna2HtmlLabel5
            '
            Me.Guna2HtmlLabel5.AutoSize = False
            Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(59, 458)
            Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
            Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(406, 49)
            Me.Guna2HtmlLabel5.TabIndex = 22
            Me.Guna2HtmlLabel5.Text = "Confirm Password"
            '
            'Guna2HtmlLabel6
            '
            Me.Guna2HtmlLabel6.AutoSize = False
            Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(740, 114)
            Me.Guna2HtmlLabel6.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
            Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(376, 49)
            Me.Guna2HtmlLabel6.TabIndex = 23
            Me.Guna2HtmlLabel6.Text = "First name"
            '
            'Guna2HtmlLabel7
            '
            Me.Guna2HtmlLabel7.AutoSize = False
            Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(740, 219)
            Me.Guna2HtmlLabel7.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
            Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(416, 49)
            Me.Guna2HtmlLabel7.TabIndex = 24
            Me.Guna2HtmlLabel7.Text = "Last name"
            '
            'Guna2HtmlLabel8
            '
            Me.Guna2HtmlLabel8.AutoSize = False
            Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel8.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(740, 336)
            Me.Guna2HtmlLabel8.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
            Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(285, 49)
            Me.Guna2HtmlLabel8.TabIndex = 25
            Me.Guna2HtmlLabel8.Text = "Email"
            '
            'Guna2HtmlLabel9
            '
            Me.Guna2HtmlLabel9.AutoSize = False
            Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(740, 458)
            Me.Guna2HtmlLabel9.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
            Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(450, 49)
            Me.Guna2HtmlLabel9.TabIndex = 26
            Me.Guna2HtmlLabel9.Text = "Contact number"
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
            Me._cancelButton.Location = New System.Drawing.Point(854, 762)
            Me._cancelButton.Margin = New System.Windows.Forms.Padding(2)
            Me._cancelButton.Name = "_cancelButton"
            Me._cancelButton.Size = New System.Drawing.Size(189, 51)
            Me._cancelButton.TabIndex = 28
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
            Me._saveButton.Margin = New System.Windows.Forms.Padding(2)
            Me._saveButton.Name = "_saveButton"
            Me._saveButton.Size = New System.Drawing.Size(189, 51)
            Me._saveButton.TabIndex = 27
            Me._saveButton.Text = "Save"
            '
            'AdminAddUserView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoScroll = True
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1321, 878)
            Me.Controls.Add(Me._cancelButton)
            Me.Controls.Add(Me._saveButton)
            Me.Controls.Add(Me.Guna2HtmlLabel9)
            Me.Controls.Add(Me.Guna2HtmlLabel8)
            Me.Controls.Add(Me.Guna2HtmlLabel7)
            Me.Controls.Add(Me.Guna2HtmlLabel6)
            Me.Controls.Add(Me.Guna2HtmlLabel5)
            Me.Controls.Add(Me.Guna2HtmlLabel4)
            Me.Controls.Add(Me.Guna2HtmlLabel2)
            Me.Controls.Add(Me.Guna2HtmlLabel3)
            Me.Controls.Add(Me._contactNumField)
            Me.Controls.Add(Me._lastNameField)
            Me.Controls.Add(Me._emailField)
            Me.Controls.Add(Me._firstNameField)
            Me.Controls.Add(Me._confirmPasswordField)
            Me.Controls.Add(Me._passwordField)
            Me.Controls.Add(Me._userNameField)
            Me.Controls.Add(Me._roles)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "AdminAddUserView"
            Me.Text = "AdminAddUserView"
            Me.Guna2Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents _label As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents _roles As Guna.UI2.WinForms.Guna2ComboBox
        Friend WithEvents _userNameField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents _passwordField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents _confirmPasswordField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents _firstNameField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents _emailField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents _lastNameField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents _contactNumField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents _cancelButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents _saveButton As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace