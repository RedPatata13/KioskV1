Imports System.Data.Entity

Public Class CustomerItemsRepository
    Inherits BaseRepository(Of CustomerItem)
    Implements ICustomerItemRepository
    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub
End Class
