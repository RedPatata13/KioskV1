Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SupplierSidebar
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupplierSidebar))
            Me.Guna2HtmlToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
            Me.RequestsButton = New Guna.UI2.WinForms.Guna2Button()
            Me.ItemsButton = New Guna.UI2.WinForms.Guna2Button()
            Me.TransacHistoryButton = New Guna.UI2.WinForms.Guna2Button()
            Me.LogOutButton = New Guna.UI2.WinForms.Guna2Button()
            Me.SuspendLayout()
            '
            'Guna2HtmlToolTip1
            '
            Me.Guna2HtmlToolTip1.AllowLinksHandling = True
            Me.Guna2HtmlToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
            '
            'RequestsButton
            '
            Me.RequestsButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.RequestsButton.BorderRadius = 15
            Me.RequestsButton.BorderThickness = 1
            Me.RequestsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.RequestsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.RequestsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.RequestsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.RequestsButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.RequestsButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.RequestsButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.RequestsButton.HoverState.BorderColor = System.Drawing.Color.White
            Me.RequestsButton.HoverState.FillColor = System.Drawing.Color.White
            Me.RequestsButton.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            Me.RequestsButton.Image = CType(resources.GetObject("RequestsButton.Image"), System.Drawing.Image)
            Me.RequestsButton.ImageSize = New System.Drawing.Size(70, 70)
            Me.RequestsButton.Location = New System.Drawing.Point(11, 47)
            Me.RequestsButton.Margin = New System.Windows.Forms.Padding(2)
            Me.RequestsButton.Name = "RequestsButton"
            Me.RequestsButton.Size = New System.Drawing.Size(88, 82)
            Me.RequestsButton.TabIndex = 2
            Me.Guna2HtmlToolTip1.SetToolTip(Me.RequestsButton, "Dashboard")
            '
            'ItemsButton
            '
            Me.ItemsButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ItemsButton.BorderRadius = 15
            Me.ItemsButton.BorderThickness = 1
            Me.ItemsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.ItemsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.ItemsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.ItemsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.ItemsButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ItemsButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.ItemsButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ItemsButton.HoverState.BorderColor = System.Drawing.Color.White
            Me.ItemsButton.HoverState.FillColor = System.Drawing.Color.White
            Me.ItemsButton.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            Me.ItemsButton.Image = CType(resources.GetObject("ItemsButton.Image"), System.Drawing.Image)
            Me.ItemsButton.ImageSize = New System.Drawing.Size(70, 70)
            Me.ItemsButton.Location = New System.Drawing.Point(11, 150)
            Me.ItemsButton.Margin = New System.Windows.Forms.Padding(2)
            Me.ItemsButton.Name = "ItemsButton"
            Me.ItemsButton.Size = New System.Drawing.Size(88, 81)
            Me.ItemsButton.TabIndex = 7
            Me.Guna2HtmlToolTip1.SetToolTip(Me.ItemsButton, "Inventory")
            '
            'TransacHistoryButton
            '
            Me.TransacHistoryButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.TransacHistoryButton.BorderRadius = 15
            Me.TransacHistoryButton.BorderThickness = 1
            Me.TransacHistoryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.TransacHistoryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.TransacHistoryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.TransacHistoryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.TransacHistoryButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.TransacHistoryButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TransacHistoryButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.TransacHistoryButton.HoverState.BorderColor = System.Drawing.Color.White
            Me.TransacHistoryButton.HoverState.FillColor = System.Drawing.Color.White
            Me.TransacHistoryButton.HoverState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            Me.TransacHistoryButton.Image = CType(resources.GetObject("TransacHistoryButton.Image"), System.Drawing.Image)
            Me.TransacHistoryButton.ImageSize = New System.Drawing.Size(70, 70)
            Me.TransacHistoryButton.Location = New System.Drawing.Point(11, 250)
            Me.TransacHistoryButton.Margin = New System.Windows.Forms.Padding(2)
            Me.TransacHistoryButton.Name = "TransacHistoryButton"
            Me.TransacHistoryButton.Size = New System.Drawing.Size(88, 81)
            Me.TransacHistoryButton.TabIndex = 8
            Me.Guna2HtmlToolTip1.SetToolTip(Me.TransacHistoryButton, "Order History")
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
            Me.LogOutButton.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            Me.LogOutButton.Image = CType(resources.GetObject("LogOutButton.Image"), System.Drawing.Image)
            Me.LogOutButton.ImageSize = New System.Drawing.Size(50, 50)
            Me.LogOutButton.Location = New System.Drawing.Point(11, 765)
            Me.LogOutButton.Margin = New System.Windows.Forms.Padding(2)
            Me.LogOutButton.Name = "LogOutButton"
            Me.LogOutButton.Size = New System.Drawing.Size(82, 81)
            Me.LogOutButton.TabIndex = 11
            Me.Guna2HtmlToolTip1.SetToolTip(Me.LogOutButton, "Logout")
            '
            'SupplierSidebar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(119, 878)
            Me.Controls.Add(Me.LogOutButton)
            Me.Controls.Add(Me.TransacHistoryButton)
            Me.Controls.Add(Me.ItemsButton)
            Me.Controls.Add(Me.RequestsButton)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "SupplierSidebar"
            Me.Text = "SupplierSidebar"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Guna2HtmlToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
        Friend WithEvents RequestsButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents ItemsButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents TransacHistoryButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents LogOutButton As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace