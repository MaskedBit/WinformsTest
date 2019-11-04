<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkSpaceTemplate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkSpaceTemplate))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btHome = New System.Windows.Forms.PictureBox()
        Me.flpMenuBar = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.TopRightPanel = New System.Windows.Forms.Panel()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.UcStatusBar = New WinformsTest.ucStatusBar()
        CType(Me.btHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        Me.TopRightPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(105, 3)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(1499, 90)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Title"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btHome
        '
        Me.btHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btHome.Dock = System.Windows.Forms.DockStyle.Left
        Me.btHome.Image = CType(resources.GetObject("btHome.Image"), System.Drawing.Image)
        Me.btHome.Location = New System.Drawing.Point(0, 0)
        Me.btHome.Name = "btHome"
        Me.btHome.Size = New System.Drawing.Size(105, 158)
        Me.btHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btHome.TabIndex = 0
        Me.btHome.TabStop = False
        '
        'flpMenuBar
        '
        Me.flpMenuBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.flpMenuBar.Location = New System.Drawing.Point(105, 95)
        Me.flpMenuBar.Margin = New System.Windows.Forms.Padding(0)
        Me.flpMenuBar.MinimumSize = New System.Drawing.Size(0, 50)
        Me.flpMenuBar.Name = "flpMenuBar"
        Me.flpMenuBar.Padding = New System.Windows.Forms.Padding(10, 2, 10, 0)
        Me.flpMenuBar.Size = New System.Drawing.Size(1815, 63)
        Me.flpMenuBar.TabIndex = 55
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(15, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.TopRightPanel)
        Me.TopPanel.Controls.Add(Me.flpMenuBar)
        Me.TopPanel.Controls.Add(Me.lblHeader)
        Me.TopPanel.Controls.Add(Me.btHome)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopPanel.ForeColor = System.Drawing.Color.White
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.MinimumSize = New System.Drawing.Size(0, 100)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1920, 158)
        Me.TopPanel.TabIndex = 10
        '
        'TopRightPanel
        '
        Me.TopRightPanel.Controls.Add(Me.lblUserName)
        Me.TopRightPanel.Controls.Add(Me.PictureBox2)
        Me.TopRightPanel.Location = New System.Drawing.Point(1610, 2)
        Me.TopRightPanel.Name = "TopRightPanel"
        Me.TopRightPanel.Size = New System.Drawing.Size(298, 90)
        Me.TopRightPanel.TabIndex = 56
        '
        'lblUserName
        '
        Me.lblUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(78, 26)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(217, 51)
        Me.lblUserName.TabIndex = 53
        Me.lblUserName.Text = "User Name"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainPanel
        '
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 158)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1920, 832)
        Me.MainPanel.TabIndex = 11
        '
        'UcStatusBar
        '
        Me.UcStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcStatusBar.Location = New System.Drawing.Point(0, 990)
        Me.UcStatusBar.Name = "UcStatusBar"
        Me.UcStatusBar.Size = New System.Drawing.Size(1920, 90)
        Me.UcStatusBar.TabIndex = 9
        '
        'frmWorkSpaceTemplate
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.UcStatusBar)
        Me.Controls.Add(Me.TopPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWorkSpaceTemplate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.btHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        Me.TopRightPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btHome As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TopPanel As System.Windows.Forms.Panel
    Friend WithEvents TopRightPanel As System.Windows.Forms.Panel
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents UcStatusBar As WinformsTest.ucStatusBar
    Protected WithEvents lblHeader As Label
    Protected WithEvents flpMenuBar As FlowLayoutPanel
    Protected WithEvents MainPanel As Panel
End Class
