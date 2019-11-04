﻿Public Class ucSetupMainMenu

    Public Sub CenterInPanel()

        Try

            With Me
                If .Height >= .Parent.Height Then
                    .Top = 0
                Else
                    .Top = (.Parent.Height / 2) - (.Height / 2)
                End If
                If .Width >= .Parent.Width Then
                    .Left = 0
                Else
                    .Left = (.Parent.Width / 2) - (.Width / 2)
                End If
            End With
        Catch ex As Exception
            MsgBox("Center in Panel: " + ex.Message)
        End Try

    End Sub

    Public Sub KillMe()

        Me.Dispose()

    End Sub

    Private Sub ucMainMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        CenterInPanel()
        Me.BackColor = UiStyles.MainMenuBackgroundColor
        Me.pnlManualMode.BackColor = UiStyles.ButtonSelectedColor
        Me.pnlRecipes.BackColor = UiStyles.ButtonSelectedColor
        Me.pnlSettings.BackColor = UiStyles.ButtonSelectedColor

    End Sub

    Private Sub btManualMode_Click(sender As System.Object, e As System.EventArgs) Handles btManualMode.Click, pnlManualMode.Click, lblManualMode.Click

        MsgBox("Display instance of frmWorkSpaceTemplate populated with Manual Mode options")

    End Sub
    Private Sub Recipes_Click(sender As System.Object, e As System.EventArgs) Handles btRecipes.Click, lblRecipes.Click, pnlRecipes.Click

        MsgBox("Display instance of frmWorkSpaceTemplate populated with Recipe options")

    End Sub

    Private Sub btSettings_Click(sender As System.Object, e As System.EventArgs) Handles btSettings.Click, lblSettings.Click, pnlSettings.Click

        MsgBox("Display instance of frmWorkSpaceTemplate populated with Settings options")

    End Sub

End Class
