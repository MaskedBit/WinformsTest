Public Class TraceOptions

    Public Property ExtendCollection As ValueWithType = New ValueWithType(1, TraceUnits.Seconds)
    Public Property SampleRate As ValueWithType = New ValueWithType(0.04D, TraceUnits.Seconds)
    Public Property KeepActiveFiles As Integer = 1000

End Class
