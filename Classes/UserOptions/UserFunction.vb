
Public Class UserFunction
    Public Property UserOptions As New List(Of UserOptions)

    Public Sub DebugPrint(ByRef indent As String)
        Dim childIndent As String = indent + "  "
        Dim grandChildIndent As String = childIndent + "  "

        Console.WriteLine("{0}UserFunction:", indent)
        Dim index = 0
        For Each curMenu In Me.UserOptions
            Console.WriteLine("{0}UserOptions({1}):", childIndent, index)
            curMenu.DebugPrint(grandChildIndent)
            index += 1
        Next
    End Sub

End Class
