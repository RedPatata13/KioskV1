Imports KioskV0.KioskV0.Forms
Namespace KioskV0.Classes
    Public Class SupplierEditSupplierItemViewModel
        Inherits ViewModel(Of SupplierEditSupplierItems, SupplierKeys)
        Private _item As SupplierItem
        Private _isNewItem As Boolean = False
        Private _supplierId As String = ""

        Public Sub New(view As SupplierEditSupplierItems, mediator As Mediator(Of SupplierKeys))
            MyBase.New(view, mediator)
        End Sub

        Public Sub LoadAsEdit(item As SupplierItem)
            _isNewItem = False
            _item = item

            _mediator.LayoutAction(Sub()
                                       _mediator.AddAction(Sub() LoadWithDetails(item))
                                       _mediator.AddAction(Sub() _mediator.SwapPage(SupplierKeys.SupplierEditSupplierItem))
                                       _mediator.InvokeAllAction()
                                   End Sub)

            _view.PageHeaderLabel.Text = "Edit Supplier Item"
            _view.SaveClicked = Sub() UpdateSupplierItem()
            _view.CancelClicked = Sub() _mediator.SwapPage(SupplierKeys.SupplierItems)
        End Sub

        Public Sub LoadAsNew(supplierId As String)
            _isNewItem = True
            _supplierId = supplierId

            _mediator.LayoutAction(Sub()
                                       _mediator.AddAction(Sub() ClearFields())
                                       _mediator.AddAction(Sub() _mediator.SwapPage(SupplierKeys.SupplierEditSupplierItem))
                                       _mediator.InvokeAllAction()
                                   End Sub)

            _view.PageHeaderLabel.Text = "Add New Supplier Item"
            _view.SaveClicked = Sub() CreateSupplierItem()
            _view.CancelClicked = Sub() _mediator.SwapPage(SupplierKeys.SupplierItems)
        End Sub

        Private Sub ClearFields()
            _view.IDField.Text = "SI_" & Guid.NewGuid().ToString().Substring(0, 10)
            _view.IDField.ReadOnly = True
            _view.ItemNameField.Text = ""
            _view.DescField.Text = ""
            _view.SupplieIdField.Text = _supplierId
            _view.SupplieIdField.ReadOnly = True
        End Sub

        Public Sub LoadWithDetails(item As SupplierItem)
            _view.IDField.Text = item.Id
            _view.IDField.ReadOnly = True
            _view.ItemNameField.Text = item.Name
            _view.DescField.Text = item.Description
            _view.SupplieIdField.Text = item.SupplierId
            _view.SupplieIdField.ReadOnly = True
        End Sub

        Private Sub CreateSupplierItem()
            Try
                If String.IsNullOrWhiteSpace(_view.ItemNameField.Text) Then
                    MessageBox.Show("Item name cannot be empty.")
                    Return
                End If

                Dim newItem As New SupplierItem With {
                    .Id = _view.IDField.Text,
                    .Name = _view.ItemNameField.Text,
                    .Description = _view.DescField.Text,
                    .SupplierId = _view.SupplieIdField.Text
                }

                _mediator.GetUnitOfWork.SupplierItems.Add(newItem)
                _mediator.GetUnitOfWork.SaveChanges()

                MessageBox.Show("Item created successfully!")
                _mediator.SwapPage(SupplierKeys.SupplierItems)
                Dim vm = DirectCast(_mediator.GetVM(SupplierKeys.SupplierItems), SupplierItemsViewModel)
                vm.Refresh()
            Catch ex As Exception
                MessageBox.Show("Error creating item: " & ex.Message)
            End Try
        End Sub

        Private Sub UpdateSupplierItem()
            Try
                Dim context = DirectCast(_mediator.GetUnitOfWork(), UnitOfWork)._context
                If context Is Nothing Then
                    Throw New Exception("Database context is null.")
                End If

                If String.IsNullOrWhiteSpace(_view.ItemNameField.Text) Then
                    MessageBox.Show("Item name cannot be empty.")
                    Return
                End If

                Dim localCopy = context.SupplierItems.Local.FirstOrDefault(Function(s) s.Id = _item.Id)
                If localCopy Is Nothing Then
                    localCopy = context.SupplierItems.Find(_item.Id)
                    If localCopy Is Nothing Then
                        Throw New Exception("Supplier item not found.")
                    End If
                End If

                localCopy.Name = _view.ItemNameField.Text
                localCopy.Description = _view.DescField.Text

                _mediator.GetUnitOfWork.SupplierItems.Update(localCopy)
                _mediator.GetUnitOfWork.SaveChanges()

                MessageBox.Show("Item updated successfully!")
                _mediator.SwapPage(SupplierKeys.SupplierItems)
                Dim vm = DirectCast(_mediator.GetVM(SupplierKeys.SupplierItems), SupplierItemsViewModel)
                vm.Refresh()
            Catch ex As Exception
                MessageBox.Show("Error updating item: " & ex.Message)
            End Try
        End Sub
    End Class
End Namespace