Public Class ucStatusBar

    Private Sub SetUiStyle()

        Me.lblMessage.BackColor = UiStyles.DarkBackgroundColor
        Me.lblSystemState.BackColor = UiStyles.DarkBackgroundColor
        Me.lblRecipeName.BackColor = UiStyles.DarkBackgroundColor

    End Sub

    Private Sub ucStatusBar_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        AddHandler clsUiStyle.UiStyleChanged, AddressOf SetUiStyle
        SetUiStyle()

    End Sub

    Protected Overrides Sub Finalize()

        RemoveHandler clsUiStyle.UiStyleChanged, AddressOf SetUiStyle
        MyBase.Finalize()

    End Sub

End Class
