Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CustomerMenuView
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerMenuView))
            Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
            Me.CustomerMainPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.ViewOrderPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.ItemCountLabel = New System.Windows.Forms.Label()
            Me.TotalPriceLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.StartOverButton = New Guna.UI2.WinForms.Guna2Button()
            Me.ViewOrderButton = New Guna.UI2.WinForms.Guna2Button()
            Me.MenuFlowLayout = New System.Windows.Forms.FlowLayoutPanel()
            Me.CategoryPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.Cat3Button = New Guna.UI2.WinForms.Guna2Button()
            Me.Cat2Button = New Guna.UI2.WinForms.Guna2Button()
            Me.Cat1Button = New Guna.UI2.WinForms.Guna2Button()
            Me.AllCategButton = New Guna.UI2.WinForms.Guna2Button()
            Me.CustomerMainPanelView = New Guna.UI2.WinForms.Guna2Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.CustomerMainPanel.SuspendLayout()
            Me.ViewOrderPanel.SuspendLayout()
            Me.CategoryPanel.SuspendLayout()
            Me.CustomerMainPanelView.SuspendLayout()
            Me.SuspendLayout()
            '
            'CustomerMainPanel
            '
            Me.CustomerMainPanel.Controls.Add(Me.ViewOrderPanel)
            Me.CustomerMainPanel.Controls.Add(Me.MenuFlowLayout)
            Me.CustomerMainPanel.Controls.Add(Me.CategoryPanel)
            Me.CustomerMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CustomerMainPanel.Location = New System.Drawing.Point(0, 0)
            Me.CustomerMainPanel.Name = "CustomerMainPanel"
            Me.CustomerMainPanel.Size = New System.Drawing.Size(1386, 788)
            Me.CustomerMainPanel.TabIndex = 21
            '
            'ViewOrderPanel
            '
            Me.ViewOrderPanel.BackColor = System.Drawing.Color.White
            Me.ViewOrderPanel.Controls.Add(Me.ItemCountLabel)
            Me.ViewOrderPanel.Controls.Add(Me.TotalPriceLabel)
            Me.ViewOrderPanel.Controls.Add(Me.StartOverButton)
            Me.ViewOrderPanel.Controls.Add(Me.ViewOrderButton)
            Me.ViewOrderPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.ViewOrderPanel.Location = New System.Drawing.Point(219, 607)
            Me.ViewOrderPanel.Name = "ViewOrderPanel"
            Me.ViewOrderPanel.Size = New System.Drawing.Size(1167, 181)
            Me.ViewOrderPanel.TabIndex = 2
            '
            'ItemCountLabel
            '
            Me.ItemCountLabel.AutoSize = True
            Me.ItemCountLabel.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ItemCountLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.ItemCountLabel.Location = New System.Drawing.Point(25, 101)
            Me.ItemCountLabel.Name = "ItemCountLabel"
            Me.ItemCountLabel.Size = New System.Drawing.Size(211, 48)
            Me.ItemCountLabel.TabIndex = 29
            Me.ItemCountLabel.Text = "3 items in cart"
            '
            'TotalPriceLabel
            '
            Me.TotalPriceLabel.AutoSize = False
            Me.TotalPriceLabel.BackColor = System.Drawing.Color.Transparent
            Me.TotalPriceLabel.Font = New System.Drawing.Font("Poppins Medium", 45.0!, System.Drawing.FontStyle.Bold)
            Me.TotalPriceLabel.Location = New System.Drawing.Point(21, 16)
            Me.TotalPriceLabel.Name = "TotalPriceLabel"
            Me.TotalPriceLabel.Size = New System.Drawing.Size(429, 98)
            Me.TotalPriceLabel.TabIndex = 28
            Me.TotalPriceLabel.Text = "P100.00"
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
            Me.StartOverButton.Font = New System.Drawing.Font("Poppins SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.StartOverButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.StartOverButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.StartOverButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.StartOverButton.HoverState.ForeColor = System.Drawing.Color.White
            Me.StartOverButton.Location = New System.Drawing.Point(878, 90)
            Me.StartOverButton.Margin = New System.Windows.Forms.Padding(2)
            Me.StartOverButton.Name = "StartOverButton"
            Me.StartOverButton.Size = New System.Drawing.Size(318, 50)
            Me.StartOverButton.TabIndex = 26
            Me.StartOverButton.Text = "Start over"
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
            Me.ViewOrderButton.Location = New System.Drawing.Point(878, 16)
            Me.ViewOrderButton.Margin = New System.Windows.Forms.Padding(2)
            Me.ViewOrderButton.Name = "ViewOrderButton"
            Me.ViewOrderButton.Size = New System.Drawing.Size(318, 59)
            Me.ViewOrderButton.TabIndex = 27
            Me.ViewOrderButton.Text = "View Order"
            '
            'MenuFlowLayout
            '
            Me.MenuFlowLayout.BackColor = System.Drawing.Color.DarkGray
            Me.MenuFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MenuFlowLayout.Location = New System.Drawing.Point(219, 0)
            Me.MenuFlowLayout.Name = "MenuFlowLayout"
            Me.MenuFlowLayout.Size = New System.Drawing.Size(1167, 788)
            Me.MenuFlowLayout.TabIndex = 1
            '
            'CategoryPanel
            '
            Me.CategoryPanel.Controls.Add(Me.Cat3Button)
            Me.CategoryPanel.Controls.Add(Me.Cat2Button)
            Me.CategoryPanel.Controls.Add(Me.Cat1Button)
            Me.CategoryPanel.Controls.Add(Me.AllCategButton)
            Me.CategoryPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.CategoryPanel.Location = New System.Drawing.Point(0, 0)
            Me.CategoryPanel.Name = "CategoryPanel"
            Me.CategoryPanel.Size = New System.Drawing.Size(219, 788)
            Me.CategoryPanel.TabIndex = 0
            '
            'Cat3Button
            '
            Me.Cat3Button.BorderColor = System.Drawing.SystemColors.ControlText
            Me.Cat3Button.BorderRadius = 15
            Me.Cat3Button.BorderThickness = 1
            Me.Cat3Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.Cat3Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.Cat3Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.Cat3Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.Cat3Button.FillColor = System.Drawing.Color.White
            Me.Cat3Button.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cat3Button.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Cat3Button.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Cat3Button.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Cat3Button.HoverState.ForeColor = System.Drawing.Color.White
            Me.Cat3Button.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            Me.Cat3Button.Image = CType(resources.GetObject("Cat3Button.Image"), System.Drawing.Image)
            Me.Cat3Button.ImageSize = New System.Drawing.Size(60, 60)
            Me.Cat3Button.Location = New System.Drawing.Point(12, 246)
            Me.Cat3Button.Name = "Cat3Button"
            Me.Cat3Button.Size = New System.Drawing.Size(153, 72)
            Me.Cat3Button.TabIndex = 5
            Me.Cat3Button.Text = "Categ 3"
            Me.Cat3Button.TextOffset = New System.Drawing.Point(0, 5)
            '
            'Cat2Button
            '
            Me.Cat2Button.BorderColor = System.Drawing.SystemColors.ControlText
            Me.Cat2Button.BorderRadius = 15
            Me.Cat2Button.BorderThickness = 1
            Me.Cat2Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.Cat2Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.Cat2Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.Cat2Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.Cat2Button.FillColor = System.Drawing.Color.White
            Me.Cat2Button.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cat2Button.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Cat2Button.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Cat2Button.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Cat2Button.HoverState.ForeColor = System.Drawing.Color.White
            Me.Cat2Button.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            Me.Cat2Button.Image = CType(resources.GetObject("Cat2Button.Image"), System.Drawing.Image)
            Me.Cat2Button.ImageSize = New System.Drawing.Size(60, 60)
            Me.Cat2Button.Location = New System.Drawing.Point(12, 168)
            Me.Cat2Button.Name = "Cat2Button"
            Me.Cat2Button.Size = New System.Drawing.Size(196, 72)
            Me.Cat2Button.TabIndex = 4
            Me.Cat2Button.Text = "Categ 2"
            Me.Cat2Button.TextOffset = New System.Drawing.Point(0, 5)
            '
            'Cat1Button
            '
            Me.Cat1Button.BorderColor = System.Drawing.SystemColors.ControlText
            Me.Cat1Button.BorderRadius = 15
            Me.Cat1Button.BorderThickness = 1
            Me.Cat1Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.Cat1Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.Cat1Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.Cat1Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.Cat1Button.FillColor = System.Drawing.Color.White
            Me.Cat1Button.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cat1Button.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Cat1Button.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Cat1Button.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Cat1Button.HoverState.ForeColor = System.Drawing.Color.White
            Me.Cat1Button.HoverState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            Me.Cat1Button.Image = CType(resources.GetObject("Cat1Button.Image"), System.Drawing.Image)
            Me.Cat1Button.ImageSize = New System.Drawing.Size(60, 60)
            Me.Cat1Button.Location = New System.Drawing.Point(12, 90)
            Me.Cat1Button.Name = "Cat1Button"
            Me.Cat1Button.Size = New System.Drawing.Size(153, 72)
            Me.Cat1Button.TabIndex = 3
            Me.Cat1Button.Text = "Categ 1"
            Me.Cat1Button.TextOffset = New System.Drawing.Point(0, 5)
            '
            'AllCategButton
            '
            Me.AllCategButton.BorderColor = System.Drawing.SystemColors.ControlText
            Me.AllCategButton.BorderRadius = 15
            Me.AllCategButton.BorderThickness = 1
            Me.AllCategButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.AllCategButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.AllCategButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.AllCategButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.AllCategButton.FillColor = System.Drawing.Color.White
            Me.AllCategButton.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AllCategButton.ForeColor = System.Drawing.SystemColors.ControlText
            Me.AllCategButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AllCategButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AllCategButton.HoverState.ForeColor = System.Drawing.Color.White
            Me.AllCategButton.HoverState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
            Me.AllCategButton.Image = CType(resources.GetObject("AllCategButton.Image"), System.Drawing.Image)
            Me.AllCategButton.ImageSize = New System.Drawing.Size(60, 60)
            Me.AllCategButton.Location = New System.Drawing.Point(12, 12)
            Me.AllCategButton.Name = "AllCategButton"
            Me.AllCategButton.Size = New System.Drawing.Size(153, 72)
            Me.AllCategButton.TabIndex = 2
            Me.AllCategButton.Text = "All"
            Me.AllCategButton.TextOffset = New System.Drawing.Point(0, 5)
            '
            'CustomerMainPanelView
            '
            Me.CustomerMainPanelView.BackColor = System.Drawing.Color.Transparent
            Me.CustomerMainPanelView.Controls.Add(Me.Panel1)
            Me.CustomerMainPanelView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CustomerMainPanelView.Location = New System.Drawing.Point(0, 0)
            Me.CustomerMainPanelView.Name = "CustomerMainPanelView"
            Me.CustomerMainPanelView.Size = New System.Drawing.Size(1386, 788)
            Me.CustomerMainPanelView.TabIndex = 22
            Me.CustomerMainPanelView.Visible = False
            '
            'Panel1
            '
            Me.Panel1.Location = New System.Drawing.Point(2, 1)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1920, 1080)
            Me.Panel1.TabIndex = 0
            '
            'CustomerMenuView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1386, 788)
            Me.Controls.Add(Me.CustomerMainPanelView)
            Me.Controls.Add(Me.CustomerMainPanel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "CustomerMenuView"
            Me.Text = "CustomerMenuPage"
            Me.CustomerMainPanel.ResumeLayout(False)
            Me.ViewOrderPanel.ResumeLayout(False)
            Me.ViewOrderPanel.PerformLayout()
            Me.CategoryPanel.ResumeLayout(False)
            Me.CustomerMainPanelView.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
        Friend WithEvents CustomerMainPanel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents CategoryPanel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents AllCategButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Cat3Button As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Cat2Button As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Cat1Button As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents MenuFlowLayout As FlowLayoutPanel
        Friend WithEvents ViewOrderPanel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents ItemCountLabel As Label
        Friend WithEvents TotalPriceLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents StartOverButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents ViewOrderButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents CustomerMainPanelView As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Panel1 As Panel
    End Class

End Namespace