Imports System.Runtime.InteropServices
Imports KioskV0.KioskV0.Forms
Imports LiveCharts

Namespace KioskV0.Classes
    Public Class StaffPosViewModel
        Inherits ViewModel(Of Forms.StaffPosView, StaffKeys)
        Private Property _currOrd As OrderPrimal = Nothing
        Private Property _cart As New Dictionary(Of String, OrderDetail)
        'Private Property _orderCache As New Dictionary(Of String, AdminItem)
        Private Property _changeCart As New Dictionary(Of String, OrderDetail)
        Private Property _cartItemIDs As New Dictionary(Of String, OrderDetail)
        Private Property _deletedItemsQueue As New Queue(Of OrderDetail)
        Private Property _changeCartDeletedItems As New Queue(Of OrderDetail)
        Private Property _pandingChanges As New Dictionary(Of String, OrderDetail)
        Private Property DontAskAgain As Boolean = False
        Private Property Loaded As Boolean = False

        Public Property Cart As Dictionary(Of String, OrderDetail)
            Get
                Return _cart
            End Get
            Set(value As Dictionary(Of String, OrderDetail))
                '_cart.Clear()
                _cartItemIDs.Clear()
                _cart = value

                For Each kv In value
                    'MessageBox.Show(kv.Value.CustomerItem.Id)
                    _cartItemIDs.Add(kv.Value.CustomerItem.Id, kv.Value)
                Next
            End Set
        End Property
        Public Property IncomingCartItems As Dictionary(Of String, OrderDetail)
            Get
                Return _changeCart
            End Get
            Set(value As Dictionary(Of String, OrderDetail))
                _changeCart = value
                _view.MenuItemsFlowLayoutPanel.Controls.Clear()
                Dim del_behaviour = Sub()
                                        While _changeCartDeletedItems.Count > 0
                                            _changeCart.Remove(_changeCartDeletedItems.Dequeue().OrderDetailsId)
                                        End While
                                    End Sub
                For Each kv In _changeCart
                    Dim uc = New StaffPosOrderUserControl()
                    'Dim uc1 = New CustomerMenuUserControl(kv.Value.CustomerItem)
                    uc.Model = kv.Value
                    uc.DeleteClick = Sub()
                                         del_behaviour.Invoke()
                                         _view.MenuItemsFlowLayoutPanel.Controls.Remove(uc)
                                         uc.Dispose()
                                     End Sub
                    _view.MenuItemsFlowLayoutPanel.Controls.Add(uc)
                Next
            End Set
        End Property
        Public Sub New(view As StaffPosView, mediator As Mediator(Of StaffKeys))
            MyBase.New(view, mediator)

            'TempOrder()
            SetEvents()
            ChangeCartCheck()
        End Sub
        Public Overrides Sub Project(projector As Form)
            If Not Loaded Then
                MyBase.Project(projector)
                'MyBase.Project(projector)
                ResizeComponents(_mediator.GetProjectorPanelSize())
            End If

            Loaded = True
            ChangeCartCheck()
            MyBase.Project(projector)
        End Sub
        Private Sub ChangeCartCheck()
            If IncomingCartItems.Count > 0 Then
                _view.AddItemsToOrder.Enabled = True
            Else
                _view.AddItemsToOrder.Enabled = False
            End If
        End Sub
        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()

            _view.PayButtonClick = AddressOf PayButtonClick
            _view.AddMoreClick = AddressOf AddMoreClick
            _view.OrderTextBoxTextchanged = Sub() LoadOrder(_view.SearchOrderTextbox.Text)
            _view.AddAllItemsToOrder = Sub() AddAllItemsToOrder()
        End Sub
        Private Sub AddAllItemsToOrder()
            Dim context = DirectCast(_mediator.GetUnitOfWork, UnitOfWork)._context
            If context Is Nothing Then Throw New Exception("Context not found")

            context.OrderPrimals.Attach(_currOrd)
            For Each kv In IncomingCartItems
                Dim val = kv.Value

                'check if item already exists in the Cart
                If _cartItemIDs.ContainsKey(val.CustomerItem.Id) Then
                    '_cart(val.OrderDetailsId).Quantity += val.Quantity
                    Dim target As OrderDetail = _cartItemIDs(val.CustomerItem.Id)
                    target.Quantity += val.Quantity
                    'check if Order Detail locally exists
                    Dim local_od_cpy = context.OrderDetails.Local.FirstOrDefault(Function(od) od.OrderDetailsId = target.OrderDetailsId)
                    If local_od_cpy Is Nothing Then

                        'check if Order Detail exists in the DB
                        local_od_cpy = context.OrderDetails.Find(target.OrderDetailsId)
                        If local_od_cpy Is Nothing Then

                            'order Details does not exist
                            Throw New Exception($"Order Detail with id: {target.OrderDetailsId} does not exist in the Database")
                        End If
                    End If

                    local_od_cpy.Quantity = target.Quantity
                    context.Categories.Attach(val.CustomerItem.Category)
                    'context.AdminItems.Attach(val.CustomerItem)
                    _mediator.GetUnitOfWork.OrderDetails.Update(local_od_cpy)
                    MessageBox.Show("Item succesffuly updated")
                    Continue For
                End If

                'item does not exist in the cart
                _cart.Add(val.OrderDetailsId, val)
                _cartItemIDs.Add(val.CustomerItem.Id, val)
                context.Categories.Attach(val.CustomerItem.Category)
                context.AdminItems.Attach(val.CustomerItem)
                Dim uc = New StaffPosOrderUserControl()
                uc.Model = val
                uc.DeleteClick = Sub() DeleteClick(uc)
                _view.CurrentItemsFlowPanel.Controls.Add(uc)
                val.OrderId = _currOrd.OrderId


                _mediator.GetUnitOfWork.OrderDetails.Add(val)
            Next

            _mediator.GetUnitOfWork.SaveChanges()
            IncomingCartItems.Clear()
            _view.CurrentItemsFlowPanel.Controls.Clear()
            _view.MenuItemsFlowLayoutPanel.Controls.Clear()
            For Each kv In Cart
                Dim uc = New StaffPosOrderUserControl()
                uc.Model = kv.Value
                _view.CurrentItemsFlowPanel.Controls.Add(uc)
                uc.DeleteClick = Sub() DeleteClick(uc)
            Next
            ChangeCartCheck()
        End Sub
        Private Sub LoadOrder(id As String)
            ResetFields()
            _currOrd = _mediator.GetUnitOfWork.Orders.GetById(id)
            If _currOrd Is Nothing Then
                MessageBox.Show("Order not found")
                Return
            End If
            Dim crt = New Dictionary(Of String, OrderDetail)
            For Each item In _currOrd.OrderItems
                crt.Add(item.OrderDetailsId, item)
                Dim uc = New StaffPosOrderUserControl()
                uc.Model = item
                uc.DeleteClick = Sub() DeleteClick(uc)
                _view.CurrentItemsFlowPanel.Controls.Add(uc)
            Next
            Cart = crt
            ChangeCartCheck()
        End Sub
        Private Sub AddMoreClick()
            If _currOrd Is Nothing Then
                MessageBox.Show("There's no order selected")
                Return
            End If
            Dim vm = DirectCast(_mediator.GetVM(StaffKeys.StaffOrderList), StaffOrderListViewModel)
            vm.UpdatedCart = IncomingCartItems
            _mediator.SwapPage(StaffKeys.StaffOrderList)
        End Sub
        Private Sub DeleteClick(uc As StaffPosOrderUserControl)
            Dim confirmPanel As StaffPosConfirmationUserControl = New StaffPosConfirmationUserControl()
            Dim backdrop = New Panel()
            Dim confirm As Action = Sub()
                                        EnableControls()
                                        _cart.Remove(uc.Model.OrderDetailsId)
                                        _view.CurrentItemsFlowPanel.Controls.Remove(uc)
                                        _view.Controls.Remove(confirmPanel)
                                        _view.Controls.Remove(backdrop)
                                        _currOrd.OrderItems.Remove(uc.Model)
                                        _deletedItemsQueue.Enqueue(uc.Model)
                                        uc.Dispose()
                                        DontAskAgain = confirmPanel.Checkbox.Checked
                                    End Sub
            Dim cancel As Action = Sub()
                                       EnableControls()
                                       _view.Controls.Remove(confirmPanel)
                                       _view.Controls.Remove(backdrop)
                                       confirmPanel.Dispose()
                                   End Sub
            If Not DontAskAgain Then
                DisableControls()
                _view.Controls.Add(confirmPanel)
                confirmPanel.BringToFront()
                confirmPanel.CancelButtonClick = cancel
                confirmPanel.ConfirmButtonClick = confirm

                Dim size = _mediator.GetProjectorPanelSize()
                Dim x = size.Width / 2 - confirmPanel.Width / 2
                Dim y = size.Height / 2 - confirmPanel.Height / 2


                backdrop.Size = size
                backdrop.BackColor = Color.FromArgb(128, 0, 0, 0)
                backdrop.Parent = _view

                _view.Controls.Add(backdrop)
                backdrop.Location = New Point(0, 0)
                confirmPanel.Location = New Point(x, y)

                backdrop.BringToFront()
                confirmPanel.BringToFront()
            Else
                confirm.Invoke()
                DontAskAgain = True
            End If
        End Sub

        Private Sub PayButtonClick()
            If _currOrd Is Nothing Then
                MessageBox.Show("There's no order selected")
                Return
            End If
            Dim context = DirectCast(_mediator.GetUnitOfWork, UnitOfWork)._context
            Dim total As Decimal = 0.0
            For Each item In _currOrd.OrderItems
                context.OrderDetails.Attach(item)
                _mediator.GetUnitOfWork.OrderDetails.Update(item)
                total += item.CustomerItem.SellingCost * item.Quantity
            Next
            If total > 0 Then
                context.OrderPrimals.Attach(_currOrd)
                Dim user = _mediator.CurrentUser

                context.Users.Attach(user)
                Dim model = New TransactedOrder With {
                    .TransactedOrderId = "TRORD_" & Guid.NewGuid().ToString().Substring(0, 5),
                    .OrderId = _currOrd.OrderId,
                    .Order = _currOrd,
                    .CashPaid = 10000,
                    .SubTotal = total,
                    .Change = 10000 - total,
                    .DateTransacted = DateTime.Now,
                    .IsFinalized = True,
                    .UserId = user.UserId,
                    .User = user
                }
                While _deletedItemsQueue.Count > 0
                    _mediator.GetUnitOfWork.OrderDetails.Delete(_deletedItemsQueue.Dequeue().OrderDetailsId)
                End While
                _mediator.GetUnitOfWork.TransactedOrder.Add(model)
                _mediator.GetUnitOfWork.SaveChanges()
                MessageBox.Show("Transaction Successful!")
                ResetFields()
            Else
                MessageBox.Show("There are no Items")
            End If
        End Sub

        Private Sub ResetFields()
            _view.CurrentItemsFlowPanel.Controls.Clear()
            _view.MenuItemsFlowLayoutPanel.Controls.Clear()
            _currOrd = Nothing
            Cart = New Dictionary(Of String, OrderDetail)
            IncomingCartItems = New Dictionary(Of String, OrderDetail)
            _cartItemIDs.Clear()
            _deletedItemsQueue.Clear()
            _changeCartDeletedItems.Clear()
        End Sub


    End Class

End Namespace