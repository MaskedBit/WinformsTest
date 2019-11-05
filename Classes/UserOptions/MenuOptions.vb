
Public Class MenuOptions
    Public Property ID As String
    Public Property Name As String
    Public Property MainMenuUIElement As String
    Public Property IconFile As String
    Public Property FormName As String
    Public Property TabOptions As New List(Of TabOptions)

    Public Sub DebugPrint(ByRef indent As String)
        Dim childIndent As String = indent + "  "
        Dim grandChildIndent As String = childIndent + "  "

        Console.WriteLine("{0}MenuOptions:", indent)
        Console.WriteLine("{0}ID=""{1}""", childIndent, Me.ID)
        Console.WriteLine("{0}Name=""{1}""", childIndent, Me.Name)
        Console.WriteLine("{0}MainMenuUIElement=""{1}""", childIndent, Me.MainMenuUIElement)
        Console.WriteLine("{0}IconFile=""{1}""", childIndent, Me.IconFile)
        Console.WriteLine("{0}FormName=""{1}""", childIndent, Me.FormName)
        Dim index = 0
        For Each curTab In Me.TabOptions
            Console.WriteLine("{0}TabOptions({1}):", childIndent, index)
            curTab.DebugPrint(grandChildIndent)
            index += 1
        Next
    End Sub

End Class
