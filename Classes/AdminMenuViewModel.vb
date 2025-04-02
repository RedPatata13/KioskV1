Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminMenuViewModel
        Inherits ViewModel(Of Forms.AdminMenuView, AdminKeys)

        Public Sub New(view As AdminMenuView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
            InitializeActions()
            AddActions()
        End Sub
        Protected Overrides Sub InitializeActions()
            Actions = New Dictionary(Of String, Action(Of ViewModel(Of AdminMenuView, AdminKeys)))
        End Sub

        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()

            _view.AddMenuButtonClick = AddressOf AddMenuButtonClick
        End Sub
        Private Sub AddActions()
            Actions.Add("LoadItems", AddressOf LoadItems)
        End Sub
        Private Sub AddMenuButtonClick()
            _mediator.SwapPage(AdminKeys.AdminEditInventoryDetails)
        End Sub

        Private Sub LoadItems(admv As AdminMenuViewModel)
            _mediator.LayoutAction(AddressOf LoadMenuItems)
        End Sub

        Private Sub LoadMenuItems()
            _view.ItemPanel.Controls.Clear()
            Dim items = _mediator.GetMenuList()
            For Each item In items
                Dim uc = New AdminMenuUserControl(item)
                _view.ItemPanel.Controls.Add(uc)
            Next
        End Sub
    End Class
End Namespace
