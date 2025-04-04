<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffProductVariationUserControl
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
        Me.ProductVariationButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'ProductVariationButton
        '
        Me.ProductVariationButton.BorderRadius = 20
        Me.ProductVariationButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ProductVariationButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ProductVariationButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ProductVariationButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ProductVariationButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.ProductVariationButton.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.ProductVariationButton.ForeColor = System.Drawing.Color.Black
        Me.ProductVariationButton.Location = New System.Drawing.Point(3, 7)
        Me.ProductVariationButton.Name = "ProductVariationButton"
        Me.ProductVariationButton.Size = New System.Drawing.Size(194, 60)
        Me.ProductVariationButton.TabIndex = 1
        Me.ProductVariationButton.Text = "Variation"
        Me.ProductVariationButton.TextOffset = New System.Drawing.Point(0, 2)
        '
        'ProductVariationUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.ProductVariationButton)
        Me.Name = "ProductVariationUserControl"
        Me.Size = New System.Drawing.Size(205, 79)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProductVariationButton As Guna.UI2.WinForms.Guna2Button
End Class
