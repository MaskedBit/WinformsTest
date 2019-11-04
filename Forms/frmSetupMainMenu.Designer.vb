<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetupMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetupMainMenu))
        Me.MainSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.lblUserGroup = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.flpLedError = New System.Windows.Forms.FlowLayoutPanel()
        Me.btLoginLogout = New WinformsTest.clsMenuButton()
        Me.UcSetupMainMenu1 = New WinformsTest.ucSetupMainMenu()
        Me.UcStatusBar = New WinformsTest.ucStatusBar()
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitContainer.Panel1.SuspendLayout()
        Me.MainSplitContainer.Panel2.SuspendLayout()
        Me.MainSplitContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainSplitContainer
        '
        Me.MainSplitContainer.BackColor = System.Drawing.SystemColors.Control
        Me.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.MainSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.MainSplitContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.MainSplitContainer.Name = "MainSplitContainer"
        Me.MainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'MainSplitContainer.Panel1
        '
        Me.MainSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.MainSplitContainer.Panel1.Controls.Add(Me.btLoginLogout)
        Me.MainSplitContainer.Panel1.Controls.Add(Me.lblUserGroup)
        Me.MainSplitContainer.Panel1.Controls.Add(Me.lblUserName)
        Me.MainSplitContainer.Panel1.Controls.Add(Me.flpLedError)
        '
        'MainSplitContainer.Panel2
        '
        Me.MainSplitContainer.Panel2.AutoScroll = True
        Me.MainSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.MainSplitContainer.Panel2.Controls.Add(Me.UcSetupMainMenu1)
        Me.MainSplitContainer.Size = New System.Drawing.Size(1920, 990)
        Me.MainSplitContainer.SplitterDistance = 160
        Me.MainSplitContainer.SplitterWidth = 1
        Me.MainSplitContainer.TabIndex = 9
        '
        'lblUserGroup
        '
        Me.lblUserGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserGroup.BackColor = System.Drawing.SystemColors.Control
        Me.lblUserGroup.Font = New System.Drawing.Font("Source Sans Pro", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserGroup.ForeColor = System.Drawing.Color.White
        Me.lblUserGroup.Location = New System.Drawing.Point(1002, 70)
        Me.lblUserGroup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserGroup.Name = "lblUserGroup"
        Me.lblUserGroup.Size = New System.Drawing.Size(605, 42)
        Me.lblUserGroup.TabIndex = 54
        Me.lblUserGroup.Text = "Setup User"
        Me.lblUserGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblUserGroup.Visible = False
        '
        'lblUserName
        '
        Me.lblUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserName.BackColor = System.Drawing.SystemColors.Control
        Me.lblUserName.Font = New System.Drawing.Font("Source Sans Pro", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(1002, 28)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(605, 42)
        Me.lblUserName.TabIndex = 53
        Me.lblUserName.Text = "John Doe"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'flpLedError
        '
        Me.flpLedError.AutoSize = True
        Me.flpLedError.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.flpLedError.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpLedError.Location = New System.Drawing.Point(0, 160)
        Me.flpLedError.Name = "flpLedError"
        Me.flpLedError.Size = New System.Drawing.Size(1920, 0)
        Me.flpLedError.TabIndex = 51
        Me.flpLedError.WrapContents = False
        '
        'btLoginLogout
        '
        Me.btLoginLogout.BackColor = System.Drawing.Color.White
        Me.btLoginLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLoginLogout.Font = New System.Drawing.Font("Source Sans Pro", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btLoginLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btLoginLogout.IsSelected = False
        Me.btLoginLogout.Location = New System.Drawing.Point(1631, 28)
        Me.btLoginLogout.Name = "btLoginLogout"
        Me.btLoginLogout.Size = New System.Drawing.Size(257, 78)
        Me.btLoginLogout.TabIndex = 55
        Me.btLoginLogout.Text = "End"
        Me.btLoginLogout.UseVisualStyleBackColor = True
        '
        'UcSetupMainMenu1
        '
        Me.UcSetupMainMenu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.UcSetupMainMenu1.Location = New System.Drawing.Point(522, 80)
        Me.UcSetupMainMenu1.Name = "UcSetupMainMenu1"
        Me.UcSetupMainMenu1.Size = New System.Drawing.Size(1193, 522)
        Me.UcSetupMainMenu1.TabIndex = 0
        '
        'UcStatusBar
        '
        Me.UcStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcStatusBar.Location = New System.Drawing.Point(0, 990)
        Me.UcStatusBar.Name = "UcStatusBar"
        Me.UcStatusBar.Size = New System.Drawing.Size(1920, 90)
        Me.UcStatusBar.TabIndex = 10
        '
        'frmSetupMainMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainSplitContainer)
        Me.Controls.Add(Me.UcStatusBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSetupMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MainSplitContainer.Panel1.ResumeLayout(False)
        Me.MainSplitContainer.Panel1.PerformLayout()
        Me.MainSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents lblUserGroup As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents flpLedError As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents UcStatusBar As WinformsTest.ucStatusBar
    Friend WithEvents UcSetupMainMenu1 As WinformsTest.ucSetupMainMenu
    Friend WithEvents btLoginLogout As WinformsTest.clsMenuButton
End Class
