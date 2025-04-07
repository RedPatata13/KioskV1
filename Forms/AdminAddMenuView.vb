Namespace KioskV0.Forms
    Public Class AdminAddMenuView
        Public Property SaveButtonClick As Action
        Public Property CancelButtonClick As Action
        Public Property SelectImageClick As Action

        Public ReadOnly Property MenuName
            Get
                Return ProductNameTextBox.Text
            End Get
        End Property

        Public ReadOnly Property CategoryName
            Get
                Return CategoryComboBox.Text
            End Get
        End Property

        Public ReadOnly Property SupplierName
            Get
                Return SupplierComboBox.Text
            End Get
        End Property

        Public ReadOnly Property Cost

            Get
                Return CostTextBox.Text
            End Get
        End Property

        Public ReadOnly Property Sell
            Get
                Return SellingTextBox.Text
            End Get
        End Property

        Public Sub ResetFields()
            ProductNameTextBox.Text = ""
            CategoryComboBox.SelectedIndex = -1
            SupplierComboBox.SelectedIndex = -1
            ProductDescriptionTextBox.Text = ""
            CostTextBox.Text = ""
            SellingTextBox.Text = ""
        End Sub

        Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
            SaveButtonClick?.Invoke()
        End Sub

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            CancelButtonClick?.Invoke()
        End Sub

        Private Sub SelectImageButton_Click(sender As Object, e As EventArgs) Handles SelectImageButton.Click
            SelectImageClick?.Invoke()
        End Sub




        Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel5.Click

        End Sub
    End Class
End Namespace