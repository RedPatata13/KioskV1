Imports Autofac
Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Classes

Public Class ContainerConfiguration
    Private Shared _container As IContainer

    ' Ensure container is only created once
    Public Shared Function ConfigureContainer() As IContainer
        If _container Is Nothing Then
            Dim builder As New ContainerBuilder()
            builder.RegisterType(Of Projector)().AsSelf().InstancePerDependency()
            builder.RegisterType(Of AppDbContext)().AsSelf().SingleInstance()
            builder.RegisterType(Of UsersRepository)().As(Of IUsersRepository)().InstancePerDependency()
            builder.RegisterType(Of UnitOfWork)().As(Of IUnitOfWork)().InstancePerDependency()
            _container = builder.Build()
        End If
        Return _container
    End Function
End Class
