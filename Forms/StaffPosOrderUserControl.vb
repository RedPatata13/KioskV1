Namespace KioskV0.Forms
    Public Class StaffPosOrderUserControl

        Private _productname As String
        Private _productquantity As String

        Public Property ItemProductName As String
            Get
                Return ProductNameLabel.Text
            End Get
            Set(value As String)
                _productname = value
                ProductNameLabel.Text = value
            End Set
        End Property

        Public Property ItemQuantity As String
            Get
                Return ProductQuantityLabel.Text
            End Get
            Set(value As String)
                _productquantity = value
                ProductQuantityLabel.Text = value
            End Set
        End Property


        Private Sub DeleteOrderButton_Click(sender As Object, e As EventArgs) Handles DeleteOrderButton.Click
            Me.Dispose()
        End Sub

        Private Sub StaffPosOrderUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub AddOrderButton_Click(sender As Object, e As EventArgs) Handles AddOrderButton.Click
            ItemQuantity += 1
        End Sub

        Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
            ItemQuantity -= 1
        End Sub
    End Class
End Namespace
