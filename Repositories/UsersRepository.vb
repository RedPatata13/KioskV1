Imports System.Data.Entity

Public Class UsersRepository
    Inherits BaseRepository(Of User)
    Implements IUsersRepository
    Public Sub New(context As AppDbContext)
        MyBase.New(context)
    End Sub
    Public Function GetUserByUsername(username As String) As User Implements IUsersRepository.GetUserByUsername
        Return _dbSet.FirstOrDefault(Function(u) u.Username = username)
    End Function
End Class
