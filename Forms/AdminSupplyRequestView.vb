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
        Private _suppliers As List(Of Supplier)

        Public Property Suppliers() As List(Of Supplier)
            Get
                Return _suppliers
            End Get
            Set(ByVal value As List(Of Supplier))
                _suppliers = value
                UpdateSupplierComboBox() ' Automatically update the ComboBox when suppliers change
            End Set
        End Property

        Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
            ConfirmButtonClick?.Invoke()
        End Sub

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            CancelButtonClick?.Invoke()
        End Sub

        ' Function to update the Supplier ComboBox
        Private Sub UpdateSupplierComboBox()
            ' Clear the existing items in the ComboBox
            SupplierField.Items.Clear()

            ' If there are suppliers, add them to the ComboBox
            If _suppliers IsNot Nothing AndAlso _suppliers.Count > 0 Then
                For Each supplier As Supplier In _suppliers
                    SupplierField.Items.Add(supplier.Username) ' Assuming 'Name' is a property of the Supplier model
                Next
            End If
        End Sub

    End Class
End Namespace