Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CustomerOrderQuantityUserControl
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerOrderQuantityUserControl))
            Me.QuantityTextBox = New System.Windows.Forms.Label()
            Me.AddOrderButton = New Guna.UI2.WinForms.Guna2Button()
            Me.CancelButton = New Guna.UI2.WinForms.Guna2Button()
            Me.productPrice = New System.Windows.Forms.Label()
            Me.productName = New System.Windows.Forms.Label()
            Me.productPanel = New Guna.UI2.WinForms.Guna2TextBox()
            Me.RemoveItemButton = New Guna.UI2.WinForms.Guna2Button()
            Me.AddItemButton = New Guna.UI2.WinForms.Guna2Button()
            Me.productImage = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            CType(Me.productImage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Guna2Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'QuantityTextBox
            '
            Me.QuantityTextBox.AutoSize = True
            Me.QuantityTextBox.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.QuantityTextBox.Location = New System.Drawing.Point(698, 44)
            Me.QuantityTextBox.Name = "QuantityTextBox"
            Me.QuantityTextBox.Size = New System.Drawing.Size(39, 34)
            Me.QuantityTextBox.TabIndex = 44
            Me.QuantityTextBox.Text = "00"
            '
            'AddOrderButton
            '
            Me.AddOrderButton.BackColor = System.Drawing.Color.White
            Me.AddOrderButton.BorderColor = System.Drawing.Color.WhiteSmoke
            Me.AddOrderButton.BorderRadius = 10
            Me.AddOrderButton.BorderThickness = 1
            Me.AddOrderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.AddOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.AddOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.AddOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.AddOrderButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.AddOrderButton.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AddOrderButton.ForeColor = System.Drawing.Color.Black
            Me.AddOrderButton.Location = New System.Drawing.Point(716, 102)
            Me.AddOrderButton.Name = "AddOrderButton"
            Me.AddOrderButton.Size = New System.Drawing.Size(204, 37)
            Me.AddOrderButton.TabIndex = 43
            Me.AddOrderButton.Text = "Add Order"
            Me.AddOrderButton.TextOffset = New System.Drawing.Point(2, 2)
            '
            'CancelButton
            '
            Me.CancelButton.BackColor = System.Drawing.Color.White
            Me.CancelButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.CancelButton.BorderRadius = 10
            Me.CancelButton.BorderThickness = 1
            Me.CancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.CancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.CancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.CancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.CancelButton.FillColor = System.Drawing.Color.White
            Me.CancelButton.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CancelButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.CancelButton.Location = New System.Drawing.Point(509, 102)
            Me.CancelButton.Name = "CancelButton"
            Me.CancelButton.Size = New System.Drawing.Size(201, 37)
            Me.CancelButton.TabIndex = 42
            Me.CancelButton.Text = "Cancel"
            Me.CancelButton.TextOffset = New System.Drawing.Point(2, 2)
            '
            'productPrice
            '
            Me.productPrice.AutoSize = True
            Me.productPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.productPrice.Location = New System.Drawing.Point(671, 428)
            Me.productPrice.Name = "productPrice"
            Me.productPrice.Size = New System.Drawing.Size(54, 16)
            Me.productPrice.TabIndex = 41
            Me.productPrice.Text = "P299.00"
            '
            'productName
            '
            Me.productName.AutoSize = True
            Me.productName.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.productName.Location = New System.Drawing.Point(642, 398)
            Me.productName.Name = "productName"
            Me.productName.Size = New System.Drawing.Size(129, 34)
            Me.productName.TabIndex = 40
            Me.productName.Text = "Inferno Bite"
            '
            'productPanel
            '
            Me.productPanel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
            Me.productPanel.BackColor = System.Drawing.Color.Transparent
            Me.productPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.productPanel.BorderRadius = 10
            Me.productPanel.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.productPanel.DefaultText = ""
            Me.productPanel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.productPanel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.productPanel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.productPanel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.productPanel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.productPanel.Font = New System.Drawing.Font("Poppins", 21.75!)
            Me.productPanel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.productPanel.Location = New System.Drawing.Point(568, 160)
            Me.productPanel.Margin = New System.Windows.Forms.Padding(4)
            Me.productPanel.Name = "productPanel"
            Me.productPanel.PlaceholderText = ""
            Me.productPanel.SelectedText = ""
            Me.productPanel.ShadowDecoration.BorderRadius = 25
            Me.productPanel.ShadowDecoration.Depth = 25
            Me.productPanel.ShadowDecoration.Enabled = True
            Me.productPanel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
            Me.productPanel.Size = New System.Drawing.Size(269, 300)
            Me.productPanel.TabIndex = 38
            '
            'RemoveItemButton
            '
            Me.RemoveItemButton.BackColor = System.Drawing.Color.Transparent
            Me.RemoveItemButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.RemoveItemButton.BorderRadius = 10
            Me.RemoveItemButton.BorderThickness = 1
            Me.RemoveItemButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.RemoveItemButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.RemoveItemButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.RemoveItemButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.RemoveItemButton.FillColor = System.Drawing.Color.White
            Me.RemoveItemButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.RemoveItemButton.ForeColor = System.Drawing.Color.White
            Me.RemoveItemButton.Image = CType(resources.GetObject("RemoveItemButton.Image"), System.Drawing.Image)
            Me.RemoveItemButton.ImageOffset = New System.Drawing.Point(0, 12)
            Me.RemoveItemButton.Location = New System.Drawing.Point(613, 41)
            Me.RemoveItemButton.Name = "RemoveItemButton"
            Me.RemoveItemButton.Size = New System.Drawing.Size(59, 35)
            Me.RemoveItemButton.TabIndex = 37
            Me.RemoveItemButton.Text = "Guna2Button2"
            '
            'AddItemButton
            '
            Me.AddItemButton.BackColor = System.Drawing.Color.Transparent
            Me.AddItemButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.AddItemButton.BorderRadius = 10
            Me.AddItemButton.BorderThickness = 1
            Me.AddItemButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.AddItemButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.AddItemButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.AddItemButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.AddItemButton.FillColor = System.Drawing.Color.White
            Me.AddItemButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.AddItemButton.ForeColor = System.Drawing.Color.White
            Me.AddItemButton.Image = CType(resources.GetObject("AddItemButton.Image"), System.Drawing.Image)
            Me.AddItemButton.ImageOffset = New System.Drawing.Point(0, 12)
            Me.AddItemButton.Location = New System.Drawing.Point(765, 41)
            Me.AddItemButton.Name = "AddItemButton"
            Me.AddItemButton.Size = New System.Drawing.Size(59, 35)
            Me.AddItemButton.TabIndex = 36
            Me.AddItemButton.Text = "Guna2Button1"
            '
            'productImage
            '
            Me.productImage.BackColor = System.Drawing.Color.Transparent
            Me.productImage.BorderRadius = 20
            Me.productImage.Image = CType(resources.GetObject("productImage.Image"), System.Drawing.Image)
            Me.productImage.ImageRotate = 0!
            Me.productImage.Location = New System.Drawing.Point(584, 177)
            Me.productImage.Name = "productImage"
            Me.productImage.Size = New System.Drawing.Size(237, 218)
            Me.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.productImage.TabIndex = 39
            Me.productImage.TabStop = False
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me.AddOrderButton)
            Me.Guna2Panel1.Controls.Add(Me.QuantityTextBox)
            Me.Guna2Panel1.Controls.Add(Me.AddItemButton)
            Me.Guna2Panel1.Controls.Add(Me.CancelButton)
            Me.Guna2Panel1.Controls.Add(Me.RemoveItemButton)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 634)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(1426, 183)
            Me.Guna2Panel1.TabIndex = 45
            '
            'CustomerOrderQuantityUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Controls.Add(Me.productPrice)
            Me.Controls.Add(Me.productName)
            Me.Controls.Add(Me.productImage)
            Me.Controls.Add(Me.productPanel)
            Me.Name = "CustomerOrderQuantityUserControl"
            Me.Size = New System.Drawing.Size(1426, 817)
            CType(Me.productImage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Guna2Panel1.ResumeLayout(False)
            Me.Guna2Panel1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents QuantityTextBox As Label
        Friend WithEvents AddOrderButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents RemoveItemButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents CancelButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents AddItemButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents productPrice As Label
        Friend WithEvents productName As Label
        Friend WithEvents productImage As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents productPanel As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    End Class

End Namespace