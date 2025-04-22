Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SupplierItemsView
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupplierItemsView))
            Me.EditPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.MainPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.SupplierItemFlowLayout = New System.Windows.Forms.FlowLayoutPanel()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.SearchMenu = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.AddSupplyButton = New Guna.UI2.WinForms.Guna2Button()
            Me.EditPanel.SuspendLayout()
            Me.MainPanel.SuspendLayout()
            Me.Guna2Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'EditPanel
            '
            Me.EditPanel.Controls.Add(Me.MainPanel)
            Me.EditPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.EditPanel.Location = New System.Drawing.Point(0, 0)
            Me.EditPanel.Name = "EditPanel"
            Me.EditPanel.Size = New System.Drawing.Size(1321, 878)
            Me.EditPanel.TabIndex = 10
            '
            'MainPanel
            '
            Me.MainPanel.Controls.Add(Me.SupplierItemFlowLayout)
            Me.MainPanel.Controls.Add(Me.Guna2Panel1)
            Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MainPanel.Location = New System.Drawing.Point(0, 0)
            Me.MainPanel.Name = "MainPanel"
            Me.MainPanel.Size = New System.Drawing.Size(1321, 878)
            Me.MainPanel.TabIndex = 11
            '
            'SupplierItemFlowLayout
            '
            Me.SupplierItemFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SupplierItemFlowLayout.Location = New System.Drawing.Point(0, 100)
            Me.SupplierItemFlowLayout.Name = "SupplierItemFlowLayout"
            Me.SupplierItemFlowLayout.Size = New System.Drawing.Size(1321, 778)
            Me.SupplierItemFlowLayout.TabIndex = 11
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me.AddSupplyButton)
            Me.Guna2Panel1.Controls.Add(Me.SearchMenu)
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(1321, 100)
            Me.Guna2Panel1.TabIndex = 10
            '
            'SearchMenu
            '
            Me.SearchMenu.BorderRadius = 15
            Me.SearchMenu.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.SearchMenu.DefaultText = ""
            Me.SearchMenu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.SearchMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.SearchMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.SearchMenu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.SearchMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.SearchMenu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SearchMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.SearchMenu.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SearchMenu.IconLeft = CType(resources.GetObject("SearchMenu.IconLeft"), System.Drawing.Image)
            Me.SearchMenu.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
            Me.SearchMenu.IconLeftOffset = New System.Drawing.Point(10, 0)
            Me.SearchMenu.IconLeftSize = New System.Drawing.Size(25, 25)
            Me.SearchMenu.Location = New System.Drawing.Point(970, 36)
            Me.SearchMenu.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.SearchMenu.Name = "SearchMenu"
            Me.SearchMenu.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.SearchMenu.PlaceholderText = "Search Menu"
            Me.SearchMenu.SelectedText = ""
            Me.SearchMenu.Size = New System.Drawing.Size(301, 45)
            Me.SearchMenu.TabIndex = 10
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 28.2!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(41, 20)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(221, 61)
            Me.Guna2HtmlLabel1.TabIndex = 9
            Me.Guna2HtmlLabel1.Text = "Supply  List"
            '
            'AddSupplyButton
            '
            Me.AddSupplyButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddSupplyButton.BorderRadius = 15
            Me.AddSupplyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.AddSupplyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.AddSupplyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.AddSupplyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.AddSupplyButton.FillColor = System.Drawing.Color.White
            Me.AddSupplyButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.AddSupplyButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddSupplyButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddSupplyButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddSupplyButton.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            Me.AddSupplyButton.Image = CType(resources.GetObject("AddSupplyButton.Image"), System.Drawing.Image)
            Me.AddSupplyButton.ImageSize = New System.Drawing.Size(30, 30)
            Me.AddSupplyButton.Location = New System.Drawing.Point(901, 36)
            Me.AddSupplyButton.Margin = New System.Windows.Forms.Padding(2)
            Me.AddSupplyButton.Name = "AddSupplyButton"
            Me.AddSupplyButton.Size = New System.Drawing.Size(41, 45)
            Me.AddSupplyButton.TabIndex = 11
            '
            'SupplierItemsView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.ClientSize = New System.Drawing.Size(1321, 878)
            Me.Controls.Add(Me.EditPanel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "SupplierItemsView"
            Me.Text = "SupplierTransactionHistoryView"
            Me.EditPanel.ResumeLayout(False)
            Me.MainPanel.ResumeLayout(False)
            Me.Guna2Panel1.ResumeLayout(False)
            Me.Guna2Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents EditPanel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
        Public WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents SupplierItemFlowLayout As FlowLayoutPanel
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents SearchMenu As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents AddSupplyButton As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace