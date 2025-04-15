Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AdminMenuUserControl
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
            Me.CategoryLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.PriceLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ProductName = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ProductPictureBox = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.Guna2Panel1.SuspendLayout()
            CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Guna2Panel1.BorderRadius = 15
            Me.Guna2Panel1.BorderThickness = 1
            Me.Guna2Panel1.Controls.Add(Me.CategoryLabel)
            Me.Guna2Panel1.Controls.Add(Me.PriceLabel)
            Me.Guna2Panel1.Controls.Add(Me.ProductName)
            Me.Guna2Panel1.Controls.Add(Me.ProductPictureBox)
            Me.Guna2Panel1.FillColor = System.Drawing.Color.White
            Me.Guna2Panel1.Location = New System.Drawing.Point(19, 0)
            Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.ShadowDecoration.BorderRadius = 25
            Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
            Me.Guna2Panel1.Size = New System.Drawing.Size(228, 282)
            Me.Guna2Panel1.TabIndex = 0
            '
            'CategoryLabel
            '
            Me.CategoryLabel.BackColor = System.Drawing.Color.Transparent
            Me.CategoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CategoryLabel.Location = New System.Drawing.Point(19, 235)
            Me.CategoryLabel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.CategoryLabel.Name = "CategoryLabel"
            Me.CategoryLabel.Size = New System.Drawing.Size(76, 24)
            Me.CategoryLabel.TabIndex = 3
            Me.CategoryLabel.Text = "Category"
            '
            'PriceLabel
            '
            Me.PriceLabel.BackColor = System.Drawing.Color.Transparent
            Me.PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PriceLabel.Location = New System.Drawing.Point(19, 210)
            Me.PriceLabel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.PriceLabel.Name = "PriceLabel"
            Me.PriceLabel.Size = New System.Drawing.Size(54, 22)
            Me.PriceLabel.TabIndex = 2
            Me.PriceLabel.Text = "P00.00"
            '
            'ProductName
            '
            Me.ProductName.BackColor = System.Drawing.Color.Transparent
            Me.ProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ProductName.Location = New System.Drawing.Point(19, 180)
            Me.ProductName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.ProductName.Name = "ProductName"
            Me.ProductName.Size = New System.Drawing.Size(127, 27)
            Me.ProductName.TabIndex = 1
            Me.ProductName.Text = "Product Name"
            '
            'ProductPictureBox
            '
            Me.ProductPictureBox.BackColor = System.Drawing.Color.Transparent
            Me.ProductPictureBox.BorderRadius = 15
            Me.ProductPictureBox.FillColor = System.Drawing.Color.LightGray
            Me.ProductPictureBox.ImageRotate = 0!
            Me.ProductPictureBox.Location = New System.Drawing.Point(19, 18)
            Me.ProductPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.ProductPictureBox.Name = "ProductPictureBox"
            Me.ProductPictureBox.Size = New System.Drawing.Size(189, 155)
            Me.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.ProductPictureBox.TabIndex = 0
            Me.ProductPictureBox.TabStop = False
            '
            'AdminMenuUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "AdminMenuUserControl"
            Me.Size = New System.Drawing.Size(247, 310)
            Me.Guna2Panel1.ResumeLayout(False)
            Me.Guna2Panel1.PerformLayout()
            CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents ProductPictureBox As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents PriceLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ProductName As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents CategoryLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace