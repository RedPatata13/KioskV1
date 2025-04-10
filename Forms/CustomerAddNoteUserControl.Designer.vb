Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CustomerAddNoteUserControl
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerAddNoteUserControl))
            Me.MenuName = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
            Me.SaveNoteButton = New Guna.UI2.WinForms.Guna2Button()
            Me.CancelNoteButton = New Guna.UI2.WinForms.Guna2Button()
            Me.NoteIcon = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.LogoIcon = New Guna.UI2.WinForms.Guna2ImageButton()
            CType(Me.NoteIcon, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'MenuName
            '
            Me.MenuName.BackColor = System.Drawing.Color.Transparent
            Me.MenuName.Font = New System.Drawing.Font("Poppins", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuName.Location = New System.Drawing.Point(1012, 107)
            Me.MenuName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
            Me.MenuName.Name = "MenuName"
            Me.MenuName.Size = New System.Drawing.Size(166, 64)
            Me.MenuName.TabIndex = 2
            Me.MenuName.Text = "Add note"
            '
            'Guna2TextBox1
            '
            Me.Guna2TextBox1.BorderRadius = 15
            Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.Guna2TextBox1.DefaultText = "Enter note..."
            Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Guna2TextBox1.Font = New System.Drawing.Font("Poppins", 14.0!)
            Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Guna2TextBox1.Location = New System.Drawing.Point(79, 214)
            Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
            Me.Guna2TextBox1.Name = "Guna2TextBox1"
            Me.Guna2TextBox1.PlaceholderText = ""
            Me.Guna2TextBox1.SelectedText = ""
            Me.Guna2TextBox1.Size = New System.Drawing.Size(1761, 713)
            Me.Guna2TextBox1.TabIndex = 3
            Me.Guna2TextBox1.TextOffset = New System.Drawing.Point(50, -310)
            '
            'SaveNoteButton
            '
            Me.SaveNoteButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.SaveNoteButton.BorderRadius = 15
            Me.SaveNoteButton.BorderThickness = 1
            Me.SaveNoteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.SaveNoteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.SaveNoteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.SaveNoteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.SaveNoteButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SaveNoteButton.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SaveNoteButton.ForeColor = System.Drawing.Color.White
            Me.SaveNoteButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.SaveNoteButton.HoverState.FillColor = System.Drawing.Color.White
            Me.SaveNoteButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.SaveNoteButton.Location = New System.Drawing.Point(1640, 960)
            Me.SaveNoteButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.SaveNoteButton.Name = "SaveNoteButton"
            Me.SaveNoteButton.Size = New System.Drawing.Size(200, 46)
            Me.SaveNoteButton.TabIndex = 24
            Me.SaveNoteButton.Text = "Save"
            Me.SaveNoteButton.TextOffset = New System.Drawing.Point(0, 1)
            '
            'CancelNoteButton
            '
            Me.CancelNoteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.CancelNoteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.CancelNoteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.CancelNoteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.CancelNoteButton.FillColor = System.Drawing.Color.Transparent
            Me.CancelNoteButton.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CancelNoteButton.ForeColor = System.Drawing.Color.DimGray
            Me.CancelNoteButton.Location = New System.Drawing.Point(1505, 967)
            Me.CancelNoteButton.Name = "CancelNoteButton"
            Me.CancelNoteButton.Size = New System.Drawing.Size(108, 33)
            Me.CancelNoteButton.TabIndex = 26
            Me.CancelNoteButton.Text = "Cancel"
            '
            'NoteIcon
            '
            Me.NoteIcon.Image = CType(resources.GetObject("NoteIcon.Image"), System.Drawing.Image)
            Me.NoteIcon.ImageRotate = 0!
            Me.NoteIcon.Location = New System.Drawing.Point(933, 98)
            Me.NoteIcon.Name = "NoteIcon"
            Me.NoteIcon.Size = New System.Drawing.Size(66, 71)
            Me.NoteIcon.TabIndex = 27
            Me.NoteIcon.TabStop = False
            '
            'LogoIcon
            '
            Me.LogoIcon.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
            Me.LogoIcon.Cursor = System.Windows.Forms.Cursors.No
            Me.LogoIcon.Enabled = False
            Me.LogoIcon.HoverState.ImageSize = New System.Drawing.Size(64, 64)
            Me.LogoIcon.Image = CType(resources.GetObject("LogoIcon.Image"), System.Drawing.Image)
            Me.LogoIcon.ImageOffset = New System.Drawing.Point(0, 0)
            Me.LogoIcon.ImageRotate = 0!
            Me.LogoIcon.ImageSize = New System.Drawing.Size(100, 94)
            Me.LogoIcon.Location = New System.Drawing.Point(0, 0)
            Me.LogoIcon.Name = "LogoIcon"
            Me.LogoIcon.PressedState.ImageSize = New System.Drawing.Size(64, 64)
            Me.LogoIcon.Size = New System.Drawing.Size(98, 94)
            Me.LogoIcon.TabIndex = 28
            '
            'CustomerAddNoteUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.Controls.Add(Me.LogoIcon)
            Me.Controls.Add(Me.NoteIcon)
            Me.Controls.Add(Me.CancelNoteButton)
            Me.Controls.Add(Me.SaveNoteButton)
            Me.Controls.Add(Me.Guna2TextBox1)
            Me.Controls.Add(Me.MenuName)
            Me.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
            Me.Name = "CustomerAddNoteUserControl"
            Me.Size = New System.Drawing.Size(1920, 1080)
            CType(Me.NoteIcon, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents MenuName As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents SaveNoteButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents CancelNoteButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents NoteIcon As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents LogoIcon As Guna.UI2.WinForms.Guna2ImageButton
    End Class

End Namespace