Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CustomerViewOrderUserControl
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
            Me.Panel = New Guna.UI2.WinForms.Guna2Panel()
            Me.ViewOrderButton = New Guna.UI2.WinForms.Guna2Button()
            Me.StartOverButton = New Guna.UI2.WinForms.Guna2Button()
            Me.TotalPriceButton = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ItemCountLabel = New System.Windows.Forms.Label()
            Me.Panel.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel
            '
            Me.Panel.BackColor = System.Drawing.Color.Transparent
            Me.Panel.BorderColor = System.Drawing.SystemColors.ControlText
            Me.Panel.BorderRadius = 15
            Me.Panel.Controls.Add(Me.ItemCountLabel)
            Me.Panel.Controls.Add(Me.TotalPriceButton)
            Me.Panel.Controls.Add(Me.StartOverButton)
            Me.Panel.Controls.Add(Me.ViewOrderButton)
            Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel.FillColor = System.Drawing.Color.WhiteSmoke
            Me.Panel.Location = New System.Drawing.Point(0, 0)
            Me.Panel.Name = "Panel"
            Me.Panel.Size = New System.Drawing.Size(1249, 175)
            Me.Panel.TabIndex = 0
            '
            'ViewOrderButton
            '
            Me.ViewOrderButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.ViewOrderButton.BorderRadius = 15
            Me.ViewOrderButton.BorderThickness = 1
            Me.ViewOrderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.ViewOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.ViewOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.ViewOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.ViewOrderButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.ViewOrderButton.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ViewOrderButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.ViewOrderButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.ViewOrderButton.HoverState.FillColor = System.Drawing.Color.White
            Me.ViewOrderButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.ViewOrderButton.Location = New System.Drawing.Point(864, 24)
            Me.ViewOrderButton.Margin = New System.Windows.Forms.Padding(2)
            Me.ViewOrderButton.Name = "ViewOrderButton"
            Me.ViewOrderButton.Size = New System.Drawing.Size(318, 50)
            Me.ViewOrderButton.TabIndex = 21
            Me.ViewOrderButton.Text = "View Order"
            '
            'StartOverButton
            '
            Me.StartOverButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.StartOverButton.BorderRadius = 15
            Me.StartOverButton.BorderThickness = 1
            Me.StartOverButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.StartOverButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.StartOverButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.StartOverButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.StartOverButton.FillColor = System.Drawing.Color.White
            Me.StartOverButton.Font = New System.Drawing.Font("Poppins SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.StartOverButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.StartOverButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.StartOverButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.StartOverButton.HoverState.ForeColor = System.Drawing.Color.White
            Me.StartOverButton.Location = New System.Drawing.Point(864, 91)
            Me.StartOverButton.Margin = New System.Windows.Forms.Padding(2)
            Me.StartOverButton.Name = "StartOverButton"
            Me.StartOverButton.Size = New System.Drawing.Size(318, 50)
            Me.StartOverButton.TabIndex = 21
            Me.StartOverButton.Text = "Start over"
            '
            'TotalPriceButton
            '
            Me.TotalPriceButton.AutoSize = False
            Me.TotalPriceButton.BackColor = System.Drawing.Color.Transparent
            Me.TotalPriceButton.Font = New System.Drawing.Font("Poppins Medium", 45.0!, System.Drawing.FontStyle.Bold)
            Me.TotalPriceButton.Location = New System.Drawing.Point(47, 8)
            Me.TotalPriceButton.Name = "TotalPriceButton"
            Me.TotalPriceButton.Size = New System.Drawing.Size(429, 98)
            Me.TotalPriceButton.TabIndex = 23
            Me.TotalPriceButton.Text = "P100.00"
            '
            'ItemCountLabel
            '
            Me.ItemCountLabel.AutoSize = True
            Me.ItemCountLabel.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ItemCountLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.ItemCountLabel.Location = New System.Drawing.Point(53, 109)
            Me.ItemCountLabel.Name = "ItemCountLabel"
            Me.ItemCountLabel.Size = New System.Drawing.Size(211, 48)
            Me.ItemCountLabel.TabIndex = 25
            Me.ItemCountLabel.Text = "3 items in cart"
            '
            'CustomerViewOrderUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.Panel)
            Me.Name = "CustomerViewOrderUserControl"
            Me.Size = New System.Drawing.Size(1249, 175)
            Me.Panel.ResumeLayout(False)
            Me.Panel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Panel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents ViewOrderButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents StartOverButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents TotalPriceButton As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ItemCountLabel As Label
    End Class


End Namespace