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
            Me.OrderNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.OrderPanel = New System.Windows.Forms.Panel()
            Me.OrderNoLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.YourOrderLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.CustomerReceiptLbl2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.CustomerReceiptLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
            Me.PrintOrderNumberButton = New Guna.UI2.WinForms.Guna2Button()
            Me.OrderPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'OrderNumber
            '
            Me.OrderNumber.BackColor = System.Drawing.Color.Transparent
            Me.OrderNumber.Font = New System.Drawing.Font("Poppins", 120.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OrderNumber.Location = New System.Drawing.Point(101, 52)
            Me.OrderNumber.Name = "OrderNumber"
            Me.OrderNumber.Size = New System.Drawing.Size(211, 284)
            Me.OrderNumber.TabIndex = 2
            Me.OrderNumber.Text = "00"
            '
            'OrderPanel
            '
            Me.OrderPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.OrderPanel.Controls.Add(Me.OrderNumber)
            Me.OrderPanel.Controls.Add(Me.OrderNoLbl)
            Me.OrderPanel.Controls.Add(Me.YourOrderLbl)
            Me.OrderPanel.Location = New System.Drawing.Point(725, 444)
            Me.OrderPanel.Name = "OrderPanel"
            Me.OrderPanel.Size = New System.Drawing.Size(388, 288)
            Me.OrderPanel.TabIndex = 5
            '
            'OrderNoLbl
            '
            Me.OrderNoLbl.BackColor = System.Drawing.Color.Transparent
            Me.OrderNoLbl.Font = New System.Drawing.Font("Poppins", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OrderNoLbl.Location = New System.Drawing.Point(44, 198)
            Me.OrderNoLbl.Name = "OrderNoLbl"
            Me.OrderNoLbl.Size = New System.Drawing.Size(51, 53)
            Me.OrderNoLbl.TabIndex = 1
            Me.OrderNoLbl.Text = "No."
            '
            'YourOrderLbl
            '
            Me.YourOrderLbl.BackColor = System.Drawing.Color.Transparent
            Me.YourOrderLbl.Font = New System.Drawing.Font("Poppins", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.YourOrderLbl.Location = New System.Drawing.Point(118, 18)
            Me.YourOrderLbl.Name = "YourOrderLbl"
            Me.YourOrderLbl.Size = New System.Drawing.Size(163, 53)
            Me.YourOrderLbl.TabIndex = 0
            Me.YourOrderLbl.Text = "Your Order"
            '
            'CustomerReceiptLbl2
            '
            Me.CustomerReceiptLbl2.BackColor = System.Drawing.Color.Transparent
            Me.CustomerReceiptLbl2.Font = New System.Drawing.Font("Poppins SemiBold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CustomerReceiptLbl2.Location = New System.Drawing.Point(713, 235)
            Me.CustomerReceiptLbl2.Name = "CustomerReceiptLbl2"
            Me.CustomerReceiptLbl2.Size = New System.Drawing.Size(429, 86)
            Me.CustomerReceiptLbl2.TabIndex = 4
            Me.CustomerReceiptLbl2.Text = "for your payment"
            '
            'CustomerReceiptLbl
            '
            Me.CustomerReceiptLbl.BackColor = System.Drawing.Color.Transparent
            Me.CustomerReceiptLbl.Font = New System.Drawing.Font("Poppins SemiBold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CustomerReceiptLbl.Location = New System.Drawing.Point(295, 151)
            Me.CustomerReceiptLbl.Name = "CustomerReceiptLbl"
            Me.CustomerReceiptLbl.Size = New System.Drawing.Size(1244, 86)
            Me.CustomerReceiptLbl.TabIndex = 3
            Me.CustomerReceiptLbl.Text = "Please get your receipt and proceed to the counter "
            '
            'PrintDoc
            '
            '
            'PrintOrderNumberButton
            '
            Me.PrintOrderNumberButton.BorderColor = System.Drawing.Color.LightGray
            Me.PrintOrderNumberButton.BorderThickness = 1
            Me.PrintOrderNumberButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.PrintOrderNumberButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.PrintOrderNumberButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.PrintOrderNumberButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.PrintOrderNumberButton.FillColor = System.Drawing.Color.Transparent
            Me.PrintOrderNumberButton.Font = New System.Drawing.Font("Poppins", 9.0!)
            Me.PrintOrderNumberButton.ForeColor = System.Drawing.Color.DimGray
            Me.PrintOrderNumberButton.Location = New System.Drawing.Point(725, 738)
            Me.PrintOrderNumberButton.Name = "PrintOrderNumberButton"
            Me.PrintOrderNumberButton.PressedColor = System.Drawing.SystemColors.ControlDark
            Me.PrintOrderNumberButton.Size = New System.Drawing.Size(388, 30)
            Me.PrintOrderNumberButton.TabIndex = 6
            Me.PrintOrderNumberButton.Text = "Print"
            Me.PrintOrderNumberButton.TextOffset = New System.Drawing.Point(0, 2)
            '
            'CustomerInvoiceUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.Controls.Add(Me.PrintOrderNumberButton)
            Me.Controls.Add(Me.OrderPanel)
            Me.Controls.Add(Me.CustomerReceiptLbl2)
            Me.Controls.Add(Me.CustomerReceiptLbl)
            Me.Name = "CustomerInvoiceUserControl"
            Me.Size = New System.Drawing.Size(1920, 1080)
            Me.OrderPanel.ResumeLayout(False)
            Me.OrderPanel.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents OrderNumber As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents OrderPanel As Panel
        Friend WithEvents OrderNoLbl As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents YourOrderLbl As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents CustomerReceiptLbl2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents CustomerReceiptLbl As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PrintDoc As Printing.PrintDocument
        Friend WithEvents PrintOrderNumberButton As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace