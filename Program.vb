﻿

Imports Autofac

Namespace KioskV0
    Module Program
        <STAThread()>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Dim supplierModel As Supplier = New Supplier() With {
                .Name = "Skibidi Rizzler",
                .Address = "Gmod Toilet",
                .ContactNumber = "+099090",
                .CreatedAt = DateTime.Now,
                .Email = "skibidi_rizzler@gmail.com",
                .MenuId = "9090990",
                .SupplierId = 909090
            }

            Dim container As IContainer = ContainerConfiguration.ConfigureContainer()
            Using scope As ILifetimeScope = container.BeginLifetimeScope()
                'AddSupplier(supplierModel)
                Dim projector = scope.Resolve(Of Classes.Projector)()
                projector.LoginProject()
            End Using
        End Sub
        Sub AddSupplier(model As Supplier)
            Using context As New AppDbContext()
                Using UnitOfWork As New UnitOfWork(context)
                    UnitOfWork.Suppliers.Add(model)
                    UnitOfWork.SaveChanges()
                End Using
            End Using
        End Sub
        Sub AddUser(fname As String, lname As String, username As String, passwordHash As String,
contactNumber As String, email As String, role As String,
address As String, createdAt As DateTime)

            Using context As New AppDbContext()
                Using unitOfWork As New UnitOfWork(context)

                    Dim newUser As New User With {
                .FirstName = fname,
                .LastName = lname,
                .Username = username,
                .PasswordHash = passwordHash,
                .ContactNumber = contactNumber,
                .Email = email,
                .Role = role,
                .Address = address,
                .CreatedAt = createdAt
            }

                    unitOfWork.Users.Add(newUser)
                    unitOfWork.SaveChanges()

                    MessageBox.Show($"User {fname} ({username}) added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        End Sub


    End Module
End Namespace