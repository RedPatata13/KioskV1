Namespace KioskV0.Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SupplierAcceptRequestView
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
            Me.RequestLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
            Me.AcceptOrderButton = New Guna.UI2.WinForms.Guna2Button()
            Me.DeclineButton = New Guna.UI2.WinForms.Guna2Button()
            Me.BlackLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
            Me.SuspendLayout()
            '
            'RequestLabel
            '
            Me.RequestLabel.BackColor = System.Drawing.Color.Transparent
            Me.RequestLabel.Font = New System.Drawing.Font("Montserrat", 28.2!, System.Drawing.FontStyle.Bold)
            Me.RequestLabel.Location = New System.Drawing.Point(21, 19)
            Me.RequestLabel.Margin = New System.Windows.Forms.Padding(2)
            Me.RequestLabel.Name = "RequestLabel"
            Me.RequestLabel.Size = New System.Drawing.Size(324, 61)
            Me.RequestLabel.TabIndex = 8
            Me.RequestLabel.Text = "Request 000001"
            '
            'Guna2DateTimePicker1
            '
            Me.Guna2DateTimePicker1.Checked = True
            Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.Transparent
            Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
            Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(51, 111)
            Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
            Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
            Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
            Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(230, 30)
            Me.Guna2DateTimePicker1.TabIndex = 9
            Me.Guna2DateTimePicker1.Value = New Date(2025, 3, 29, 9, 25, 26, 96)
            '
            'AcceptOrderButton
            '
            Me.AcceptOrderButton.BackColor = System.Drawing.Color.Transparent
            Me.AcceptOrderButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AcceptOrderButton.BorderRadius = 15
            Me.AcceptOrderButton.BorderThickness = 1
            Me.AcceptOrderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.AcceptOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.AcceptOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.AcceptOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.AcceptOrderButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AcceptOrderButton.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AcceptOrderButton.ForeColor = System.Drawing.Color.White
            Me.AcceptOrderButton.Location = New System.Drawing.Point(1073, 803)
            Me.AcceptOrderButton.Name = "AcceptOrderButton"
            Me.AcceptOrderButton.ShadowDecoration.BorderRadius = 25
            Me.AcceptOrderButton.ShadowDecoration.Depth = 25
            Me.AcceptOrderButton.ShadowDecoration.Enabled = True
            Me.AcceptOrderButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
            Me.AcceptOrderButton.Size = New System.Drawing.Size(189, 51)
            Me.AcceptOrderButton.TabIndex = 11
            Me.AcceptOrderButton.Text = "Accept Order"
            '
            'DeclineButton
            '
            Me.DeclineButton.BackColor = System.Drawing.Color.Transparent
            Me.DeclineButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DeclineButton.BorderRadius = 15
            Me.DeclineButton.BorderThickness = 1
            Me.DeclineButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.DeclineButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.DeclineButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.DeclineButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.DeclineButton.FillColor = System.Drawing.Color.White
            Me.DeclineButton.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DeclineButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DeclineButton.Location = New System.Drawing.Point(856, 803)
            Me.DeclineButton.Name = "DeclineButton"
            Me.DeclineButton.ShadowDecoration.BorderRadius = 25
            Me.DeclineButton.ShadowDecoration.Depth = 25
            Me.DeclineButton.ShadowDecoration.Enabled = True
            Me.DeclineButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
            Me.DeclineButton.Size = New System.Drawing.Size(189, 51)
            Me.DeclineButton.TabIndex = 12
            Me.DeclineButton.Text = "Decline"
            '
            'BlackLabel
            '
            Me.BlackLabel.BackColor = System.Drawing.Color.Transparent
            Me.BlackLabel.Font = New System.Drawing.Font("Poppins", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BlackLabel.Location = New System.Drawing.Point(51, 816)
            Me.BlackLabel.Margin = New System.Windows.Forms.Padding(2)
            Me.BlackLabel.Name = "BlackLabel"
            Me.BlackLabel.Size = New System.Drawing.Size(51, 38)
            Me.BlackLabel.TabIndex = 13
            Me.BlackLabel.Text = "Back"
            '
            'Guna2Panel2
            '
            Me.Guna2Panel2.BackColor = System.Drawing.Color.White
            Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
            Me.Guna2Panel2.BorderThickness = 1
            Me.Guna2Panel2.FillColor = System.Drawing.Color.White
            Me.Guna2Panel2.Location = New System.Drawing.Point(51, 169)
            Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2Panel2.Name = "Guna2Panel2"
            Me.Guna2Panel2.Size = New System.Drawing.Size(1188, 608)
            Me.Guna2Panel2.TabIndex = 17
            '
            'SupplierAcceptRequestView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1321, 878)
            Me.Controls.Add(Me.Guna2Panel2)
            Me.Controls.Add(Me.BlackLabel)
            Me.Controls.Add(Me.DeclineButton)
            Me.Controls.Add(Me.AcceptOrderButton)
            Me.Controls.Add(Me.Guna2DateTimePicker1)
            Me.Controls.Add(Me.RequestLabel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "SupplierAcceptRequestView"
            Me.Text = "SupplierFormView"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents RequestLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
        Friend WithEvents AcceptOrderButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents DeclineButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents BlackLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    End Class

End Namespace