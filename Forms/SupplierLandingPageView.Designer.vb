<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierLandingPageView
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
        Me.Logout = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Logout
        '
        Me.Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Logout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Logout.ForeColor = System.Drawing.Color.White
        Me.Logout.Location = New System.Drawing.Point(72, 56)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(180, 45)
        Me.Logout.TabIndex = 0
        Me.Logout.Text = "Logout"
        '
        'SupplierLandingPageView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Logout)
        Me.Name = "SupplierLandingPageView"
        Me.Text = "SupplierLandingPageView"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Logout As Guna.UI2.WinForms.Guna2Button
End Class
