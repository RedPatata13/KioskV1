Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class SupplierEditSupplierItemViewModel
        Inherits ViewModel(Of SupplierEditSupplierItems, SupplierKeys)
        Private _item As SupplierItem
        Public Sub New(view As SupplierEditSupplierItems, mediator As Mediator(Of SupplierKeys))
            MyBase.New(view, mediator)


        End Sub

        Public Sub LoadAsEdit(item As SupplierItem)
            _mediator.LayoutAction(Sub()
                                       _mediator.AddAction(Sub() LoadWithDetails(item))
                                       _mediator.AddAction(Sub() _mediator.SwapPage(SupplierKeys.SupplierEditSupplierItem))
                                       _mediator.InvokeAllAction()
                                   End Sub)
            _view.SaveClicked = Sub() UpdateSupplierItem(item)
            _view.CancelClicked = Sub() _mediator.SwapPage(SupplierKeys.SupplierItems)
        End Sub

        Public Sub LoadWithDetails(item As SupplierItem)
            _view._IDField.Text = item.Id
            _view._itemNameField.Text = item.Name
            _view.DescField.Text = item.Description
            _view.SupplieIdField.Text = item.SupplierId
        End Sub

        Private Sub UpdateSupplierItem(item As SupplierItem)
            Try
                Dim context = DirectCast(_mediator.GetUnitOfWork(), UnitOfWork)._context
                If context Is Nothing Then
                    Throw New Exception("Database context is null.")
                End If

                Dim localCopy = context.SupplierItems.Local.FirstOrDefault(Function(s) s.Id = item.Id)
                If localCopy Is Nothing Then
                    localCopy = context.SupplierItems.Find(item.Id)
                    If localCopy Is Nothing Then
                        Throw New Exception("Supplier item not found.")
                    End If
                End If

                localCopy.Name = _view._itemNameField.Text
                localCopy.Description = _view.DescField.Text
                localCopy.SupplierId = _view.SupplieIdField.Text

                _mediator.GetUnitOfWork.SupplierItems.Update(localCopy)
                _mediator.GetUnitOfWork.SaveChanges()
                _mediator.SwapPage(SupplierKeys.SupplierItems)
                Dim vm = DirectCast(_mediator.GetVM(SupplierKeys.SupplierItems), SupplierItemsViewModel)
                vm.Refresh()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub


    End Class

End Namespace