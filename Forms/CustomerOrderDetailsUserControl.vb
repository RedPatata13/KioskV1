Imports System.IO
Imports System.Runtime.InteropServices
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Forms
    Public Class CustomerOrderDetailsUserControl
        Private Property _model As AdminItem
        Private Property _order As OrderDetail
        Public Property AddItemClick As Action
        Public Property DecreaseItemClick As Action
        Public Property RemoveItemClick As Action
        Public Property ShowButtons As Boolean
            Get
                Return _showButtons
            End Get
            Set(value As Boolean)
                _showButtons = value
                SetButtonVisibility()
            End Set
        End Property
        Private _showButtons As Boolean = True
        Public Sub New(order As OrderDetail)
            InitializeComponent()
            _order = order
            SetLabels()

        End Sub
        Public Sub SetLabels()
            If _order?.CustomerItem Is Nothing Then Exit Sub

            ItemName.Text = _order.CustomerItem.Name
            QuantityTextBox.Text = _order.Quantity.ToString()
            ItemPrice.Text = $"P{_order.CustomerItem.SellingCost:N2}"
            ItemTotalPrice.Text = $"P{_order.CustomerItem.SellingCost * _order.Quantity:N2}"
            Dim defaultImagePath As String = "picture.png"

            'Dim imagePath As String = If(String.IsNullOrWhiteSpace(_model.ImageFilePath), defaultImagePath, _model.ImageFilePath)

            'If File.Exists(imagePath) Then
            '    MenuPictureBox.Image = Image.FromFile(imagePath)
            'Else
            '    MenuPictureBox.Image = Nothing
            'End If


        End Sub

        Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
            AddItemClick?.Invoke()
        End Sub

        Private Sub DecreaseItemButton_Click(sender As Object, e As EventArgs) Handles DecreaseItemButton.Click
            DecreaseItemClick?.Invoke()
        End Sub

        Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
            RemoveItemClick?.Invoke()
        End Sub
        Private Sub SetButtonVisibility()
            AddItemButton.Visible = _showButtons
            DecreaseItemButton.Visible = _showButtons
            RemoveButton.Visible = _showButtons
        End Sub
    End Class

End Namespace