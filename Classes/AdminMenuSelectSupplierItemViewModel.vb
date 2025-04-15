Imports System.Runtime.InteropServices.ComTypes

Namespace KioskV0.Classes
    Public Class AdminMenuSelectSupplierItemViewModel
        Inherits ViewModel(Of AdminMenuSelectSupplierItemView, AdminKeys)
        Private Property Loaded As Boolean = False
        Private Property SelectedRow As InventoryBatch

        Public Sub New(view As Form, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)

            SetEvents()
        End Sub

        Public Overrides Sub Project(projector As Form)
            If Not Loaded Then
                _mediator.AddAction(Sub() MyBase.Project(projector))
                _mediator.AddAction(Sub() MyBase.Project(projector))
                _mediator.AddAction(Sub() ResizeComponents(_mediator.GetProjectorPanelSize()))
                _mediator.InvokeAllAction()
            End If
            Loaded = False
            MyBase.Project(projector)
        End Sub

        Public Function GetSelectedItem() As InventoryBatch
            Return SelectedRow
        End Function

        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()

            _view.DGV_Source = New BindingSource With {.DataSource = _mediator.GetUnitOfWork.InventoryBatches.GetAll()}
            _view.CellClickAction = Sub() ChangeDocked()
            _view.SelectButtonClick = Sub() ConfirmClick()
            _view.CancelButtonCLick = Sub() CancelClick()
        End Sub
        Private Sub ChangeDocked()
            SelectedRow = _view.SelectedItem
            'MessageBox.Show($"{SelectedRow.BatchId}")
        End Sub
        Private Sub ConfirmClick()
            Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminEditMenuDetails), AdminEditMenuDetailsViewModel)
            vm.LoadedBatch = _view.SelectedItem
            vm.SetLoadedBatch()
        End Sub
        Private Sub CancelClick()
            _mediator.SwapPage(AdminKeys.AdminEditMenuDetails)
        End Sub

        Private Sub ResetFields()

        End Sub
    End Class

End Namespace