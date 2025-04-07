Imports Autofac
Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Model
Imports KioskV0.KioskV0.Services

Namespace KioskV0.Classes
    Public Class AdminMenuViewModel
        Inherits ViewModel(Of Forms.AdminMenuView, AdminKeys)

        Private Property Loaded As Boolean = False
        Public Sub New(view As AdminMenuView,
                       mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
            SetEvents()
        End Sub

        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()

            _view.AddMenuButtonClick = AddressOf AddMenuButtonClick
        End Sub

        Public Overrides Sub Project(projector As Form)
            _mediator.LayoutAction(Sub()
                                       _mediator.AddAction(Sub() MyBase.Project(projector))
                                       If Not Loaded Then
                                           _mediator.AddAction(Sub() MyBase.Project(projector))

                                       End If
                                       _mediator.AddAction(Sub() LoadMenuItems())
                                       _mediator.InvokeAllAction()
                                   End Sub)
            Loaded = True
        End Sub
        Private Sub AddMenuButtonClick()
            Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminEditMenuDetails), AdminEditMenuDetailsViewModel)
            vm.Previous = AdminKeys.AdminMenu
            _mediator.SwapPage(AdminKeys.AdminEditMenuDetails)
        End Sub
        Private Sub MenuUserControlClick()

        End Sub
        Private Sub PrepareEditMenu(model As Menu)
            Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminEditMenuDetails), AdminEditMenuDetailsViewModel)
            vm.Previous = AdminKeys.AdminMenu
            vm.LoadAsEdit(model)
        End Sub

        Private Sub LoadMenuItems()
            _view.ItemPanel.Controls.Clear()

            Dim container As IContainer = ContainerConfiguration.ConfigureContainer()
            Dim adminService = container.Resolve(Of AdminService)()

            Dim items = adminService.GetAllMenus()
            For Each item In items
                Dim uc = New AdminMenuUserControl(item)
                uc.SelfClick = Sub() PrepareEditMenu(item)
                _view.ItemPanel.Controls.Add(uc)
            Next
        End Sub
    End Class
End Namespace
