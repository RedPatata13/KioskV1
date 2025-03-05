Namespace KioskV0.Classes
    Public MustInherit Class ViewModel(Of TView As {Form, New}, TKey)
        Implements IProjectable
        Protected Friend _view As TView
        Protected Friend _model
        Protected Friend _mediator As Mediator(Of TKey)

        Public Sub New(view As TView, mediator As Mediator(Of TKey))
            _view = view
            _mediator = mediator
        End Sub

        Public Sub Project(projector As Form) Implements IProjectable.Project
            _view.TopLevel = False
            _view.FormBorderStyle = FormBorderStyle.None
            _view.Dock = DockStyle.Fill
            _view.Location = New Point(0, 0)
            _view.Visible = True
            projector.Controls.Add(_view)
        End Sub

        Public Sub RevertState() Implements IProjectable.RevertState
            Throw New NotImplementedException()
        End Sub
    End Class

End Namespace