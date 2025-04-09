Namespace KioskV0.Forms
    Public Class AdminSupplyRequestView

        Public Property ConfirmButtonClick As Action
        Public Property CancelButtonClick As Action
        Public Property IDField As String
            Get
                Return ID_Field.Text
            End Get
            Set(value As String)
                ID_Field.Text = value
            End Set
        End Property

        Public Property Product_Name
            Get
                Return ProductNameField.Text
            End Get
            Set(value)
                ProductNameField.Text = value
            End Set
        End Property

        Public Property Quantity As String
            Get
                Return QuantityField.Text
            End Get
            Set(value As String)
                QuantityField.Text = value
            End Set
        End Property

        Public Property Supplier As String
            Get
                Return SupplierField.Text
            End Get
            Set(value As String)
                SupplierField.Text = value
            End Set
        End Property

        Public Property Notes As String
            Get
                Return NoteField.Text
            End Get
            Set(value As String)
                NoteField.Text = value
            End Set
        End Property

        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
            ConfirmButtonClick?.Invoke()
        End Sub

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            CancelButtonClick?.Invoke()
        End Sub


    End Class
End Namespace