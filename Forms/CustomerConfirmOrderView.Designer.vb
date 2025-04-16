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
            Me.AddNoteButton = New Guna.UI2.WinForms.Guna2Button()
            Me.OrdersPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.OrdersFlowlayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
            Me.BackButton = New Guna.UI2.WinForms.Guna2Button()
            Me.ViewOrderButton = New Guna.UI2.WinForms.Guna2Button()
            Me.ConfirmOrderPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.OrdersPanel.SuspendLayout()
            Me.Guna2Panel1.SuspendLayout()
            Me.Guna2Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'YourOrderListLbl
            '
            Me.YourOrderListLbl.AutoSize = False
            Me.YourOrderListLbl.BackColor = System.Drawing.Color.Transparent
            Me.YourOrderListLbl.Font = New System.Drawing.Font("Montserrat", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.YourOrderListLbl.Location = New System.Drawing.Point(38, 21)
            Me.YourOrderListLbl.Name = "YourOrderListLbl"
            Me.YourOrderListLbl.Size = New System.Drawing.Size(478, 51)
            Me.YourOrderListLbl.TabIndex = 39
            Me.YourOrderListLbl.Text = "Your Order"
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
            Me.AddNoteButton.Location = New System.Drawing.Point(1284, 21)
            Me.AddNoteButton.Margin = New System.Windows.Forms.Padding(2)
            Me.AddNoteButton.Name = "AddNoteButton"
            Me.AddNoteButton.Size = New System.Drawing.Size(57, 51)
            Me.AddNoteButton.TabIndex = 41
            '
            'OrdersPanel
            '
            Me.OrdersPanel.BackColor = System.Drawing.Color.White
            Me.OrdersPanel.Controls.Add(Me.OrdersFlowlayoutPanel)
            Me.OrdersPanel.Controls.Add(Me.Guna2Panel1)
            Me.OrdersPanel.Controls.Add(Me.Guna2Panel2)
            Me.OrdersPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OrdersPanel.Location = New System.Drawing.Point(0, 0)
            Me.OrdersPanel.Name = "OrdersPanel"
            Me.OrdersPanel.Size = New System.Drawing.Size(1370, 749)
            Me.OrdersPanel.TabIndex = 42
            '
            'OrdersFlowlayoutPanel
            '
            Me.OrdersFlowlayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OrdersFlowlayoutPanel.Location = New System.Drawing.Point(0, 89)
            Me.OrdersFlowlayoutPanel.Name = "OrdersFlowlayoutPanel"
            Me.OrdersFlowlayoutPanel.Size = New System.Drawing.Size(1370, 566)
            Me.OrdersFlowlayoutPanel.TabIndex = 2
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me.AddNoteButton)
            Me.Guna2Panel1.Controls.Add(Me.YourOrderListLbl)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(1370, 89)
            Me.Guna2Panel1.TabIndex = 1
            '
            'Guna2Panel2
            '
            Me.Guna2Panel2.Controls.Add(Me.BackButton)
            Me.Guna2Panel2.Controls.Add(Me.ViewOrderButton)
            Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Guna2Panel2.Location = New System.Drawing.Point(0, 655)
            Me.Guna2Panel2.Name = "Guna2Panel2"
            Me.Guna2Panel2.Size = New System.Drawing.Size(1370, 94)
            Me.Guna2Panel2.TabIndex = 0
            '
            'BackButton
            '
            Me.BackButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.BackButton.BorderRadius = 15
            Me.BackButton.BorderThickness = 1
            Me.BackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BackButton.FillColor = System.Drawing.Color.White
            Me.BackButton.Font = New System.Drawing.Font("Poppins SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BackButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.BackButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.BackButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.BackButton.HoverState.ForeColor = System.Drawing.Color.White
            Me.BackButton.Location = New System.Drawing.Point(674, 21)
            Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
            Me.BackButton.Name = "BackButton"
            Me.BackButton.Size = New System.Drawing.Size(318, 50)
            Me.BackButton.TabIndex = 28
            Me.BackButton.Text = "Back"
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
            Me.ViewOrderButton.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ViewOrderButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.ViewOrderButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.ViewOrderButton.HoverState.FillColor = System.Drawing.Color.White
            Me.ViewOrderButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.ViewOrderButton.Location = New System.Drawing.Point(1023, 21)
            Me.ViewOrderButton.Margin = New System.Windows.Forms.Padding(2)
            Me.ViewOrderButton.Name = "ViewOrderButton"
            Me.ViewOrderButton.Size = New System.Drawing.Size(318, 50)
            Me.ViewOrderButton.TabIndex = 23
            Me.ViewOrderButton.Text = "Confirm Order"
            '
            'ConfirmOrderPanel
            '
            Me.ConfirmOrderPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ConfirmOrderPanel.Location = New System.Drawing.Point(0, 0)
            Me.ConfirmOrderPanel.Name = "ConfirmOrderPanel"
            Me.ConfirmOrderPanel.Size = New System.Drawing.Size(1370, 749)
            Me.ConfirmOrderPanel.TabIndex = 43
            '
            'CustomerConfirmOrderView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1370, 749)
            Me.Controls.Add(Me.OrdersPanel)
            Me.Controls.Add(Me.ConfirmOrderPanel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "CustomerConfirmOrderView"
            Me.Text = "CustomerOrderListPage"
            Me.OrdersPanel.ResumeLayout(False)
            Me.Guna2Panel1.ResumeLayout(False)
            Me.Guna2Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents YourOrderListLbl As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents OrdersPanel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents ViewOrderButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents AddNoteButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents OrdersFlowlayoutPanel As FlowLayoutPanel
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents BackButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents ConfirmOrderPanel As Guna.UI2.WinForms.Guna2Panel
    End Class

End Namespace