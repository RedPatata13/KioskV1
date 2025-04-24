Namespace KioskV0.Forms
    Public Class SupplierRequestDetailsView
        Public Property ConfirmButtonClick As Action
        Public Property CancelButtonClick As Action

        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
            ConfirmButtonClick?.Invoke()
        End Sub

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            CancelButtonClick?.Invoke()
        End Sub
    End Class
End Namespace