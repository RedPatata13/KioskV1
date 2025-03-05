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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(168, 128)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(345, 42)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "AdminLandingPage"
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(272, 232)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(112, 32)
            Me.Button1.TabIndex = 1
            Me.Button1.Text = "Button1"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'AdminLandingPageView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Label1)
            Me.Name = "AdminLandingPageView"
            Me.Text = "AdminLandingPageView"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents Button1 As Button
    End Class

End Namespace