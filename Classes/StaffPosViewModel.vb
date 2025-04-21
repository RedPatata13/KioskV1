Imports System.Net.Security
Imports System.Runtime.InteropServices
Imports System.Runtime.InteropServices.ComTypes
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
        Private Property DeletedItems As HashSet(Of OrderDetail)
        Private Property _changeCartDeletedItems As New Queue(Of OrderDetail)
        'Private Property Pen
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
                Dim del_behaviour = Sub(uc As StaffPosOrderUserControl)
                                        _changeCart.Remove(uc.Model.OrderDetailsId)
                                    End Sub
                For Each kv In _changeCart
                    Dim uc = New StaffPosOrderUserControl()
                    'Dim uc1 = New CustomerMenuUserControl(kv.Value.CustomerItem)
                    uc.Model = kv.Value
                    uc.DeleteClick = Sub()
                                         _changeCartDeletedItems.Enqueue(uc.Model)
                                         _view.MenuItemsFlowLayoutPanel.Controls.Remove(uc)
                                         del_behaviour.Invoke(uc)
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

            _view.PayButtonClick = AddressOf Pay
            _view.AddMoreClick = AddressOf AddMoreClick
            _view.OrderTextBoxTextchanged = Sub() LoadOrder(_view.SearchOrderTextbox.Text)
            _view.AddAllItemsToOrder = Sub() AddAllItemsToOrder()
            _view.DiscardButtonClick = AddressOf DiscardButtonClick
        End Sub
        Private Sub AddAllItemsToOrder()
            Dim context = DirectCast(_mediator.GetUnitOfWork, UnitOfWork)._context
            If context Is Nothing Then Throw New Exception("Context not found")

            context.OrderPrimals.Attach(_currOrd)
            For Each kv In IncomingCartItems
                Dim val = kv.Value

                'check if item already exists in the Cart
                If _cartItemIDs.ContainsKey(val.CustomerItem.Id) Then
                    Dim target As OrderDetail = _cartItemIDs(val.CustomerItem.Id)
                    target.Quantity += val.Quantity
                    Continue For
                End If

                _cart.Add(val.OrderDetailsId, val)
                _cartItemIDs.Add(val.CustomerItem.Id, val)

                Dim uc = New StaffPosOrderUserControl()
                uc.Model = val
                uc.DeleteClick = Sub() DeleteClick(uc)
                _view.CurrentItemsFlowPanel.Controls.Add(uc)
                val.OrderId = _currOrd.OrderId

            Next
            MessageBox.Show("Order Updated")
            '_mediator.GetUnitOfWork.SaveChanges()
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
                                        '_currOrd.OrderItems.Remove(uc.Model)
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
        Private Sub Pay()
            If _currOrd Is Nothing Then
                MessageBox.Show("There's no order selected")
                Return
            End If
            Dim vm = DirectCast(_mediator.GetVM(StaffKeys.StaffPayment), StaffPaymentViewModel)
            Dim total = Cart.Values.
                Where(Function(od) od?.CustomerItem IsNot Nothing).
                Sum(Function(od) od.CustomerItem.SellingCost * od.Quantity)
            Dim model = PayButtonClick(total)
            Dim pending = Sub()
                              ResolveChanges()
                              _mediator.GetUnitOfWork.TransactedOrder.Add(model)
                              _mediator.GetUnitOfWork.SaveChanges()
                              ResetFields()
                          End Sub
            vm.LoadWithDetails(total, pending, model)
        End Sub

        Private Function PayButtonClick(total As Decimal) As TransactedOrder
            'ResolveChanges()
            Dim context = DirectCast(_mediator.GetUnitOfWork, UnitOfWork)._context
            Dim order = context.OrderPrimals.Local.FirstOrDefault(Function(o) o.OrderId = _currOrd.OrderId)
            If order Is Nothing Then
                order = context.OrderPrimals.Find(_currOrd.OrderId)
                If order Is Nothing Then
                    Throw New Exception($"Order with Order ID: {_currOrd.OrderId} not found.")
                End If
            End If


            context.OrderPrimals.Attach(order)
            Dim user = _mediator.GetCurrentUser

            context.Users.Attach(user)
            Dim model = New TransactedOrder With {
                    .TransactedOrderId = "TRORD_" & Guid.NewGuid().ToString().Substring(0, 5),
                    .OrderId = order.OrderId,
                    .Order = order,
                    .SubTotal = total,
                    .DateTransacted = DateTime.Now,
                    .IsFinalized = True,
                    .UserId = user.UserId,
                    .User = user
                }



            'MessageBox.Show("Transaction Successful!")

            'ResetFields()
            Return model
        End Function

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

        Private Sub ResolveChanges()
            ''Assumes that base and Cart uses the same Values
            Dim context = DirectCast(_mediator.GetUnitOfWork, UnitOfWork)._context
            Dim base As New Dictionary(Of String, OrderDetail)
            For Each item In _currOrd.OrderItems
                base.Add(item.OrderDetailsId, item)
            Next

            'Resolve quantity changes
            For Each item In Cart
                If base.ContainsKey(item.Value.OrderDetailsId) Then
                    base(item.Key).Quantity = item.Value.Quantity ' item is present in the original order which means it's quantity is to be updated
                    context.OrderDetails.Attach(item.Value)
                Else
                    base.Add(item.Key, item.Value) ' item was only added during the session
                    context.Categories.Attach(item.Value.CustomerItem.Category)
                    context.AdminItems.Attach(item.Value.CustomerItem)
                    item.Value.OrderId = _currOrd.OrderId
                    _mediator.GetUnitOfWork.OrderDetails.Add(item.Value)

                End If
            Next

            Dim toBeDeleted As New Queue(Of OrderDetail)
            Dim subtotal = 0
            'Added new items
            For Each item In base
                If Not Cart.ContainsKey(item.Key) Then 'items that exist in the base and not in the cart implies that it got deleted
                    toBeDeleted.Enqueue(item.Value)
                Else
                    subtotal += item.Value.CustomerItem.SellingCost * item.Value.Quantity
                End If
            Next

            Dim local_op_cpy = context.OrderPrimals.Local.FirstOrDefault(Function(op) op.OrderId = _currOrd.OrderId)
            If local_op_cpy Is Nothing Then
                local_op_cpy = context.OrderPrimals.Find(_currOrd.OrderId)
                If local_op_cpy Is Nothing Then
                    Throw New Exception($"Order with Order ID: {_currOrd.OrderId} does not exist.")
                End If
            End If

            local_op_cpy.TotalPrice = subtotal
            _mediator.GetUnitOfWork.Orders.Update(local_op_cpy)

            'delete excluded items
            While toBeDeleted.Count > 0
                Dim item = toBeDeleted.Dequeue()

                Dim local_od_cpy = context.OrderDetails.Local.FirstOrDefault(Function(c) c.OrderDetailsId = item.OrderDetailsId)
                If local_od_cpy Is Nothing Then
                    local_od_cpy = context.OrderDetails.Find(item.OrderDetailsId)
                    If local_od_cpy Is Nothing Then
                        Throw New Exception($"Order Detail with ID: {item.OrderDetailsId} does not exist.")
                    End If
                End If

                _mediator.GetUnitOfWork.OrderDetails.Delete(local_od_cpy.OrderDetailsId)
            End While

            _mediator.GetUnitOfWork.SaveChanges()

            'ResetFields()
        End Sub
        Private Sub DiscardButtonClick()
            If _currOrd IsNot Nothing Then
                'ResetFields()
                ChangeCartCheck()
                Dim confirmPanel As StaffPosConfirmationUserControl = New StaffPosConfirmationUserControl()
                confirmPanel.LabelMessage = "Are you sure you wish to discard this order? This action cannot be reversed."
                Dim backdrop = New Panel()
                Dim confirm As Action = Sub()
                                            EnableControls()
                                            ResetFields()
                                            ChangeCartCheck()
                                            DontAskAgain = confirmPanel.Checkbox.Checked
                                            _view.Controls.Remove(backdrop)
                                            _view.Controls.Remove(confirmPanel)
                                        End Sub
                Dim cancel As Action = Sub()
                                           EnableControls()
                                           'confirmPanel.Dispose()
                                           _view.Controls.Remove(backdrop)
                                           _view.Controls.Remove(confirmPanel)
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
            Else
                MessageBox.Show("No order is selected")
            End If
        End Sub
    End Class

End Namespace