<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffProductUserControl
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
        Me.ProductButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'ProductButton
        '
        Me.ProductButton.BorderRadius = 20
        Me.ProductButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ProductButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ProductButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ProductButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ProductButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.ProductButton.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.ProductButton.ForeColor = System.Drawing.Color.Black
        Me.ProductButton.Location = New System.Drawing.Point(3, 3)
        Me.ProductButton.Name = "ProductButton"
        Me.ProductButton.Size = New System.Drawing.Size(194, 147)
        Me.ProductButton.TabIndex = 1
        Me.ProductButton.Text = "Product"
        Me.ProductButton.TextOffset = New System.Drawing.Point(0, 2)
        '
        'ProductUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.ProductButton)
        Me.Name = "ProductUserControl"
        Me.Size = New System.Drawing.Size(205, 162)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProductButton As Guna.UI2.WinForms.Guna2Button
End Class
