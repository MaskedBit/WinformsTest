<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucStatusBar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucStatusBar))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblSystemState = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblRecipeName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.AutoSize = False
        Me.StatusStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.StatusStrip.GripMargin = New System.Windows.Forms.Padding(0)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSystemState, Me.lblMessage, Me.lblRecipeName})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip.MinimumSize = New System.Drawing.Size(0, 90)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 18, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(2205, 90)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 6
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'lblSystemState
        '
        Me.lblSystemState.AutoSize = False
        Me.lblSystemState.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblSystemState.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top
        Me.lblSystemState.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.lblSystemState.Font = New System.Drawing.Font("Source Sans Pro", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemState.ForeColor = System.Drawing.Color.White
        Me.lblSystemState.Margin = New System.Windows.Forms.Padding(0, 1, 1, 0)
        Me.lblSystemState.Name = "lblSystemState"
        Me.lblSystemState.Size = New System.Drawing.Size(350, 89)
        Me.lblSystemState.Text = "System Not Ready"
        Me.lblSystemState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = False
        Me.lblMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblMessage.BorderSides = CType(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblMessage.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.lblMessage.Font = New System.Drawing.Font("Source Sans Pro", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Image = CType(resources.GetObject("lblMessage.Image"), System.Drawing.Image)
        Me.lblMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMessage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(0, 1, 1, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(800, 89)
        Me.lblMessage.Text = "Safety Gates Opened"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRecipeName
        '
        Me.lblRecipeName.AutoSize = False
        Me.lblRecipeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblRecipeName.BorderSides = CType(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblRecipeName.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.lblRecipeName.Font = New System.Drawing.Font("Source Sans Pro", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeName.ForeColor = System.Drawing.Color.White
        Me.lblRecipeName.Margin = New System.Windows.Forms.Padding(0, 1, 1, 0)
        Me.lblRecipeName.Name = "lblRecipeName"
        Me.lblRecipeName.Size = New System.Drawing.Size(1002, 89)
        Me.lblRecipeName.Spring = True
        Me.lblRecipeName.Text = "Interior Left Panel - A3568"
        Me.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ucStatusBar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.StatusStrip)
        Me.Name = "ucStatusBar"
        Me.Size = New System.Drawing.Size(2205, 90)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lblSystemState As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblMessage As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblRecipeName As System.Windows.Forms.ToolStripStatusLabel

End Class
