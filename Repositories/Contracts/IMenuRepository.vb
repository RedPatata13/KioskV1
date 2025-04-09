Public Interface IMenuRepository
    Inherits IBaseRepository(Of Menu)
    Function GetMenuByMenuName(menu_name As String) As Menu
    Function GetMenuByID(id As String) As Menu
End Interface
