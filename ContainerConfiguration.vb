Imports Autofac
Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Classes
Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Services

Public Class ContainerConfiguration
    Private Shared _container As IContainer

    ' Ensure container is only created once
    Public Shared Function ConfigureContainer() As IContainer
        If _container Is Nothing Then
            Dim builder As New ContainerBuilder()
            builder.RegisterType(Of Projector)().
            AsSelf().
            InstancePerLifetimeScope() ' ✅ Ensures it gets a valid scope.

            builder.RegisterType(Of AppDbContext)().AsSelf().SingleInstance()
            builder.RegisterType(Of UsersRepository)().As(Of IUsersRepository)().InstancePerDependency()
            builder.RegisterType(Of UnitOfWork)().As(Of IUnitOfWork)().InstancePerDependency()
            builder.RegisterType(Of ValidationService)().AsSelf().SingleInstance()
            builder.RegisterType(Of AdminService)().AsSelf().InstancePerDependency()
            builder.RegisterType(Of User)().AsSelf().InstancePerDependency()
            builder.RegisterType(Of Menu)().AsSelf().InstancePerDependency()
            builder.RegisterType(Of Inventory)().AsSelf().InstancePerDependency()
            ' Register Mediator as Singleton
            builder.RegisterType(Of Mediator(Of AdminKeys))().SingleInstance()

            ' Register other services and classes as needed
            _container = builder.Build()
        End If
        Return _container
    End Function
End Class
