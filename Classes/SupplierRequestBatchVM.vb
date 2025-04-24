Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Classes

Public Class SupplierRequestBatchVM
    Inherits Classes.ViewModel(Of Forms.SupplierRequestDetailsView, AdminKeys)
    Private Property Loaded As Boolean = False
    Public Sub New(view As Forms.SupplierRequestDetailsView, mediator As Mediator(Of AdminKeys))
        MyBase.New(view, mediator)
    End Sub
    Protected Friend Overrides Sub SetEvents()
        MyBase.SetEvents()


    End Sub

    Public Overrides Sub Project(projector As Form)
        If Not Loaded Then
            MyBase.Project(projector)
            ResizeComponents(_mediator.GetProjectorPanelSize())
            Loaded = True
        End If
        MyBase.Project(projector)
    End Sub
    Public Sub LoadAsEdit(request As BatchRequest)
        Dim item = request.Item
        Dim admin = request.Requester

        _view.ItemIDField.Text = item.Name
        _view.ItemIDField.Text = item.Id
        _view.DescriptionField.Text = item.Description
        _view.UnitCostField.Text = item.UnitCost

        _view.AdminNameField.Text = admin.Username
        _view.AdminID_field.Text = admin.UserId
        _view.QTY_Field.Text = request.Units
        _view.DateReq.Text = request.DateRequested.Date.ToString()
    End Sub

    Private Sub ResetField()
        _view.ItemIDField.Text = ""
        _view.ItemNameField.Text = ""
        _view.DescriptionField.Text = ""
        _view.UnitCostField.Text = ""

        _view.AdminNameField.Text = ""
        _view.AdminID_field.Text = ""
        _view.QTY_Field.Text = ""
        _view.DateReq.Text = ""
    End Sub

End Class
