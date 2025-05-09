﻿Namespace KioskV0.Classes
    Public Class Projector
        Public Property _projector As ProjectorView
        Private ReadOnly _unitOfWork As IUnitOfWork
        Public ReadOnly Property ProjectPanel As Form
            Get
                Return _projector.ProjectPanel
            End Get
        End Property
        Public ReadOnly Property SidebarPanel As Form
            Get
                Return _projector.SidebarPanel
            End Get
        End Property

        Public Sub New(unitOfWork As IUnitOfWork)
            _unitOfWork = unitOfWork
            _projector = New ProjectorView()
            _projector.WindowState = FormWindowState.Maximized
            _projector.Size = Screen.PrimaryScreen.WorkingArea.Size
            _projector.Text = "Kiosk"
            _projector.SetupPanels()
        End Sub

        Public Sub Project(projectable As IProjectable)
            _projector.ProjectPanel.SuspendLayout()
            projectable.Project(_projector.ProjectPanel)
            If _projector.ProjectPanel.Controls.Count > 1 Then
                _projector.ProjectPanel.Controls.RemoveAt(0)
            End If
            _projector.ProjectPanel.ResumeLayout()
        End Sub
        Public Sub ProjectSidebar(sidebar As IProjectable)
            _projector.SidebarPanel.Controls.Clear()
            sidebar.Project(_projector.SidebarPanel)
        End Sub

        Public Sub LoginProject()
            Clear()
            Dim lvm = New LoginViewModel(Me, _unitOfWork)
            _projector.ShowDialog()
        End Sub
        Public Sub LogoutProject()
            Clear()
            Dim lvl = New LoginViewModel(Me, _unitOfWork)
            '_projector.SidebarPanel.Controls.Clear()
        End Sub
        Public Sub SpawnSideBar()
            _projector.AddSideBar()
        End Sub

        Public Sub RemoveSideBar()
            _projector.RemoveSideBar()
        End Sub

        Public Sub LayoutAction(action As Action)
            _projector.ProjectPanel.SuspendLayout()
            action?.Invoke()
            _projector.ProjectPanel.ResumeLayout()
        End Sub
        Private Sub Clear()
            _projector.ProjectPanel.Controls.Clear()
        End Sub

        Public Function GetWindowSize() As System.Drawing.Size
            Return _projector.GetProjectPanelSize()
        End Function

        Public Function GetSidebarSize() As System.Drawing.Size
            Return _projector.GetSidebarPanelSize()
        End Function

        Friend Function GetScreenSize() As Size
            Return _projector.GetTotalScreenSize()
        End Function
    End Class

End Namespace