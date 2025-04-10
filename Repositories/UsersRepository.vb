Imports System.Data.Entity

Public Class UsersRepository
    Inherits BaseRepository(Of User)
    Implements IUsersRepository
    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub

    Public Function GetUserByID(id As String) As User Implements IUsersRepository.GetUserByID
        Return _dbSet.FirstOrDefault(Function(u) u.UserId = id)
    End Function
    Public Function GetUserByUsername(username As String) As User Implements IUsersRepository.GetUserByUsername
        Return _dbSet.FirstOrDefault(Function(u) u.Username = username)
    End Function
End Class
