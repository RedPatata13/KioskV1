Namespace KioskV0.Classes
    Public MustInherit Class ViewModel(Of TView As {Form, New}, TKey) 'Abstract equivalent of vb
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

        'Public Sub DisplayPopup(popup As Popup)

        '    DisableControls(_view, True)
        '    Dim closing_act As Action =
        '        Sub()
        '            DisableControls(_view, False)
        '            popup.Dispose()
        '        End Sub

        '    popup.Close(closing_act)

        'End Sub

        Private Sub DisableControls(parent As Control, current As Boolean)
            For Each ctrl As Control In parent.Controls
                ctrl.Enabled = Not current

                If ctrl.HasChildren Then
                    DisableControls(ctrl, current)
                End If
            Next
        End Sub

        Public Sub RevertState() Implements IProjectable.RevertState
            Throw New NotImplementedException()
        End Sub
    End Class

End Namespace