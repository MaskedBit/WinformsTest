Public Class ManualModeForm
    Private Property TabControls As New List(Of TabSelectControl)
    Private Property UserControls As New Dictionary(Of String, UserControl)
    Private Property SelectedControl As UserControl

    Public Sub New(ByRef menu As MenuOptions, ByRef model As ManualModeModel)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblUserName.Text = gActiveUserName

        For Each curTab In menu.TabOptions
            Dim tabSelect = New TabSelectControl(curTab)
            AddHandler tabSelect.TabSelected, AddressOf tabSelect_TabSelected
            flpMenuBar.Controls.Add(tabSelect)
            Me.TabControls.Add(tabSelect)
            Dim newControl = BuildUserControl(curTab.UIElement)
            newControl.Location = New Point((Me.MainPanel.Width - newControl.Width) / 2, (Me.MainPanel.Height - newControl.Height) / 2)
            Me.UserControls.Add(curTab.UIElement, newControl)
            Me.MainPanel.Controls.Add(newControl)
        Next

        Me.TabControls.First.SetActive()
        Me.SelectedControl = Me.UserControls.Item(Me.TabControls.First.TabOptions.UIElement)
        Me.SelectedControl.Show()
    End Sub

    Private Function BuildUserControl(uIElement As String) As UserControl
        Dim control As New NotImplementedControl(uIElement)

        Return control
    End Function

    Private Sub tabSelect_TabSelected(ByRef UIElement As String)
        For Each curTab In Me.TabControls
            curTab.SetInactive()
        Next
        Me.SelectedControl.Hide()
        Me.SelectedControl = Me.UserControls.Item(UIElement)
        Me.SelectedControl.Show()
    End Sub

End Class
