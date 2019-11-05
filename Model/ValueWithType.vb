Public Class ValueWithType

    Public Property TraceValue As Decimal
    Public Property TraceUnits As TraceUnits

    Public Sub New(ByVal value As Decimal, ByVal units As TraceUnits)
        Me.TraceValue = value
        Me.TraceUnits = units
    End Sub
End Class
