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
            Me.CategoryPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.MenuFlowLayout = New System.Windows.Forms.FlowLayoutPanel()
            Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
            Me.CustomerMainPanel.SuspendLayout()
            Me.CategoryPanel.SuspendLayout()
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
            Me.CustomerMainPanel.Size = New System.Drawing.Size(1426, 817)
            Me.CustomerMainPanel.TabIndex = 21
            '
            'ViewOrderPanel
            '
            Me.ViewOrderPanel.BackColor = System.Drawing.Color.DimGray
            Me.ViewOrderPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.ViewOrderPanel.Location = New System.Drawing.Point(177, 642)
            Me.ViewOrderPanel.Name = "ViewOrderPanel"
            Me.ViewOrderPanel.Size = New System.Drawing.Size(1249, 175)
            Me.ViewOrderPanel.TabIndex = 2
            '
            'CategoryPanel
            '
            Me.CategoryPanel.Controls.Add(Me.Guna2Button4)
            Me.CategoryPanel.Controls.Add(Me.Guna2Button3)
            Me.CategoryPanel.Controls.Add(Me.Guna2Button1)
            Me.CategoryPanel.Controls.Add(Me.Guna2Button2)
            Me.CategoryPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.CategoryPanel.Location = New System.Drawing.Point(0, 0)
            Me.CategoryPanel.Name = "CategoryPanel"
            Me.CategoryPanel.Size = New System.Drawing.Size(177, 817)
            Me.CategoryPanel.TabIndex = 0
            '
            'MenuFlowLayout
            '
            Me.MenuFlowLayout.BackColor = System.Drawing.Color.DarkGray
            Me.MenuFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MenuFlowLayout.Location = New System.Drawing.Point(177, 0)
            Me.MenuFlowLayout.Name = "MenuFlowLayout"
            Me.MenuFlowLayout.Size = New System.Drawing.Size(1249, 817)
            Me.MenuFlowLayout.TabIndex = 1
            '
            'Guna2Button4
            '
            Me.Guna2Button4.BorderColor = System.Drawing.SystemColors.ControlText
            Me.Guna2Button4.BorderRadius = 15
            Me.Guna2Button4.BorderThickness = 1
            Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.Guna2Button4.FillColor = System.Drawing.Color.White
            Me.Guna2Button4.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2Button4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2Button4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2Button4.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2Button4.HoverState.ForeColor = System.Drawing.Color.White
            Me.Guna2Button4.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            Me.Guna2Button4.Image = CType(resources.GetObject("Guna2Button4.Image"), System.Drawing.Image)
            Me.Guna2Button4.ImageSize = New System.Drawing.Size(60, 60)
            Me.Guna2Button4.Location = New System.Drawing.Point(12, 246)
            Me.Guna2Button4.Name = "Guna2Button4"
            Me.Guna2Button4.Size = New System.Drawing.Size(153, 72)
            Me.Guna2Button4.TabIndex = 5
            Me.Guna2Button4.Text = "Burger"
            Me.Guna2Button4.TextOffset = New System.Drawing.Point(0, 5)
            '
            'Guna2Button3
            '
            Me.Guna2Button3.BorderColor = System.Drawing.SystemColors.ControlText
            Me.Guna2Button3.BorderRadius = 15
            Me.Guna2Button3.BorderThickness = 1
            Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.Guna2Button3.FillColor = System.Drawing.Color.White
            Me.Guna2Button3.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2Button3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2Button3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2Button3.HoverState.ForeColor = System.Drawing.Color.White
            Me.Guna2Button3.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            Me.Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), System.Drawing.Image)
            Me.Guna2Button3.ImageSize = New System.Drawing.Size(60, 60)
            Me.Guna2Button3.Location = New System.Drawing.Point(12, 168)
            Me.Guna2Button3.Name = "Guna2Button3"
            Me.Guna2Button3.Size = New System.Drawing.Size(153, 72)
            Me.Guna2Button3.TabIndex = 4
            Me.Guna2Button3.Text = "Burger"
            Me.Guna2Button3.TextOffset = New System.Drawing.Point(0, 5)
            '
            'Guna2Button1
            '
            Me.Guna2Button1.BorderColor = System.Drawing.SystemColors.ControlText
            Me.Guna2Button1.BorderRadius = 15
            Me.Guna2Button1.BorderThickness = 1
            Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.Guna2Button1.FillColor = System.Drawing.Color.White
            Me.Guna2Button1.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2Button1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.White
            Me.Guna2Button1.HoverState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
            Me.Guna2Button1.ImageSize = New System.Drawing.Size(60, 60)
            Me.Guna2Button1.Location = New System.Drawing.Point(12, 90)
            Me.Guna2Button1.Name = "Guna2Button1"
            Me.Guna2Button1.Size = New System.Drawing.Size(153, 72)
            Me.Guna2Button1.TabIndex = 3
            Me.Guna2Button1.Text = "Burger"
            Me.Guna2Button1.TextOffset = New System.Drawing.Point(0, 5)
            '
            'Guna2Button2
            '
            Me.Guna2Button2.BorderColor = System.Drawing.SystemColors.ControlText
            Me.Guna2Button2.BorderRadius = 15
            Me.Guna2Button2.BorderThickness = 1
            Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.Guna2Button2.FillColor = System.Drawing.Color.White
            Me.Guna2Button2.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2Button2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Guna2Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2Button2.HoverState.ForeColor = System.Drawing.Color.White
            Me.Guna2Button2.HoverState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
            Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
            Me.Guna2Button2.ImageSize = New System.Drawing.Size(60, 60)
            Me.Guna2Button2.Location = New System.Drawing.Point(12, 12)
            Me.Guna2Button2.Name = "Guna2Button2"
            Me.Guna2Button2.Size = New System.Drawing.Size(153, 72)
            Me.Guna2Button2.TabIndex = 2
            Me.Guna2Button2.Text = "Burger"
            Me.Guna2Button2.TextOffset = New System.Drawing.Point(0, 5)
            '
            'CustomerMenuView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1426, 817)
            Me.Controls.Add(Me.CustomerMainPanel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "CustomerMenuView"
            Me.Text = "CustomerMenuPage"
            Me.CustomerMainPanel.ResumeLayout(False)
            Me.CategoryPanel.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
        Friend WithEvents CustomerMainPanel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents ViewOrderPanel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents CategoryPanel As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents MenuFlowLayout As FlowLayoutPanel
    End Class

End Namespace