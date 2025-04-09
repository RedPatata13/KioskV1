Imports System.ComponentModel.DataAnnotations

Namespace KioskV0.Model
    Public Class OrderModel
        Inherits BaseModel

        Friend Property MenuItem As Object

        ' Order ID (unique identifier for the order)
        <Required(ErrorMessage:="Order ID is required.")>
        <StringLength(50, ErrorMessage:="Order ID cannot exceed 50 characters.")>
        Public Property OrderID As String

        ' Date and Time of the order
        <Required(ErrorMessage:="Order date and time is required.")>
        Public Property OrderDateTime As DateTime

        ' Product Name
        <Required(ErrorMessage:="Product Name is required.")>
        <StringLength(100, ErrorMessage:="Product Name cannot exceed 100 characters.")>
        Public Property ProductName As String

        ' Product ID (unique identifier for the product)
        <Required(ErrorMessage:="Product ID is required.")>
        <StringLength(50, ErrorMessage:="Product ID cannot exceed 50 characters.")>
        Public Property ProductID As String

        ' Quantity of the product ordered
        <Required(ErrorMessage:="Quantity is required.")>
        <Range(1, Integer.MaxValue, ErrorMessage:="Quantity must be at least 1.")>
        Public Property Quantity As Integer

        ' Amount (price) of the product
        <Required(ErrorMessage:="Amount is required.")>
        <Range(0, Double.MaxValue, ErrorMessage:="Amount must be a positive value.")>
        Public Property Amount As Double
        Public Sub New()
            OrderID = Guid.NewGuid().ToString().Substring(0, 10)
        End Sub
    End Class
End Namespace
