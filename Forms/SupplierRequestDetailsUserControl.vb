Namespace KioskV0.Forms
    Public Class SupplierRequestDetailsUserControl
        Public Event AcceptClicked()
        Public Event Declineclicked()
        Public Event Cancelclicked()

        Private _request As SupplyRequest
        Private Sub SupplierRequestDetailsUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Public Sub BindDetails(request As SupplyRequest)
            _request = request

            ProductLabel.Text = request.ProductName
            QuantityLabel.Text = request.Quantity
            NoteLabel.Text = If(String.IsNullOrWhiteSpace(request.Note), "No notes", request.Note)
            RequestIdLabel.Text = request.ID
            SupplierLabel.Text = request.SupplierID
            CostLabel.Text = $"PHP {request.UnitCost:F2}"
        End Sub

        Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
            RaiseEvent AcceptClicked()
        End Sub

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            RaiseEvent Cancelclicked()
        End Sub

        Private Sub DeclineButton_Click_1(sender As Object, e As EventArgs) Handles DeclineButton.Click
            RaiseEvent Declineclicked()
        End Sub
    End Class

End Namespace