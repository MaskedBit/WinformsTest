Public Class clsMenuButton

    Inherits Button

    Public Shared Event FunctionClicked(ByVal sName As String)
    Private _btIsSelected As Boolean = False

    Private Sub bt_Click(sender As Object, e As System.EventArgs) Handles Me.Click

        RaiseEvent FunctionClicked(Me.Text)
        _btIsSelected = True

    End Sub

    Public Property IsSelected() As Boolean

        Get
            Return _btIsSelected
        End Get
        Set(btSelected As Boolean)
            _btIsSelected = btSelected
            If _btIsSelected Then
                Me.BackColor = UiStyles.ActionButtonBorderColor
                Me.ForeColor = Color.White
            Else
                Me.BackColor = Color.White
                Me.ForeColor = UiStyles.ActionButtonBorderColor
            End If
        End Set

    End Property

    Public Sub New()

        With Me
            .AutoSize = False
            .AutoSizeMode = Windows.Forms.AutoSizeMode.GrowOnly
            .FlatStyle = System.Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 1
            .Font = New System.Drawing.Font("Source Sans Pro", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            .Size = New System.Drawing.Size(320, 70)
            .ForeColor = UiStyles.ActionButtonBorderColor
            .TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        End With

    End Sub

    Private Sub btBlueMenuButton_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        If _btIsSelected = False Then
            ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, UiStyles.ActionButtonBorderColor, ButtonBorderStyle.Solid)
        End If

    End Sub

End Class
