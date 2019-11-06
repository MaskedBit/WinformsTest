Public Class RecipesForm

    Public Sub New(ByRef menu As MenuOptions, ByRef model As RecipeModel)
        MyBase.New(menu)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Function BuildUserControl(uIElement As String) As UserControl
        Dim control As New NotImplementedControl(uIElement)

        Return control
    End Function

End Class
