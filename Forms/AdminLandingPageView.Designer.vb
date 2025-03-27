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
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2Panel2.SuspendLayout()
            Me.AdminPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'Guna2Panel2
            '
            Me.Guna2Panel2.BackColor = System.Drawing.Color.White
            Me.Guna2Panel2.Controls.Add(Me.AdminPanel)
            Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2Panel2.Name = "Guna2Panel2"
            Me.Guna2Panel2.Size = New System.Drawing.Size(1920, 1080)
            Me.Guna2Panel2.TabIndex = 3
            '
            'AdminPanel
            '
            Me.AdminPanel.BackColor = System.Drawing.Color.White
            Me.AdminPanel.Controls.Add(Me.Guna2Panel1)
            Me.AdminPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.AdminPanel.Location = New System.Drawing.Point(0, 0)
            Me.AdminPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.AdminPanel.Name = "AdminPanel"
            Me.AdminPanel.Size = New System.Drawing.Size(1920, 1080)
            Me.AdminPanel.TabIndex = 1
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(1920, 1080)
            Me.Guna2Panel1.TabIndex = 0
            '
            'AdminLandingPageView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1920, 1080)
            Me.Controls.Add(Me.Guna2Panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "AdminLandingPageView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "AdminLandingPageView"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Guna2Panel2.ResumeLayout(False)
            Me.AdminPanel.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents AdminPanel As Panel
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    End Class

End Namespace