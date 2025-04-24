<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierSidebar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupplierSidebar))
        Me.Guna2HtmlToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.LogOutButton = New Guna.UI2.WinForms.Guna2Button()
        Me.InventoryButton = New Guna.UI2.WinForms.Guna2Button()
        Me.DashboardButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Guna2HtmlToolTip1
        '
        Me.Guna2HtmlToolTip1.AllowLinksHandling = True
        Me.Guna2HtmlToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'LogOutButton
        '
        Me.LogOutButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogOutButton.BorderRadius = 15
        Me.LogOutButton.BorderThickness = 1
        Me.LogOutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LogOutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LogOutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LogOutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LogOutButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogOutButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogOutButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogOutButton.HoverState.BorderColor = System.Drawing.Color.White
        Me.LogOutButton.HoverState.FillColor = System.Drawing.Color.White
        Me.LogOutButton.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.LogOutButton.Image = CType(resources.GetObject("LogOutButton.Image"), System.Drawing.Image)
        Me.LogOutButton.ImageSize = New System.Drawing.Size(50, 50)
        Me.LogOutButton.Location = New System.Drawing.Point(16, 723)
        Me.LogOutButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(82, 81)
        Me.LogOutButton.TabIndex = 17
        Me.Guna2HtmlToolTip1.SetToolTip(Me.LogOutButton, "Logout")
        '
        'InventoryButton
        '
        Me.InventoryButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InventoryButton.BorderRadius = 15
        Me.InventoryButton.BorderThickness = 1
        Me.InventoryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.InventoryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.InventoryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.InventoryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.InventoryButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InventoryButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.InventoryButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InventoryButton.HoverState.BorderColor = System.Drawing.Color.White
        Me.InventoryButton.HoverState.FillColor = System.Drawing.Color.White
        Me.InventoryButton.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.InventoryButton.Image = CType(resources.GetObject("InventoryButton.Image"), System.Drawing.Image)
        Me.InventoryButton.ImageSize = New System.Drawing.Size(70, 70)
        Me.InventoryButton.Location = New System.Drawing.Point(16, 112)
        Me.InventoryButton.Margin = New System.Windows.Forms.Padding(2)
        Me.InventoryButton.Name = "InventoryButton"
        Me.InventoryButton.Size = New System.Drawing.Size(88, 81)
        Me.InventoryButton.TabIndex = 13
        Me.Guna2HtmlToolTip1.SetToolTip(Me.InventoryButton, "Inventory")
        '
        'DashboardButton
        '
        Me.DashboardButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DashboardButton.BorderRadius = 15
        Me.DashboardButton.BorderThickness = 1
        Me.DashboardButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DashboardButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DashboardButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DashboardButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DashboardButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DashboardButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DashboardButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DashboardButton.HoverState.BorderColor = System.Drawing.Color.White
        Me.DashboardButton.HoverState.FillColor = System.Drawing.Color.White
        Me.DashboardButton.HoverState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.DashboardButton.Image = CType(resources.GetObject("DashboardButton.Image"), System.Drawing.Image)
        Me.DashboardButton.ImageSize = New System.Drawing.Size(70, 70)
        Me.DashboardButton.Location = New System.Drawing.Point(16, 35)
        Me.DashboardButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DashboardButton.Name = "DashboardButton"
        Me.DashboardButton.Size = New System.Drawing.Size(88, 82)
        Me.DashboardButton.TabIndex = 11
        Me.Guna2HtmlToolTip1.SetToolTip(Me.DashboardButton, "Dashboard")
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.BorderRadius = 15
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(70, 70)
        Me.Guna2Button1.Location = New System.Drawing.Point(16, 192)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(88, 81)
        Me.Guna2Button1.TabIndex = 18
        Me.Guna2HtmlToolTip1.SetToolTip(Me.Guna2Button1, "Inventory")
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button2.BorderRadius = 15
        Me.Guna2Button2.BorderThickness = 1
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button2.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(70, 70)
        Me.Guna2Button2.Location = New System.Drawing.Point(16, 272)
        Me.Guna2Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(88, 81)
        Me.Guna2Button2.TabIndex = 19
        Me.Guna2HtmlToolTip1.SetToolTip(Me.Guna2Button2, "Inventory")
        '
        'SupplierSidebar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(119, 878)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.LogOutButton)
        Me.Controls.Add(Me.InventoryButton)
        Me.Controls.Add(Me.DashboardButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SupplierSidebar"
        Me.Text = "SupplierSidebar"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogOutButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents InventoryButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DashboardButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
