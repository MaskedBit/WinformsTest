' This class is the base the container class for each of the various Main Menu selections
' It contains the template for each menu form
' On load the Main Menu will pass in an identifier which will be used to set up the tabs and the linked user controls that they load

Public Class frmWorkSpaceTemplate
    Private Sub btnGoHome(sender As Object, e As EventArgs) Handles btHome.Click
        Me.Close()
    End Sub
End Class