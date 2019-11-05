
Public Class UserOptions
    Public Property ID As String
    Public Property Name As String
    Public Property MenuOptions As New List(Of MenuOptions)

    Public Sub DebugPrint(ByRef indent As String)
        Dim childIndent As String = indent + "  "
        Dim grandChildIndent As String = childIndent + "  "

        Console.WriteLine("{0}UserOptions:", indent)
        Console.WriteLine("{0}ID=""{1}""", childIndent, Me.ID)
        Console.WriteLine("{0}Name=""{1}""", childIndent, Me.Name)
        Dim index = 0
        For Each curMenu In Me.MenuOptions
            Console.WriteLine("{0}MenuOptions({1}):", childIndent, index)
            curMenu.DebugPrint(grandChildIndent)
            index += 1
        Next
    End Sub

    Public Function GetMenuOptions(ByRef menuId As String)
        For Each curMenu In Me.MenuOptions
            If curMenu.ID = menuId Then
                Return curMenu
            End If
        Next

        Return Me.MenuOptions.First()
    End Function

End Class
