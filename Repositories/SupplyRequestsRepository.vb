Public Class SupplyRequestsRepository
    Inherits BaseRepository(Of SupplyRequest)
    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub
End Class
