Namespace KioskV0.Classes
    Public MustInherit Class ViewModel(Of TView As {Form, New}, TKey) 'Abstract equivalent of vb
        Implements IProjectable
        Protected Friend _view As TView
        Protected Friend _model
        Protected Friend _mediator As Mediator(Of TKey)
        Protected Friend Previous As TKey
        Public Sub New(view As TView, mediator As Mediator(Of TKey))
            _view = view
            _mediator = mediator
        End Sub

        Public Overridable Sub Project(projector As Form) Implements IProjectable.Project
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


        ''' <summary>
        ''' For popup behavios where current control must be the only interactable control
        ''' </summary>
        ''' <param name="parent">Parent Control. Used for recursion</param>
        ''' <param name="current">Control Exempted</param>
        Private Sub DisableControls(parent As Control, current As Boolean)
            For Each ctrl As Control In parent.Controls
                ctrl.Enabled = Not current

                If ctrl.HasChildren Then
                    DisableControls(ctrl, current)
                End If
            Next
        End Sub
        ''' <summary>
        ''' For Logout Behavior
        ''' </summary>
        Public Sub RevertState() Implements IProjectable.RevertState
            Throw New NotImplementedException()
        End Sub

        ''' <summary>
        ''' Override function for ViewModels to set their View Events
        ''' </summary>
        Protected Friend Overridable Sub SetEvents()
            'Do nothing for now
        End Sub
    End Class

End Namespace