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
            Me.AdminLandingPage = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.SuspendLayout()
            '
            'AdminLandingPage
            '
            Me.AdminLandingPage.BackColor = System.Drawing.Color.Transparent
            Me.AdminLandingPage.Location = New System.Drawing.Point(88, 56)
            Me.AdminLandingPage.Name = "AdminLandingPage"
            Me.AdminLandingPage.Size = New System.Drawing.Size(95, 15)
            Me.AdminLandingPage.TabIndex = 0
            Me.AdminLandingPage.Text = "AdminLandingPage"
            '
            'AdminLandingPageView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1440, 878)
            Me.Controls.Add(Me.AdminLandingPage)
            Me.Name = "AdminLandingPageView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "AdminLandingPageView"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents AdminLandingPage As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace