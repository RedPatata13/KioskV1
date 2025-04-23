Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class StaffSideBar
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffSideBar))
            Me.Guna2HtmlToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
            Me.PendingOrdersButton = New Guna.UI2.WinForms.Guna2Button()
            Me.LogOutButton = New Guna.UI2.WinForms.Guna2Button()
            Me.CreditSalesButton = New Guna.UI2.WinForms.Guna2Button()
            Me.POSButton = New Guna.UI2.WinForms.Guna2Button()
            Me.SuspendLayout()
            '
            'Guna2HtmlToolTip1
            '
            Me.Guna2HtmlToolTip1.AllowLinksHandling = True
            Me.Guna2HtmlToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
            '
            'PendingOrdersButton
            '
            Me.PendingOrdersButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.PendingOrdersButton.BorderRadius = 15
            Me.PendingOrdersButton.BorderThickness = 1
            Me.PendingOrdersButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.PendingOrdersButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.PendingOrdersButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.PendingOrdersButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.PendingOrdersButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.PendingOrdersButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.PendingOrdersButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.PendingOrdersButton.HoverState.BorderColor = System.Drawing.Color.White
            Me.PendingOrdersButton.HoverState.FillColor = System.Drawing.Color.White
            Me.PendingOrdersButton.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            Me.PendingOrdersButton.Image = Global.KioskV0.My.Resources.Resources.order_history1
            Me.PendingOrdersButton.ImageSize = New System.Drawing.Size(70, 70)
            Me.PendingOrdersButton.Location = New System.Drawing.Point(24, 338)
            Me.PendingOrdersButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.PendingOrdersButton.Name = "PendingOrdersButton"
            Me.PendingOrdersButton.Size = New System.Drawing.Size(109, 100)
            Me.PendingOrdersButton.TabIndex = 12
            Me.Guna2HtmlToolTip1.SetToolTip(Me.PendingOrdersButton, "Transactions")
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
            Me.LogOutButton.Location = New System.Drawing.Point(24, 967)
            Me.LogOutButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.LogOutButton.Name = "LogOutButton"
            Me.LogOutButton.Size = New System.Drawing.Size(109, 100)
            Me.LogOutButton.TabIndex = 11
            '
            'CreditSalesButton
            '
            Me.CreditSalesButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.CreditSalesButton.BorderRadius = 15
            Me.CreditSalesButton.BorderThickness = 1
            Me.CreditSalesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.CreditSalesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.CreditSalesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.CreditSalesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.CreditSalesButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.CreditSalesButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.CreditSalesButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.CreditSalesButton.HoverState.BorderColor = System.Drawing.Color.White
            Me.CreditSalesButton.HoverState.FillColor = System.Drawing.Color.White
            Me.CreditSalesButton.HoverState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            Me.CreditSalesButton.Image = CType(resources.GetObject("CreditSalesButton.Image"), System.Drawing.Image)
            Me.CreditSalesButton.ImageSize = New System.Drawing.Size(70, 70)
            Me.CreditSalesButton.Location = New System.Drawing.Point(24, 219)
            Me.CreditSalesButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.CreditSalesButton.Name = "CreditSalesButton"
            Me.CreditSalesButton.Size = New System.Drawing.Size(109, 100)
            Me.CreditSalesButton.TabIndex = 3
            Me.Guna2HtmlToolTip1.SetToolTip(Me.CreditSalesButton, "Transactions")
            '
            'POSButton
            '
            Me.POSButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.POSButton.BorderRadius = 15
            Me.POSButton.BorderThickness = 1
            Me.POSButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.POSButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.POSButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.POSButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.POSButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.POSButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.POSButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.POSButton.HoverState.BorderColor = System.Drawing.Color.White
            Me.POSButton.HoverState.FillColor = System.Drawing.Color.White
            Me.POSButton.HoverState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
            Me.POSButton.Image = CType(resources.GetObject("POSButton.Image"), System.Drawing.Image)
            Me.POSButton.ImageSize = New System.Drawing.Size(70, 70)
            Me.POSButton.Location = New System.Drawing.Point(24, 113)
            Me.POSButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.POSButton.Name = "POSButton"
            Me.POSButton.Size = New System.Drawing.Size(109, 100)
            Me.POSButton.TabIndex = 2
            Me.Guna2HtmlToolTip1.SetToolTip(Me.POSButton, "PendingOrders")
            '
            'StaffSideBar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(159, 1081)
            Me.Controls.Add(Me.PendingOrdersButton)
            Me.Controls.Add(Me.LogOutButton)
            Me.Controls.Add(Me.CreditSalesButton)
            Me.Controls.Add(Me.POSButton)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "StaffSideBar"
            Me.Text = "StaffSideBar"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents POSButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents CreditSalesButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents LogOutButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Guna2HtmlToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
        Friend WithEvents PendingOrdersButton As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace