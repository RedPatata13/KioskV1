Imports KioskV0.KioskV0.Model

Namespace KioskV0.Forms
    Public Class CustomerOrderListView
        Public Property OrderMoreClick As Action
        Public Property StartOverClick As Action
        Public Property CheckOutClick As Action

        Public ReadOnly Property OrderPanel As FlowLayoutPanel
            Get
                Return OrderListFlowLayout
            End Get
        End Property

        Public Sub AddOrderDetailControl(control As Control)
            OrderListFlowLayout.Controls.Add(control)
        End Sub
        Public Sub ClearOrderDetailControls()
            OrderListFlowLayout.Controls.Clear()
        End Sub
        Public Sub PopulateDataGrid(dataSource As Object)
            OrderDetailsDGV.DataSource = dataSource
        End Sub

        Private Sub OrderMoreButton_Click(sender As Object, e As EventArgs) Handles OrderMoreButton.Click
            OrderMoreClick?.Invoke()
        End Sub

        Private Sub StartOverButton_Click(sender As Object, e As EventArgs) Handles StartOverButton.Click
            StartOverClick?.Invoke()
        End Sub

        Private Sub CheckOutButton_Click(sender As Object, e As EventArgs) Handles CheckOutButton.Click
            CheckOutClick?.Invoke()
        End Sub
    End Class
End Namespace