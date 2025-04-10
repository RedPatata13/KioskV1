Imports System.Data.Entity

Public Class SupplierItemsRepository
    Inherits BaseRepository(Of SupplierItem)
    Implements ISupplierItemsRepository
    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub
End Class
