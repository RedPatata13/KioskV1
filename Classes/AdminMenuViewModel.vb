Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class AdminMenuViewModel
        Inherits ViewModel(Of Forms.AdminMenuView, AdminKeys)
        Private Property UserControlMap As Dictionary(Of MenuModel, UserControl)
        Public Sub New(view As AdminMenuView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
            UserControlMap = New Dictionary(Of MenuModel, UserControl)
            InitializeActions()
            AddActions()
            SetEvents()
        End Sub
        Protected Overrides Sub InitializeActions()
            InternalActions = New Dictionary(Of String, Action(Of ViewModel(Of AdminMenuView, AdminKeys)))
        End Sub

        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()

            _view.AddMenuButtonClick = AddressOf AddMenuButtonClick
        End Sub
        Private Sub AddActions()
            InternalActions.Add("LoadItems", AddressOf LoadItems)
        End Sub
        Private Sub AddMenuButtonClick()
            _mediator.SwapPage(AdminKeys.AdminEditMenuDetails)
        End Sub
        Private Sub MenuUserControlClick()

        End Sub
        Private Sub PrepareEditMenu(model As BaseModel)
            Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminEditMenuDetails), AdminEditMenuDetailsViewModel)

            ' Ensure we get the correct UserControl using the Model as a key
            If UserControlMap.ContainsKey(model) Then
                Dim uc As AdminMenuUserControl = UserControlMap(model)

                UserControlMap.Remove(model)
                vm.PendingAction = Sub(updatedModel) uc.Model = updatedModel
                uc.SelfClick = Sub() PrepareEditMenu(uc.Model)
                UserControlMap(uc.Model) = uc
            End If
            vm.Previous = AdminKeys.AdminMenu
            ' Load data into the form
            vm.ExecuteExternalAction("LoadWithDetails", model)
        End Sub



        Private Sub LoadItems(admv As AdminMenuViewModel)
            _mediator.LayoutAction(AddressOf LoadMenuItems)
        End Sub

        Private Sub LoadMenuItems()
            _view.ItemPanel.Controls.Clear()
            Dim items = _mediator.GetMenuList()
            For Each item In items
                Dim uc = New AdminMenuUserControl(item)
                uc.SelfClick = Sub() PrepareEditMenu(item)
                'uc.SelfClick = Sub() MessageBox.Show("Hey")
                _view.ItemPanel.Controls.Add(uc)
                UserControlMap(item) = uc
            Next

        End Sub
    End Class
End Namespace
