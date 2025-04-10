Public Class MenuRepository
    Inherits BaseRepository(Of Menu)
    Implements IMenuRepository
    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub

    Public Function GetMenuByMenuName(name As String) As Menu
        Return _dbSet.FirstOrDefault(Function(m) m.MenuName = name)
    End Function

    Public Function GetMenuByID(id As String) As Menu
        Return _dbSet.FirstOrDefault(Function(m) m.MenuId = id)
    End Function

    Private Function IMenuRepository_GetMenuByMenuName(menu_name As String) As Menu Implements IMenuRepository.GetMenuByMenuName
        Return _dbSet.FirstOrDefault(Function(m) m.MenuName = menu_name)
    End Function

    Private Function IMenuRepository_GetMenuByID(id As String) As Menu Implements IMenuRepository.GetMenuByID
        Return _dbSet.FirstOrDefault(Function(m) m.MenuId = id)
    End Function
End Class