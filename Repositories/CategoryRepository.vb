Imports System.Data.Entity

Public Class CategoryRepository
    Inherits BaseRepository(Of Category)
    Implements ICategoryRepository
    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub

End Class
