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

    <DisplayName("Date Requested")>
    Public Property DateRequested As DateTime

    <DisplayName("Units")>
    Public Property Units As Integer

    <DisplayName("Is Pending")>
    Public Property IsPending As Boolean

    <DisplayName("Final Result")>
    Public Property FinalResult As Boolean
End Class
