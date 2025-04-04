Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class StaffManagerAuthorizationView
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
            Me.ManagerPasswordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
            Me.CancelButton = New System.Windows.Forms.Button()
            Me.SubmitButton = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 28.0!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(311, 232)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(638, 60)
            Me.Guna2HtmlLabel1.TabIndex = 10
            Me.Guna2HtmlLabel1.Text = "Manager Authorization Required"
            '
            'ManagerPasswordTextBox
            '
            Me.ManagerPasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ManagerPasswordTextBox.BorderRadius = 10
            Me.ManagerPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.ManagerPasswordTextBox.DefaultText = ""
            Me.ManagerPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.ManagerPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ManagerPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.ManagerPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.ManagerPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ManagerPasswordTextBox.Font = New System.Drawing.Font("Poppins", 14.0!)
            Me.ManagerPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ManagerPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ManagerPasswordTextBox.Location = New System.Drawing.Point(193, 354)
            Me.ManagerPasswordTextBox.Margin = New System.Windows.Forms.Padding(5)
            Me.ManagerPasswordTextBox.Name = "ManagerPasswordTextBox"
            Me.ManagerPasswordTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ManagerPasswordTextBox.PlaceholderText = "PIN/Password"
            Me.ManagerPasswordTextBox.SelectedText = ""
            Me.ManagerPasswordTextBox.Size = New System.Drawing.Size(884, 77)
            Me.ManagerPasswordTextBox.TabIndex = 11
            Me.ManagerPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'CancelButton
            '
            Me.CancelButton.FlatAppearance.BorderSize = 0
            Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.CancelButton.Font = New System.Drawing.Font("Poppins", 19.0!)
            Me.CancelButton.Location = New System.Drawing.Point(193, 478)
            Me.CancelButton.Name = "CancelButton"
            Me.CancelButton.Size = New System.Drawing.Size(163, 48)
            Me.CancelButton.TabIndex = 18
            Me.CancelButton.Text = "Cancel"
            Me.CancelButton.UseVisualStyleBackColor = True
            '
            'SubmitButton
            '
            Me.SubmitButton.FlatAppearance.BorderSize = 0
            Me.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.SubmitButton.Font = New System.Drawing.Font("Poppins", 19.0!)
            Me.SubmitButton.Location = New System.Drawing.Point(914, 478)
            Me.SubmitButton.Name = "SubmitButton"
            Me.SubmitButton.Size = New System.Drawing.Size(163, 48)
            Me.SubmitButton.TabIndex = 19
            Me.SubmitButton.Text = "Submit"
            Me.SubmitButton.UseVisualStyleBackColor = True
            '
            'StaffManagerAuthorizationView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1305, 839)
            Me.Controls.Add(Me.SubmitButton)
            Me.Controls.Add(Me.CancelButton)
            Me.Controls.Add(Me.ManagerPasswordTextBox)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "StaffManagerAuthorizationView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = " "
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ManagerPasswordTextBox As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents CancelButton As Button
        Friend WithEvents SubmitButton As Button
    End Class

End Namespace