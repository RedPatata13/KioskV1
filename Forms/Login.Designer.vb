Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class Login
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
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.SubmitButton = New Guna.UI2.WinForms.Guna2Button()
            Me.PasswordField = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.UIDField = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Guna2Button1)
            Me.Panel1.Controls.Add(Me.SubmitButton)
            Me.Panel1.Controls.Add(Me.PasswordField)
            Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Panel1.Controls.Add(Me.UIDField)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(876, 0)
            Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1044, 1080)
            Me.Panel1.TabIndex = 0
            '
            'SubmitButton
            '
            Me.SubmitButton.BackColor = System.Drawing.Color.Transparent
            Me.SubmitButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SubmitButton.BorderRadius = 15
            Me.SubmitButton.BorderThickness = 1
            Me.SubmitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.SubmitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.SubmitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.SubmitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.SubmitButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SubmitButton.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SubmitButton.ForeColor = System.Drawing.Color.White
            Me.SubmitButton.Location = New System.Drawing.Point(418, 626)
            Me.SubmitButton.Margin = New System.Windows.Forms.Padding(4)
            Me.SubmitButton.Name = "SubmitButton"
            Me.SubmitButton.ShadowDecoration.BorderRadius = 25
            Me.SubmitButton.ShadowDecoration.Depth = 25
            Me.SubmitButton.ShadowDecoration.Enabled = True
            Me.SubmitButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
            Me.SubmitButton.Size = New System.Drawing.Size(288, 74)
            Me.SubmitButton.TabIndex = 3
            Me.SubmitButton.Text = "Submit"
            '
            'PasswordField
            '
            Me.PasswordField.BackColor = System.Drawing.Color.Transparent
            Me.PasswordField.BorderRadius = 15
            Me.PasswordField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.PasswordField.DefaultText = ""
            Me.PasswordField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.PasswordField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.PasswordField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.PasswordField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.PasswordField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.PasswordField.Font = New System.Drawing.Font("Poppins", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PasswordField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.PasswordField.Location = New System.Drawing.Point(240, 470)
            Me.PasswordField.Margin = New System.Windows.Forms.Padding(5)
            Me.PasswordField.Name = "PasswordField"
            Me.PasswordField.PlaceholderText = "Password"
            Me.PasswordField.SelectedText = ""
            Me.PasswordField.ShadowDecoration.BorderRadius = 25
            Me.PasswordField.ShadowDecoration.Depth = 25
            Me.PasswordField.ShadowDecoration.Enabled = True
            Me.PasswordField.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
            Me.PasswordField.Size = New System.Drawing.Size(628, 74)
            Me.PasswordField.TabIndex = 2
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.AutoSize = False
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(228, 179)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(4)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(640, 127)
            Me.Guna2HtmlLabel1.TabIndex = 1
            Me.Guna2HtmlLabel1.Text = "Log-in"
            Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter
            '
            'UIDField
            '
            Me.UIDField.BackColor = System.Drawing.Color.Transparent
            Me.UIDField.BorderRadius = 15
            Me.UIDField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.UIDField.DefaultText = ""
            Me.UIDField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.UIDField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.UIDField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.UIDField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.UIDField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.UIDField.Font = New System.Drawing.Font("Poppins", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UIDField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.UIDField.Location = New System.Drawing.Point(240, 367)
            Me.UIDField.Margin = New System.Windows.Forms.Padding(5)
            Me.UIDField.Name = "UIDField"
            Me.UIDField.PlaceholderText = "Username"
            Me.UIDField.SelectedText = ""
            Me.UIDField.ShadowDecoration.BorderRadius = 25
            Me.UIDField.ShadowDecoration.Depth = 25
            Me.UIDField.ShadowDecoration.Enabled = True
            Me.UIDField.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
            Me.UIDField.Size = New System.Drawing.Size(628, 74)
            Me.UIDField.TabIndex = 0
            '
            'Guna2Button1
            '
            Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
            Me.Guna2Button1.Font = New System.Drawing.Font("Poppins", 13.8!)
            Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2Button1.Location = New System.Drawing.Point(327, 723)
            Me.Guna2Button1.Name = "Guna2Button1"
            Me.Guna2Button1.Size = New System.Drawing.Size(449, 45)
            Me.Guna2Button1.TabIndex = 4
            Me.Guna2Button1.Text = "Log in as Customer"
            '
            'Login
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1920, 1080)
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Login"
            Me.Text = "Login"
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents UIDField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PasswordField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents SubmitButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace