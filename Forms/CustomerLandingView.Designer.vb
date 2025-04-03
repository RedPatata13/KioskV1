<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerLandingPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerLandingPage))
        Me.DineinPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.DineInPctrBx = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.DineInLbl = New System.Windows.Forms.Label()
        Me.TakeOutPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.TakeOutPtcrBx = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TakeOutLblb = New System.Windows.Forms.Label()
        Me.LandingPagePanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.DineinPanel.SuspendLayout()
        CType(Me.DineInPctrBx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TakeOutPanel.SuspendLayout()
        CType(Me.TakeOutPtcrBx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DineinPanel
        '
        Me.DineinPanel.BackColor = System.Drawing.Color.White
        Me.DineinPanel.BorderColor = System.Drawing.Color.Black
        Me.DineinPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.DineinPanel.BorderThickness = 1
        Me.DineinPanel.Controls.Add(Me.DineInPctrBx)
        Me.DineinPanel.Controls.Add(Me.DineInLbl)
        Me.DineinPanel.Location = New System.Drawing.Point(269, 176)
        Me.DineinPanel.Name = "DineinPanel"
        Me.DineinPanel.Size = New System.Drawing.Size(318, 316)
        Me.DineinPanel.TabIndex = 0
        '
        'DineInPctrBx
        '
        Me.DineInPctrBx.Image = CType(resources.GetObject("DineInPctrBx.Image"), System.Drawing.Image)
        Me.DineInPctrBx.ImageRotate = 0!
        Me.DineInPctrBx.Location = New System.Drawing.Point(54, 8)
        Me.DineInPctrBx.Name = "DineInPctrBx"
        Me.DineInPctrBx.Size = New System.Drawing.Size(199, 239)
        Me.DineInPctrBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DineInPctrBx.TabIndex = 4
        Me.DineInPctrBx.TabStop = False
        '
        'DineInLbl
        '
        Me.DineInLbl.AutoSize = True
        Me.DineInLbl.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DineInLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DineInLbl.Location = New System.Drawing.Point(98, 245)
        Me.DineInLbl.Name = "DineInLbl"
        Me.DineInLbl.Size = New System.Drawing.Size(115, 40)
        Me.DineInLbl.TabIndex = 1
        Me.DineInLbl.Text = "Dine In"
        '
        'TakeOutPanel
        '
        Me.TakeOutPanel.BackColor = System.Drawing.Color.Transparent
        Me.TakeOutPanel.BorderColor = System.Drawing.Color.Black
        Me.TakeOutPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TakeOutPanel.BorderThickness = 1
        Me.TakeOutPanel.Controls.Add(Me.TakeOutPtcrBx)
        Me.TakeOutPanel.Controls.Add(Me.TakeOutLblb)
        Me.TakeOutPanel.Location = New System.Drawing.Point(775, 176)
        Me.TakeOutPanel.Name = "TakeOutPanel"
        Me.TakeOutPanel.Size = New System.Drawing.Size(318, 316)
        Me.TakeOutPanel.TabIndex = 1
        '
        'TakeOutPtcrBx
        '
        Me.TakeOutPtcrBx.Image = CType(resources.GetObject("TakeOutPtcrBx.Image"), System.Drawing.Image)
        Me.TakeOutPtcrBx.ImageRotate = 0!
        Me.TakeOutPtcrBx.Location = New System.Drawing.Point(45, 51)
        Me.TakeOutPtcrBx.Name = "TakeOutPtcrBx"
        Me.TakeOutPtcrBx.Size = New System.Drawing.Size(237, 158)
        Me.TakeOutPtcrBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TakeOutPtcrBx.TabIndex = 5
        Me.TakeOutPtcrBx.TabStop = False
        '
        'TakeOutLblb
        '
        Me.TakeOutLblb.AutoSize = True
        Me.TakeOutLblb.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TakeOutLblb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TakeOutLblb.Location = New System.Drawing.Point(94, 245)
        Me.TakeOutLblb.Name = "TakeOutLblb"
        Me.TakeOutLblb.Size = New System.Drawing.Size(139, 40)
        Me.TakeOutLblb.TabIndex = 2
        Me.TakeOutLblb.Text = "Take Out"
        '
        'LandingPagePanel
        '
        Me.LandingPagePanel.BorderColor = System.Drawing.Color.White
        Me.LandingPagePanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.LandingPagePanel.BorderThickness = 1
        Me.LandingPagePanel.Location = New System.Drawing.Point(0, 0)
        Me.LandingPagePanel.Name = "LandingPagePanel"
        Me.LandingPagePanel.Size = New System.Drawing.Size(1920, 1080)
        Me.LandingPagePanel.TabIndex = 2
        '
        'CustomerLandingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.TakeOutPanel)
        Me.Controls.Add(Me.DineinPanel)
        Me.Controls.Add(Me.LandingPagePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomerLandingPage"
        Me.Text = "CustomerLandingPage"
        Me.DineinPanel.ResumeLayout(False)
        Me.DineinPanel.PerformLayout()
        CType(Me.DineInPctrBx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TakeOutPanel.ResumeLayout(False)
        Me.TakeOutPanel.PerformLayout()
        CType(Me.TakeOutPtcrBx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DineinPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TakeOutPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DineInLbl As Label
    Friend WithEvents TakeOutLblb As Label
    Friend WithEvents DineInPctrBx As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TakeOutPtcrBx As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LandingPagePanel As Guna.UI2.WinForms.Guna2Panel
End Class