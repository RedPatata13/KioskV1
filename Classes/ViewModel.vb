Imports System.Management
'Imports System.Web.UI.WebControls
Imports System.Windows.Forms

Namespace KioskV0.Classes
    Public MustInherit Class ViewModel(Of TView As {Form, New}, TKey) 'Abstract equivalent of vb
        Implements IProjectable
        Protected Friend _view As TView
        Protected Friend _model
        Protected Friend _mediator As Mediator(Of TKey)
        Private ReadOnly _aspectRatios As New Dictionary(Of Control, (SizeF, PointF, Single?))
        Protected Friend Previous As TKey
        Public Sub New(view As TView, mediator As Mediator(Of TKey))
            _view = view
            _mediator = mediator
            RecordAspectRatios()
        End Sub

        Public Overridable Sub Project(projector As Form) Implements IProjectable.Project
            _view.TopLevel = False
            _view.FormBorderStyle = FormBorderStyle.None
            _view.Dock = DockStyle.Fill
            _view.Location = New Point(0, 0)
            _view.Visible = True
            projector.Controls.Add(_view)
        End Sub

        Public Sub ViewDock()
            _view.Dock = DockStyle.Fill
        End Sub
        Protected Overridable Sub InitializeActions()

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
        End Sub
        Private Sub RecordAspectRatios()
            Dim parentSize = _view.Size
            For Each ctrl As Control In _view.Controls
                Dim sizeRatio As New SizeF(ctrl.Width / parentSize.Width, ctrl.Height / parentSize.Height)
                Dim locationRatio As New PointF(ctrl.Location.X / parentSize.Width, ctrl.Location.Y / parentSize.Height)
                Dim fontSize As Single? = If(TypeOf ctrl Is Label, CType(ctrl, Label).Font.Size, Nothing)
                _aspectRatios(ctrl) = (sizeRatio, locationRatio, fontSize)
            Next
        End Sub
        Protected Friend Sub RecordChildAspectRatio(ctrl As Control)
            Dim parentSize = _view.Size
            Dim sizeRatio As New SizeF(ctrl.Width / parentSize.Width, ctrl.Height / parentSize.Height)
            Dim locationRatio As New PointF(ctrl.Location.X / parentSize.Width, ctrl.Location.Y / parentSize.Height)
            Dim fontSize As Single? = If(TypeOf ctrl Is Label, CType(ctrl, Label).Font.Size, Nothing)
            _aspectRatios(ctrl) = (sizeRatio, locationRatio, fontSize)
        End Sub
        Public Sub ResizeComponents(newSize As Size)
            For Each kvp In _aspectRatios
                Dim ctrl = kvp.Key
                Dim sizeRatio = kvp.Value.Item1
                Dim locationRatio = kvp.Value.Item2
                Dim FontSize = kvp.Value.Item3
                ctrl.Size = New Size(CInt(newSize.Width * sizeRatio.Width), CInt(newSize.Height * sizeRatio.Height))

                ' Adjust position
                ctrl.Location = New Point(CInt(newSize.Width * locationRatio.X), CInt(newSize.Height * locationRatio.Y))
                If FontSize.HasValue AndAlso TypeOf ctrl Is Windows.Forms.Label Then
                    Dim lbl = CType(ctrl, Label)
                    lbl.Font = New Font(lbl.Font.FontFamily, FontSize.Value * (newSize.Width / _view.Width))
                End If
            Next
        End Sub

        Protected Sub PrintViewSize()
            MessageBox.Show($"{_view.Width} x {_view.Height}")
        End Sub
    End Class

End Namespace