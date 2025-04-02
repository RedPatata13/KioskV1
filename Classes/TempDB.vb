Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class TempDB
        Public Property TempMenu As Dictionary(Of String, MenuModel)
        Public Property TempAccounts As Dictionary(Of String, AuthModel)

        Public Sub New()
            TempMenu = LoadTempMenu()
            TempAccounts = LoadTempAccounts()
        End Sub
        Public Function GetMenu(id As String) As MenuModel
            Dim val As MenuModel = Nothing
            If Not TempMenu.TryGetValue(id, val) Then
                Throw New Exception("Menu ID does not Exist")
            End If

            Return val
        End Function

        Public Function GetMenuList() As List(Of MenuModel)
            Dim res = New List(Of MenuModel)
            For Each KVP In TempMenu
                res.Add(KVP.Value)
            Next

            Return res
        End Function

        Public Function GetAccount(id As String) As AuthModel
            Dim val As AuthModel = Nothing
            If Not TempAccounts.TryGetValue(id, val) Then
                Throw New Exception("Account ID does not exist")
            End If

            Return val
        End Function
        Private Function LoadTempMenu() As Dictionary(Of String, MenuModel)
            Dim tmp As New Dictionary(Of String, MenuModel)

            Dim items As New List(Of MenuModel) From {
                New MenuModel With {
                    .MenuID = Guid.NewGuid().ToString(),
                    .MenuName = "Item 1",
                    .Category = "Category1",
                    .Supplier = "Supplier1",
                    .ProductDescription = "A sample product description.",
                    .Cost = 10.99D,
                    .Selling = 15.99D
                },
                New MenuModel With {
                    .MenuID = Guid.NewGuid().ToString(),
                    .MenuName = "Item 2",
                    .Category = "Category2",
                    .Supplier = "Supplier2",
                    .ProductDescription = "Another sample product description.",
                    .Cost = 8.5D,
                    .Selling = 12.75D
                },
                New MenuModel With {
                    .MenuID = Guid.NewGuid().ToString(),
                    .MenuName = "Item 3",
                    .Category = "Category3",
                    .Supplier = "Supplier3",
                    .ProductDescription = "Yet another product description.",
                    .Cost = 5.99D,
                    .Selling = 9.99D
                },
                New MenuModel With {
                    .MenuID = Guid.NewGuid().ToString(),
                    .MenuName = "Item 4",
                    .Category = "Category1",
                    .Supplier = "Supplier2",
                    .ProductDescription = "Product with different category & supplier.",
                    .Cost = 12D,
                    .Selling = 18D
                },
                New MenuModel With {
                    .MenuID = Guid.NewGuid().ToString(),
                    .MenuName = "Item 5",
                    .Category = "Category2",
                    .Supplier = "Supplier3",
                    .ProductDescription = "Last sample product.",
                    .Cost = 7.25D,
                    .Selling = 11.5D
                }
            }

            For Each item In items
                tmp(item.MenuID) = item
            Next

            Return tmp
        End Function

        Private Function LoadTempAccounts() As Dictionary(Of String, Model.AuthModel)

            Dim map = New Dictionary(Of String, Model.AuthModel) From
            {
                {
                    "AdminTemp",
                    New Model.AuthModel() With
                    {
                        .UID = "AdminTemp",
                        .Password = "1234",
                        .UserType = UserType.Admin
                    }
                },
                {
                    "StaffTemp",
                    New Model.AuthModel() With
                    {
                        .UID = "StaffTemp",
                        .Password = "1234",
                        .UserType = UserType.Staff
                    }
                },
                {
                    "SupplierTemp",
                    New Model.AuthModel() With
                    {
                        .UID = "SupplierTemp",
                        .Password = "1234",
                        .UserType = UserType.Supplier
                    }
                },
                {
                    "CustomerTemp",
                    New Model.AuthModel() With
                    {
                        .UID = "CustomerTemp",
                        .Password = "1234",
                        .UserType = UserType.Customer
                    }
                }
            }

            Return map
        End Function
    End Class

End Namespace