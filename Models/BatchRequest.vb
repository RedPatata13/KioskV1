Public Class BatchRequest
    Public Property RequestID As String
    Public Property RequestMSG As String
    Public Property Requester As User
    Public Property RequesterID As String

    Public Property Item As SupplierItem
    Public Property ItemID As String
    Public Property DateRequested As DateTime
    Public Property Units As Integer
    Public Property IsPending As Boolean
    Public Property FinalResult As String
End Class
