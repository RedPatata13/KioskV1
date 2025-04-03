Public Class ProjectorView
    Private Split = 1
    Public Property ProjectPanel = New Form()
    Public Property SidebarPanel = New Form()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SetupPanels()

    End Sub
    Public Sub AddSideBar()
        Controls.Add(SidebarPanel)
    End Sub

    Public Sub RemoveSideBar()
        Controls.Remove(SidebarPanel)
    End Sub

    ''' <summary>
    ''' Function to initialize the internal panels of the ProjectorView
    ''' </summary>
    Private Sub SetupPanels()
        Dim proj_width = Me.Width * (10 - Split) / 10
        Dim sidebar_width = Me.Width * Split / 10

        SidebarPanel.Size = New Size(sidebar_width, Me.Height)
        SidebarPanel.Toplevel = False
        SidebarPanel.Dock = DockStyle.Left
        SidebarPanel.Location = New Point(0, 0)
        SidebarPanel.Visible = True
        SidebarPanel.FormBorderStyle = FormBorderStyle.None
        SidebarPanel.BackColor = Color.Red

        ProjectPanel.TopLevel = False
        ProjectPanel.Dock = DockStyle.Fill
        'ProjectPanel.MaximumSize = New Size(Me.Width, Me.Height)
        'ProjectPanel.Size = New Size(Me.Width - SidebarPanel.Width, Me.Height)
        ProjectPanel.Visible = True
        ProjectPanel.BackColor = Color.Wheat
        ProjectPanel.FormBorderStyle = FormBorderStyle.None

        Me.Controls.Add(ProjectPanel)
        'Me.Controls.Add(SidebarPanel)
    End Sub

    Private Sub ProjectorView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class