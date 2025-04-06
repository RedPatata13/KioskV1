Public Class MenuRepository
    Inherits BaseRepository(Of Menu)
    Public Sub New(context As AppDbContext)
        MyBase.New(context)
    End Sub
End Class