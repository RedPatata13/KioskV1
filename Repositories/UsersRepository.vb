Imports System.Data.Entity

Public Class UsersRepository
    Inherits BaseRepository(Of User)
    Public Sub New(context As AppDbContext)
        MyBase.New(context)
    End Sub
End Class
