Imports System.Runtime.InteropServices
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Forms
    Public Class CustomerOrderDetailsUserControl
        Private Property _model As MenuModel
        Private Property _order As OrderModel
        Public Property AddItemClick As Action
        Public Property DecreaseItemClick As Action
        Public Property RemoveItemClick As Action

        Public Sub New(order As OrderModel)
            InitializeComponent()
            _order = order
            SetLabels()

        End Sub
        Public Sub SetLabels()
            If _order?.MenuItem Is Nothing Then Exit Sub

            ItemName.Text = _order.MenuItem.MenuName
            QuantityTextBox.Text = _order.Quantity.ToString()
            ItemPrice.Text = $"P{_order.MenuItem.Selling:N2}"
            ItemTotalPrice.Text = $"P{_order.MenuItem.Selling * _order.Quantity:N2}"
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
    End Class

End Namespace