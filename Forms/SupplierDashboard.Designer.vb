<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SupplierDashboard
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
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ViewModeButton = New Guna.UI2.WinForms.Guna2Button()
        Me.BatchReqCountLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 28.2!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(8, 8)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(219, 61)
        Me.Guna2HtmlLabel1.TabIndex = 10
        Me.Guna2HtmlLabel1.Text = "Dashboard"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(8, 64)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(366, 40)
        Me.Guna2HtmlLabel2.TabIndex = 11
        Me.Guna2HtmlLabel2.Text = "Welcome, Supplier11  - Supplier"
        '
        'ViewModeButton
        '
        Me.ViewModeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ViewModeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ViewModeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ViewModeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ViewModeButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ViewModeButton.ForeColor = System.Drawing.Color.White
        Me.ViewModeButton.Location = New System.Drawing.Point(272, 488)
        Me.ViewModeButton.Name = "ViewModeButton"
        Me.ViewModeButton.Size = New System.Drawing.Size(136, 32)
        Me.ViewModeButton.TabIndex = 15
        Me.ViewModeButton.Text = "View Batch Requests"
        '
        'BatchReqCountLabel
        '
        Me.BatchReqCountLabel.AutoSize = False
        Me.BatchReqCountLabel.AutoSizeHeightOnly = True
        Me.BatchReqCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.BatchReqCountLabel.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchReqCountLabel.Location = New System.Drawing.Point(16, 16)
        Me.BatchReqCountLabel.Margin = New System.Windows.Forms.Padding(2)
        Me.BatchReqCountLabel.Name = "BatchReqCountLabel"
        Me.BatchReqCountLabel.Size = New System.Drawing.Size(296, 51)
        Me.BatchReqCountLabel.TabIndex = 16
        Me.BatchReqCountLabel.Text = "You have 2 Pending requests for a batch of items"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BatchReqCountLabel)
        Me.Guna2Panel1.Controls.Add(Me.ViewModeButton)
        Me.Guna2Panel1.Location = New System.Drawing.Point(408, 208)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(416, 528)
        Me.Guna2Panel1.TabIndex = 17
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Location = New System.Drawing.Point(40, 208)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(348, 528)
        Me.Guna2Panel2.TabIndex = 18
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Location = New System.Drawing.Point(840, 208)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(348, 528)
        Me.Guna2Panel3.TabIndex = 19
        '
        'SupplierDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 839)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SupplierDashboard"
        Me.Text = "SupplierLandingPageView"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ViewModeButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BatchReqCountLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
End Class
