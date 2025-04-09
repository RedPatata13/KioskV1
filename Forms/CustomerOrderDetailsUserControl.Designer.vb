Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CustomerOrderDetailsUserControl
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerOrderDetailsUserControl))
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.ItemPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ItemTotalPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
            Me.RemoveButton = New Guna.UI2.WinForms.Guna2Button()
            Me.DecreaseItemButton = New Guna.UI2.WinForms.Guna2Button()
            Me.AddItemButton = New Guna.UI2.WinForms.Guna2Button()
            Me.QuantityTextBox = New System.Windows.Forms.Label()
            Me.ItemName = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.MenuPictureBox = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.Guna2Panel1.SuspendLayout()
            Me.Guna2Panel2.SuspendLayout()
            CType(Me.MenuPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
            Me.Guna2Panel1.BorderRadius = 15
            Me.Guna2Panel1.BorderThickness = 2
            Me.Guna2Panel1.Controls.Add(Me.ItemPrice)
            Me.Guna2Panel1.Controls.Add(Me.ItemTotalPrice)
            Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
            Me.Guna2Panel1.Controls.Add(Me.ItemName)
            Me.Guna2Panel1.Controls.Add(Me.MenuPictureBox)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Guna2Panel1.FillColor = System.Drawing.Color.White
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(1364, 160)
            Me.Guna2Panel1.TabIndex = 0
            '
            'ItemPrice
            '
            Me.ItemPrice.BackColor = System.Drawing.Color.Transparent
            Me.ItemPrice.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ItemPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.ItemPrice.Location = New System.Drawing.Point(1119, 81)
            Me.ItemPrice.Name = "ItemPrice"
            Me.ItemPrice.Size = New System.Drawing.Size(119, 44)
            Me.ItemPrice.TabIndex = 49
            Me.ItemPrice.Text = "Php 00.00"
            '
            'ItemTotalPrice
            '
            Me.ItemTotalPrice.BackColor = System.Drawing.Color.Transparent
            Me.ItemTotalPrice.Font = New System.Drawing.Font("Poppins SemiBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ItemTotalPrice.Location = New System.Drawing.Point(1119, 30)
            Me.ItemTotalPrice.Name = "ItemTotalPrice"
            Me.ItemTotalPrice.Size = New System.Drawing.Size(165, 58)
            Me.ItemTotalPrice.TabIndex = 48
            Me.ItemTotalPrice.Text = "Php 00.00"
            '
            'Guna2Panel2
            '
            Me.Guna2Panel2.Controls.Add(Me.RemoveButton)
            Me.Guna2Panel2.Controls.Add(Me.DecreaseItemButton)
            Me.Guna2Panel2.Controls.Add(Me.AddItemButton)
            Me.Guna2Panel2.Controls.Add(Me.QuantityTextBox)
            Me.Guna2Panel2.Location = New System.Drawing.Point(880, 30)
            Me.Guna2Panel2.Name = "Guna2Panel2"
            Me.Guna2Panel2.Size = New System.Drawing.Size(176, 100)
            Me.Guna2Panel2.TabIndex = 47
            '
            'RemoveButton
            '
            Me.RemoveButton.BackColor = System.Drawing.Color.Transparent
            Me.RemoveButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.RemoveButton.BorderRadius = 10
            Me.RemoveButton.BorderThickness = 1
            Me.RemoveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.RemoveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.RemoveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.RemoveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.RemoveButton.FillColor = System.Drawing.Color.White
            Me.RemoveButton.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.RemoveButton.ForeColor = System.Drawing.SystemColors.ControlText
            Me.RemoveButton.ImageOffset = New System.Drawing.Point(0, 12)
            Me.RemoveButton.Location = New System.Drawing.Point(3, 51)
            Me.RemoveButton.Name = "RemoveButton"
            Me.RemoveButton.Size = New System.Drawing.Size(169, 35)
            Me.RemoveButton.TabIndex = 47
            Me.RemoveButton.Text = "Remove"
            '
            'DecreaseItemButton
            '
            Me.DecreaseItemButton.BackColor = System.Drawing.Color.Transparent
            Me.DecreaseItemButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.DecreaseItemButton.BorderRadius = 10
            Me.DecreaseItemButton.BorderThickness = 1
            Me.DecreaseItemButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.DecreaseItemButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.DecreaseItemButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.DecreaseItemButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.DecreaseItemButton.FillColor = System.Drawing.Color.White
            Me.DecreaseItemButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.DecreaseItemButton.ForeColor = System.Drawing.Color.White
            Me.DecreaseItemButton.Image = CType(resources.GetObject("DecreaseItemButton.Image"), System.Drawing.Image)
            Me.DecreaseItemButton.ImageOffset = New System.Drawing.Point(0, 12)
            Me.DecreaseItemButton.Location = New System.Drawing.Point(3, 10)
            Me.DecreaseItemButton.Name = "DecreaseItemButton"
            Me.DecreaseItemButton.Size = New System.Drawing.Size(59, 35)
            Me.DecreaseItemButton.TabIndex = 46
            Me.DecreaseItemButton.Text = "Guna2Button2"
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
            Me.AddItemButton.Location = New System.Drawing.Point(113, 11)
            Me.AddItemButton.Name = "AddItemButton"
            Me.AddItemButton.Size = New System.Drawing.Size(59, 35)
            Me.AddItemButton.TabIndex = 37
            Me.AddItemButton.Text = "Guna2Button1"
            '
            'QuantityTextBox
            '
            Me.QuantityTextBox.AutoSize = True
            Me.QuantityTextBox.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.QuantityTextBox.Location = New System.Drawing.Point(68, 11)
            Me.QuantityTextBox.Name = "QuantityTextBox"
            Me.QuantityTextBox.Size = New System.Drawing.Size(39, 34)
            Me.QuantityTextBox.TabIndex = 45
            Me.QuantityTextBox.Text = "00"
            '
            'ItemName
            '
            Me.ItemName.BackColor = System.Drawing.Color.Transparent
            Me.ItemName.Font = New System.Drawing.Font("Poppins SemiBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ItemName.Location = New System.Drawing.Point(204, 30)
            Me.ItemName.Name = "ItemName"
            Me.ItemName.Size = New System.Drawing.Size(41, 58)
            Me.ItemName.TabIndex = 1
            Me.ItemName.Text = "--"
            '
            'MenuPictureBox
            '
            Me.MenuPictureBox.BorderRadius = 15
            Me.MenuPictureBox.FillColor = System.Drawing.Color.Gainsboro
            Me.MenuPictureBox.ImageRotate = 0!
            Me.MenuPictureBox.Location = New System.Drawing.Point(27, 15)
            Me.MenuPictureBox.Name = "MenuPictureBox"
            Me.MenuPictureBox.Size = New System.Drawing.Size(150, 127)
            Me.MenuPictureBox.TabIndex = 0
            Me.MenuPictureBox.TabStop = False
            '
            'CustomerOrderDetailsUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Name = "CustomerOrderDetailsUserControl"
            Me.Size = New System.Drawing.Size(1364, 160)
            Me.Guna2Panel1.ResumeLayout(False)
            Me.Guna2Panel1.PerformLayout()
            Me.Guna2Panel2.ResumeLayout(False)
            Me.Guna2Panel2.PerformLayout()
            CType(Me.MenuPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents ItemName As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents MenuPictureBox As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents AddItemButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents QuantityTextBox As Label
        Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents RemoveButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents DecreaseItemButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents ItemTotalPrice As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ItemPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace