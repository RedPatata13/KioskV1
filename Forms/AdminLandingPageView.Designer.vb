Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AdminLandingPageView
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLandingPageView))
            Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
            Me.AdminPanel = New System.Windows.Forms.Panel()
            Me.AdminSidebar = New System.Windows.Forms.Panel()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.DashboardButton = New Guna.UI2.WinForms.Guna2Button()
            Me.MenuListButton = New Guna.UI2.WinForms.Guna2Button()
            Me.InventoryButton = New Guna.UI2.WinForms.Guna2Button()
            Me.OrderHistoryButton = New Guna.UI2.WinForms.Guna2Button()
            Me.StaffTransacButton = New Guna.UI2.WinForms.Guna2Button()
            Me.AccountsButton = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2Panel2.SuspendLayout()
            Me.AdminPanel.SuspendLayout()
            Me.AdminSidebar.SuspendLayout()
            Me.SuspendLayout()
            '
            'Guna2Panel2
            '
            Me.Guna2Panel2.BackColor = System.Drawing.Color.White
            Me.Guna2Panel2.Controls.Add(Me.AdminPanel)
            Me.Guna2Panel2.Controls.Add(Me.AdminSidebar)
            Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2Panel2.Name = "Guna2Panel2"
            Me.Guna2Panel2.Size = New System.Drawing.Size(1920, 1080)
            Me.Guna2Panel2.TabIndex = 3
            '
            'AdminPanel
            '
            Me.AdminPanel.BackColor = System.Drawing.Color.White
            Me.AdminPanel.Controls.Add(Me.Guna2Panel1)
            Me.AdminPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.AdminPanel.Location = New System.Drawing.Point(159, 0)
            Me.AdminPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.AdminPanel.Name = "AdminPanel"
            Me.AdminPanel.Size = New System.Drawing.Size(1761, 1080)
            Me.AdminPanel.TabIndex = 1
            '
            'AdminSidebar
            '
            Me.AdminSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AdminSidebar.Controls.Add(Me.AccountsButton)
            Me.AdminSidebar.Controls.Add(Me.StaffTransacButton)
            Me.AdminSidebar.Controls.Add(Me.OrderHistoryButton)
            Me.AdminSidebar.Controls.Add(Me.InventoryButton)
            Me.AdminSidebar.Controls.Add(Me.MenuListButton)
            Me.AdminSidebar.Controls.Add(Me.DashboardButton)
            Me.AdminSidebar.Dock = System.Windows.Forms.DockStyle.Left
            Me.AdminSidebar.Location = New System.Drawing.Point(0, 0)
            Me.AdminSidebar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.AdminSidebar.Name = "AdminSidebar"
            Me.AdminSidebar.Size = New System.Drawing.Size(159, 1080)
            Me.AdminSidebar.TabIndex = 0
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(1761, 1080)
            Me.Guna2Panel1.TabIndex = 0
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
            Me.DashboardButton.HoverState.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
            Me.DashboardButton.Image = CType(resources.GetObject("DashboardButton.Image"), System.Drawing.Image)
            Me.DashboardButton.ImageSize = New System.Drawing.Size(70, 70)
            Me.DashboardButton.Location = New System.Drawing.Point(21, 123)
            Me.DashboardButton.Name = "DashboardButton"
            Me.DashboardButton.Size = New System.Drawing.Size(110, 100)
            Me.DashboardButton.TabIndex = 0
            '
            'MenuListButton
            '
            Me.MenuListButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.MenuListButton.BorderRadius = 15
            Me.MenuListButton.BorderThickness = 1
            Me.MenuListButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.MenuListButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.MenuListButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.MenuListButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.MenuListButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.MenuListButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuListButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.MenuListButton.HoverState.BorderColor = System.Drawing.Color.White
            Me.MenuListButton.HoverState.FillColor = System.Drawing.Color.White
            Me.MenuListButton.HoverState.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
            Me.MenuListButton.Image = CType(resources.GetObject("MenuListButton.Image"), System.Drawing.Image)
            Me.MenuListButton.ImageSize = New System.Drawing.Size(70, 70)
            Me.MenuListButton.Location = New System.Drawing.Point(21, 229)
            Me.MenuListButton.Name = "MenuListButton"
            Me.MenuListButton.Size = New System.Drawing.Size(110, 100)
            Me.MenuListButton.TabIndex = 1
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
            Me.InventoryButton.HoverState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
            Me.InventoryButton.Image = CType(resources.GetObject("InventoryButton.Image"), System.Drawing.Image)
            Me.InventoryButton.ImageSize = New System.Drawing.Size(70, 70)
            Me.InventoryButton.Location = New System.Drawing.Point(21, 335)
            Me.InventoryButton.Name = "InventoryButton"
            Me.InventoryButton.Size = New System.Drawing.Size(110, 100)
            Me.InventoryButton.TabIndex = 2
            '
            'OrderHistoryButton
            '
            Me.OrderHistoryButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.OrderHistoryButton.BorderRadius = 15
            Me.OrderHistoryButton.BorderThickness = 1
            Me.OrderHistoryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.OrderHistoryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.OrderHistoryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.OrderHistoryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.OrderHistoryButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.OrderHistoryButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.OrderHistoryButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.OrderHistoryButton.HoverState.BorderColor = System.Drawing.Color.White
            Me.OrderHistoryButton.HoverState.FillColor = System.Drawing.Color.White
            Me.OrderHistoryButton.HoverState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            Me.OrderHistoryButton.Image = CType(resources.GetObject("OrderHistoryButton.Image"), System.Drawing.Image)
            Me.OrderHistoryButton.ImageSize = New System.Drawing.Size(70, 70)
            Me.OrderHistoryButton.Location = New System.Drawing.Point(21, 441)
            Me.OrderHistoryButton.Name = "OrderHistoryButton"
            Me.OrderHistoryButton.Size = New System.Drawing.Size(110, 100)
            Me.OrderHistoryButton.TabIndex = 3
            '
            'StaffTransacButton
            '
            Me.StaffTransacButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.StaffTransacButton.BorderRadius = 15
            Me.StaffTransacButton.BorderThickness = 1
            Me.StaffTransacButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.StaffTransacButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.StaffTransacButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.StaffTransacButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.StaffTransacButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.StaffTransacButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.StaffTransacButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.StaffTransacButton.HoverState.BorderColor = System.Drawing.Color.White
            Me.StaffTransacButton.HoverState.FillColor = System.Drawing.Color.White
            Me.StaffTransacButton.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            Me.StaffTransacButton.Image = CType(resources.GetObject("StaffTransacButton.Image"), System.Drawing.Image)
            Me.StaffTransacButton.ImageSize = New System.Drawing.Size(70, 70)
            Me.StaffTransacButton.Location = New System.Drawing.Point(21, 547)
            Me.StaffTransacButton.Name = "StaffTransacButton"
            Me.StaffTransacButton.Size = New System.Drawing.Size(110, 100)
            Me.StaffTransacButton.TabIndex = 4
            '
            'AccountsButton
            '
            Me.AccountsButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AccountsButton.BorderRadius = 15
            Me.AccountsButton.BorderThickness = 1
            Me.AccountsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.AccountsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.AccountsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.AccountsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.AccountsButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AccountsButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.AccountsButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AccountsButton.HoverState.BorderColor = System.Drawing.Color.White
            Me.AccountsButton.HoverState.FillColor = System.Drawing.Color.White
            Me.AccountsButton.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            Me.AccountsButton.Image = CType(resources.GetObject("AccountsButton.Image"), System.Drawing.Image)
            Me.AccountsButton.ImageSize = New System.Drawing.Size(70, 70)
            Me.AccountsButton.Location = New System.Drawing.Point(21, 653)
            Me.AccountsButton.Name = "AccountsButton"
            Me.AccountsButton.Size = New System.Drawing.Size(110, 100)
            Me.AccountsButton.TabIndex = 5
            '
            'AdminLandingPageView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1920, 1080)
            Me.Controls.Add(Me.Guna2Panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "AdminLandingPageView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "AdminLandingPageView"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Guna2Panel2.ResumeLayout(False)
            Me.AdminPanel.ResumeLayout(False)
            Me.AdminSidebar.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents AdminSidebar As Panel
        Friend WithEvents AdminPanel As Panel
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents DashboardButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents AccountsButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents StaffTransacButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents OrderHistoryButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents InventoryButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents MenuListButton As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace