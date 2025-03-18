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
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.SubmitButton = New Guna.UI2.WinForms.Guna2Button()
            Me.PasswordField = New Guna.UI2.WinForms.Guna2TextBox()
            Me.UIDField = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me.SubmitButton)
            Me.Guna2Panel1.Controls.Add(Me.PasswordField)
            Me.Guna2Panel1.Controls.Add(Me.UIDField)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Guna2Panel1.Location = New System.Drawing.Point(1224, 0)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.ShadowDecoration.CustomizableEdges.BottomRight = False
            Me.Guna2Panel1.ShadowDecoration.CustomizableEdges.TopLeft = False
            Me.Guna2Panel1.Size = New System.Drawing.Size(696, 1080)
            Me.Guna2Panel1.TabIndex = 4
            '
            'SubmitButton
            '
            Me.SubmitButton.BackColor = System.Drawing.Color.Transparent
            Me.SubmitButton.BorderColor = System.Drawing.Color.Transparent
            Me.SubmitButton.BorderRadius = 18
            Me.SubmitButton.BorderThickness = 1
            Me.SubmitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.SubmitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.SubmitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.SubmitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.SubmitButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SubmitButton.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SubmitButton.ForeColor = System.Drawing.Color.White
            Me.SubmitButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SubmitButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.SubmitButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SubmitButton.Location = New System.Drawing.Point(83, 648)
            Me.SubmitButton.Name = "SubmitButton"
            Me.SubmitButton.ShadowDecoration.BorderRadius = 28
            Me.SubmitButton.ShadowDecoration.Color = System.Drawing.Color.Silver
            Me.SubmitButton.ShadowDecoration.Depth = 40
            Me.SubmitButton.ShadowDecoration.Enabled = True
            Me.SubmitButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 13, 15)
            Me.SubmitButton.Size = New System.Drawing.Size(460, 67)
            Me.SubmitButton.TabIndex = 2
            Me.SubmitButton.Text = "Log in"
            '
            'PasswordField
            '
            Me.PasswordField.BackColor = System.Drawing.Color.Transparent
            Me.PasswordField.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.PasswordField.BorderRadius = 18
            Me.PasswordField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.PasswordField.DefaultText = ""
            Me.PasswordField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.PasswordField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.PasswordField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.PasswordField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.PasswordField.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.PasswordField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.PasswordField.Font = New System.Drawing.Font("Meiryo UI", 9.0!)
            Me.PasswordField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.PasswordField.Location = New System.Drawing.Point(83, 547)
            Me.PasswordField.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.PasswordField.Name = "PasswordField"
            Me.PasswordField.PlaceholderText = "Enter Password"
            Me.PasswordField.SelectedText = ""
            Me.PasswordField.ShadowDecoration.BorderRadius = 28
            Me.PasswordField.ShadowDecoration.Color = System.Drawing.Color.Silver
            Me.PasswordField.ShadowDecoration.Depth = 40
            Me.PasswordField.ShadowDecoration.Enabled = True
            Me.PasswordField.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 13, 15)
            Me.PasswordField.Size = New System.Drawing.Size(460, 67)
            Me.PasswordField.TabIndex = 1
            '
            'UIDField
            '
            Me.UIDField.BackColor = System.Drawing.Color.Transparent
            Me.UIDField.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.UIDField.BorderRadius = 18
            Me.UIDField.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.UIDField.DefaultText = ""
            Me.UIDField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.UIDField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.UIDField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.UIDField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.UIDField.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.UIDField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.UIDField.Font = New System.Drawing.Font("Meiryo UI", 9.0!)
            Me.UIDField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.UIDField.Location = New System.Drawing.Point(83, 454)
            Me.UIDField.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.UIDField.Name = "UIDField"
            Me.UIDField.PlaceholderText = "Enter Username"
            Me.UIDField.SelectedText = ""
            Me.UIDField.ShadowDecoration.BorderRadius = 28
            Me.UIDField.ShadowDecoration.Color = System.Drawing.Color.Silver
            Me.UIDField.ShadowDecoration.Depth = 40
            Me.UIDField.ShadowDecoration.Enabled = True
            Me.UIDField.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 13, 15)
            Me.UIDField.Size = New System.Drawing.Size(460, 67)
            Me.UIDField.TabIndex = 0
            '
            'Login
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1920, 1080)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "Login"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Login"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Guna2Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents UIDField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents SubmitButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents PasswordField As Guna.UI2.WinForms.Guna2TextBox
    End Class

End Namespace