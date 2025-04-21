Imports KioskV0.KioskV0.Model

Namespace KioskV0.Forms
    Public Class CustomerOrderQuantityUserControl
        Public Property AddOrderClick As Action(Of AdminItemVersion, Integer)
        Public Property CancelClick As Action
        Public Property Quantity As Integer
            Get
                Return _quantity
            End Get
            Set(value As Integer)
                _quantity = value
                QuantityTextBox.Text = value.ToString()
            End Set
        End Property

        Private _menu As AdminItemVersion
        Private _quantity As Integer = 1

        Public Sub New(menu As AdminItemVersion)
            InitializeComponent()
            _menu = menu
            SetUI()
        End Sub

        Private Sub SetUI()
            Dim menuUC As New CustomerMenuUserControl(_menu)
            menuUC.Enabled = False
            productPanel.Controls.Add(menuUC)
            QuantityTextBox.Text = _quantity.ToString()
        End Sub

        Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
            _quantity += 1
            QuantityTextBox.Text = _quantity.ToString()
        End Sub

        Private Sub DecButton_Click(sender As Object, e As EventArgs) Handles DecButton.Click
            If _quantity > 1 Then
                _quantity -= 1
                QuantityTextBox.Text = _quantity.ToString()
            End If
        End Sub

        Private Sub AddOrderButton_Click(sender As Object, e As EventArgs) Handles AddOrderButton.Click
            AddOrderClick?.Invoke(_menu, _quantity)
        End Sub

        Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
            CancelClick?.Invoke()
        End Sub
    End Class

End Namespace