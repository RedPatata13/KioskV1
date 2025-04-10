Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CustomerOrderQuantityUserControl
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerOrderQuantityUserControl))
            Me.QuantityTextBox = New System.Windows.Forms.Label()
            Me.AddOrderButton = New Guna.UI2.WinForms.Guna2Button()
            Me.CancelButton = New Guna.UI2.WinForms.Guna2Button()
            Me.DecButton = New Guna.UI2.WinForms.Guna2Button()
            Me.AddButton = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.productPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'QuantityTextBox
            '
            Me.QuantityTextBox.AutoSize = True
            Me.QuantityTextBox.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.QuantityTextBox.Location = New System.Drawing.Point(698, 44)
            Me.QuantityTextBox.Name = "QuantityTextBox"
            Me.QuantityTextBox.Size = New System.Drawing.Size(39, 34)
            Me.QuantityTextBox.TabIndex = 44
            Me.QuantityTextBox.Text = "00"
            '
            'AddOrderButton
            '
            Me.AddOrderButton.BackColor = System.Drawing.Color.White
            Me.AddOrderButton.BorderColor = System.Drawing.Color.WhiteSmoke
            Me.AddOrderButton.BorderRadius = 10
            Me.AddOrderButton.BorderThickness = 1
            Me.AddOrderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.AddOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.AddOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.AddOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.AddOrderButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.AddOrderButton.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AddOrderButton.ForeColor = System.Drawing.Color.Black
            Me.AddOrderButton.Location = New System.Drawing.Point(716, 102)
            Me.AddOrderButton.Name = "AddOrderButton"
            Me.AddOrderButton.Size = New System.Drawing.Size(204, 37)
            Me.AddOrderButton.TabIndex = 43
            Me.AddOrderButton.Text = "Add Order"
            Me.AddOrderButton.TextOffset = New System.Drawing.Point(2, 2)
            '
            'CancelButton
            '
            Me.CancelButton.BackColor = System.Drawing.Color.Transparent
            Me.CancelButton.BorderColor = System.Drawing.Color.Gray
            Me.CancelButton.BorderRadius = 10
            Me.CancelButton.BorderThickness = 1
            Me.CancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.CancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.CancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.CancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.CancelButton.FillColor = System.Drawing.Color.White
            Me.CancelButton.Font = New System.Drawing.Font("Poppins", 11.0!)
            Me.CancelButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.CancelButton.Location = New System.Drawing.Point(508, 104)
            Me.CancelButton.Name = "CancelButton"
            Me.CancelButton.Size = New System.Drawing.Size(204, 34)
            Me.CancelButton.TabIndex = 42
            Me.CancelButton.Text = "Cancel"
            Me.CancelButton.TextOffset = New System.Drawing.Point(2, 2)
            '
            'DecButton
            '
            Me.DecButton.BackColor = System.Drawing.Color.Transparent
            Me.DecButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.DecButton.BorderRadius = 10
            Me.DecButton.BorderThickness = 1
            Me.DecButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.DecButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.DecButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.DecButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.DecButton.FillColor = System.Drawing.Color.White
            Me.DecButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.DecButton.ForeColor = System.Drawing.Color.White
            Me.DecButton.Image = CType(resources.GetObject("DecButton.Image"), System.Drawing.Image)
            Me.DecButton.Location = New System.Drawing.Point(613, 41)
            Me.DecButton.Name = "DecButton"
            Me.DecButton.Size = New System.Drawing.Size(59, 35)
            Me.DecButton.TabIndex = 37
            '
            'AddButton
            '
            Me.AddButton.BackColor = System.Drawing.Color.Transparent
            Me.AddButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.AddButton.BorderRadius = 10
            Me.AddButton.BorderThickness = 1
            Me.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.AddButton.FillColor = System.Drawing.Color.White
            Me.AddButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.AddButton.ForeColor = System.Drawing.Color.White
            Me.AddButton.Image = CType(resources.GetObject("AddButton.Image"), System.Drawing.Image)
            Me.AddButton.Location = New System.Drawing.Point(765, 41)
            Me.AddButton.Name = "AddButton"
            Me.AddButton.Size = New System.Drawing.Size(59, 35)
            Me.AddButton.TabIndex = 36
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me.AddOrderButton)
            Me.Guna2Panel1.Controls.Add(Me.QuantityTextBox)
            Me.Guna2Panel1.Controls.Add(Me.AddButton)
            Me.Guna2Panel1.Controls.Add(Me.CancelButton)
            Me.Guna2Panel1.Controls.Add(Me.DecButton)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 634)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(1426, 183)
            Me.Guna2Panel1.TabIndex = 45
            '
            'productPanel
            '
            Me.productPanel.Location = New System.Drawing.Point(613, 162)
            Me.productPanel.Name = "productPanel"
            Me.productPanel.Size = New System.Drawing.Size(239, 225)
            Me.productPanel.TabIndex = 46
            '
            'CustomerOrderQuantityUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.Controls.Add(Me.productPanel)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Name = "CustomerOrderQuantityUserControl"
            Me.Size = New System.Drawing.Size(1426, 817)
            Me.Guna2Panel1.ResumeLayout(False)
            Me.Guna2Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents QuantityTextBox As Label
        Friend WithEvents AddOrderButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents DecButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents CancelButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents AddButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents productPanel As Guna.UI2.WinForms.Guna2Panel
    End Class

End Namespace