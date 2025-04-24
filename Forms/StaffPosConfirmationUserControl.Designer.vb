<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffPosConfirmationUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Confirm = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Message = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Checkbox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ConfirmClick = New Guna.UI2.WinForms.Guna2Button()
        Me.CancelClick = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Confirm
        '
        Me.Confirm.BackColor = System.Drawing.Color.Transparent
        Me.Confirm.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Confirm.Location = New System.Drawing.Point(98, 4)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(236, 30)
        Me.Confirm.TabIndex = 0
        Me.Confirm.Text = "Confirm deletion of object"
        '
        'Message
        '
        Me.Message.BackColor = System.Drawing.Color.Transparent
        Me.Message.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Message.Location = New System.Drawing.Point(49, 40)
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(339, 21)
        Me.Message.TabIndex = 1
        Me.Message.Text = "Are you sure you wish to remove this item from the order list?"
        '
        'Checkbox
        '
        Me.Checkbox.AutoSize = True
        Me.Checkbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Checkbox.CheckedState.BorderRadius = 0
        Me.Checkbox.CheckedState.BorderThickness = 0
        Me.Checkbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Checkbox.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkbox.Location = New System.Drawing.Point(13, 75)
        Me.Checkbox.Name = "Checkbox"
        Me.Checkbox.Size = New System.Drawing.Size(112, 23)
        Me.Checkbox.TabIndex = 2
        Me.Checkbox.Text = "Don't ask again"
        Me.Checkbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Checkbox.UncheckedState.BorderRadius = 0
        Me.Checkbox.UncheckedState.BorderThickness = 0
        Me.Checkbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ConfirmClick
        '
        Me.ConfirmClick.BorderRadius = 10
        Me.ConfirmClick.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ConfirmClick.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ConfirmClick.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ConfirmClick.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ConfirmClick.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ConfirmClick.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ConfirmClick.ForeColor = System.Drawing.Color.White
        Me.ConfirmClick.Location = New System.Drawing.Point(8, 104)
        Me.ConfirmClick.Name = "ConfirmClick"
        Me.ConfirmClick.Size = New System.Drawing.Size(184, 37)
        Me.ConfirmClick.TabIndex = 3
        Me.ConfirmClick.Text = "Yes, I wish to remove this Item from the order list"
        '
        'CancelClick
        '
        Me.CancelClick.BorderRadius = 10
        Me.CancelClick.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CancelClick.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CancelClick.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CancelClick.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CancelClick.FillColor = System.Drawing.Color.White
        Me.CancelClick.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.CancelClick.ForeColor = System.Drawing.Color.Black
        Me.CancelClick.Location = New System.Drawing.Point(216, 104)
        Me.CancelClick.Name = "CancelClick"
        Me.CancelClick.Size = New System.Drawing.Size(184, 37)
        Me.CancelClick.TabIndex = 4
        Me.CancelClick.Text = "No, I do not wish to remove this Item from the order list"
        '
        'StaffPosConfirmationUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CancelClick)
        Me.Controls.Add(Me.ConfirmClick)
        Me.Controls.Add(Me.Checkbox)
        Me.Controls.Add(Me.Message)
        Me.Controls.Add(Me.Confirm)
        Me.Name = "StaffPosConfirmationUserControl"
        Me.Size = New System.Drawing.Size(428, 148)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Confirm As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Message As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Checkbox As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ConfirmClick As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CancelClick As Guna.UI2.WinForms.Guna2Button
End Class
