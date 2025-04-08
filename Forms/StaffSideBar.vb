Namespace KioskV0.Forms
    Public Class StaffSideBar
        Public Property POSButtonClick As Action
        Public Property CreditSalesButtonClick As Action
        Private Sub POSButton_Click(sender As Object, e As EventArgs) Handles POSButton.Click
            POSButtonClick?.Invoke()
        End Sub

        Private Sub CreditSalesButton_Click(sender As Object, e As EventArgs) Handles CreditSalesButton.Click
            CreditSalesButtonClick?.Invoke()
        End Sub
    End Class

End Namespace