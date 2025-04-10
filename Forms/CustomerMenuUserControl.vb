Imports System.Runtime.InteropServices
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Forms
    Public Class CustomerMenuUserControl
        Private Property _selfClick As Action
        Public Property SelfClick As Action
            Get
                Return _selfClick
            End Get
            Set(value As Action)
                _selfClick = value
                ApplyClickEvent(Me)
            End Set
        End Property
        Private Property _model As CustomerItem

        Public Sub New(model As CustomerItem)
            InitializeComponent()
            _model = model
            SetLabels()
        End Sub
        Private Sub CustomerMenuUserControl_Click(sender As Object, e As EventArgs) Handles Me.Click
            SelfClick?.Invoke()
        End Sub

        Private Sub SetLabels()
            ProductName.Text = _model.Name
            PriceLabel.Text = $"P{_model.AdminItem.SellingCost}"
        End Sub
        Private Sub ApplyClickEvent(ctrl As Control)
            AddHandler ctrl.Click, Sub(sender, e)
                                       SelfClick?.Invoke()
                                   End Sub

            For Each child As Control In ctrl.Controls
                ApplyClickEvent(child)
            Next
        End Sub
    End Class

End Namespace