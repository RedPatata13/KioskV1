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
            Me.OrderNoLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.YourOrderLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.CustomerReceiptLbl2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.CustomerReceiptLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.OrderPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'OrderNumberLabel
            '
            Me.OrderNumberLabel.BackColor = System.Drawing.Color.Transparent
            Me.OrderNumberLabel.Font = New System.Drawing.Font("Poppins", 120.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OrderNumberLabel.Location = New System.Drawing.Point(137, 60)
            Me.OrderNumberLabel.Name = "OrderNumberLabel"
            Me.OrderNumberLabel.Size = New System.Drawing.Size(160, 284)
            Me.OrderNumberLabel.TabIndex = 2
            Me.OrderNumberLabel.Text = "31"
            '
            'OrderPanel
            '
            Me.OrderPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.OrderPanel.Controls.Add(Me.OrderNumberLabel)
            Me.OrderPanel.Controls.Add(Me.OrderNoLbl)
            Me.OrderPanel.Controls.Add(Me.YourOrderLbl)
            Me.OrderPanel.Location = New System.Drawing.Point(499, 337)
            Me.OrderPanel.Name = "OrderPanel"
            Me.OrderPanel.Size = New System.Drawing.Size(381, 288)
            Me.OrderPanel.TabIndex = 5
            '
            'OrderNoLbl
            '
            Me.OrderNoLbl.BackColor = System.Drawing.Color.Transparent
            Me.OrderNoLbl.Font = New System.Drawing.Font("Poppins", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OrderNoLbl.Location = New System.Drawing.Point(80, 207)
            Me.OrderNoLbl.Name = "OrderNoLbl"
            Me.OrderNoLbl.Size = New System.Drawing.Size(51, 53)
            Me.OrderNoLbl.TabIndex = 1
            Me.OrderNoLbl.Text = "No."
            '
            'YourOrderLbl
            '
            Me.YourOrderLbl.BackColor = System.Drawing.Color.Transparent
            Me.YourOrderLbl.Font = New System.Drawing.Font("Poppins", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.YourOrderLbl.Location = New System.Drawing.Point(107, 26)
            Me.YourOrderLbl.Name = "YourOrderLbl"
            Me.YourOrderLbl.Size = New System.Drawing.Size(163, 53)
            Me.YourOrderLbl.TabIndex = 0
            Me.YourOrderLbl.Text = "Your Order"
            '
            'CustomerReceiptLbl2
            '
            Me.CustomerReceiptLbl2.BackColor = System.Drawing.Color.Transparent
            Me.CustomerReceiptLbl2.Font = New System.Drawing.Font("Poppins SemiBold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CustomerReceiptLbl2.Location = New System.Drawing.Point(474, 153)
            Me.CustomerReceiptLbl2.Name = "CustomerReceiptLbl2"
            Me.CustomerReceiptLbl2.Size = New System.Drawing.Size(429, 86)
            Me.CustomerReceiptLbl2.TabIndex = 4
            Me.CustomerReceiptLbl2.Text = "for your payment"
            '
            'CustomerReceiptLbl
            '
            Me.CustomerReceiptLbl.BackColor = System.Drawing.Color.Transparent
            Me.CustomerReceiptLbl.Font = New System.Drawing.Font("Poppins SemiBold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CustomerReceiptLbl.Location = New System.Drawing.Point(56, 69)
            Me.CustomerReceiptLbl.Name = "CustomerReceiptLbl"
            Me.CustomerReceiptLbl.Size = New System.Drawing.Size(1244, 86)
            Me.CustomerReceiptLbl.TabIndex = 3
            Me.CustomerReceiptLbl.Text = "Please get your receipt and proceed to the counter "
            '
            'CustomerInvoiceUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
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
        Friend WithEvents OrderNoLbl As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents YourOrderLbl As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents CustomerReceiptLbl2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents CustomerReceiptLbl As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace