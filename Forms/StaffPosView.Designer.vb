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
            Me.SearchProductTextBox = New Guna.UI2.WinForms.Guna2TextBox()
            Me.DeleteAllButton = New Guna.UI2.WinForms.Guna2Button()
            Me.PayButton = New Guna.UI2.WinForms.Guna2Button()
            Me.CurrentItemsFlowPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
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
            'SearchProductTextBox
            '
            Me.SearchProductTextBox.BorderColor = System.Drawing.Color.Black
            Me.SearchProductTextBox.BorderRadius = 17
            Me.SearchProductTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.SearchProductTextBox.DefaultText = ""
            Me.SearchProductTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.SearchProductTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.SearchProductTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.SearchProductTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.SearchProductTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SearchProductTextBox.Font = New System.Drawing.Font("Poppins", 10.0!)
            Me.SearchProductTextBox.ForeColor = System.Drawing.Color.Black
            Me.SearchProductTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SearchProductTextBox.Location = New System.Drawing.Point(317, 45)
            Me.SearchProductTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            Me.SearchProductTextBox.Name = "SearchProductTextBox"
            Me.SearchProductTextBox.PlaceholderText = "Product"
            Me.SearchProductTextBox.SelectedText = ""
            Me.SearchProductTextBox.Size = New System.Drawing.Size(254, 34)
            Me.SearchProductTextBox.TabIndex = 1
            '
            'DeleteAllButton
            '
            Me.DeleteAllButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DeleteAllButton.BorderRadius = 17
            Me.DeleteAllButton.BorderThickness = 1
            Me.DeleteAllButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.DeleteAllButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.DeleteAllButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.DeleteAllButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.DeleteAllButton.FillColor = System.Drawing.Color.Transparent
            Me.DeleteAllButton.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.DeleteAllButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DeleteAllButton.Location = New System.Drawing.Point(55, 779)
            Me.DeleteAllButton.Name = "DeleteAllButton"
            Me.DeleteAllButton.Size = New System.Drawing.Size(233, 39)
            Me.DeleteAllButton.TabIndex = 2
            Me.DeleteAllButton.Text = "Delete All"
            Me.DeleteAllButton.TextOffset = New System.Drawing.Point(0, 2)
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
            Me.PayButton.Location = New System.Drawing.Point(317, 779)
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
            Me.CurrentItemsFlowPanel.Location = New System.Drawing.Point(42, 101)
            Me.CurrentItemsFlowPanel.Name = "CurrentItemsFlowPanel"
            Me.CurrentItemsFlowPanel.Size = New System.Drawing.Size(529, 663)
            Me.CurrentItemsFlowPanel.TabIndex = 4
            '
            'FlowLayoutPanel2
            '
            Me.FlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.FlowLayoutPanel2.Location = New System.Drawing.Point(591, 45)
            Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
            Me.FlowLayoutPanel2.Size = New System.Drawing.Size(687, 763)
            Me.FlowLayoutPanel2.TabIndex = 5
            '
            'StaffPosView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1305, 839)
            Me.Controls.Add(Me.FlowLayoutPanel2)
            Me.Controls.Add(Me.CurrentItemsFlowPanel)
            Me.Controls.Add(Me.PayButton)
            Me.Controls.Add(Me.DeleteAllButton)
            Me.Controls.Add(Me.SearchProductTextBox)
            Me.Controls.Add(Me.SearchOrderTextbox)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "StaffPosView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "StaffPosView"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents SearchOrderTextbox As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents SearchProductTextBox As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents DeleteAllButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents PayButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents CurrentItemsFlowPanel As FlowLayoutPanel
        Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    End Class

End Namespace