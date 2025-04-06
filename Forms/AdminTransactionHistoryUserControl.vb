Namespace KioskV0.Forms
    Public Class AdminTransactionHistoryUserControl
        Private _dgvSource As BindingSource
        Private _cashierID As String
        Private _orderID As String
        Private _dateAndTime As String

        Public Property DGV_Source As BindingSource
            Get
                Return _dgvSource
            End Get
            Set(value As BindingSource)
                _dgvSource = value
                ItemTransactionDataGrid.DataSource = _dgvSource
            End Set
        End Property

        Public Property CashierID_Source As String
            Get

                Return TransactionCashierID.Text
            End Get
            Set(value As String)
                _cashierID = value
            End Set
        End Property

        Public Property OrderID_Source As String
            Get
                Return TransactionOrderID.Text
            End Get
            Set(value As String)
                _orderID = value
            End Set
        End Property

        Public Property DateAndTime_Source As String
            Get
                Return TransactionHistoryDateAndTime.Text
            End Get
            Set(value As String)
                _dateAndTime = value
            End Set
        End Property







    End Class
End Namespace
