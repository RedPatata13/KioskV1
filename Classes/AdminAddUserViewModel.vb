Imports System.ComponentModel.DataAnnotations
Imports System.Reflection
Imports Autofac
Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Model
Imports KioskV0.KioskV0.Services
Imports Microsoft.VisualBasic.ApplicationServices

Namespace KioskV0.Classes
    Public Class AdminAddUserViewModel
        Inherits ViewModel(Of Forms.AdminAddUserView, AdminKeys)
        Public Sub New(view As AdminAddUserView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
            SetEvents()
        End Sub

        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()
            _view.CancelButtonClick = AddressOf CancelButtonClick
            _view.SaveButtonClick = AddressOf SaveButtonClick
        End Sub

        Private Sub CancelButtonClick()
            _mediator.SwapPage(AdminKeys.AdminAccountSettings)
            _view.ResetFields()
        End Sub
        Private Sub SaveButtonClick()
            Dim container As IContainer = ContainerConfiguration.ConfigureContainer()
            Dim adminService = container.Resolve(Of AdminService)()
            adminService.MapViewToUser(_view)
            Dim isSuccess As Boolean = adminService.AddUser()
            If isSuccess Then
                CancelButtonClick()
            End If
        End Sub
    End Class
End Namespace
