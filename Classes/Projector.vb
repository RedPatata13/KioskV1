Namespace KioskV0.Classes
    Public Class Projector
        Public Property _projector As ProjectorView
        Public ReadOnly Property ProjectPanel
            Get
                Return _projector.ProjectPanel
            End Get
        End Property

        Public Sub New()
            _projector = New ProjectorView()
            _projector.WindowState = FormWindowState.Maximized
            _projector.Size = Screen.PrimaryScreen.WorkingArea.Size
            _projector.Text = "Kiosk"
        End Sub

        Public Sub Project(projectable As IProjectable)
            Clear()
            projectable.Project(_projector.ProjectPanel)
        End Sub

        Public Sub LoginProject()
            Clear()
            Dim lvm = New LoginViewModel(Me)
            _projector.ShowDialog()
        End Sub
        Public Sub SpawnSideBar()
            _projector.AddSideBar()
        End Sub
        Private Sub Clear()
            _projector.ProjectPanel.Controls.Clear()
        End Sub
    End Class

End Namespace