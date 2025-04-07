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
            Me.MenuPictureBox = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.MenuName = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.AddItemButton = New Guna.UI2.WinForms.Guna2Button()
            Me.QuantityTextBox = New System.Windows.Forms.Label()
            Me.RemoveItemButton = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            Me.MenuTotalPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.MenuPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel1.SuspendLayout()
            CType(Me.MenuPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Guna2Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
            Me.Guna2Panel1.BorderRadius = 15
            Me.Guna2Panel1.BorderThickness = 2
            Me.Guna2Panel1.Controls.Add(Me.MenuPrice)
            Me.Guna2Panel1.Controls.Add(Me.MenuTotalPrice)
            Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
            Me.Guna2Panel1.Controls.Add(Me.MenuName)
            Me.Guna2Panel1.Controls.Add(Me.MenuPictureBox)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Guna2Panel1.FillColor = System.Drawing.Color.White
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(1364, 160)
            Me.Guna2Panel1.TabIndex = 0
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
            'MenuName
            '
            Me.MenuName.BackColor = System.Drawing.Color.Transparent
            Me.MenuName.Font = New System.Drawing.Font("Poppins SemiBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuName.Location = New System.Drawing.Point(204, 30)
            Me.MenuName.Name = "MenuName"
            Me.MenuName.Size = New System.Drawing.Size(192, 58)
            Me.MenuName.TabIndex = 1
            Me.MenuName.Text = "Blazing Bite"
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
            Me.RemoveItemButton.Location = New System.Drawing.Point(3, 10)
            Me.RemoveItemButton.Name = "RemoveItemButton"
            Me.RemoveItemButton.Size = New System.Drawing.Size(59, 35)
            Me.RemoveItemButton.TabIndex = 46
            Me.RemoveItemButton.Text = "Guna2Button2"
            '
            'Guna2Panel2
            '
            Me.Guna2Panel2.Controls.Add(Me.Guna2Button1)
            Me.Guna2Panel2.Controls.Add(Me.RemoveItemButton)
            Me.Guna2Panel2.Controls.Add(Me.AddItemButton)
            Me.Guna2Panel2.Controls.Add(Me.QuantityTextBox)
            Me.Guna2Panel2.Location = New System.Drawing.Point(880, 30)
            Me.Guna2Panel2.Name = "Guna2Panel2"
            Me.Guna2Panel2.Size = New System.Drawing.Size(176, 100)
            Me.Guna2Panel2.TabIndex = 47
            '
            'Guna2Button1
            '
            Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Guna2Button1.BorderRadius = 10
            Me.Guna2Button1.BorderThickness = 1
            Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.Guna2Button1.FillColor = System.Drawing.Color.White
            Me.Guna2Button1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2Button1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2Button1.ImageOffset = New System.Drawing.Point(0, 12)
            Me.Guna2Button1.Location = New System.Drawing.Point(3, 51)
            Me.Guna2Button1.Name = "Guna2Button1"
            Me.Guna2Button1.Size = New System.Drawing.Size(169, 35)
            Me.Guna2Button1.TabIndex = 47
            Me.Guna2Button1.Text = "Remove"
            '
            'MenuTotalPrice
            '
            Me.MenuTotalPrice.BackColor = System.Drawing.Color.Transparent
            Me.MenuTotalPrice.Font = New System.Drawing.Font("Poppins SemiBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuTotalPrice.Location = New System.Drawing.Point(1119, 30)
            Me.MenuTotalPrice.Name = "MenuTotalPrice"
            Me.MenuTotalPrice.Size = New System.Drawing.Size(183, 58)
            Me.MenuTotalPrice.TabIndex = 48
            Me.MenuTotalPrice.Text = "Php 200.00"
            '
            'MenuPrice
            '
            Me.MenuPrice.BackColor = System.Drawing.Color.Transparent
            Me.MenuPrice.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.MenuPrice.Location = New System.Drawing.Point(1119, 81)
            Me.MenuPrice.Name = "MenuPrice"
            Me.MenuPrice.Size = New System.Drawing.Size(133, 44)
            Me.MenuPrice.TabIndex = 49
            Me.MenuPrice.Text = "Php 200.00"
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
            CType(Me.MenuPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Guna2Panel2.ResumeLayout(False)
            Me.Guna2Panel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents MenuName As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents MenuPictureBox As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents AddItemButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents QuantityTextBox As Label
        Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents RemoveItemButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents MenuTotalPrice As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents MenuPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace