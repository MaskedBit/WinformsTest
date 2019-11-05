Public Class SettingsForm
    Private Property TabControls As New List(Of TabSelectControl)

    Public Sub New(ByRef menu As MenuOptions, ByRef config As SystemSettings)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblUserName.Text = gActiveUserName

        For Each curTab In menu.TabOptions
            Dim tabSelect = New TabSelectControl(curTab)
            AddHandler tabSelect.TabSelected, AddressOf tabSelect_TabSelected
            flpMenuBar.Controls.Add(tabSelect)
            Me.TabControls.Add(tabSelect)
        Next

        Me.TabControls.First.SetActive()
    End Sub

    Private Sub tabSelect_TabSelected()
        For Each curTab In Me.TabControls
            curTab.SetInactive()
        Next
    End Sub

End Class
