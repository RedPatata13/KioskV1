Namespace KioskV0.Forms
    Public Class CustomerViewOrderUserControl
        Public Property ViewOrderClick As Action
        Public Property StartOverClick As Action

        Public Sub UpdateCartSummary(itemCount As Integer, totalPrice As Decimal)
            TotalPriceLabel.Text = $"P{totalPrice:N2}"
            ItemCountLabel.Text = $"{itemCount} items in cart"
        End Sub
        Private Sub ViewOrderButton_Click(sender As Object, e As EventArgs) Handles ViewOrderButton.Click
            ViewOrderClick?.Invoke()
        End Sub

        Private Sub StartOverButton_Click(sender As Object, e As EventArgs) Handles StartOverButton.Click
            StartOverClick?.Invoke()
        End Sub
    End Class

End Namespace