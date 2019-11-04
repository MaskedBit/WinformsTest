<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSetupMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSetupMainMenu))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlManualMode = New System.Windows.Forms.Panel()
        Me.btManualMode = New System.Windows.Forms.PictureBox()
        Me.lblManualMode = New System.Windows.Forms.Label()
        Me.pnlRecipes = New System.Windows.Forms.Panel()
        Me.btRecipes = New System.Windows.Forms.PictureBox()
        Me.lblRecipes = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlSettings = New System.Windows.Forms.Panel()
        Me.btSettings = New System.Windows.Forms.PictureBox()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlManualMode.SuspendLayout()
        CType(Me.btManualMode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRecipes.SuspendLayout()
        CType(Me.btRecipes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSettings.SuspendLayout()
        CType(Me.btSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(4, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 80)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = " - Open / Close Pins" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Purge" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Home" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Calibration"
        '
        'pnlManualMode
        '
        Me.pnlManualMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.pnlManualMode.Controls.Add(Me.btManualMode)
        Me.pnlManualMode.Controls.Add(Me.lblManualMode)
        Me.pnlManualMode.Location = New System.Drawing.Point(9, 2)
        Me.pnlManualMode.Name = "pnlManualMode"
        Me.pnlManualMode.Size = New System.Drawing.Size(289, 349)
        Me.pnlManualMode.TabIndex = 5
        '
        'btManualMode
        '
        Me.btManualMode.Image = CType(resources.GetObject("btManualMode.Image"), System.Drawing.Image)
        Me.btManualMode.Location = New System.Drawing.Point(85, 70)
        Me.btManualMode.Name = "btManualMode"
        Me.btManualMode.Size = New System.Drawing.Size(119, 121)
        Me.btManualMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btManualMode.TabIndex = 2
        Me.btManualMode.TabStop = False
        '
        'lblManualMode
        '
        Me.lblManualMode.BackColor = System.Drawing.Color.White
        Me.lblManualMode.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblManualMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManualMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblManualMode.Location = New System.Drawing.Point(0, 238)
        Me.lblManualMode.Name = "lblManualMode"
        Me.lblManualMode.Size = New System.Drawing.Size(289, 111)
        Me.lblManualMode.TabIndex = 0
        Me.lblManualMode.Text = "Manual Mode"
        Me.lblManualMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlRecipes
        '
        Me.pnlRecipes.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.pnlRecipes.Controls.Add(Me.btRecipes)
        Me.pnlRecipes.Controls.Add(Me.lblRecipes)
        Me.pnlRecipes.Location = New System.Drawing.Point(451, 2)
        Me.pnlRecipes.Name = "pnlRecipes"
        Me.pnlRecipes.Size = New System.Drawing.Size(289, 349)
        Me.pnlRecipes.TabIndex = 5
        '
        'btRecipes
        '
        Me.btRecipes.Image = CType(resources.GetObject("btRecipes.Image"), System.Drawing.Image)
        Me.btRecipes.Location = New System.Drawing.Point(84, 70)
        Me.btRecipes.Name = "btRecipes"
        Me.btRecipes.Size = New System.Drawing.Size(119, 121)
        Me.btRecipes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btRecipes.TabIndex = 2
        Me.btRecipes.TabStop = False
        '
        'lblRecipes
        '
        Me.lblRecipes.BackColor = System.Drawing.Color.White
        Me.lblRecipes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblRecipes.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblRecipes.Location = New System.Drawing.Point(0, 238)
        Me.lblRecipes.Name = "lblRecipes"
        Me.lblRecipes.Size = New System.Drawing.Size(289, 111)
        Me.lblRecipes.TabIndex = 0
        Me.lblRecipes.Text = "Recipes"
        Me.lblRecipes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(446, 373)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(223, 60)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = " - Create new recipes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Edit existing recipes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Recall recipes for production" &
    ""
        '
        'pnlSettings
        '
        Me.pnlSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.pnlSettings.Controls.Add(Me.btSettings)
        Me.pnlSettings.Controls.Add(Me.lblSettings)
        Me.pnlSettings.Location = New System.Drawing.Point(893, 2)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(289, 349)
        Me.pnlSettings.TabIndex = 5
        '
        'btSettings
        '
        Me.btSettings.Image = CType(resources.GetObject("btSettings.Image"), System.Drawing.Image)
        Me.btSettings.Location = New System.Drawing.Point(85, 70)
        Me.btSettings.Name = "btSettings"
        Me.btSettings.Size = New System.Drawing.Size(119, 121)
        Me.btSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btSettings.TabIndex = 2
        Me.btSettings.TabStop = False
        '
        'lblSettings
        '
        Me.lblSettings.BackColor = System.Drawing.Color.White
        Me.lblSettings.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblSettings.Location = New System.Drawing.Point(0, 238)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(289, 111)
        Me.lblSettings.TabIndex = 0
        Me.lblSettings.Text = "Settings"
        Me.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(888, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 60)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = " - IMM Interface configuration" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Controller configuration" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - User management"
        '
        'ucSetupMainMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pnlSettings)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pnlRecipes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.pnlManualMode)
        Me.Name = "ucSetupMainMenu"
        Me.Size = New System.Drawing.Size(1195, 522)
        Me.pnlManualMode.ResumeLayout(False)
        CType(Me.btManualMode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRecipes.ResumeLayout(False)
        CType(Me.btRecipes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSettings.ResumeLayout(False)
        CType(Me.btSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pnlManualMode As System.Windows.Forms.Panel
    Friend WithEvents lblManualMode As System.Windows.Forms.Label
    Friend WithEvents pnlRecipes As System.Windows.Forms.Panel
    Friend WithEvents btRecipes As System.Windows.Forms.PictureBox
    Friend WithEvents lblRecipes As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pnlSettings As System.Windows.Forms.Panel
    Friend WithEvents btSettings As System.Windows.Forms.PictureBox
    Friend WithEvents lblSettings As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btManualMode As System.Windows.Forms.PictureBox

End Class
