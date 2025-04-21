Namespace KioskV0.Forms
    Public Class CustomerOrderTypeUserControl
        Public Event DineInClicked()
        Public Event TakeOutClicked()

        Private Sub DineInButton_Click(sender As Object, e As EventArgs) Handles DineInButton.Click
            RaiseEvent DineInClicked()
        End Sub

        Private Sub TakeOutButton_Click(sender As Object, e As EventArgs) Handles TakeOutButton.Click
            RaiseEvent TakeOutClicked()
        End Sub
    End Class

End Namespace