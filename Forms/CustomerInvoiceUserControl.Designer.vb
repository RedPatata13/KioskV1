Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CustomerInvoiceUserControl
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
            Me.OrderNumberLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.OrderPanel = New System.Windows.Forms.Panel()
            Me.YourOrderLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.CustomerReceiptLbl2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.CustomerReceiptLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.PayButton = New Guna.UI2.WinForms.Guna2Button()
            Me.OrderPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'OrderNumberLabel
            '
            Me.OrderNumberLabel.AutoSize = False
            Me.OrderNumberLabel.BackColor = System.Drawing.Color.Transparent
            Me.OrderNumberLabel.Font = New System.Drawing.Font("Poppins", 140.0!, System.Drawing.FontStyle.Bold)
            Me.OrderNumberLabel.Location = New System.Drawing.Point(220, 77)
            Me.OrderNumberLabel.Name = "OrderNumberLabel"
            Me.OrderNumberLabel.Size = New System.Drawing.Size(208, 252)
            Me.OrderNumberLabel.TabIndex = 2
            Me.OrderNumberLabel.Text = "31"
            Me.OrderNumberLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            '
            'OrderPanel
            '
            Me.OrderPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.OrderPanel.Controls.Add(Me.YourOrderLbl)
            Me.OrderPanel.Controls.Add(Me.Guna2HtmlLabel1)
            Me.OrderPanel.Controls.Add(Me.OrderNumberLabel)
            Me.OrderPanel.Location = New System.Drawing.Point(416, 238)
            Me.OrderPanel.Name = "OrderPanel"
            Me.OrderPanel.Size = New System.Drawing.Size(550, 336)
            Me.OrderPanel.TabIndex = 5
            '
            'YourOrderLbl
            '
            Me.YourOrderLbl.BackColor = System.Drawing.Color.Transparent
            Me.YourOrderLbl.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Bold)
            Me.YourOrderLbl.Location = New System.Drawing.Point(130, 3)
            Me.YourOrderLbl.Name = "YourOrderLbl"
            Me.YourOrderLbl.Size = New System.Drawing.Size(272, 86)
            Me.YourOrderLbl.TabIndex = 0
            Me.YourOrderLbl.Text = "Your Order"
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(79, 209)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(84, 86)
            Me.Guna2HtmlLabel1.TabIndex = 3
            Me.Guna2HtmlLabel1.Text = "No."
            '
            'CustomerReceiptLbl2
            '
            Me.CustomerReceiptLbl2.BackColor = System.Drawing.Color.Transparent
            Me.CustomerReceiptLbl2.Font = New System.Drawing.Font("Poppins SemiBold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CustomerReceiptLbl2.Location = New System.Drawing.Point(470, 129)
            Me.CustomerReceiptLbl2.Name = "CustomerReceiptLbl2"
            Me.CustomerReceiptLbl2.Size = New System.Drawing.Size(429, 86)
            Me.CustomerReceiptLbl2.TabIndex = 4
            Me.CustomerReceiptLbl2.Text = "for your payment"
            '
            'CustomerReceiptLbl
            '
            Me.CustomerReceiptLbl.BackColor = System.Drawing.Color.Transparent
            Me.CustomerReceiptLbl.Font = New System.Drawing.Font("Poppins SemiBold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CustomerReceiptLbl.Location = New System.Drawing.Point(54, 37)
            Me.CustomerReceiptLbl.Name = "CustomerReceiptLbl"
            Me.CustomerReceiptLbl.Size = New System.Drawing.Size(1244, 86)
            Me.CustomerReceiptLbl.TabIndex = 3
            Me.CustomerReceiptLbl.Text = "Please get your receipt and proceed to the counter "
            '
            'PayButton
            '
            Me.PayButton.BackColor = System.Drawing.Color.Transparent
            Me.PayButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.PayButton.BorderRadius = 10
            Me.PayButton.BorderThickness = 1
            Me.PayButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.PayButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.PayButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.PayButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.PayButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.PayButton.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PayButton.ForeColor = System.Drawing.Color.Black
            Me.PayButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.PayButton.Location = New System.Drawing.Point(416, 623)
            Me.PayButton.Name = "PayButton"
            Me.PayButton.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.PayButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.PayButton.ShadowDecoration.Enabled = True
            Me.PayButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
            Me.PayButton.Size = New System.Drawing.Size(545, 76)
            Me.PayButton.TabIndex = 12
            Me.PayButton.Text = "Done"
            Me.PayButton.TextOffset = New System.Drawing.Point(0, 2)
            '
            'CustomerInvoiceUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.Controls.Add(Me.PayButton)
            Me.Controls.Add(Me.OrderPanel)
            Me.Controls.Add(Me.CustomerReceiptLbl2)
            Me.Controls.Add(Me.CustomerReceiptLbl)
            Me.Name = "CustomerInvoiceUserControl"
            Me.Size = New System.Drawing.Size(1370, 749)
            Me.OrderPanel.ResumeLayout(False)
            Me.OrderPanel.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents OrderNumberLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents OrderPanel As Panel
        Friend WithEvents YourOrderLbl As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents CustomerReceiptLbl2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents CustomerReceiptLbl As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PayButton As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace