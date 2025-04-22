Imports KioskV0.KioskV0.Classes

Namespace KioskV0.Forms
    Public Class SupplierEditSupplierItems
        Public Property SaveClicked As Action
        Public Property CancelClicked As Action
        Public Property DeleteClicked As Action


        Private Sub _saveButton_Click(sender As Object, e As EventArgs) Handles _saveButton.Click
            SaveClicked?.Invoke()
        End Sub

        Private Sub _cancelButton_Click(sender As Object, e As EventArgs) Handles _cancelButton.Click
            CancelClicked?.Invoke()
        End Sub

        Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
            DeleteClicked?.Invoke()
        End Sub
    End Class
End Namespace