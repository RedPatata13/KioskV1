Imports KioskV0.KioskV0.Model

Namespace KioskV0.Forms
    Public Class CustomerOrderListView
        Public Property OrderMoreClick As Action
        Public Property StartOverClick As Action
        Public Property CheckOutClick As Action

        Public Property PanelLocation As Point
            Get
                Return OrderListFlowLayout.Location
            End Get
            Set(value As Point)
                OrderListFlowLayout.Location = value
            End Set
        End Property
        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            'Controls.Add(StartOverButton)
            'Controls.Add(OrderMoreButton)
        End Sub
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

        Private Sub CustomerNoItemUserControl1_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        End Sub

        Private Sub OrderDetailsDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrderDetailsDGV.CellContentClick

        End Sub

        Private Sub OrderListFlowLayout_Paint(sender As Object, e As PaintEventArgs) Handles OrderListFlowLayout.Paint

        End Sub
    End Class
End Namespace