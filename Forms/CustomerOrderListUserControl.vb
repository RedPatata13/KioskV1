Namespace KioskV0.Forms
    Public Class CustomerOrderListUserControl
        Public Property OrderListDataSource As Object
            Get
                Return OrderListDGV.DataSource
            End Get
            Set(value As Object)
                OrderListDGV.DataSource = value
            End Set
        End Property

        Public Property OrderListBindingSource As BindingSource
            Get
                Return CType(OrderListDGV.DataSource, BindingSource)
            End Get
            Set(value As BindingSource)
                OrderListDGV.DataSource = value
            End Set
        End Property



    End Class

End Namespace