Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class StaffPosView
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
            Me.SearchOrderTextbox = New Guna.UI2.WinForms.Guna2TextBox()
            Me.DiscardButton = New Guna.UI2.WinForms.Guna2Button()
            Me.PayButton = New Guna.UI2.WinForms.Guna2Button()
            Me.CurrentItemsFlowPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.MenuItemsFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.AddMoreButton = New Guna.UI2.WinForms.Guna2Button()
            Me.AddItemsToOrder = New Guna.UI2.WinForms.Guna2Button()
            Me.SuspendLayout()
            '
            'SearchOrderTextbox
            '
            Me.SearchOrderTextbox.BorderColor = System.Drawing.Color.Black
            Me.SearchOrderTextbox.BorderRadius = 17
            Me.SearchOrderTextbox.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.SearchOrderTextbox.DefaultText = ""
            Me.SearchOrderTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.SearchOrderTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.SearchOrderTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.SearchOrderTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.SearchOrderTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SearchOrderTextbox.Font = New System.Drawing.Font("Poppins", 10.0!)
            Me.SearchOrderTextbox.ForeColor = System.Drawing.Color.Black
            Me.SearchOrderTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SearchOrderTextbox.Location = New System.Drawing.Point(42, 45)
            Me.SearchOrderTextbox.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
            Me.SearchOrderTextbox.Name = "SearchOrderTextbox"
            Me.SearchOrderTextbox.PlaceholderText = "Order"
            Me.SearchOrderTextbox.SelectedText = ""
            Me.SearchOrderTextbox.Size = New System.Drawing.Size(254, 34)
            Me.SearchOrderTextbox.TabIndex = 0
            '
            'DiscardButton
            '
            Me.DiscardButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DiscardButton.BorderRadius = 17
            Me.DiscardButton.BorderThickness = 1
            Me.DiscardButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.DiscardButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.DiscardButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.DiscardButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.DiscardButton.FillColor = System.Drawing.Color.Transparent
            Me.DiscardButton.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.DiscardButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DiscardButton.Location = New System.Drawing.Point(64, 744)
            Me.DiscardButton.Name = "DiscardButton"
            Me.DiscardButton.Size = New System.Drawing.Size(233, 39)
            Me.DiscardButton.TabIndex = 2
            Me.DiscardButton.Text = "Discard Order"
            Me.DiscardButton.TextOffset = New System.Drawing.Point(0, 2)
            '
            'PayButton
            '
            Me.PayButton.BackColor = System.Drawing.Color.Transparent
            Me.PayButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.PayButton.BorderRadius = 17
            Me.PayButton.BorderThickness = 1
            Me.PayButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.PayButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.PayButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.PayButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.PayButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.PayButton.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.PayButton.ForeColor = System.Drawing.Color.White
            Me.PayButton.Location = New System.Drawing.Point(304, 744)
            Me.PayButton.Name = "PayButton"
            Me.PayButton.ShadowDecoration.BorderRadius = 20
            Me.PayButton.ShadowDecoration.Depth = 50
            Me.PayButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4, 0, 4, 4)
            Me.PayButton.Size = New System.Drawing.Size(233, 39)
            Me.PayButton.TabIndex = 3
            Me.PayButton.Text = "Pay"
            Me.PayButton.TextOffset = New System.Drawing.Point(0, 2)
            '
            'CurrentItemsFlowPanel
            '
            Me.CurrentItemsFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.CurrentItemsFlowPanel.Location = New System.Drawing.Point(42, 88)
            Me.CurrentItemsFlowPanel.Name = "CurrentItemsFlowPanel"
            Me.CurrentItemsFlowPanel.Size = New System.Drawing.Size(529, 640)
            Me.CurrentItemsFlowPanel.TabIndex = 4
            '
            'MenuItemsFlowLayoutPanel
            '
            Me.MenuItemsFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.MenuItemsFlowLayoutPanel.Location = New System.Drawing.Point(591, 88)
            Me.MenuItemsFlowLayoutPanel.Name = "MenuItemsFlowLayoutPanel"
            Me.MenuItemsFlowLayoutPanel.Size = New System.Drawing.Size(687, 640)
            Me.MenuItemsFlowLayoutPanel.TabIndex = 5
            '
            'AddMoreButton
            '
            Me.AddMoreButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.AddMoreButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.AddMoreButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.AddMoreButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.AddMoreButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddMoreButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.AddMoreButton.ForeColor = System.Drawing.Color.White
            Me.AddMoreButton.Location = New System.Drawing.Point(1096, 40)
            Me.AddMoreButton.Name = "AddMoreButton"
            Me.AddMoreButton.Size = New System.Drawing.Size(180, 45)
            Me.AddMoreButton.TabIndex = 6
            Me.AddMoreButton.Text = "Add more items"
            '
            'AddItemsToOrder
            '
            Me.AddItemsToOrder.BorderColor = System.Drawing.Color.Red
            Me.AddItemsToOrder.BorderRadius = 1
            Me.AddItemsToOrder.BorderThickness = 1
            Me.AddItemsToOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.AddItemsToOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.AddItemsToOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.AddItemsToOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.AddItemsToOrder.FillColor = System.Drawing.Color.White
            Me.AddItemsToOrder.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.AddItemsToOrder.ForeColor = System.Drawing.Color.Black
            Me.AddItemsToOrder.Location = New System.Drawing.Point(904, 40)
            Me.AddItemsToOrder.Name = "AddItemsToOrder"
            Me.AddItemsToOrder.Size = New System.Drawing.Size(180, 45)
            Me.AddItemsToOrder.TabIndex = 7
            Me.AddItemsToOrder.Text = "Add all items to order"
            '
            'StaffPosView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1305, 839)
            Me.Controls.Add(Me.AddItemsToOrder)
            Me.Controls.Add(Me.AddMoreButton)
            Me.Controls.Add(Me.MenuItemsFlowLayoutPanel)
            Me.Controls.Add(Me.CurrentItemsFlowPanel)
            Me.Controls.Add(Me.PayButton)
            Me.Controls.Add(Me.DiscardButton)
            Me.Controls.Add(Me.SearchOrderTextbox)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "StaffPosView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "StaffPosView"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents SearchOrderTextbox As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents DiscardButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents PayButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents CurrentItemsFlowPanel As FlowLayoutPanel
        Friend WithEvents MenuItemsFlowLayoutPanel As FlowLayoutPanel
        Friend WithEvents AddMoreButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents AddItemsToOrder As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace