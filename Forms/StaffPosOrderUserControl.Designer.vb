<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffPosOrderUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ProductNameLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.AddOrderButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ProductQuantityLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.RemoveButton = New Guna.UI2.WinForms.Guna2Button()
        Me.DeleteOrderButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'ProductNameLabel
        '
        Me.ProductNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProductNameLabel.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.ProductNameLabel.Location = New System.Drawing.Point(32, 31)
        Me.ProductNameLabel.Name = "ProductNameLabel"
        Me.ProductNameLabel.Size = New System.Drawing.Size(65, 30)
        Me.ProductNameLabel.TabIndex = 0
        Me.ProductNameLabel.Text = "Product"
        '
        'AddOrderButton
        '
        Me.AddOrderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddOrderButton.FillColor = System.Drawing.Color.White
        Me.AddOrderButton.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.AddOrderButton.ForeColor = System.Drawing.Color.Black
        Me.AddOrderButton.Location = New System.Drawing.Point(432, 31)
        Me.AddOrderButton.Name = "AddOrderButton"
        Me.AddOrderButton.Size = New System.Drawing.Size(34, 30)
        Me.AddOrderButton.TabIndex = 1
        Me.AddOrderButton.Text = "+"
        '
        'ProductQuantityLabel
        '
        Me.ProductQuantityLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProductQuantityLabel.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.ProductQuantityLabel.Location = New System.Drawing.Point(391, 36)
        Me.ProductQuantityLabel.Name = "ProductQuantityLabel"
        Me.ProductQuantityLabel.Size = New System.Drawing.Size(21, 21)
        Me.ProductQuantityLabel.TabIndex = 3
        Me.ProductQuantityLabel.Text = "00"
        '
        'RemoveButton
        '
        Me.RemoveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.RemoveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.RemoveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RemoveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.RemoveButton.FillColor = System.Drawing.Color.White
        Me.RemoveButton.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.RemoveButton.ForeColor = System.Drawing.Color.Black
        Me.RemoveButton.Location = New System.Drawing.Point(336, 31)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(34, 30)
        Me.RemoveButton.TabIndex = 2
        Me.RemoveButton.Text = "-"
        '
        'DeleteOrderButton
        '
        Me.DeleteOrderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DeleteOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DeleteOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DeleteOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DeleteOrderButton.FillColor = System.Drawing.Color.White
        Me.DeleteOrderButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DeleteOrderButton.ForeColor = System.Drawing.Color.Black
        Me.DeleteOrderButton.Location = New System.Drawing.Point(474, 31)
        Me.DeleteOrderButton.Name = "DeleteOrderButton"
        Me.DeleteOrderButton.Size = New System.Drawing.Size(34, 30)
        Me.DeleteOrderButton.TabIndex = 2
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.White
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button2.Location = New System.Drawing.Point(570, 40)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(34, 30)
        Me.Guna2Button2.TabIndex = 2
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.White
        Me.Guna2Button1.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.Location = New System.Drawing.Point(528, 40)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(34, 30)
        Me.Guna2Button1.TabIndex = 1
        Me.Guna2Button1.Text = "+"
        '
        'StaffPosOrderUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ProductQuantityLabel)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.DeleteOrderButton)
        Me.Controls.Add(Me.AddOrderButton)
        Me.Controls.Add(Me.ProductNameLabel)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "StaffPosOrderUserControl"
        Me.Size = New System.Drawing.Size(529, 90)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductNameLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents AddOrderButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DeleteOrderButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ProductQuantityLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents RemoveButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
