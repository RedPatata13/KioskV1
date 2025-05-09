﻿Imports System.IO
Imports System.Web.ModelBinding
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Forms
    Public Class AdminMenuUserControl
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
        Public Property Model As AdminItem
            Get
                Return _model
            End Get
            Set(value As AdminItem)
                _model = value
                SetLabels()
            End Set
        End Property


        Public Sub New(model As AdminItem)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.Model = model
            'SetLabels()
        End Sub

        Private Sub SetLabels()
            ProductName.Text = _model.Name
            CategoryLabel.Text = _model.Category?.CategoryName
            PriceLabel.Text = $"P{_model.SellingCost}"

            If Not String.IsNullOrEmpty(_model.ImageFilePath) AndAlso IO.File.Exists(_model.ImageFilePath) Then
                ProductPictureBox.Image = Image.FromFile(_model.ImageFilePath)
            Else
                ProductPictureBox.Image = Nothing
            End If
        End Sub


        Private Sub AdminMenuUserControl_Click(sender As Object, e As EventArgs) Handles Me.Click
            SelfClick?.Invoke()
        End Sub

        Private Sub ApplyClickEvent(ctrl As Control)
            AddHandler ctrl.Click, Sub(sender, e)
                                       SelfClick?.Invoke()
                                   End Sub

            For Each child As Control In ctrl.Controls
                ApplyClickEvent(child)
            Next
        End Sub

        Private Sub AdminMenuUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class

End Namespace