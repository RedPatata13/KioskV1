Namespace KioskV0.Forms
    Public Class CustomerAddNoteUserControl
        Private Sub SaveNoteButton_Click(sender As Object, e As EventArgs) Handles SaveNoteButton.Click

        End Sub

        Private Sub CancelNoteButton_Click(sender As Object, e As EventArgs) Handles CancelNoteButton.Click

            Me.Hide()

            Dim confirmOrderView As New CustomerConfirmOrderView()
            confirmOrderView.Show()
        End Sub


        Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub MenuName_Click(sender As Object, e As EventArgs) Handles MenuName.Click

        End Sub

        Private Sub LogoIcon_Click(sender As Object, e As EventArgs) Handles LogoIcon.Click

        End Sub
    End Class

End Namespace