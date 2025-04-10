Module InitialDBSetup
    Public Sub AddMockCategories()
        Using context As New KioskDbContext()
            Using UnitOfWork As New UnitOfWork(context)
                Dim categories As New List(Of Category) From {
                New Category() With {.CategoryName = "Burger"},
                New Category() With {.CategoryName = "Rice Meal"},
                New Category() With {.CategoryName = "Pasta"},
                New Category() With {.CategoryName = "Pizza"},
                New Category() With {.CategoryName = "Sides"},
                New Category() With {.CategoryName = "Desserts"},
                New Category() With {.CategoryName = "Beverages"},
                New Category() With {.CategoryName = "Sandwich"},
                New Category() With {.CategoryName = "Veg Salad"}
            }
                For Each category In categories
                    category.CategoryId = Guid.NewGuid().ToString().Substring(0, 10)
                Next
                UnitOfWork.Categories.AddRange(categories)
                UnitOfWork.SaveChanges()
            End Using
        End Using
    End Sub
    Public Sub AddMockCustomerItems()
        Using context As New KioskDbContext()
            Using UnitOfWork As New UnitOfWork(context)
                Dim adminItemList = UnitOfWork.AdminItems.GetAll()

                Dim customerItemList As New List(Of CustomerItem)
                Dim cnt As Integer = 1
                For Each ail In adminItemList
                    context.AdminItems.Attach(ail)

                    customerItemList.Add(New CustomerItem With {
                                         .Id = Guid.NewGuid().ToString().Substring(0, 10),
                                         .Name = "Customer Item" & cnt,
                                         .Description = "Customer Item Description" & cnt,
                                         .AdminItemId = ail.Id
                                         })

                    cnt += 1
                Next

                UnitOfWork.CustomerItems.AddRange(customerItemList)
                UnitOfWork.SaveChanges()
            End Using
        End Using
    End Sub
    Public Sub AddMockAdminItems()
        Using context As New KioskDbContext()
            Using UnitOfWork As New UnitOfWork(context)
                ' Get all the SupplierItems and Categories
                Dim inventoryItemList = UnitOfWork.SupplierItems.GetAll()
                Dim categoryItemList = UnitOfWork.Categories.GetAll().ToList() ' Ensure it's a list for easier access by index

                Dim adminItemList As New List(Of AdminItem)
                Dim cnt As Integer = 1
                Dim rand As New Random()

                For Each iil In inventoryItemList
                    context.SupplierItems.Attach(iil)

                    ' Select a random CategoryId from categoryItemList
                    Dim randomCategory = categoryItemList(rand.Next(categoryItemList.Count)) ' Get a random Category

                    adminItemList.Add(New AdminItem With {
                    .Id = Guid.NewGuid().ToString().Substring(0, 10),
                    .Name = "Admin Item" & cnt,
                    .Description = "Description of Item " & cnt,
                    .SupplierItemId = iil.Id,
                    .CategoryId = randomCategory.CategoryId ' Assign a random CategoryId
                })

                    cnt += 1
                Next

                UnitOfWork.AdminItems.AddRange(adminItemList)
                UnitOfWork.SaveChanges()
            End Using
        End Using
    End Sub

    Public Sub AddMockSupplierItems()
        Using context As New KioskDbContext()
            Using UnitOfWork As New UnitOfWork(context)
                Dim supplierList = UnitOfWork.Suppliers.GetAll()

                ' Assuming you are creating SupplierItems for these Suppliers:
                Dim supplierItems As New List(Of SupplierItem)

                For Each supplier In supplierList
                    ' Attach existing Supplier to context if necessary
                    context.Suppliers.Attach(supplier)  ' Ensure the Supplier is tracked by EF

                    ' Create SupplierItems and add them to the list
                    supplierItems.Add(New SupplierItem With {
                    .Id = Guid.NewGuid().ToString().Substring(0, 10),
                    .Name = "Item for " & supplier.Username,
                    .Description = "Description of Item",
                    .SupplierId = supplier.UserId,
                    .Supplier = supplier
                })
                Next

                ' Now, add the SupplierItems to the context
                UnitOfWork.SupplierItems.AddRange(supplierItems)
                UnitOfWork.SaveChanges()
            End Using
        End Using
    End Sub


    Public Sub AddMockUsers()
        Using context As New KioskDbContext()
            Using UnitOfWork As New UnitOfWork(context)
                Dim list = GenerateUsers()
                For Each i In list
                    UnitOfWork.Users.Add(i)
                    If TypeOf i Is Supplier Then ' Ensure it's actually a Supplier instance
                        UnitOfWork.Suppliers.Add(DirectCast(i, Supplier))
                    End If
                Next
                UnitOfWork.SaveChanges()
            End Using
        End Using
    End Sub
    Private Function GenerateUsers() As List(Of User)
        Dim users As New List(Of User)
        Dim roles As String() = {"Admin", "Staff", "Supplier"}
        Dim rnd As New Random()

        For i As Integer = 1 To 10
            Dim userId As String = Guid.NewGuid().ToString("N").Substring(0, 10)
            Dim role As String = If(i <= 5, "Supplier", roles(rnd.Next(0, 2))) ' First 5 are Suppliers, rest are Admin/Staff

            Dim user As User

            If role = "Supplier" Then
                ' Instantiate a Supplier instead of User
                user = New Supplier With {
                        .UserId = userId,
                        .FirstName = "First" & i,
                        .LastName = "Last" & i,
                        .Username = "User" & i,
                        .PasswordHash = "Password" & i,
                        .ContactNumber = "091234567" & i Mod 10,
                        .Email = "user" & i & "@example.com",
                        .Role = role,
                        .Address = "Address " & i,
                        .CreatedAt = DateTime.Now
                    }
            Else
                ' Instantiate a regular User
                user = New User With {
                        .UserId = userId,
                        .FirstName = "First" & i,
                        .LastName = "Last" & i,
                        .Username = "User" & i,
                        .PasswordHash = "Password" & i,
                        .ContactNumber = "091234567" & i Mod 10,
                        .Email = "user" & i & "@example.com",
                        .Role = role,
                        .Address = "Address " & i,
                        .CreatedAt = DateTime.Now
                    }
            End If

            users.Add(user)
        Next

        Return users
    End Function
End Module
