Imports System.ComponentModel.DataAnnotations
Imports System.Reflection
Imports KioskV0.KioskV0.Classes
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class AdminEditMenuDetailsViewModel
        Inherits ViewModel(Of Forms.AdminEditMenuDetailsView, AdminKeys)

        Public Sub New(view As Forms.AdminEditMenuDetailsView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)

            SetEvents()
        End Sub

        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()

            _view.CancelButtonClick = AddressOf CancelButtonClick
            _view.SelectImageClick = AddressOf SelectImageClick
            _view.SaveButtonClick = AddressOf SaveButtonClick
        End Sub

        Private Sub CancelButtonClick()
            _mediator.SwapPage(AdminKeys.AdminAccountSettings)
            _view.ResetFields()
            'Dim temp = _view
            '_view = New Forms.AdminAddMenuView()
            'SetEvents()
            'temp.Dispose()
        End Sub

        Private Sub SelectImageClick()
            MessageBox.Show("Works")
        End Sub

        Private Sub SaveButtonClick()
            Try
                Dim model = New MenuModel()
                model.MenuName = _view.MenuName
                model.Category = _view.CategoryName
                model.Supplier = _view.SupplierName

                Dim cost As Decimal
                Dim selling As Decimal

                If Not Decimal.TryParse(_view.Cost, cost) Then
                    Throw New FormatException("Invalid format for Cost.")
                End If
                If Not Decimal.TryParse(_view.Sell, selling) Then
                    Throw New FormatException("Invalid format for Selling price.")
                End If

                model.Cost = cost
                model.Selling = selling

                model.Validate()

                Dim properties = model.GetType().GetProperties()
                Dim str As String = ""
                For Each prop As PropertyInfo In properties
                    Dim value = prop.GetValue(model)
                    str &= Convert.ToString(value) & vbCrLf
                Next

                MessageBox.Show(str)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Sub

    End Class
End Namespace