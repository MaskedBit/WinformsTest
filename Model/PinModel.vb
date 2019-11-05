Public Class PinModel
    Public Property Name As String
    Public Property IsEnabled As Boolean

    Public Sub New(ByVal name As String, ByVal enabled As Boolean)
        Me.Name = name
        Me.IsEnabled = enabled
    End Sub
End Class
