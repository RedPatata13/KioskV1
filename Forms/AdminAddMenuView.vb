Imports System.IO

Namespace KioskV0.Forms
    Public Class AdminEditMenuDetailsView
        Public Property SaveButtonClick As Action
        Public Property CancelButtonClick As Action
        Public Property SelectImageClick As Action
        Public Property DeleteButtonClick As Action
        Public Property SelectSupplierClick As Action
        Public Property SetAsMenuClick As Action
        Public Property IsCustomerItem As Boolean = False
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


        'Public Property SupplierName As String
        '    Get
        '        Return SupplierComboBox.Text
        '    End Get
        '    Set(value As String)
        '        Dim index As Integer = SupplierComboBox.FindStringExact(value)

        '        If index <> -1 Then
        '            SupplierComboBox.SelectedIndex = index
        '        Else
        '            SupplierComboBox.SelectedIndex = 0
        '            'Throw New ArgumentException($"'{value}' is not a valid category.")
        '            'SupplierComboBox.Items.Add("supplierNotFound")
        '        End If
        '    End Set
        'End Property


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
        Private _productImagePath As String

        Public Property ProductImagePath As String
            Get
                Return _productImagePath
            End Get
            Set(value As String)
                _productImagePath = value

                If Not String.IsNullOrEmpty(_productImagePath) AndAlso IO.File.Exists(_productImagePath) Then
                    Thumbnail.Image = Image.FromFile(_productImagePath)
                Else
                    Thumbnail.Image = Nothing
                End If
            End Set
        End Property


        Public Sub ResetFields()
            ProductNameTextBox.Text = ""
            CategoryComboBox.SelectedIndex = -1
            BoundItem.Text = ""
            ProductDescriptionTextBox.Text = ""
            CostTextBox.Text = ""
            SellingTextBox.Text = ""
        End Sub
        Public Sub SetClick()
            If Not IsCustomerItem Then
                SetAsCustomerItem.Text = "Set As Menu"

            Else
                SetAsCustomerItem.Text = "Remove from Menu"
                'MessageBox.Show("Item is now included in the menu.")
            End If
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

        Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
            DeleteButtonClick?.Invoke()
        End Sub

        Private Sub SelectSupplierButton_Click(sender As Object, e As EventArgs) Handles SelectSupplierButton.Click
            SelectSupplierClick?.Invoke()
        End Sub

        Private Sub SetAsCustomerItem_Click(sender As Object, e As EventArgs) Handles SetAsCustomerItem.Click
            SetAsMenuClick?.Invoke()
            'SetClick()
            'IsCustomerItem = Not IsCustomerItem
        End Sub
    End Class
End Namespace