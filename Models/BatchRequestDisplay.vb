Imports System.ComponentModel

Public Class BatchRequestDisplay
    <DisplayName("Item Name")>
    Public Property Item As String

    <DisplayName("Date Requested")>
    Public Property DateRequested As Date

    <DisplayName("Requested By")>
    Public Property Requester As String

    <DisplayName("Units Requested")>
    Public Property Units As Integer
End Class

Public Class BatchSoldPercentageDisplay
    <DisplayName("Batch #")>
    Public Property BatchNumber As String

    <DisplayName("Item Name")>
    Public Property ItemName As String

    <DisplayName("Quantity Received")>
    Public Property QuantityReceived As Integer

    <DisplayName("Remaining Quantity")>
    Public Property RemainingQuantity As Integer

    <DisplayName("Units Sold")>
    Public Property UnitsSold As Integer

    <DisplayName("Sold (%)")>
    Public Property SoldPercentage As Decimal
End Class
