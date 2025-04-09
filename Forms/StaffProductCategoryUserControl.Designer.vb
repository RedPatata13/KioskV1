Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class StaffProductCategoryUserControl
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
            Me.ProductCategoryButton = New Guna.UI2.WinForms.Guna2Button()
            Me.SuspendLayout()
            '
            'ProductCategoryButton
            '
            Me.ProductCategoryButton.BorderRadius = 20
            Me.ProductCategoryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.ProductCategoryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.ProductCategoryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.ProductCategoryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.ProductCategoryButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer))
            Me.ProductCategoryButton.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.ProductCategoryButton.ForeColor = System.Drawing.Color.Black
            Me.ProductCategoryButton.Location = New System.Drawing.Point(3, 3)
            Me.ProductCategoryButton.Name = "ProductCategoryButton"
            Me.ProductCategoryButton.Size = New System.Drawing.Size(194, 39)
            Me.ProductCategoryButton.TabIndex = 0
            Me.ProductCategoryButton.Text = "Category"
            Me.ProductCategoryButton.TextOffset = New System.Drawing.Point(0, 2)
            '
            'StaffProductCategoryUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.ProductCategoryButton)
            Me.Name = "StaffProductCategoryUserControl"
            Me.Size = New System.Drawing.Size(205, 49)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents ProductCategoryButton As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace