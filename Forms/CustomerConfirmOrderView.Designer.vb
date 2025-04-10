Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CustomerConfirmOrderView
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerConfirmOrderView))
            Me.YourOrderListLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.AddNoteButton = New Guna.UI2.WinForms.Guna2Button()
            Me.OrderListLogo = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.OrdersPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
            Me.ViewOrderButton = New Guna.UI2.WinForms.Guna2Button()
            Me.OrdersFlowlayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.LogoIcon = New Guna.UI2.WinForms.Guna2ImageButton()
            Me.Guna2Panel1.SuspendLayout()
            CType(Me.OrderListLogo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.OrdersPanel.SuspendLayout()
            Me.Guna2Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'YourOrderListLbl
            '
            Me.YourOrderListLbl.AutoSize = False
            Me.YourOrderListLbl.BackColor = System.Drawing.Color.Transparent
            Me.YourOrderListLbl.Font = New System.Drawing.Font("Montserrat", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.YourOrderListLbl.Location = New System.Drawing.Point(104, 24)
            Me.YourOrderListLbl.Name = "YourOrderListLbl"
            Me.YourOrderListLbl.Size = New System.Drawing.Size(206, 51)
            Me.YourOrderListLbl.TabIndex = 39
            Me.YourOrderListLbl.Text = "Your Order"
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me.LogoIcon)
            Me.Guna2Panel1.Controls.Add(Me.AddNoteButton)
            Me.Guna2Panel1.Controls.Add(Me.OrderListLogo)
            Me.Guna2Panel1.Controls.Add(Me.YourOrderListLbl)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(1370, 1080)
            Me.Guna2Panel1.TabIndex = 41
            '
            'AddNoteButton
            '
            Me.AddNoteButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddNoteButton.BorderRadius = 15
            Me.AddNoteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.AddNoteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.AddNoteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.AddNoteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.AddNoteButton.FillColor = System.Drawing.Color.White
            Me.AddNoteButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.AddNoteButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddNoteButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddNoteButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddNoteButton.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            Me.AddNoteButton.Image = CType(resources.GetObject("AddNoteButton.Image"), System.Drawing.Image)
            Me.AddNoteButton.ImageSize = New System.Drawing.Size(40, 40)
            Me.AddNoteButton.Location = New System.Drawing.Point(1284, 24)
            Me.AddNoteButton.Margin = New System.Windows.Forms.Padding(2)
            Me.AddNoteButton.Name = "AddNoteButton"
            Me.AddNoteButton.Size = New System.Drawing.Size(57, 51)
            Me.AddNoteButton.TabIndex = 41
            '
            'OrderListLogo
            '
            Me.OrderListLogo.BackColor = System.Drawing.Color.Transparent
            Me.OrderListLogo.ImageRotate = 0!
            Me.OrderListLogo.Location = New System.Drawing.Point(3, 3)
            Me.OrderListLogo.Name = "OrderListLogo"
            Me.OrderListLogo.Size = New System.Drawing.Size(106, 93)
            Me.OrderListLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.OrderListLogo.TabIndex = 40
            Me.OrderListLogo.TabStop = False
            Me.OrderListLogo.UseTransparentBackground = True
            '
            'OrdersPanel
            '
            Me.OrdersPanel.BackColor = System.Drawing.Color.White
            Me.OrdersPanel.Controls.Add(Me.Guna2Panel2)
            Me.OrdersPanel.Controls.Add(Me.Guna2Panel1)
            Me.OrdersPanel.Controls.Add(Me.OrdersFlowlayoutPanel)
            Me.OrdersPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OrdersPanel.Location = New System.Drawing.Point(0, 0)
            Me.OrdersPanel.Name = "OrdersPanel"
            Me.OrdersPanel.Size = New System.Drawing.Size(1370, 749)
            Me.OrdersPanel.TabIndex = 42
            '
            'Guna2Panel2
            '
            Me.Guna2Panel2.Controls.Add(Me.ViewOrderButton)
            Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Guna2Panel2.Location = New System.Drawing.Point(0, 655)
            Me.Guna2Panel2.Name = "Guna2Panel2"
            Me.Guna2Panel2.Size = New System.Drawing.Size(1370, 94)
            Me.Guna2Panel2.TabIndex = 0
            '
            'ViewOrderButton
            '
            Me.ViewOrderButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.ViewOrderButton.BorderRadius = 15
            Me.ViewOrderButton.BorderThickness = 1
            Me.ViewOrderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.ViewOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.ViewOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.ViewOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.ViewOrderButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.ViewOrderButton.Font = New System.Drawing.Font("Poppins Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ViewOrderButton.ForeColor = System.Drawing.Color.White
            Me.ViewOrderButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.ViewOrderButton.HoverState.FillColor = System.Drawing.Color.White
            Me.ViewOrderButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.ViewOrderButton.Location = New System.Drawing.Point(1016, 24)
            Me.ViewOrderButton.Margin = New System.Windows.Forms.Padding(2)
            Me.ViewOrderButton.Name = "ViewOrderButton"
            Me.ViewOrderButton.Size = New System.Drawing.Size(293, 46)
            Me.ViewOrderButton.TabIndex = 23
            Me.ViewOrderButton.Text = "Confirm Order"
            Me.ViewOrderButton.TextOffset = New System.Drawing.Point(0, 1)
            '
            'OrdersFlowlayoutPanel
            '
            Me.OrdersFlowlayoutPanel.BackColor = System.Drawing.Color.White
            Me.OrdersFlowlayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OrdersFlowlayoutPanel.Location = New System.Drawing.Point(0, 0)
            Me.OrdersFlowlayoutPanel.Name = "OrdersFlowlayoutPanel"
            Me.OrdersFlowlayoutPanel.Size = New System.Drawing.Size(1370, 749)
            Me.OrdersFlowlayoutPanel.TabIndex = 1
            '
            'LogoIcon
            '
            Me.LogoIcon.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
            Me.LogoIcon.Cursor = System.Windows.Forms.Cursors.No
            Me.LogoIcon.Enabled = False
            Me.LogoIcon.HoverState.ImageSize = New System.Drawing.Size(64, 64)
            Me.LogoIcon.Image = CType(resources.GetObject("LogoIcon.Image"), System.Drawing.Image)
            Me.LogoIcon.ImageOffset = New System.Drawing.Point(0, 0)
            Me.LogoIcon.ImageRotate = 0!
            Me.LogoIcon.ImageSize = New System.Drawing.Size(100, 94)
            Me.LogoIcon.Location = New System.Drawing.Point(0, 1)
            Me.LogoIcon.Name = "LogoIcon"
            Me.LogoIcon.PressedState.ImageSize = New System.Drawing.Size(64, 64)
            Me.LogoIcon.Size = New System.Drawing.Size(98, 94)
            Me.LogoIcon.TabIndex = 42
            '
            'CustomerConfirmOrderView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1370, 749)
            Me.Controls.Add(Me.OrdersPanel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "CustomerConfirmOrderView"
            Me.Text = "CustomerOrderListPage"
            Me.Guna2Panel1.ResumeLayout(False)
            CType(Me.OrderListLogo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.OrdersPanel.ResumeLayout(False)
            Me.Guna2Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents YourOrderListLbl As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents OrderListLogo As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents OrdersPanel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents OrdersFlowlayoutPanel As FlowLayoutPanel
        Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents ViewOrderButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents AddNoteButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents LogoIcon As Guna.UI2.WinForms.Guna2ImageButton
    End Class

End Namespace