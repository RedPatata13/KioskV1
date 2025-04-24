Namespace KioskV0.Forms
    Public Class StaffPosView
        Public Property PayButtonClick As Action
        Public Property OrderTextBoxTextchanged As Action
        Public Property AddMoreClick As Action
        Public Property AddAllItemsToOrder As Action
        Public Property DiscardButtonClick As Action
        Public Property Cart As Dictionary(Of String, AdminItem)
        Private Property Property1

        Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click
            PayButtonClick?.Invoke()
        End Sub

        Private Sub SearchOrderTextbox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles SearchOrderTextbox.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                OrderTextBoxTextchanged?.Invoke()
            End If
        End Sub

        Private Sub AddMoreButton_Click(sender As Object, e As EventArgs) Handles AddMoreButton.Click
            AddMoreClick?.Invoke()
        End Sub

        Private Sub AddItemsToOrder_Click(sender As Object, e As EventArgs) Handles AddItemsToOrder.Click
            AddAllItemsToOrder?.Invoke()
        End Sub

        Private Sub DiscardButton_Click(sender As Object, e As EventArgs) Handles DiscardButton.Click
            DiscardButtonClick?.Invoke()
        End Sub

        Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

        End Sub
    End Class
End Namespace