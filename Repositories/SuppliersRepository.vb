Public Class SuppliersRepository
    Inherits BaseRepository(Of Supplier)
    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub
End Class
