Imports System.Windows.Controls.Primitives
Imports System.Data.Entity
Module InitialDBSetup
    Public Sub AddMockItemVersions()
        Using context As New KioskDbContext()
            ' Disable auto-detect changes for better performance
            context.Configuration.AutoDetectChangesEnabled = False

            Using UnitOfWork As New UnitOfWork(context)
                ' Get all admin items with their relationships
                Dim adminItems = UnitOfWork.AdminItems.GetAll()

                ' Create dictionaries to track already attached entities
                Dim attachedCategories = New Dictionary(Of String, Category)()
                Dim attachedBatches = New Dictionary(Of String, InventoryBatch)()
                Dim attachedAdminItems = New Dictionary(Of String, AdminItem)()

                Dim list As New List(Of AdminItemVersion)

                For Each ai In adminItems
                    ' Handle Category attachment
                    If ai.Category IsNot Nothing Then
                        If Not attachedCategories.ContainsKey(ai.CategoryId) Then
                            context.Categories.Attach(ai.Category)
                            attachedCategories.Add(ai.CategoryId, ai.Category)
                        Else
                            ai.Category = attachedCategories(ai.CategoryId)
                        End If
                    End If

                    ' Handle Batch attachment
                    If ai.Batch IsNot Nothing Then
                        If Not attachedBatches.ContainsKey(ai.BatchId) Then
                            context.InventoryBatches.Attach(ai.Batch)
                            attachedBatches.Add(ai.BatchId, ai.Batch)
                        Else
                            ai.Batch = attachedBatches(ai.BatchId)
                        End If
                    End If

                    ' Handle AdminItem attachment
                    If Not attachedAdminItems.ContainsKey(ai.Id) Then
                        context.AdminItems.Attach(ai)
                        attachedAdminItems.Add(ai.Id, ai)
                    Else
                        ai = attachedAdminItems(ai.Id)
                    End If

                    ' Create new version
                    Dim model = New AdminItemVersion With {
                    .VersionId = "BASEVER_" & Guid.NewGuid().ToString().Substring(0, 5),
                    .BaseItemId = ai.Id,  ' Set foreign key
                    .CategoryId = ai.CategoryId,  ' Set foreign key
                    .BatchID = ai.BatchId,  ' Set foreign key
                    .Name = ai.Name,
                    .ImageFilePath = ai.ImageFilePath,
                    .IsDisplayedAsACustomerItem = ai.IsDisplayedAsCustomerItem,
                    .IsCurrentVersion = True,
                    .UnitCost = ai.Batch.UnitCost,
                    .SellingCost = ai.SellingCost,
                    .VersionUpdateReason = "Base Item with name: [" & ai.Name & "] and with ID: {" & ai.Id & "} created."
                }

                    ' Set navigation properties from our tracked entities
                    model.BaseItem = attachedAdminItems(ai.Id)
                    If ai.Category IsNot Nothing Then
                        model.Category = attachedCategories(ai.CategoryId)
                    End If
                    If ai.Batch IsNot Nothing Then
                        model.Batch = attachedBatches(ai.BatchId)
                    End If

                    list.Add(model)
                Next

                ' Add all versions
                UnitOfWork.AdminItemVersions.AddRange(list)

                ' Re-enable change detection
                context.Configuration.AutoDetectChangesEnabled = True
                UnitOfWork.SaveChanges()
            End Using
        End Using
    End Sub

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
    Public Sub AddMockAdminItems()
        Using context As New KioskDbContext()
            Using UnitOfWork As New UnitOfWork(context)
                ' Get required references
                Dim categories = UnitOfWork.Categories.GetAll().ToList()
                Dim supplierItems = UnitOfWork.SupplierItems.GetAll().ToList()
                Dim batches = UnitOfWork.InventoryBatches.GetAll().ToList()

                Dim adminItems As New List(Of AdminItem)
                Dim rnd As New Random()

                ' Create 2-3 admin items per supplier item
                For Each si In supplierItems
                    Dim itemCount = rnd.Next(2, 4)
                    Dim itemBatches = batches.Where(Function(b) b.SupplierItemId = si.Id).ToList()
                    context.SupplierItems.Attach(si)
                    For i = 1 To itemCount
                        ' Select random category
                        Dim category = categories(rnd.Next(0, categories.Count))
                        context.Categories.Attach(category)
                        ' Create admin item
                        Dim adminItem = New AdminItem With {
                        .Id = "ADMIN_" & Guid.NewGuid().ToString().Substring(0, 8),
                        .Name = $"{si.Name} Product {i}",
                        .Description = $"Customer-facing version of {si.Name} ({i})",
                        .CategoryId = category.CategoryId,
                        .Category = category,
                        .IsDisplayedAsCustomerItem = (i = 1), ' First item per supplier shown to customers
                        .SellingCost = Math.Round(si.Batches.Average(Function(b) b.UnitCost) * 1.5, 2) ' 50% markup
                    }

                        ' Assign newest active batch
                        Dim availableBatch = itemBatches.Where(Function(b) b.IsActive AndAlso Not b.IsDeprecated) _
                        .OrderByDescending(Function(b) b.ReceivedDate) _
                        .FirstOrDefault()

                        If availableBatch IsNot Nothing Then
                            adminItem.BatchId = availableBatch.BatchId
                        End If

                        adminItems.Add(adminItem)
                    Next
                Next

                UnitOfWork.AdminItems.AddRange(adminItems)
                UnitOfWork.SaveChanges()
            End Using
        End Using
    End Sub

    Public Sub AddMockSupplierItems()
        Using context As New KioskDbContext()
            Using UnitOfWork As New UnitOfWork(context)
                Dim supplierList = UnitOfWork.Users.GetAll().Where(Function(s) s.Role = "Supplier")
                Dim supplierItems As New List(Of SupplierItem)

                ' Item name templates to create variety
                Dim itemTemplates = {"Premium {0} Supplies", "Standard {0} Goods", "Budget {0} Materials"}

                For Each supplier In supplierList
                    context.Suppliers.Attach(supplier)

                    ' Create 3 items per supplier
                    For i = 1 To 3
                        supplierItems.Add(New SupplierItem With {
                        .Id = "SI_" & Guid.NewGuid().ToString().Substring(0, 10),
                        .Name = String.Format(itemTemplates(i - 1), supplier.FirstName),
                        .Description = $"Sample {supplier.FirstName} product line #{i}",
                        .SupplierId = supplier.UserId,
                        .Supplier = supplier
                    })
                    Next
                Next

                UnitOfWork.SupplierItems.AddRange(supplierItems)
                UnitOfWork.SaveChanges()
            End Using
        End Using
    End Sub
    Public Sub AddMockBatches()
        Using context As New KioskDbContext()
            Using UnitOfWork As New UnitOfWork(context)
                ' Get all supplier items
                Dim supplierItems = UnitOfWork.SupplierItems.GetAll().ToList()
                Dim batches As New List(Of InventoryBatch)
                Dim rnd As New Random()

                For Each item In supplierItems
                    ' Create 2-4 batches per item (random variation)
                    context.SupplierItems.Attach(item)
                    Dim batchCount = rnd.Next(2, 5)

                    For i = 1 To batchCount

                        Dim batchSize = If(i = 1, 100, If(i = 2, 75, 50)) ' Decreasing batch sizes
                        Dim daysOld = (i - 1) * 30 ' Stagger receipt dates by 30 days
                        Dim expiryDays = If(item.Name.Contains("Premium"), 365, 180) ' Premium items last longer

                        batches.Add(New InventoryBatch With {
                        .BatchId = "BATCH_" & Guid.NewGuid().ToString().Substring(0, 8),
                        .SupplierId = item.SupplierId,
                        .SupplierItemId = item.Id,
                        .SupplierItem = item,
                        .QuantityReceived = batchSize,
                        .RemainingQuantity = batchSize, ' Start with full quantity
                        .UnitCost = If(item.Name.Contains("Premium"), 9.99D,
                                    If(item.Name.Contains("Standard"), 6.5D, 3.25D)),
                        .ReceivedDate = DateTime.Now.AddDays(-daysOld),
                        .ExpiryDate = DateTime.Now.AddDays(expiryDays - daysOld),
                        .BatchNumber = $"B-{item.Name.Substring(0, 3)}-{DateTime.Now.Year}-{i}",
                            .IsActive = True,
                            .IsDeprecated = False
                        })
                    Next
                Next

                UnitOfWork.InventoryBatches.AddRange(batches)
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
