Public Class AdminStockDebtCRUDView
    Public Property ConfirmButtonCick As Action
    Public Property CancelButtonClick As Action
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        ConfirmButtonCick?.Invoke()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        CancelButtonClick?.Invoke()
    End Sub
End Class