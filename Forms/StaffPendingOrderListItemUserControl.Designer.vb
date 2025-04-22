<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffPendingOrderListItemUserControl
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
        Me.ProductNameQuantityLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'ProductNameQuantityLabel
        '
        Me.ProductNameQuantityLabel.AutoSize = False
        Me.ProductNameQuantityLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProductNameQuantityLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductNameQuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ProductNameQuantityLabel.ForeColor = System.Drawing.Color.Black
        Me.ProductNameQuantityLabel.Location = New System.Drawing.Point(0, 0)
        Me.ProductNameQuantityLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductNameQuantityLabel.Name = "ProductNameQuantityLabel"
        Me.ProductNameQuantityLabel.Size = New System.Drawing.Size(304, 50)
        Me.ProductNameQuantityLabel.TabIndex = 2
        Me.ProductNameQuantityLabel.Text = "Paid"
        Me.ProductNameQuantityLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StaffPendingOrderListItemUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ProductNameQuantityLabel)
        Me.Name = "StaffPendingOrderListItemUserControl"
        Me.Size = New System.Drawing.Size(304, 50)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProductNameQuantityLabel As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
