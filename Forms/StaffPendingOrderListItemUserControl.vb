Public Class StaffPendingOrderListItemUserControl
    Public Property ItemLabel As Label
    Public Sub New(itemName As String)
        InitializeComponent()
        ProductNameQuantityLabel.Text = itemName
    End Sub
End Class
