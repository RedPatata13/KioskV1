Imports Autofac

Namespace KioskV0
    Module Program
        <STAThread()>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            'Dim container As IContainer = ContainerConfiguration.ConfigureContainer()
            'Using scope As ILifetimeScope = container.BeginLifetimeScope()
            '    'AddMockUsers()
            '    'AddMockSupplierItems()
            '    'AddMockBatches()
            '    'AddMockAdminItems()
            '    'AddMockCustomerItems()
            '    'AddMockCategories()
            '    'AddMockItemVersions()
            '    Using context As New KioskDbContext()
            '        Using UnitOfWord As New UnitOfWork(context)
            '            Dim si_list = UnitOfWord.SupplierItems.GetAll()
            '            Dim totalbatches = 0

            '            For Each si In si_list
            '                totalbatches += si.Batches.Count
            '            Next

            '            MessageBox.Show($"{totalbatches}")
            '        End Using
            '    End Using
            'End Using
            Dim container As IContainer = ContainerConfiguration.ConfigureContainer()
            Using scope As ILifetimeScope = container.BeginLifetimeScope()
                Dim projector = scope.Resolve(Of Classes.Projector)()
                projector.LoginProject()
            End Using
        End Sub
    End Module

End Namespace