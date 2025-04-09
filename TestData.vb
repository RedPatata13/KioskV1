Public Class TestData

    Public Sub AddOrderData()
        Using context As New AppDbContext()
            Using unitOfWork As New UnitOfWork(context)
                ' Create a new order
                Dim newOrder As New Order With {
            .OrderId = Guid.NewGuid().ToString().Substring(0, 10),
            .TotalAmount = 100D,
            .CreatedAt = DateTime.Now
        }
                Dim existingOrder = unitOfWork.Orders.GetAll().FirstOrDefault(Function(o) o.OrderId = newOrder.OrderId)
                If existingOrder Is Nothing Then
                    unitOfWork.Orders.Add(newOrder)
                End If

                ' Create a new order item
                Dim newOrderItem As New OrderItem With {
            .OrderItemId = Guid.NewGuid().ToString().Substring(0, 10),
            .OrderId = newOrder.OrderId,
            .MenuId = "0a9b9f98-2", 'existing dapat yong id sa menu table
            .Quantity = 2,
            .Price = 50D,
            .TotalAmount = 100D
        }

                ' Check if the order item already exists (optional, if needed)
                Dim existingOrderItem = unitOfWork.OrderItems.GetAll().FirstOrDefault(Function(oi) oi.OrderItemId = newOrderItem.OrderItemId)
                If existingOrderItem Is Nothing Then
                    unitOfWork.OrderItems.Add(newOrderItem)
                End If

                ' Save all changes
                unitOfWork.SaveChanges()
            End Using
        End Using

    End Sub
End Class
