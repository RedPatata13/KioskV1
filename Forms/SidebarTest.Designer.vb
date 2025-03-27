<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SidebarTest
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
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.TestButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(16, 40)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 0
        Me.HomeButton.Text = "LandingPage"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'TestButton
        '
        Me.TestButton.Location = New System.Drawing.Point(16, 72)
        Me.TestButton.Name = "TestButton"
        Me.TestButton.Size = New System.Drawing.Size(75, 23)
        Me.TestButton.TabIndex = 1
        Me.TestButton.Text = "TestPage"
        Me.TestButton.UseVisualStyleBackColor = True
        '
        'SidebarTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(106, 450)
        Me.Controls.Add(Me.TestButton)
        Me.Controls.Add(Me.HomeButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SidebarTest"
        Me.Text = "SidebarTest"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HomeButton As Button
    Friend WithEvents TestButton As Button
End Class
