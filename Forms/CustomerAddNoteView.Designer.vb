<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerAddNotePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerAddNotePage))
        Me.AddNotePanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.AddNoteCancelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.AddNoteSaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.AddNoteTxtBx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AddNoteLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.AddNoteLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.AddNotePanel.SuspendLayout()
        CType(Me.AddNoteLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddNotePanel
        '
        Me.AddNotePanel.BackColor = System.Drawing.Color.White
        Me.AddNotePanel.Controls.Add(Me.AddNoteLbl)
        Me.AddNotePanel.Controls.Add(Me.AddNoteCancelBtn)
        Me.AddNotePanel.Controls.Add(Me.AddNoteSaveBtn)
        Me.AddNotePanel.Controls.Add(Me.AddNoteTxtBx)
        Me.AddNotePanel.Controls.Add(Me.AddNoteLogo)
        Me.AddNotePanel.Font = New System.Drawing.Font("Poppins", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNotePanel.Location = New System.Drawing.Point(0, 1)
        Me.AddNotePanel.Name = "AddNotePanel"
        Me.AddNotePanel.Size = New System.Drawing.Size(1920, 1080)
        Me.AddNotePanel.TabIndex = 1
        '
        'AddNoteCancelBtn
        '
        Me.AddNoteCancelBtn.BackColor = System.Drawing.Color.White
        Me.AddNoteCancelBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddNoteCancelBtn.BorderRadius = 10
        Me.AddNoteCancelBtn.BorderThickness = 1
        Me.AddNoteCancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddNoteCancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddNoteCancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddNoteCancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddNoteCancelBtn.FillColor = System.Drawing.Color.White
        Me.AddNoteCancelBtn.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNoteCancelBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddNoteCancelBtn.Location = New System.Drawing.Point(65, 658)
        Me.AddNoteCancelBtn.Name = "AddNoteCancelBtn"
        Me.AddNoteCancelBtn.Size = New System.Drawing.Size(343, 41)
        Me.AddNoteCancelBtn.TabIndex = 38
        Me.AddNoteCancelBtn.Text = "Cancel"
        Me.AddNoteCancelBtn.TextOffset = New System.Drawing.Point(2, 2)
        '
        'AddNoteSaveBtn
        '
        Me.AddNoteSaveBtn.BackColor = System.Drawing.Color.White
        Me.AddNoteSaveBtn.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.AddNoteSaveBtn.BorderRadius = 10
        Me.AddNoteSaveBtn.BorderThickness = 1
        Me.AddNoteSaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddNoteSaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddNoteSaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddNoteSaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddNoteSaveBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddNoteSaveBtn.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNoteSaveBtn.ForeColor = System.Drawing.Color.White
        Me.AddNoteSaveBtn.Location = New System.Drawing.Point(951, 652)
        Me.AddNoteSaveBtn.Name = "AddNoteSaveBtn"
        Me.AddNoteSaveBtn.Size = New System.Drawing.Size(343, 47)
        Me.AddNoteSaveBtn.TabIndex = 36
        Me.AddNoteSaveBtn.Text = "Save"
        Me.AddNoteSaveBtn.TextOffset = New System.Drawing.Point(2, 2)
        '
        'AddNoteTxtBx
        '
        Me.AddNoteTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AddNoteTxtBx.DefaultText = "Add note..."
        Me.AddNoteTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AddNoteTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AddNoteTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddNoteTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddNoteTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddNoteTxtBx.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNoteTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddNoteTxtBx.Location = New System.Drawing.Point(65, 145)
        Me.AddNoteTxtBx.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.AddNoteTxtBx.Name = "AddNoteTxtBx"
        Me.AddNoteTxtBx.PlaceholderText = ""
        Me.AddNoteTxtBx.SelectedText = ""
        Me.AddNoteTxtBx.Size = New System.Drawing.Size(1229, 479)
        Me.AddNoteTxtBx.TabIndex = 2
        Me.AddNoteTxtBx.TextOffset = New System.Drawing.Point(40, -200)
        '
        'AddNoteLogo
        '
        Me.AddNoteLogo.Image = CType(resources.GetObject("AddNoteLogo.Image"), System.Drawing.Image)
        Me.AddNoteLogo.ImageRotate = 0!
        Me.AddNoteLogo.Location = New System.Drawing.Point(586, 34)
        Me.AddNoteLogo.Name = "AddNoteLogo"
        Me.AddNoteLogo.Size = New System.Drawing.Size(62, 70)
        Me.AddNoteLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AddNoteLogo.TabIndex = 0
        Me.AddNoteLogo.TabStop = False
        '
        'AddNoteLbl
        '
        Me.AddNoteLbl.BackColor = System.Drawing.Color.Transparent
        Me.AddNoteLbl.Location = New System.Drawing.Point(654, 37)
        Me.AddNoteLbl.Name = "AddNoteLbl"
        Me.AddNoteLbl.Size = New System.Drawing.Size(199, 67)
        Me.AddNoteLbl.TabIndex = 39
        Me.AddNoteLbl.Text = "Add Notes"
        '
        'CustomerAddNotePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.AddNotePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomerAddNotePage"
        Me.Text = "CustomerAddNotePage"
        Me.AddNotePanel.ResumeLayout(False)
        Me.AddNotePanel.PerformLayout()
        CType(Me.AddNoteLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddNotePanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents AddNoteLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents AddNoteTxtBx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AddNoteSaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddNoteCancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddNoteLbl As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
