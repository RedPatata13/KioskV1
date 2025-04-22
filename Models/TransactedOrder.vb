Public Class TransactedOrder
    Public Property TransactedOrderId As String
    Public Property IsFinalized As Boolean
    ' 0 - Cancelled
    ' 1 - Finalized

    Public Property UserId As String
    Public Property User As User
    Public Property EatMode As String
    Public Property OrderId As String
    Public Property Order As OrderPrimal

    Public Property SubTotal As Integer
    Public Property CashPaid As Integer
    Public Property Change As Integer
    Public Property DateTransacted As DateTime
End Class
