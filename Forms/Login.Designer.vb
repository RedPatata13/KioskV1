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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.SubmitButton = New Guna.UI2.WinForms.Guna2Button()
            Me.PasswordField = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.UIDField = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2PictureBox11 = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.Guna2ContainerControl19 = New Guna.UI2.WinForms.Guna2ContainerControl()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            CType(Me.Guna2PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Guna2ContainerControl19.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Label25)
            Me.Panel1.Controls.Add(Me.Label26)
            Me.Panel1.Controls.Add(Me.Guna2ContainerControl19)
            Me.Panel1.Controls.Add(Me.Guna2TextBox1)
            Me.Panel1.Controls.Add(Me.SubmitButton)
            Me.Panel1.Controls.Add(Me.PasswordField)
            Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Panel1.Controls.Add(Me.UIDField)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(257, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(783, 640)
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
            Me.SubmitButton.Location = New System.Drawing.Point(297, 667)
            Me.SubmitButton.Name = "SubmitButton"
            Me.SubmitButton.ShadowDecoration.BorderRadius = 25
            Me.SubmitButton.ShadowDecoration.Depth = 25
            Me.SubmitButton.ShadowDecoration.Enabled = True
            Me.SubmitButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
            Me.SubmitButton.Size = New System.Drawing.Size(216, 60)
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
            Me.PasswordField.Location = New System.Drawing.Point(180, 550)
            Me.PasswordField.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.PasswordField.Name = "PasswordField"
            Me.PasswordField.PlaceholderText = "Password"
            Me.PasswordField.SelectedText = ""
            Me.PasswordField.ShadowDecoration.BorderRadius = 25
            Me.PasswordField.ShadowDecoration.Depth = 25
            Me.PasswordField.ShadowDecoration.Enabled = True
            Me.PasswordField.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
            Me.PasswordField.Size = New System.Drawing.Size(471, 60)
            Me.PasswordField.TabIndex = 2
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(296, 331)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(217, 102)
            Me.Guna2HtmlLabel1.TabIndex = 1
            Me.Guna2HtmlLabel1.Text = "Log-in"
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
            Me.UIDField.Location = New System.Drawing.Point(180, 462)
            Me.UIDField.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.UIDField.Name = "UIDField"
            Me.UIDField.PlaceholderText = "Username"
            Me.UIDField.SelectedText = ""
            Me.UIDField.ShadowDecoration.BorderRadius = 25
            Me.UIDField.ShadowDecoration.Depth = 25
            Me.UIDField.ShadowDecoration.Enabled = True
            Me.UIDField.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
            Me.UIDField.Size = New System.Drawing.Size(471, 60)
            Me.UIDField.TabIndex = 0
            '
            'Guna2TextBox1
            '
            Me.Guna2TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
            Me.Guna2TextBox1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.Guna2TextBox1.BorderRadius = 15
            Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.Guna2TextBox1.DefaultText = ""
            Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Guna2TextBox1.Font = New System.Drawing.Font("Poppins", 21.75!)
            Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2TextBox1.Location = New System.Drawing.Point(29, 22)
            Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4)
            Me.Guna2TextBox1.Name = "Guna2TextBox1"
            Me.Guna2TextBox1.PlaceholderText = ""
            Me.Guna2TextBox1.SelectedText = ""
            Me.Guna2TextBox1.ShadowDecoration.BorderRadius = 25
            Me.Guna2TextBox1.ShadowDecoration.Depth = 25
            Me.Guna2TextBox1.ShadowDecoration.Enabled = True
            Me.Guna2TextBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
            Me.Guna2TextBox1.Size = New System.Drawing.Size(278, 269)
            Me.Guna2TextBox1.TabIndex = 4
            '
            'Guna2PictureBox11
            '
            Me.Guna2PictureBox11.BackColor = System.Drawing.Color.Transparent
            Me.Guna2PictureBox11.BorderRadius = 20
            Me.Guna2PictureBox11.Image = CType(resources.GetObject("Guna2PictureBox11.Image"), System.Drawing.Image)
            Me.Guna2PictureBox11.ImageRotate = 0!
            Me.Guna2PictureBox11.Location = New System.Drawing.Point(14, 11)
            Me.Guna2PictureBox11.Name = "Guna2PictureBox11"
            Me.Guna2PictureBox11.Size = New System.Drawing.Size(208, 151)
            Me.Guna2PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.Guna2PictureBox11.TabIndex = 21
            Me.Guna2PictureBox11.TabStop = False
            '
            'Guna2ContainerControl19
            '
            Me.Guna2ContainerControl19.BackColor = System.Drawing.Color.Transparent
            Me.Guna2ContainerControl19.BorderColor = System.Drawing.Color.Black
            Me.Guna2ContainerControl19.BorderRadius = 20
            Me.Guna2ContainerControl19.BorderThickness = 1
            Me.Guna2ContainerControl19.Controls.Add(Me.Guna2PictureBox11)
            Me.Guna2ContainerControl19.FillColor = System.Drawing.Color.Black
            Me.Guna2ContainerControl19.Location = New System.Drawing.Point(52, 44)
            Me.Guna2ContainerControl19.Name = "Guna2ContainerControl19"
            Me.Guna2ContainerControl19.Size = New System.Drawing.Size(236, 173)
            Me.Guna2ContainerControl19.TabIndex = 27
            Me.Guna2ContainerControl19.Text = "Guna2ContainerControl19"
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Font = New System.Drawing.Font("Roboto Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.Location = New System.Drawing.Point(136, 260)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(64, 18)
            Me.Label25.TabIndex = 30
            Me.Label25.Text = "P299.00"
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label26.Location = New System.Drawing.Point(110, 227)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(129, 34)
            Me.Label26.TabIndex = 29
            Me.Label26.Text = "Inferno Bite"
            '
            'Login
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1040, 640)
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "Login"
            Me.Text = "Login"
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            CType(Me.Guna2PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Guna2ContainerControl19.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents UIDField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PasswordField As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents SubmitButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2ContainerControl19 As Guna.UI2.WinForms.Guna2ContainerControl
        Friend WithEvents Guna2PictureBox11 As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents Label25 As Label
        Friend WithEvents Label26 As Label
    End Class

End Namespace