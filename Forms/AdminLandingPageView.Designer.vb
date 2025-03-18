Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AdminLandingPageView
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
            Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
            Me.AdminPanel = New System.Windows.Forms.Panel()
            Me.AdminSidebar = New System.Windows.Forms.Panel()
            Me.Guna2Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'Guna2Panel2
            '
            Me.Guna2Panel2.BackColor = System.Drawing.Color.White
            Me.Guna2Panel2.Controls.Add(Me.AdminPanel)
            Me.Guna2Panel2.Controls.Add(Me.AdminSidebar)
            Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel2.Name = "Guna2Panel2"
            Me.Guna2Panel2.Size = New System.Drawing.Size(1920, 1080)
            Me.Guna2Panel2.TabIndex = 3
            '
            'AdminPanel
            '
            Me.AdminPanel.BackColor = System.Drawing.Color.White
            Me.AdminPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.AdminPanel.Location = New System.Drawing.Point(115, 0)
            Me.AdminPanel.Name = "AdminPanel"
            Me.AdminPanel.Size = New System.Drawing.Size(1805, 1080)
            Me.AdminPanel.TabIndex = 1
            '
            'AdminSidebar
            '
            Me.AdminSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AdminSidebar.Dock = System.Windows.Forms.DockStyle.Left
            Me.AdminSidebar.Location = New System.Drawing.Point(0, 0)
            Me.AdminSidebar.Name = "AdminSidebar"
            Me.AdminSidebar.Size = New System.Drawing.Size(115, 1080)
            Me.AdminSidebar.TabIndex = 0
            '
            'AdminLandingPageView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1920, 1080)
            Me.Controls.Add(Me.Guna2Panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "AdminLandingPageView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "AdminLandingPageView"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Guna2Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents AdminSidebar As Panel
        Friend WithEvents AdminPanel As Panel
    End Class

End Namespace