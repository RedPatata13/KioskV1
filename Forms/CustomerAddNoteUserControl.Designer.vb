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
            Me.MenuName = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.NoteTextBox = New Guna.UI2.WinForms.Guna2TextBox()
            Me.SaveNoteButton = New Guna.UI2.WinForms.Guna2Button()
            Me.BackButton = New Guna.UI2.WinForms.Guna2Button()
            Me.SuspendLayout()
            '
            'MenuName
            '
            Me.MenuName.BackColor = System.Drawing.Color.Transparent
            Me.MenuName.Font = New System.Drawing.Font("Poppins", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuName.Location = New System.Drawing.Point(573, 62)
            Me.MenuName.Name = "MenuName"
            Me.MenuName.Size = New System.Drawing.Size(166, 64)
            Me.MenuName.TabIndex = 2
            Me.MenuName.Text = "Add note"
            '
            'NoteTextBox
            '
            Me.NoteTextBox.BorderColor = System.Drawing.Color.Black
            Me.NoteTextBox.BorderRadius = 20
            Me.NoteTextBox.BorderThickness = 2
            Me.NoteTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.NoteTextBox.DefaultText = ""
            Me.NoteTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.NoteTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.NoteTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.NoteTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.NoteTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.NoteTextBox.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.NoteTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.NoteTextBox.Location = New System.Drawing.Point(261, 132)
            Me.NoteTextBox.Name = "NoteTextBox"
            Me.NoteTextBox.PlaceholderText = "Add note here"
            Me.NoteTextBox.SelectedText = ""
            Me.NoteTextBox.Size = New System.Drawing.Size(843, 484)
            Me.NoteTextBox.TabIndex = 3
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
            Me.SaveNoteButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.SaveNoteButton.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SaveNoteButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.SaveNoteButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.SaveNoteButton.HoverState.FillColor = System.Drawing.Color.White
            Me.SaveNoteButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.SaveNoteButton.Location = New System.Drawing.Point(1016, 677)
            Me.SaveNoteButton.Margin = New System.Windows.Forms.Padding(2)
            Me.SaveNoteButton.Name = "SaveNoteButton"
            Me.SaveNoteButton.Size = New System.Drawing.Size(318, 50)
            Me.SaveNoteButton.TabIndex = 24
            Me.SaveNoteButton.Text = "Save"
            '
            'BackButton
            '
            Me.BackButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.BackButton.BorderRadius = 15
            Me.BackButton.BorderThickness = 1
            Me.BackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BackButton.FillColor = System.Drawing.Color.White
            Me.BackButton.Font = New System.Drawing.Font("Poppins SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BackButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.BackButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.BackButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.BackButton.HoverState.ForeColor = System.Drawing.Color.White
            Me.BackButton.Location = New System.Drawing.Point(664, 677)
            Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
            Me.BackButton.Name = "BackButton"
            Me.BackButton.Size = New System.Drawing.Size(318, 50)
            Me.BackButton.TabIndex = 29
            Me.BackButton.Text = "Back"
            '
            'CustomerAddNoteUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.Controls.Add(Me.BackButton)
            Me.Controls.Add(Me.SaveNoteButton)
            Me.Controls.Add(Me.NoteTextBox)
            Me.Controls.Add(Me.MenuName)
            Me.Name = "CustomerAddNoteUserControl"
            Me.Size = New System.Drawing.Size(1370, 749)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents MenuName As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents NoteTextBox As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents SaveNoteButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents BackButton As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace