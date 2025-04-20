Namespace KioskV0.Forms
    Public Class CustomerAddNoteUserControl

        Public Event SaveNoteClick(note As String)
        Public Event BackClick()

        Public Property NoteText As String
            Get
                Return NoteTextBox.Text
            End Get
            Set(value As String)
                NoteTextBox.Text = value
            End Set
        End Property

        Private Sub SaveNoteButton_Click(sender As Object, e As EventArgs) Handles SaveNoteButton.Click
            RaiseEvent SaveNoteClick(NoteTextBox.Text)
        End Sub

        Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
            RaiseEvent BackClick()
        End Sub

        Private Sub NoteTextBox_TextChanged(sender As Object, e As EventArgs) Handles NoteTextBox.TextChanged

        End Sub
    End Class

End Namespace