Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CustomerNoItemUserControl
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
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.OrderMoreButton = New Guna.UI2.WinForms.Guna2Button()
            Me.SuspendLayout()
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins SemiBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(250, 160)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(504, 58)
            Me.Guna2HtmlLabel1.TabIndex = 0
            Me.Guna2HtmlLabel1.Text = "You have no items in your cart."
            '
            'OrderMoreButton
            '
            Me.OrderMoreButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.OrderMoreButton.BorderRadius = 15
            Me.OrderMoreButton.BorderThickness = 1
            Me.OrderMoreButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.OrderMoreButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.OrderMoreButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.OrderMoreButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.OrderMoreButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.OrderMoreButton.Font = New System.Drawing.Font("Poppins Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OrderMoreButton.ForeColor = System.Drawing.Color.White
            Me.OrderMoreButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.OrderMoreButton.HoverState.FillColor = System.Drawing.Color.White
            Me.OrderMoreButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.OrderMoreButton.Location = New System.Drawing.Point(352, 247)
            Me.OrderMoreButton.Margin = New System.Windows.Forms.Padding(2)
            Me.OrderMoreButton.Name = "OrderMoreButton"
            Me.OrderMoreButton.Size = New System.Drawing.Size(282, 50)
            Me.OrderMoreButton.TabIndex = 22
            Me.OrderMoreButton.Text = "Order more"
            '
            'CustomerNoItemUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.Controls.Add(Me.OrderMoreButton)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Name = "CustomerNoItemUserControl"
            Me.Size = New System.Drawing.Size(963, 462)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents OrderMoreButton As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace