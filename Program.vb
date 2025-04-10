

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
                'AddMockAdminItems()
                AddMockCustomerItems()
            End Using
        End Sub
    End Module

End Namespace