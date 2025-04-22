Namespace KioskV0.Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class StaffPendingOrdersUserControl
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
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.OrderIdLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ProductNameLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.PendingOrdersFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.CompleteButton = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me.OrderIdLabel)
            Me.Guna2Panel1.Controls.Add(Me.ProductNameLabel)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(310, 55)
            Me.Guna2Panel1.TabIndex = 0
            '
            'OrderIdLabel
            '
            Me.OrderIdLabel.AutoSize = False
            Me.OrderIdLabel.BackColor = System.Drawing.Color.Transparent
            Me.OrderIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
            Me.OrderIdLabel.ForeColor = System.Drawing.Color.White
            Me.OrderIdLabel.Location = New System.Drawing.Point(197, 15)
            Me.OrderIdLabel.Margin = New System.Windows.Forms.Padding(4)
            Me.OrderIdLabel.Name = "OrderIdLabel"
            Me.OrderIdLabel.Size = New System.Drawing.Size(100, 27)
            Me.OrderIdLabel.TabIndex = 2
            Me.OrderIdLabel.Text = "041"
            Me.OrderIdLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            '
            'ProductNameLabel
            '
            Me.ProductNameLabel.AutoSize = False
            Me.ProductNameLabel.BackColor = System.Drawing.Color.Transparent
            Me.ProductNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
            Me.ProductNameLabel.ForeColor = System.Drawing.Color.White
            Me.ProductNameLabel.Location = New System.Drawing.Point(14, 15)
            Me.ProductNameLabel.Margin = New System.Windows.Forms.Padding(4)
            Me.ProductNameLabel.Name = "ProductNameLabel"
            Me.ProductNameLabel.Size = New System.Drawing.Size(60, 27)
            Me.ProductNameLabel.TabIndex = 1
            Me.ProductNameLabel.Text = "Paid"
            '
            'PendingOrdersFlowLayoutPanel
            '
            Me.PendingOrdersFlowLayoutPanel.AutoSize = True
            Me.PendingOrdersFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.PendingOrdersFlowLayoutPanel.Location = New System.Drawing.Point(3, 56)
            Me.PendingOrdersFlowLayoutPanel.Name = "PendingOrdersFlowLayoutPanel"
            Me.PendingOrdersFlowLayoutPanel.Size = New System.Drawing.Size(304, 100)
            Me.PendingOrdersFlowLayoutPanel.TabIndex = 1
            Me.PendingOrdersFlowLayoutPanel.WrapContents = False
            '
            'CompleteButton
            '
            Me.CompleteButton.BorderRadius = 10
            Me.CompleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.CompleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.CompleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.CompleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.CompleteButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.CompleteButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CompleteButton.ForeColor = System.Drawing.Color.White
            Me.CompleteButton.Location = New System.Drawing.Point(62, 162)
            Me.CompleteButton.Name = "CompleteButton"
            Me.CompleteButton.Size = New System.Drawing.Size(180, 45)
            Me.CompleteButton.TabIndex = 2
            Me.CompleteButton.Text = "Complete"
            '
            'StaffPendingOrdersUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.Controls.Add(Me.CompleteButton)
            Me.Controls.Add(Me.PendingOrdersFlowLayoutPanel)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Name = "StaffPendingOrdersUserControl"
            Me.Size = New System.Drawing.Size(310, 210)
            Me.Guna2Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents OrderIdLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ProductNameLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PendingOrdersFlowLayoutPanel As FlowLayoutPanel
        Friend WithEvents CompleteButton As Guna.UI2.WinForms.Guna2Button
    End Class
End Namespace
