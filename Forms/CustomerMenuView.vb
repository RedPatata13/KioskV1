Imports KioskV0.KioskV0.Model

Namespace KioskV0.Forms
    Public Class CustomerMenuView
        Public Property CategoryClick As Action(Of String)
        Public Property ViewOrderClick As Action
        Public Property StartOverClick As Action
        Public ReadOnly Property ItemPanel As FlowLayoutPanel
            Get
                Return MenuFlowLayout
            End Get
        End Property

        Public Sub UpdateCartSummary(itemCount As Integer, totalPrice As Decimal)
            TotalPriceLabel.Text = $"P{totalPrice}"
            ItemCountLabel.Text = $"{itemCount} items in cart"
        End Sub

        Public Sub DisplayOrderQuantity(uc As CustomerOrderQuantityUserControl)
            CustomerMainPanelView.Controls.Clear()
            CustomerMainPanelView.Controls.Add(uc)
            CustomerMainPanelView.Visible = True
        End Sub
        Public Sub HideQuantityPopup()
            For Each ctrl As Control In CustomerMainPanelView.Controls
                ctrl.SendToBack()
            Next
            CustomerMainPanelView.Controls.Clear()
            CustomerMainPanelView.Visible = False
        End Sub
        Private Sub ViewOrderButton_Click(sender As Object, e As EventArgs) Handles ViewOrderButton.Click
            ViewOrderClick?.Invoke()
        End Sub
        Private Sub StartOverButton_Click(sender As Object, e As EventArgs) Handles StartOverButton.Click
            StartOverClick?.Invoke()
        End Sub
        Private Sub AllCategButton_Click(sender As Object, e As EventArgs) Handles AllCategButton.Click
            CategoryClick?.Invoke("All")
        End Sub

        Private Sub Cat1Button_Click(sender As Object, e As EventArgs) Handles Cat1Button.Click
            CategoryClick?.Invoke("Category1")
        End Sub

        Private Sub Cat2Button_Click(sender As Object, e As EventArgs) Handles Cat2Button.Click
            CategoryClick?.Invoke("Category2")
        End Sub

        Private Sub Cat3Button_Click(sender As Object, e As EventArgs) Handles Cat3Button.Click
            CategoryClick?.Invoke("Category3")
        End Sub


    End Class
End Namespace