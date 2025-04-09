Public Interface IUsersRepository
    Inherits IBaseRepository(Of User)
    Function GetUserByUsername(username As String) As User
    Function GetUserByID(id As String) As User
End Interface
