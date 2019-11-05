Imports System.Reflection

Public Class frmSetupMainMenu

    Private Sub frmSetupMainMenu_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        lblUserName.Text = gActiveUserName
        lblUserGroup.Text = gActiveUserGroup
        btLoginLogout.IsSelected = True
        With Me
            .MainSplitContainer.BackColor = UiStyles.MainMenuBackgroundColor
            .MainSplitContainer.Panel1.BackColor = UiStyles.MainMenuBackgroundColor
            .MainSplitContainer.Panel2.BackColor = UiStyles.MainMenuBackgroundColor
            .lblUserName.BackColor = UiStyles.MainMenuBackgroundColor
            .lblUserGroup.BackColor = UiStyles.MainMenuBackgroundColor
        End With
        Dim UserFunctions As New UserFunctionReader("..\\..\\XML\\UserFunction.xml")

        ' TODO:  Remove debug output
        UserFunctions.UserFunctions.DebugPrint("")

        ' Set the options for the current user
        For Each curUser In UserFunctions.UserFunctions.UserOptions
            If curUser.Name = gActiveUserName Then
                gActiveUserOptions = curUser
                Exit For
            End If
        Next

    End Sub

    Public Sub CenterUserControl(ByRef panel As Panel, ByRef uc As Object)

        If uc.height >= panel.Height Then
            uc.top = 0
        Else
            uc.Top = (panel.Height / 2) - (uc.Height / 2)
        End If
        uc.Left = (panel.Width / 2) - (uc.Width / 2)

    End Sub

    Private Sub btLoginLogout_Click(sender As System.Object, e As System.EventArgs) Handles btLoginLogout.Click

        End

    End Sub

End Class