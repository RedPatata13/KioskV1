Imports System.ComponentModel

Public Class BatchRequest
    <DisplayName("Request ID")>
    Public Property RequestID As String

    <DisplayName("Message")>
    Public Property RequestMSG As String

    <DisplayName("Requester")>
    Public Property Requester As User

    <DisplayName("Requester ID")>
    Public Property RequesterID As String

    <DisplayName("Item")>
    Public Property Item As SupplierItem

    <DisplayName("Item ID")>
    Public Property ItemID As String
    Public Property Recipient As User
    Public Property RecipientID As String
    Public Property DateRequested As DateTime

    <DisplayName("Units")>
    Public Property Units As Integer
    Public Property IsPending As Boolean
    Public Property FinalResult As String
End Class
