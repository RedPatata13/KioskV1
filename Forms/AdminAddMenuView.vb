Namespace KioskV0.Forms
    Public Class AdminEditMenuDetailsView
        Public Property SaveButtonClick As Action
        Public Property CancelButtonClick As Action
        Public Property SelectImageClick As Action

        Public Property MenuName
            Get
                Return ProductNameTextBox.Text
            End Get
            Set(value)
                ProductNameTextBox.Text = value
            End Set
        End Property

        Public Property CategoryName As String
            Get
                Return CategoryComboBox.Text
            End Get
            Set(value As String)
                Dim index As Integer = CategoryComboBox.FindStringExact(value)

                If index <> -1 Then
                    CategoryComboBox.SelectedIndex = index
                Else
                    Throw New ArgumentException($"'{value}' is not a valid category.")
                End If
            End Set
        End Property


        Public Property SupplierName As String
            Get
                Return SupplierComboBox.Text
            End Get
            Set(value As String)
                Dim index As Integer = SupplierComboBox.FindStringExact(value)

                If index <> -1 Then
                    SupplierComboBox.SelectedIndex = index
                Else
                    Throw New ArgumentException($"'{value}' is not a valid category.")
                End If
            End Set
        End Property


        Public Property Cost As String
            Get
                Return CostTextBox.Text
            End Get
            Set(value As String)
                CostTextBox.Text = value
            End Set
        End Property

        Public Property Sell As String
            Get
                Return SellingTextBox.Text
            End Get
            Set(value As String)
                SellingTextBox.Text = value
            End Set
        End Property
        Public Property ProductDescription As String
            Get
                Return ProductDescriptionTextBox.Text
            End Get
            Set(value As String)
                ProductDescriptionTextBox.Text = value
            End Set
        End Property

        Public WriteOnly Property Label As String
            Set(value As String)
                PageLabel.Text = value
            End Set
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

        Private Sub AdminEditMenuDetailsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace