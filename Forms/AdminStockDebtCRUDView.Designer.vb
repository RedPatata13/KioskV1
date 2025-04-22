<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminStockDebtCRUDView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PageLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CancelButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ConfirmButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ReasonTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ItemNameField = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UnitField = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ItemIDField = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.PageLabel)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1321, 81)
        Me.Guna2Panel1.TabIndex = 42
        '
        'PageLabel
        '
        Me.PageLabel.BackColor = System.Drawing.Color.Transparent
        Me.PageLabel.Font = New System.Drawing.Font("Montserrat", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageLabel.Location = New System.Drawing.Point(16, 16)
        Me.PageLabel.Margin = New System.Windows.Forms.Padding(2)
        Me.PageLabel.Name = "PageLabel"
        Me.PageLabel.Size = New System.Drawing.Size(346, 51)
        Me.PageLabel.TabIndex = 5
        Me.PageLabel.Text = "Generate stock debt"
        '
        'CancelButton
        '
        Me.CancelButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.CancelButton.BorderRadius = 15
        Me.CancelButton.BorderThickness = 1
        Me.CancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CancelButton.FillColor = System.Drawing.Color.White
        Me.CancelButton.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.CancelButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.CancelButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.CancelButton.HoverState.ForeColor = System.Drawing.Color.White
        Me.CancelButton.Location = New System.Drawing.Point(56, 568)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(189, 51)
        Me.CancelButton.TabIndex = 41
        Me.CancelButton.Text = "Cancel"
        '
        'ConfirmButton
        '
        Me.ConfirmButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ConfirmButton.BorderRadius = 15
        Me.ConfirmButton.BorderThickness = 1
        Me.ConfirmButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ConfirmButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ConfirmButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ConfirmButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ConfirmButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ConfirmButton.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmButton.ForeColor = System.Drawing.Color.White
        Me.ConfirmButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ConfirmButton.HoverState.FillColor = System.Drawing.Color.White
        Me.ConfirmButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ConfirmButton.Location = New System.Drawing.Point(280, 568)
        Me.ConfirmButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(189, 51)
        Me.ConfirmButton.TabIndex = 40
        Me.ConfirmButton.Text = "Confirm"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(56, 320)
        Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(438, 49)
        Me.Guna2HtmlLabel5.TabIndex = 34
        Me.Guna2HtmlLabel5.Text = "Reason"
        '
        'ReasonTextBox
        '
        Me.ReasonTextBox.BorderRadius = 15
        Me.ReasonTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ReasonTextBox.DefaultText = ""
        Me.ReasonTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ReasonTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ReasonTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ReasonTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ReasonTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReasonTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ReasonTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReasonTextBox.Location = New System.Drawing.Point(56, 368)
        Me.ReasonTextBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ReasonTextBox.MaxLength = 250
        Me.ReasonTextBox.Name = "ReasonTextBox"
        Me.ReasonTextBox.PlaceholderText = """Premium ham with cheese, tomatoes...."""
        Me.ReasonTextBox.SelectedText = ""
        Me.ReasonTextBox.Size = New System.Drawing.Size(512, 168)
        Me.ReasonTextBox.TabIndex = 33
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(56, 96)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(291, 49)
        Me.Guna2HtmlLabel3.TabIndex = 31
        Me.Guna2HtmlLabel3.Text = "Item Name"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(64, 208)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(196, 49)
        Me.Guna2HtmlLabel2.TabIndex = 29
        Me.Guna2HtmlLabel2.Text = "Units"
        '
        'ItemNameField
        '
        Me.ItemNameField.BorderRadius = 15
        Me.ItemNameField.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ItemNameField.DefaultText = ""
        Me.ItemNameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ItemNameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ItemNameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ItemNameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ItemNameField.Enabled = False
        Me.ItemNameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemNameField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ItemNameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemNameField.Location = New System.Drawing.Point(56, 149)
        Me.ItemNameField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ItemNameField.Name = "ItemNameField"
        Me.ItemNameField.PlaceholderText = "Ex.: ""Hamburger"""
        Me.ItemNameField.SelectedText = ""
        Me.ItemNameField.Size = New System.Drawing.Size(510, 49)
        Me.ItemNameField.TabIndex = 27
        '
        'UnitField
        '
        Me.UnitField.BorderRadius = 15
        Me.UnitField.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UnitField.DefaultText = ""
        Me.UnitField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UnitField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UnitField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UnitField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UnitField.Enabled = False
        Me.UnitField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UnitField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UnitField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UnitField.Location = New System.Drawing.Point(56, 256)
        Me.UnitField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.UnitField.Name = "UnitField"
        Me.UnitField.PlaceholderText = "Ex.: ""Hamburger"""
        Me.UnitField.SelectedText = ""
        Me.UnitField.Size = New System.Drawing.Size(510, 49)
        Me.UnitField.TabIndex = 47
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins Medium", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(608, 96)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(291, 49)
        Me.Guna2HtmlLabel1.TabIndex = 49
        Me.Guna2HtmlLabel1.Text = "Item ID"
        '
        'ItemIDField
        '
        Me.ItemIDField.BorderRadius = 15
        Me.ItemIDField.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ItemIDField.DefaultText = ""
        Me.ItemIDField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ItemIDField.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ItemIDField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ItemIDField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ItemIDField.Enabled = False
        Me.ItemIDField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemIDField.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ItemIDField.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemIDField.Location = New System.Drawing.Point(608, 149)
        Me.ItemIDField.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ItemIDField.Name = "ItemIDField"
        Me.ItemIDField.PlaceholderText = "Ex.: ""Hamburger"""
        Me.ItemIDField.SelectedText = ""
        Me.ItemIDField.Size = New System.Drawing.Size(510, 49)
        Me.ItemIDField.TabIndex = 48
        '
        'AdminStockDebtCRUDView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1321, 691)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.ItemIDField)
        Me.Controls.Add(Me.UnitField)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.ReasonTextBox)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.ItemNameField)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminStockDebtCRUDView"
        Me.Text = "AdminStockDebtCRUDView"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PageLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CancelButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ConfirmButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ReasonTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ItemNameField As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UnitField As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ItemIDField As Guna.UI2.WinForms.Guna2TextBox
End Class
