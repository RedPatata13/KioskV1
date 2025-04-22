Namespace KioskV0.Forms
    Public Class StaffSideBar
        Public Property POSButtonClick As Action
        Public Property CreditSalesButtonClick As Action
        Public Property LogoutButtonClick As Action
        Public Property PendingOrdersButtonClick As Action
        Private Sub POSButton_Click(sender As Object, e As EventArgs) Handles POSButton.Click
            POSButtonClick?.Invoke()
        End Sub

        Private Sub CreditSalesButton_Click(sender As Object, e As EventArgs) Handles CreditSalesButton.Click
            CreditSalesButtonClick?.Invoke()
        End Sub

        Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
            LogoutButtonClick?.Invoke()
        End Sub

        Private Sub PendingOrdersButton_Click(sender As Object, e As EventArgs) Handles PendingOrdersButton.Click
            PendingOrdersButtonClick?.Invoke()
        End Sub
    End Class

End Namespace