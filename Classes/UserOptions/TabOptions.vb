Public Class TabOptions
    Public Property ID As String
    Public Property Name As String
    Public Property UIElement As String
    Public Property TabAction As String

    Public Sub DebugPrint(ByRef indent As String)
        Dim childIndent As String = indent + "  "

        Console.WriteLine("{0}TabOptions:", indent)
        Console.WriteLine("{0}ID=""{1}""", childIndent, Me.ID)
        Console.WriteLine("{0}Name=""{1}""", childIndent, Me.Name)
        Console.WriteLine("{0}UIElement=""{1}""", childIndent, Me.UIElement)
        Console.WriteLine("{0}TabAction=""{1}""", childIndent, Me.TabAction)
    End Sub

End Class
