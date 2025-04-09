Imports System.Runtime.InteropServices.ComTypes
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class TempDB
        Public Property TempMenu As Dictionary(Of String, MenuModel)
        Public Property TempAccounts As Dictionary(Of String, AuthModel)
        Public Property TempItems As Dictionary(Of String, ItemModel)
        Public Property TempUsers As Dictionary(Of String, Model.UserModel)
        Public Property TempOrders As Dictionary(Of String, OrderModel)
        Public Sub New()

            TempUsers = LoadTempUsers()
            TempMenu = LoadTempMenu()
            TempAccounts = LoadTempAccounts()
            TempItems = LoadTempItems()
            TempOrders = LoadTempOrders()

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
        Public Function GetOrderList() As List(Of OrderModel)
            Dim res = New List(Of OrderModel)
            For Each KVP In TempOrders
                res.Add(KVP.Value)
            Next
            Return res
        End Function
        Public Sub AddMenu(model As MenuModel)
            TempMenu.Add(model.MenuID, model)
        End Sub
        Public Sub DeleteMenu(model As MenuModel)
            Dim val As MenuModel = Nothing
            If Not TempMenu.TryGetValue(model.MenuID, val) Then
                Throw New Exception("Account Id does not exist")
            End If

            TempMenu.Remove(model.MenuID)
        End Sub
        Public Sub UpdateMenu(str As String, newModel As MenuModel)
            Dim menu As MenuModel = Nothing
            If Not TempMenu.TryGetValue(str, menu) Then
                Throw New Exception("Menu ID does not Exist")
            End If

            If menu.MenuID <> newModel.MenuID Then
                Throw New Exception("Menu ID found but does not match.")
            End If

            newModel.Validate()
            TempMenu(menu.MenuID) = newModel
            LoadTempItems()
        End Sub
        Public Function GetItemList() As List(Of ItemModel)
            Dim res = New List(Of ItemModel)
            For Each KVP In TempMenu
                Dim model = New ItemModel With {
                    .ProductId = KVP.Key,
                    .ProductName = KVP.Value.MenuName,
                    .Quantity = 10,
                    .Status = ItemStatus.Active,
                    .Supplier = KVP.Value.Supplier
                }

                res.Add(model)
            Next
            Return res
        End Function

        Public Function GetUserList() As List(Of Model.UserModel)
            Dim res = New List(Of Model.UserModel)
            For Each KVP In TempUsers
                res.Add(KVP.Value)
            Next

            Return res
        End Function
        Public Function GetAccount(id As String) As AuthModel
            Dim val As Model.UserModel = Nothing
            If Not TempUsers.TryGetValue(id, val) Then
                Throw New Exception("Account ID does not exist")
            End If
            Dim model As New AuthModel With {
                .UID = val.UserName,
                .Password = val.Password,
                .UserType = val.Role
            }
            Return model
        End Function
        Private Function LoadTempMenu() As Dictionary(Of String, MenuModel)
            Dim tmp As New Dictionary(Of String, MenuModel)

            Dim items As New List(Of MenuModel) From {
                New MenuModel With {
                    .MenuID = Guid.NewGuid().ToString("N").Substring(0, 10),
                    .MenuName = "Item 1",
                    .Category = "Category1",
                    .Supplier = "Supplier1",
                    .ProductDescription = "A sample product description.",
                    .Cost = 10.99D,
                    .Selling = 15.99D
                },
                New MenuModel With {
                    .MenuID = Guid.NewGuid().ToString("N").Substring(0, 10),
                    .MenuName = "Item 2",
                    .Category = "Category2",
                    .Supplier = "Supplier2",
                    .ProductDescription = "Another sample product description.",
                    .Cost = 8.5D,
                    .Selling = 12.75D
                },
                New MenuModel With {
                    .MenuID = Guid.NewGuid().ToString("N").Substring(0, 10),
                    .MenuName = "Item 3",
                    .Category = "Category3",
                    .Supplier = "Supplier3",
                    .ProductDescription = "Yet another product description.",
                    .Cost = 5.99D,
                    .Selling = 9.99D
                },
                New MenuModel With {
                    .MenuID = Guid.NewGuid().ToString("N").Substring(0, 10),
                    .MenuName = "Item 4",
                    .Category = "Category1",
                    .Supplier = "Supplier2",
                    .ProductDescription = "Product with different category & supplier.",
                    .Cost = 12D,
                    .Selling = 18D
                },
                New MenuModel With {
                    .MenuID = Guid.NewGuid().ToString("N").Substring(0, 10),
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

            Dim map = New Dictionary(Of String, Model.AuthModel)
            For Each KVP In TempUsers
                Dim model = New AuthModel With {
                    .UID = KVP.Value.UserName,
                    .Password = KVP.Value.Password,
                    .UserType = KVP.Value.Role
                }

                map.Add(model.UID, model)
            Next

            Return map
        End Function
        Private Function LoadTempUsers() As Dictionary(Of String, Model.UserModel)

            Dim map = New Dictionary(Of String, Model.UserModel) From
            {
                {
                    "AdminTemp",
                    New Model.UserModel() With
                    {
                        .UserName = "AdminTemp",
                        .Password = "1234",
                        .FirstName = "Jane",
                        .LastName = "Doe",
                        .Role = UserType.Admin,
                        .ContactNo = "092190121",
                        .Email = "admin123@gmail.com"
                    }
                },
                {
                    "StaffTemp",
                    New Model.UserModel() With
                    {
                        .UserName = "StaffTemp",
                        .Password = "1234",
                        .FirstName = "John",
                        .LastName = "Smith",
                        .Role = UserType.Staff,
                        .ContactNo = "092190122",
                        .Email = "staff123@gmail.com"
                    }
                },
                {
                    "SupplierTemp",
                    New Model.UserModel() With
                    {
                        .UserName = "SupplierTemp",
                        .Password = "1234",
                        .FirstName = "Alice",
                        .LastName = "Johnson",
                        .Role = UserType.Supplier,
                        .ContactNo = "092190123",
                        .Email = "supplier123@gmail.com"
                    }
                },
                {
                    "CustomerTemp",
                    New Model.UserModel() With
                    {
                        .UserName = "CustomerTemp",
                        .Password = "1234",
                        .FirstName = "Bob",
                        .LastName = "Lee",
                        .Role = UserType.Customer,
                        .ContactNo = "092190124",
                        .Email = "customer123@gmail.com"
                    }
                },
                {
                    "AdminTemp2",
                    New Model.UserModel() With
                    {
                        .UserName = "AdminTemp2",
                        .Password = "1234",
                        .FirstName = "Eve",
                        .LastName = "White",
                        .Role = UserType.Admin,
                        .ContactNo = "092190125",
                        .Email = "admin2@gmail.com"
                    }
                },
                {
                    "StaffTemp2",
                    New Model.UserModel() With
                    {
                        .UserName = "StaffTemp2",
                        .Password = "1234",
                        .FirstName = "Tom",
                        .LastName = "Green",
                        .Role = UserType.Staff,
                        .ContactNo = "092190126",
                        .Email = "staff2@gmail.com"
                    }
                },
                {
                    "SupplierTemp2",
                    New Model.UserModel() With
                    {
                        .UserName = "SupplierTemp2",
                        .Password = "1234",
                        .FirstName = "Mia",
                        .LastName = "Brown",
                        .Role = UserType.Supplier,
                        .ContactNo = "092190127",
                        .Email = "supplier2@gmail.com"
                    }
                },
                {
                    "CustomerTemp2",
                    New Model.UserModel() With
                    {
                        .UserName = "CustomerTemp2",
                        .Password = "1234",
                        .FirstName = "Liam",
                        .LastName = "Davis",
                        .Role = UserType.Customer,
                        .ContactNo = "092190128",
                        .Email = "customer2@gmail.com"
                    }
                }
            }

            Return map
        End Function


        Private Function LoadTempItems() As Dictionary(Of String, Model.ItemModel)
            Dim map = New Dictionary(Of String, ItemModel)
            For Each KVP In TempMenu
                Dim model = New ItemModel With {
                    .ProductId = KVP.Key,
                    .ProductName = KVP.Value.MenuName,
                    .Quantity = 10,
                    .Status = ItemStatus.Active,
                    .Supplier = KVP.Value.Supplier
                }

                map.Add(model.ProductId, model)
            Next
            Return map
        End Function

        Private Function LoadTempOrders() As Dictionary(Of String, Model.OrderModel)
            Dim map = New Dictionary(Of String, OrderModel) From
            {
                {
                    "Order1",
                    New OrderModel() With {
                        .OrderDateTime = New DateTime(2025, 4, 1, 14, 30, 0),
                        .ProductName = "Product A",
                        .ProductID = "A001",
                        .Quantity = 5,
                        .Amount = 50.75
                    }
                },
                {
                    "Order2",
                    New OrderModel() With {
                        .OrderDateTime = New DateTime(2025, 4, 2, 9, 0, 0),
                        .ProductName = "Product B",
                        .ProductID = "B002",
                        .Quantity = 3,
                        .Amount = 30.0
                    }
                },
                {
                    "Order3",
                    New OrderModel() With {
                        .OrderDateTime = New DateTime(2025, 4, 3, 17, 45, 0),
                        .ProductName = "Product C",
                        .ProductID = "C003",
                        .Quantity = 10,
                        .Amount = 100.25
                    }
                },
                {
                    "Order4",
                    New OrderModel() With {
                        .OrderDateTime = New DateTime(2025, 4, 4, 11, 15, 0),
                        .ProductName = "Product D",
                        .ProductID = "D004",
                        .Quantity = 2,
                        .Amount = 20.0
                    }
                },
                {
                    "Order5",
                    New OrderModel() With {
                        .OrderDateTime = New DateTime(2025, 4, 5, 16, 10, 0),
                        .ProductName = "Product E",
                        .ProductID = "E005",
                        .Quantity = 7,
                        .Amount = 70.5
                    }
                },
                {
                    "Order6",
                    New OrderModel() With {
                        .OrderDateTime = New DateTime(2025, 4, 6, 13, 5, 0),
                        .ProductName = "Product F",
                        .ProductID = "F006",
                        .Quantity = 4,
                        .Amount = 40.0
                    }
                },
                {
                    "Order7",
                    New OrderModel() With {
                        .OrderDateTime = New DateTime(2025, 4, 7, 10, 30, 0),
                        .ProductName = "Product G",
                        .ProductID = "G007",
                        .Quantity = 1,
                        .Amount = 10.0
                    }
                },
                {
                    "Order8",
                    New OrderModel() With {
                        .OrderDateTime = New DateTime(2025, 4, 8, 18, 0, 0),
                        .ProductName = "Product H",
                        .ProductID = "H008",
                        .Quantity = 6,
                        .Amount = 60.75
                    }
                },
                {
                    "Order9",
                    New OrderModel() With {
                        .OrderDateTime = New DateTime(2025, 4, 9, 14, 30, 0),
                        .ProductName = "Product I",
                        .ProductID = "I009",
                        .Quantity = 8,
                        .Amount = 80.8
                    }
                },
                {
                    "Order10",
                    New OrderModel() With {
                        .OrderDateTime = New DateTime(2025, 4, 10, 12, 20, 0),
                        .ProductName = "Product J",
                        .ProductID = "J010",
                        .Quantity = 3,
                        .Amount = 35.9
                    }
                }
            }

            Return map
        End Function
    End Class

End Namespace