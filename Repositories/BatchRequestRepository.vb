Public Class BatchRequestRepository
    Inherits BaseRepository(Of BatchRequest)

    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub
End Class
