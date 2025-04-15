Imports Autofac

Namespace KioskV0
    Module Program
        <STAThread()>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Dim container As IContainer = ContainerConfiguration.ConfigureContainer()
            Using scope As ILifetimeScope = container.BeginLifetimeScope()
                'AddMockUsers()
                'AddMockSupplierItems()
                'AddMockBatches()
                'AddMockAdminItems()
                'AddMockCustomerItems()
                'AddMockCategories()
            End Using
            'Dim container As IContainer = ContainerConfiguration.ConfigureContainer()
            Using scope As ILifetimeScope = container.BeginLifetimeScope()
                'AddSupplier(supplierModel)
                Dim projector = scope.Resolve(Of Classes.Projector)()
                projector.LoginProject()
            End Using
        End Sub
    End Module

End Namespace