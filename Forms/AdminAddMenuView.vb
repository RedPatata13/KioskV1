Namespace KioskV0.Forms
    Public Class AdminEditMenuDetailsView
        Public Property SaveButtonClick As Action
        Public Property CancelButtonClick As Action
        Public Property SelectImageClick As Action
        Public Property DeleteButtonClick As Action
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
                    CategoryComboBox.Items.Add(value)
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
                    'Throw New ArgumentException($"'{value}' is not a valid category.")
                    SupplierComboBox.Items.Add(value)
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

            CancelButton.FillColor = Color.Transparent
            CancelButton.ForeColor = Color.Gray
            CancelButton.BorderColor = Color.Gray
            CancelButton.BorderThickness = 2
            CancelButton.HoverState.FillColor = Color.Gainsboro
            CancelButton.BorderRadius = 20

        End Sub

        Private Sub SelectImageButton_Click(sender As Object, e As EventArgs) Handles SelectImageButton.Click
            SelectImageClick?.Invoke()

            SelectImageButton.FillColor = Color.Transparent
            SelectImageButton.ForeColor = Color.FromArgb(250, 128, 114) ' Salmon
            SelectImageButton.BorderColor = Color.FromArgb(250, 128, 114)
            SelectImageButton.BorderThickness = 2
            SelectImageButton.HoverState.FillColor = Color.FromArgb(255, 160, 122)
            SelectImageButton.HoverState.ForeColor = Color.White
            SelectImageButton.BorderRadius = 20

        End Sub

        Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
            DeleteButtonClick?.Invoke()

        End Sub

        Private Sub ProductNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductNameTextBox.TextChanged
            ProductNameTextBox.ShadowDecoration.Enabled = True
            ProductNameTextBox.ShadowDecoration.Color = Color.Gray
            ProductNameTextBox.ShadowDecoration.BorderRadius = 10
            ProductNameTextBox.ShadowDecoration.Depth = 5
            ProductNameTextBox.ShadowDecoration.Shadow = New Padding(2)

        End Sub

        Private Sub CategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryComboBox.SelectedIndexChanged
            CategoryComboBox.ShadowDecoration.Enabled = True
            CategoryComboBox.ShadowDecoration.Color = Color.Gray
            CategoryComboBox.ShadowDecoration.BorderRadius = 10
            CategoryComboBox.ShadowDecoration.Depth = 5
            CategoryComboBox.ShadowDecoration.Shadow = New Padding(2)

        End Sub

        Private Sub SupplierComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupplierComboBox.SelectedIndexChanged
            SupplierComboBox.ShadowDecoration.Enabled = True
            SupplierComboBox.ShadowDecoration.Color = Color.Gray
            SupplierComboBox.ShadowDecoration.BorderRadius = 10
            SupplierComboBox.ShadowDecoration.Depth = 5
            SupplierComboBox.ShadowDecoration.Shadow = New Padding(2)

        End Sub

        Private Sub ProductDescriptionTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductDescriptionTextBox.TextChanged
            ProductDescriptionTextBox.ShadowDecoration.Enabled = True
            ProductDescriptionTextBox.ShadowDecoration.Color = Color.Gray
            ProductDescriptionTextBox.ShadowDecoration.BorderRadius = 10
            ProductDescriptionTextBox.ShadowDecoration.Depth = 5
            ProductDescriptionTextBox.ShadowDecoration.Shadow = New Padding(2)

        End Sub

        Private Sub AdminEditMenuDetailsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace