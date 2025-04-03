<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerThankYouView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerThankYouView))
        Me.ThankYouViewPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.ThankYouLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TYLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ThankYouViewPanel.SuspendLayout()
        CType(Me.TYLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ThankYouViewPanel
        '
        Me.ThankYouViewPanel.Controls.Add(Me.TYLogo)
        Me.ThankYouViewPanel.Controls.Add(Me.ThankYouLbl)
        Me.ThankYouViewPanel.Location = New System.Drawing.Point(1, 1)
        Me.ThankYouViewPanel.Name = "ThankYouViewPanel"
        Me.ThankYouViewPanel.Size = New System.Drawing.Size(1920, 1080)
        Me.ThankYouViewPanel.TabIndex = 0
        '
        'ThankYouLbl
        '
        Me.ThankYouLbl.BackColor = System.Drawing.Color.Transparent
        Me.ThankYouLbl.Font = New System.Drawing.Font("Poppins", 69.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThankYouLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ThankYouLbl.Location = New System.Drawing.Point(473, 493)
        Me.ThankYouLbl.Name = "ThankYouLbl"
        Me.ThankYouLbl.Size = New System.Drawing.Size(544, 166)
        Me.ThankYouLbl.TabIndex = 0
        Me.ThankYouLbl.Text = "Thank You!"
        '
        'TYLogo
        '
        Me.TYLogo.Image = CType(resources.GetObject("TYLogo.Image"), System.Drawing.Image)
        Me.TYLogo.ImageRotate = 0!
        Me.TYLogo.Location = New System.Drawing.Point(579, 83)
        Me.TYLogo.Name = "TYLogo"
        Me.TYLogo.Size = New System.Drawing.Size(359, 251)
        Me.TYLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TYLogo.TabIndex = 1
        Me.TYLogo.TabStop = False
        '
        'CustomerThankYouView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.ThankYouViewPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomerThankYouView"
        Me.Text = "CustomerThankYouView"
        Me.ThankYouViewPanel.ResumeLayout(False)
        Me.ThankYouViewPanel.PerformLayout()
        CType(Me.TYLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ThankYouViewPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ThankYouLbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TYLogo As Guna.UI2.WinForms.Guna2PictureBox
End Class
