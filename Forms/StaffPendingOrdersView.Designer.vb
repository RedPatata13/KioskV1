Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class StaffPendingOrdersView
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
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ListPendingOrdersFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.SuspendLayout()
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.AutoSize = False
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(51, 36)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(400, 56)
            Me.Guna2HtmlLabel1.TabIndex = 13
            Me.Guna2HtmlLabel1.Text = "Transactions"
            '
            'ListPendingOrdersFlowLayoutPanel
            '
            Me.ListPendingOrdersFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.ListPendingOrdersFlowLayoutPanel.Location = New System.Drawing.Point(0, 119)
            Me.ListPendingOrdersFlowLayoutPanel.Name = "ListPendingOrdersFlowLayoutPanel"
            Me.ListPendingOrdersFlowLayoutPanel.Size = New System.Drawing.Size(1722, 867)
            Me.ListPendingOrdersFlowLayoutPanel.TabIndex = 14
            '
            'StaffPendingOrdersView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1722, 986)
            Me.Controls.Add(Me.ListPendingOrdersFlowLayoutPanel)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "StaffPendingOrdersView"
            Me.Text = "StaffPendingOrdersView"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ListPendingOrdersFlowLayoutPanel As FlowLayoutPanel
    End Class
End Namespace
