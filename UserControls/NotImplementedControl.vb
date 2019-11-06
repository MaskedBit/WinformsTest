
Public Class NotImplementedControl

    Public Sub New(ByRef identity As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Label1.Text = identity + " is not implemented"
    End Sub

End Class
