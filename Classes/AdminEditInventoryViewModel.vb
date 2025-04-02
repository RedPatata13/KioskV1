Imports System.ComponentModel.DataAnnotations
Imports System.Reflection
Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminEditInventoryViewModel
        Inherits ViewModel(Of AdminEditInventoryView, AdminKeys)

        Public Sub New(view As AdminEditInventoryView, mediator As Mediator(Of AdminKeys))
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
            Dim ItemStatusFactory = Function(status As String) As KioskV0.ItemStatus
                                        Select Case status
                                            Case "Active"
                                                Return ItemStatus.Active
                                            Case "Inactive"
                                                Return ItemStatus.Inactive
                                            Case "Out Of Stock"
                                                Return ItemStatus.OutOfStock
                                            Case Else
                                                Throw New Exception("Invalid Item Status")
                                        End Select
                                    End Function
            Try
                Dim model = New Model.ItemModel With {
                    .ProductId = _view.ProductID,
                    .ProductName = _view.ProductFormalName,
                    .Quantity = Convert.ToInt32(_view.Quantity),
                    .Status = ItemStatusFactory(_view.Status),
                    .Supplier = _view.Supplier
                }

                model.Validate()

                Dim properties = model.GetType().GetProperties()
                Dim str As String = ""
                For Each prop As PropertyInfo In properties
                    Dim value = prop.GetValue(model)
                    str &= Convert.ToString(value) & vbCrLf
                Next

                MessageBox.Show(str)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
    End Class

End Namespace