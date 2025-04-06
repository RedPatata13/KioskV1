﻿

Imports Autofac

Namespace KioskV0
    Module Program
        <STAThread()>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            Dim container As IContainer = ContainerConfiguration.ConfigureContainer()
            Using scope As ILifetimeScope = container.BeginLifetimeScope()
                Dim projector = scope.Resolve(Of Classes.Projector)()
                projector.LoginProject()
            End Using
        End Sub
    End Module
End Namespace