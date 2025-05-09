﻿Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AdminMenuView
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminMenuView))
            Me.MenuListFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.SearchMenu = New Guna.UI2.WinForms.Guna2TextBox()
            Me.AddMenuButton = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.SuspendLayout()
            '
            'MenuListFlowLayoutPanel
            '
            Me.MenuListFlowLayoutPanel.AutoScroll = True
            Me.MenuListFlowLayoutPanel.Location = New System.Drawing.Point(0, 134)
            Me.MenuListFlowLayoutPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.MenuListFlowLayoutPanel.Name = "MenuListFlowLayoutPanel"
            Me.MenuListFlowLayoutPanel.Size = New System.Drawing.Size(1761, 946)
            Me.MenuListFlowLayoutPanel.TabIndex = 5
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
            Me.SearchMenu.IconLeftOffset = New System.Drawing.Point(10, 0)
            Me.SearchMenu.IconLeftSize = New System.Drawing.Size(25, 25)
            Me.SearchMenu.Location = New System.Drawing.Point(1323, 36)
            Me.SearchMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.SearchMenu.Name = "SearchMenu"
            Me.SearchMenu.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.SearchMenu.PlaceholderText = "Search Menu"
            Me.SearchMenu.SelectedText = ""
            Me.SearchMenu.Size = New System.Drawing.Size(401, 55)
            Me.SearchMenu.TabIndex = 3
            '
            'AddMenuButton
            '
            Me.AddMenuButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddMenuButton.BorderRadius = 15
            Me.AddMenuButton.BorderThickness = 1
            Me.AddMenuButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.AddMenuButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.AddMenuButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.AddMenuButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.AddMenuButton.FillColor = System.Drawing.Color.White
            Me.AddMenuButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.AddMenuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddMenuButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddMenuButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AddMenuButton.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            Me.AddMenuButton.Image = CType(resources.GetObject("AddMenuButton.Image"), System.Drawing.Image)
            Me.AddMenuButton.ImageSize = New System.Drawing.Size(40, 40)
            Me.AddMenuButton.Location = New System.Drawing.Point(1248, 36)
            Me.AddMenuButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.AddMenuButton.Name = "AddMenuButton"
            Me.AddMenuButton.Size = New System.Drawing.Size(55, 55)
            Me.AddMenuButton.TabIndex = 2
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.AutoSize = False
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(43, 30)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(263, 74)
            Me.Guna2HtmlLabel1.TabIndex = 4
            Me.Guna2HtmlLabel1.Text = "Menu List"
            '
            'AdminMenuView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1761, 1081)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Controls.Add(Me.MenuListFlowLayoutPanel)
            Me.Controls.Add(Me.AddMenuButton)
            Me.Controls.Add(Me.SearchMenu)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "AdminMenuView"
            Me.Text = "AdminMenu"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents MenuListFlowLayoutPanel As FlowLayoutPanel
        Friend WithEvents SearchMenu As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents AddMenuButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class


End Namespace