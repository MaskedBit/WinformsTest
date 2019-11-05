Public Class TabSelectControl
    Public Property TabOptions As TabOptions
    Private Property IsActive As Boolean = False

    Public Event TabSelected()

    Public Sub New(ByRef tabOptions As TabOptions)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.TabOptions = tabOptions
        Label1.Text = tabOptions.Name

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        RaiseEvent TabSelected()
        Me.SetActive()
    End Sub

    Friend Sub SetActive()
        MessageBox.Show("Setting " + TabOptions.Name + " active")
        IsActive = True
        Me.Refresh()
    End Sub

    Friend Sub SetInactive()
        IsActive = False
        Me.Refresh()
    End Sub

    Private Sub TabSelectControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Yecch!  Is this really the best way to add a bottom border???
    Private Sub TabControl_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MyBase.Paint
        If IsActive Then
            ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle,
                                    Color.Red, 0, ButtonBorderStyle.Solid,
                                    Color.Red, 0, ButtonBorderStyle.Solid,
                                    Color.Red, 0, ButtonBorderStyle.Solid,
                                    Color.White, 8, ButtonBorderStyle.Solid)
        End If
    End Sub

End Class
