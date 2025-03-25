<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectorView
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
        Me.sidebar = New System.Windows.Forms.Panel()
        Me.projectorPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.projectorPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'sidebar
        '
        Me.sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebar.Location = New System.Drawing.Point(0, 0)
        Me.sidebar.Margin = New System.Windows.Forms.Padding(2)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Size = New System.Drawing.Size(77, 663)
        Me.sidebar.TabIndex = 1
        '
        'projectorPanel
        '
        Me.projectorPanel.Controls.Add(Me.Label1)
        Me.projectorPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.projectorPanel.Location = New System.Drawing.Point(77, 0)
        Me.projectorPanel.Name = "projectorPanel"
        Me.projectorPanel.Size = New System.Drawing.Size(1110, 663)
        Me.projectorPanel.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Test"
        '
        'ProjectorView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 663)
        Me.Controls.Add(Me.projectorPanel)
        Me.Controls.Add(Me.sidebar)
        Me.Name = "ProjectorView"
        Me.Text = "ProjectorView"
        Me.projectorPanel.ResumeLayout(False)
        Me.projectorPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sidebar As Panel
    Friend WithEvents projectorPanel As Panel
    Friend WithEvents Label1 As Label
End Class
