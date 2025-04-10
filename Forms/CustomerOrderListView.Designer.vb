Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CustomerOrderListView
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerOrderListView))
            Me.YourOrderListLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.TopBar = New Guna.UI2.WinForms.Guna2Panel()
            Me.OrdersPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.Buttons = New Guna.UI2.WinForms.Guna2Panel()
            Me.StartOverButton = New Guna.UI2.WinForms.Guna2Button()
            Me.OrderMoreButton = New Guna.UI2.WinForms.Guna2Button()
            Me.OrderListFlowLayout = New System.Windows.Forms.FlowLayoutPanel()
            Me.OrderListPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.LogoIcon = New Guna.UI2.WinForms.Guna2ImageButton()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.TopBar.SuspendLayout()
            Me.OrdersPanel.SuspendLayout()
            Me.Buttons.SuspendLayout()
            Me.Guna2Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'YourOrderListLbl
            '
            Me.YourOrderListLbl.AutoSize = False
            Me.YourOrderListLbl.BackColor = System.Drawing.Color.Transparent
            Me.YourOrderListLbl.Font = New System.Drawing.Font("Montserrat", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.YourOrderListLbl.Location = New System.Drawing.Point(104, 25)
            Me.YourOrderListLbl.Name = "YourOrderListLbl"
            Me.YourOrderListLbl.Size = New System.Drawing.Size(197, 51)
            Me.YourOrderListLbl.TabIndex = 39
            Me.YourOrderListLbl.Text = "Your Order"
            '
            'TopBar
            '
            Me.TopBar.Controls.Add(Me.LogoIcon)
            Me.TopBar.Controls.Add(Me.YourOrderListLbl)
            Me.TopBar.Controls.Add(Me.Guna2Panel1)
            Me.TopBar.Dock = System.Windows.Forms.DockStyle.Top
            Me.TopBar.Location = New System.Drawing.Point(0, 0)
            Me.TopBar.Name = "TopBar"
            Me.TopBar.Size = New System.Drawing.Size(1370, 1080)
            Me.TopBar.TabIndex = 41
            '
            'OrdersPanel
            '
            Me.OrdersPanel.Controls.Add(Me.Buttons)
            Me.OrdersPanel.Controls.Add(Me.OrderListFlowLayout)
            Me.OrdersPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OrdersPanel.Location = New System.Drawing.Point(0, 1080)
            Me.OrdersPanel.Name = "OrdersPanel"
            Me.OrdersPanel.Size = New System.Drawing.Size(1370, 0)
            Me.OrdersPanel.TabIndex = 42
            '
            'Buttons
            '
            Me.Buttons.BackColor = System.Drawing.Color.White
            Me.Buttons.Controls.Add(Me.OrderListPanel)
            Me.Buttons.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Buttons.Location = New System.Drawing.Point(0, -140)
            Me.Buttons.Name = "Buttons"
            Me.Buttons.Size = New System.Drawing.Size(1370, 140)
            Me.Buttons.TabIndex = 2
            '
            'StartOverButton
            '
            Me.StartOverButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.StartOverButton.BorderRadius = 15
            Me.StartOverButton.BorderThickness = 1
            Me.StartOverButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.StartOverButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.StartOverButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.StartOverButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.StartOverButton.FillColor = System.Drawing.Color.White
            Me.StartOverButton.Font = New System.Drawing.Font("Poppins", 14.0!)
            Me.StartOverButton.ForeColor = System.Drawing.Color.DimGray
            Me.StartOverButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.StartOverButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.StartOverButton.HoverState.ForeColor = System.Drawing.Color.White
            Me.StartOverButton.Location = New System.Drawing.Point(42, 691)
            Me.StartOverButton.Margin = New System.Windows.Forms.Padding(2)
            Me.StartOverButton.Name = "StartOverButton"
            Me.StartOverButton.Size = New System.Drawing.Size(318, 38)
            Me.StartOverButton.TabIndex = 27
            Me.StartOverButton.Text = "Start over"
            Me.StartOverButton.TextOffset = New System.Drawing.Point(0, 2)
            '
            'OrderMoreButton
            '
            Me.OrderMoreButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.OrderMoreButton.BorderRadius = 15
            Me.OrderMoreButton.BorderThickness = 1
            Me.OrderMoreButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.OrderMoreButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.OrderMoreButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.OrderMoreButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.OrderMoreButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.OrderMoreButton.Font = New System.Drawing.Font("Poppins Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OrderMoreButton.ForeColor = System.Drawing.Color.White
            Me.OrderMoreButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.OrderMoreButton.HoverState.FillColor = System.Drawing.Color.White
            Me.OrderMoreButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.OrderMoreButton.Location = New System.Drawing.Point(42, 632)
            Me.OrderMoreButton.Margin = New System.Windows.Forms.Padding(2)
            Me.OrderMoreButton.Name = "OrderMoreButton"
            Me.OrderMoreButton.Size = New System.Drawing.Size(318, 50)
            Me.OrderMoreButton.TabIndex = 21
            Me.OrderMoreButton.Text = "Order more"
            Me.OrderMoreButton.TextOffset = New System.Drawing.Point(0, 2)
            '
            'OrderListFlowLayout
            '
            Me.OrderListFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OrderListFlowLayout.Location = New System.Drawing.Point(0, 0)
            Me.OrderListFlowLayout.Name = "OrderListFlowLayout"
            Me.OrderListFlowLayout.Size = New System.Drawing.Size(1370, 0)
            Me.OrderListFlowLayout.TabIndex = 1
            '
            'OrderListPanel
            '
            Me.OrderListPanel.BackColor = System.Drawing.Color.Transparent
            Me.OrderListPanel.BorderColor = System.Drawing.Color.Transparent
            Me.OrderListPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.OrderListPanel.FillColor = System.Drawing.Color.Transparent
            Me.OrderListPanel.Location = New System.Drawing.Point(-550, 0)
            Me.OrderListPanel.Name = "OrderListPanel"
            Me.OrderListPanel.Size = New System.Drawing.Size(1920, 140)
            Me.OrderListPanel.TabIndex = 0
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
            Me.LogoIcon.Location = New System.Drawing.Point(0, 0)
            Me.LogoIcon.Name = "LogoIcon"
            Me.LogoIcon.PressedState.ImageSize = New System.Drawing.Size(64, 64)
            Me.LogoIcon.Size = New System.Drawing.Size(98, 94)
            Me.LogoIcon.TabIndex = 40
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me.OrderMoreButton)
            Me.Guna2Panel1.Controls.Add(Me.StartOverButton)
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(1920, 1080)
            Me.Guna2Panel1.TabIndex = 41
            '
            'CustomerOrderListView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1370, 749)
            Me.Controls.Add(Me.OrdersPanel)
            Me.Controls.Add(Me.TopBar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "CustomerOrderListView"
            Me.Text = "CustomerOrderListPage"
            Me.TopBar.ResumeLayout(False)
            Me.OrdersPanel.ResumeLayout(False)
            Me.Buttons.ResumeLayout(False)
            Me.Guna2Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents YourOrderListLbl As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents TopBar As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents OrdersPanel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Buttons As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents OrderListFlowLayout As FlowLayoutPanel
        Friend WithEvents OrderListPanel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents OrderMoreButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents StartOverButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents LogoIcon As Guna.UI2.WinForms.Guna2ImageButton
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    End Class


End Namespace