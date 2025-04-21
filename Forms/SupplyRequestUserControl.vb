Namespace KioskV0.Forms
    Public Class SupplyRequestUserControl

        Public Event SelfClicked()
        Public ReadOnly Property RequestID As String
            Get
                Return _request.ID
            End Get
        End Property
        Private _request As SupplyRequest
        Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs)
        End Sub
        Public Sub Bind(request As SupplyRequest)
            _request = request

            ProductLabel.Text = request.ProductName
            QuantityLabel.Text = request.Quantity
            RequestIdLabel.Text = request.ID
            DateLabel.Text = request.CreatedAt.ToShortDateString()
        End Sub

        Private Sub SupplyRequestUserControl_Click(sender As Object, e As EventArgs) Handles MyBase.Click

        End Sub

        Private Sub Guna2Panel4_Click(sender As Object, e As EventArgs) Handles Guna2Panel4.Click
            RaiseEvent SelfClicked()
        End Sub
    End Class

End Namespace