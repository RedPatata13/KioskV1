Namespace KioskV0.Forms
    Public Class StaffPendingOrdersUserControl
        Inherits UserControl

        Public Event CompleteOrderClicked()

        Private _orderId As String
        Private _itemNames As List(Of String)
        Private _isPaid As Boolean
        Private _isComplete As Boolean

        Public Sub New(orderId As String, itemNames As List(Of String), isPaid As Boolean, isComplete As Boolean)
            InitializeComponent()
            _orderId = orderId
            _itemNames = itemNames
            _isPaid = isPaid
            _isComplete = isComplete
            LoadOrderDetails()
        End Sub

        Private Sub LoadOrderDetails()
            OrderIdLabel.Text = _orderId

            PendingOrdersFlowLayoutPanel.Controls.Clear()

            For Each item In _itemNames
                Dim lbl As New Label()
                lbl.Text = "• " & item
                lbl.AutoSize = True
                lbl.Margin = New Padding(3)
                PendingOrdersFlowLayoutPanel.Controls.Add(lbl)
            Next
        End Sub

        Private Sub CompleteButton_Click(sender As Object, e As EventArgs) Handles CompleteButton.Click
            RaiseEvent CompleteOrderClicked()
        End Sub
    End Class
End Namespace