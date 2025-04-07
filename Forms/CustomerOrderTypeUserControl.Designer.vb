Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CustomerOrderTypeUserControl
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
            Me.DineInButton = New Guna.UI2.WinForms.Guna2Button()
            Me.TakeOutButton = New Guna.UI2.WinForms.Guna2Button()
            Me.SuspendLayout()
            '
            'DineInButton
            '
            Me.DineInButton.BackColor = System.Drawing.Color.White
            Me.DineInButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DineInButton.BorderRadius = 15
            Me.DineInButton.BorderThickness = 1
            Me.DineInButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.DineInButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.DineInButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.DineInButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.DineInButton.FillColor = System.Drawing.Color.White
            Me.DineInButton.Font = New System.Drawing.Font("Poppins", 21.75!, System.Drawing.FontStyle.Bold)
            Me.DineInButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DineInButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DineInButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DineInButton.HoverState.ForeColor = System.Drawing.Color.White
            Me.DineInButton.Location = New System.Drawing.Point(275, 179)
            Me.DineInButton.Margin = New System.Windows.Forms.Padding(2)
            Me.DineInButton.Name = "DineInButton"
            Me.DineInButton.Size = New System.Drawing.Size(343, 333)
            Me.DineInButton.TabIndex = 20
            Me.DineInButton.Text = "Dine-in"
            '
            'TakeOutButton
            '
            Me.TakeOutButton.BackColor = System.Drawing.Color.White
            Me.TakeOutButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.TakeOutButton.BorderRadius = 15
            Me.TakeOutButton.BorderThickness = 1
            Me.TakeOutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.TakeOutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.TakeOutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.TakeOutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.TakeOutButton.FillColor = System.Drawing.Color.White
            Me.TakeOutButton.Font = New System.Drawing.Font("Poppins", 21.75!, System.Drawing.FontStyle.Bold)
            Me.TakeOutButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.TakeOutButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.TakeOutButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.TakeOutButton.HoverState.ForeColor = System.Drawing.Color.White
            Me.TakeOutButton.Location = New System.Drawing.Point(757, 179)
            Me.TakeOutButton.Margin = New System.Windows.Forms.Padding(2)
            Me.TakeOutButton.Name = "TakeOutButton"
            Me.TakeOutButton.Size = New System.Drawing.Size(343, 333)
            Me.TakeOutButton.TabIndex = 21
            Me.TakeOutButton.Text = "Take out"
            '
            'CustomerOrderTypeUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.Controls.Add(Me.TakeOutButton)
            Me.Controls.Add(Me.DineInButton)
            Me.Name = "CustomerOrderTypeUserControl"
            Me.Size = New System.Drawing.Size(1370, 749)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents DineInButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents TakeOutButton As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace