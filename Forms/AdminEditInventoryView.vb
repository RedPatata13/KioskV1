Namespace KioskV0.Forms
    Public Class AdminEditInventoryView
        Public Property CancelButtonClick As Action
        Public Property SaveButtonClick As Action
        Public ReadOnly Property ProductID As String
            Get
                Return _productID.Text
            End Get
        End Property

        Public ReadOnly Property ProductFormalName As String
            Get
                Return _prodNameField.Text
            End Get
        End Property

        Public ReadOnly Property Quantity As String
            Get
                Return _quantityField.Text
            End Get
        End Property

        Public ReadOnly Property Supplier As String
            Get
                Return _suppliers.Text
            End Get
        End Property

        Public ReadOnly Property Status As String
            Get
                Return _statuses.Text
            End Get
        End Property

        Public Sub ResetFields()
            _productID.Text = String.Empty
            _prodNameField.Text = String.Empty
            _quantityField.Text = String.Empty
            _suppliers.SelectedIndex = -1
            _statuses.SelectedIndex = -1
        End Sub

        Private Sub _cancelButton_Click(sender As Object, e As EventArgs) Handles _cancelButton.Click
            CancelButtonClick?.Invoke()
        End Sub

        Private Sub _saveButton_Click(sender As Object, e As EventArgs) Handles _saveButton.Click
            SaveButtonClick?.Invoke()
        End Sub


        Private Sub AdminEditInventoryView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace