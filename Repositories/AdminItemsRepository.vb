Imports System.Data.Entity

Public Class AdminItemsRepository
    Inherits BaseRepository(Of AdminItem)
    Implements IAdminItemsRepository
    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub
End Class
