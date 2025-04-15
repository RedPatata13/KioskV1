Imports System.IO
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
        Private Property _model As AdminItem

        Public Sub New(model As AdminItem)
            InitializeComponent()
            _model = model
            SetLabels()
        End Sub
        Private Sub CustomerMenuUserControl_Click(sender As Object, e As EventArgs) Handles Me.Click
            SelfClick?.Invoke()
        End Sub

        Private Sub SetLabels()
            ProductName.Text = _model.Name
            PriceLabel.Text = $"P{_model.SellingCost}"

            Dim defaultImagePath As String = "picture.png"

            Dim imagePath As String = If(String.IsNullOrWhiteSpace(_model.ImageFilePath), defaultImagePath, _model.ImageFilePath)

            If File.Exists(imagePath) Then
                ProductPictureBox.Image = Image.FromFile(imagePath)
            Else
                ProductPictureBox.Image = Nothing
            End If
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