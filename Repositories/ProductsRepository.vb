Public Class ProductsRepository
    Inherits BaseRepository(Of Product)
    Public Sub New(context As AppDbContext)
        MyBase.New(context)
    End Sub
End Class