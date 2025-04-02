﻿Namespace KioskV0.Classes
    Public MustInherit Class ViewModel(Of TView As {Form, New}, TKey) 'Abstract equivalent of vb
        Implements IProjectable
        Protected Friend _view As TView
        Protected Friend _model
        Protected Friend _mediator As Mediator(Of TKey)
        Protected Friend Actions As New Dictionary(Of String, Action(Of ViewModel(Of TView, TKey)))
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
        Protected Overridable Sub InitializeActions()

        End Sub

        ''' <summary>
        ''' Executes an action from the dictionary
        ''' </summary>
        ''' <param name="actionName">The key of the action</param>
        Public Sub ExecuteAction(actionName As String)
            If Actions.ContainsKey(actionName) Then
                Actions(actionName).Invoke(Me)
            Else
                MessageBox.Show($"Action '{actionName}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub

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