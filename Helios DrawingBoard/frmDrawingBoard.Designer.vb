<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrawingBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDrawingBoard))
        Me.mnuDrawingBoard = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.sfdSavePic = New System.Windows.Forms.SaveFileDialog()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblPink = New System.Windows.Forms.Label()
        Me.lblViolet = New System.Windows.Forms.Label()
        Me.lblFuchsia = New System.Windows.Forms.Label()
        Me.lblMediumVioletRed = New System.Windows.Forms.Label()
        Me.lblPurple = New System.Windows.Forms.Label()
        Me.lblIndigo = New System.Windows.Forms.Label()
        Me.lblMediumPurple = New System.Windows.Forms.Label()
        Me.lblPaleGreen = New System.Windows.Forms.Label()
        Me.lblSlateBlue = New System.Windows.Forms.Label()
        Me.lblPapayaWhip = New System.Windows.Forms.Label()
        Me.lblPaleTurquoise = New System.Windows.Forms.Label()
        Me.lblLightGreen = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblNavajoWhite = New System.Windows.Forms.Label()
        Me.lblAqua = New System.Windows.Forms.Label()
        Me.lblLightYellow = New System.Windows.Forms.Label()
        Me.lblMediumBlue = New System.Windows.Forms.Label()
        Me.lblLime = New System.Windows.Forms.Label()
        Me.lblCyan = New System.Windows.Forms.Label()
        Me.lblMistyRose = New System.Windows.Forms.Label()
        Me.lblNavy = New System.Windows.Forms.Label()
        Me.lblPaleGoldenrod = New System.Windows.Forms.Label()
        Me.lblTurquoise = New System.Windows.Forms.Label()
        Me.lblMidnightBlue = New System.Windows.Forms.Label()
        Me.lblOrange = New System.Windows.Forms.Label()
        Me.lblTeal = New System.Windows.Forms.Label()
        Me.lblLimeGreen = New System.Windows.Forms.Label()
        Me.lblSeaGreen = New System.Windows.Forms.Label()
        Me.lblSalmon = New System.Windows.Forms.Label()
        Me.lblYellow = New System.Windows.Forms.Label()
        Me.lblChocolate = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblGoldenRod = New System.Windows.Forms.Label()
        Me.lblSienna = New System.Windows.Forms.Label()
        Me.lblDarkGreen = New System.Windows.Forms.Label()
        Me.lblFirebrick = New System.Windows.Forms.Label()
        Me.lblOlive = New System.Windows.Forms.Label()
        Me.lblGray = New System.Windows.Forms.Label()
        Me.lblDarkGoldenrod = New System.Windows.Forms.Label()
        Me.lblMaroon = New System.Windows.Forms.Label()
        Me.lblDimGray = New System.Windows.Forms.Label()
        Me.lblWhite = New System.Windows.Forms.Label()
        Me.lblGainsboro = New System.Windows.Forms.Label()
        Me.lblSilver = New System.Windows.Forms.Label()
        Me.lblDarkRed = New System.Windows.Forms.Label()
        Me.lblSaddleBrown = New System.Windows.Forms.Label()
        Me.cmbPenWidth = New System.Windows.Forms.ComboBox()
        Me.lblPenWidth = New System.Windows.Forms.Label()
        Me.cmbBrushSize = New System.Windows.Forms.ComboBox()
        Me.lblBrushSize = New System.Windows.Forms.Label()
        Me.lblColorSelected = New System.Windows.Forms.Label()
        Me.lblToolSelected = New System.Windows.Forms.Label()
        Me.lblEllFill = New System.Windows.Forms.Label()
        Me.LblEllOut = New System.Windows.Forms.Label()
        Me.lblCircFill = New System.Windows.Forms.Label()
        Me.lblCircOut = New System.Windows.Forms.Label()
        Me.lblRecFill = New System.Windows.Forms.Label()
        Me.lblRecOut = New System.Windows.Forms.Label()
        Me.lblSqFill = New System.Windows.Forms.Label()
        Me.lblSqOut = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lblBrush = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblBlack = New System.Windows.Forms.Label()
        Me.cmdFont = New System.Windows.Forms.Button()
        Me.lblFontDetails = New System.Windows.Forms.Label()
        Me.txtInsertText = New System.Windows.Forms.TextBox()
        Me.lblEditText = New System.Windows.Forms.Label()
        Me.pnlFrame = New System.Windows.Forms.Panel()
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.mnuDrawingBoard.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlFrame.SuspendLayout()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuDrawingBoard
        '
        Me.mnuDrawingBoard.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuDrawingBoard.Location = New System.Drawing.Point(0, 0)
        Me.mnuDrawingBoard.Name = "mnuDrawingBoard"
        Me.mnuDrawingBoard.Size = New System.Drawing.Size(624, 24)
        Me.mnuDrawingBoard.TabIndex = 0
        Me.mnuDrawingBoard.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.mnuFileExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Image = CType(resources.GetObject("mnuFileExit.Image"), System.Drawing.Image)
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.lblPink)
        Me.pnlMain.Controls.Add(Me.lblViolet)
        Me.pnlMain.Controls.Add(Me.lblFuchsia)
        Me.pnlMain.Controls.Add(Me.lblMediumVioletRed)
        Me.pnlMain.Controls.Add(Me.lblPurple)
        Me.pnlMain.Controls.Add(Me.lblIndigo)
        Me.pnlMain.Controls.Add(Me.lblMediumPurple)
        Me.pnlMain.Controls.Add(Me.lblPaleGreen)
        Me.pnlMain.Controls.Add(Me.lblSlateBlue)
        Me.pnlMain.Controls.Add(Me.lblPapayaWhip)
        Me.pnlMain.Controls.Add(Me.lblPaleTurquoise)
        Me.pnlMain.Controls.Add(Me.lblLightGreen)
        Me.pnlMain.Controls.Add(Me.lblBlue)
        Me.pnlMain.Controls.Add(Me.lblNavajoWhite)
        Me.pnlMain.Controls.Add(Me.lblAqua)
        Me.pnlMain.Controls.Add(Me.lblLightYellow)
        Me.pnlMain.Controls.Add(Me.lblMediumBlue)
        Me.pnlMain.Controls.Add(Me.lblLime)
        Me.pnlMain.Controls.Add(Me.lblCyan)
        Me.pnlMain.Controls.Add(Me.lblMistyRose)
        Me.pnlMain.Controls.Add(Me.lblNavy)
        Me.pnlMain.Controls.Add(Me.lblPaleGoldenrod)
        Me.pnlMain.Controls.Add(Me.lblTurquoise)
        Me.pnlMain.Controls.Add(Me.lblMidnightBlue)
        Me.pnlMain.Controls.Add(Me.lblOrange)
        Me.pnlMain.Controls.Add(Me.lblTeal)
        Me.pnlMain.Controls.Add(Me.lblLimeGreen)
        Me.pnlMain.Controls.Add(Me.lblSeaGreen)
        Me.pnlMain.Controls.Add(Me.lblSalmon)
        Me.pnlMain.Controls.Add(Me.lblYellow)
        Me.pnlMain.Controls.Add(Me.lblChocolate)
        Me.pnlMain.Controls.Add(Me.lblGreen)
        Me.pnlMain.Controls.Add(Me.lblRed)
        Me.pnlMain.Controls.Add(Me.lblGoldenRod)
        Me.pnlMain.Controls.Add(Me.lblSienna)
        Me.pnlMain.Controls.Add(Me.lblDarkGreen)
        Me.pnlMain.Controls.Add(Me.lblFirebrick)
        Me.pnlMain.Controls.Add(Me.lblOlive)
        Me.pnlMain.Controls.Add(Me.lblGray)
        Me.pnlMain.Controls.Add(Me.lblDarkGoldenrod)
        Me.pnlMain.Controls.Add(Me.lblMaroon)
        Me.pnlMain.Controls.Add(Me.lblDimGray)
        Me.pnlMain.Controls.Add(Me.lblWhite)
        Me.pnlMain.Controls.Add(Me.lblGainsboro)
        Me.pnlMain.Controls.Add(Me.lblSilver)
        Me.pnlMain.Controls.Add(Me.lblDarkRed)
        Me.pnlMain.Controls.Add(Me.lblSaddleBrown)
        Me.pnlMain.Controls.Add(Me.cmbPenWidth)
        Me.pnlMain.Controls.Add(Me.lblPenWidth)
        Me.pnlMain.Controls.Add(Me.cmbBrushSize)
        Me.pnlMain.Controls.Add(Me.lblBrushSize)
        Me.pnlMain.Controls.Add(Me.lblColorSelected)
        Me.pnlMain.Controls.Add(Me.lblToolSelected)
        Me.pnlMain.Controls.Add(Me.lblEllFill)
        Me.pnlMain.Controls.Add(Me.LblEllOut)
        Me.pnlMain.Controls.Add(Me.lblCircFill)
        Me.pnlMain.Controls.Add(Me.lblCircOut)
        Me.pnlMain.Controls.Add(Me.lblRecFill)
        Me.pnlMain.Controls.Add(Me.lblRecOut)
        Me.pnlMain.Controls.Add(Me.lblSqFill)
        Me.pnlMain.Controls.Add(Me.lblSqOut)
        Me.pnlMain.Controls.Add(Me.lblText)
        Me.pnlMain.Controls.Add(Me.lblLine)
        Me.pnlMain.Controls.Add(Me.lblBrush)
        Me.pnlMain.Controls.Add(Me.lblColor)
        Me.pnlMain.Controls.Add(Me.lblBlack)
        Me.pnlMain.Controls.Add(Me.cmdFont)
        Me.pnlMain.Controls.Add(Me.lblFontDetails)
        Me.pnlMain.Controls.Add(Me.txtInsertText)
        Me.pnlMain.Controls.Add(Me.lblEditText)
        Me.pnlMain.Controls.Add(Me.pnlFrame)
        Me.pnlMain.Enabled = False
        Me.pnlMain.Location = New System.Drawing.Point(0, 24)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(624, 538)
        Me.pnlMain.TabIndex = 1
        '
        'lblPink
        '
        Me.lblPink.BackColor = System.Drawing.Color.Pink
        Me.lblPink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPink.Location = New System.Drawing.Point(599, 213)
        Me.lblPink.Name = "lblPink"
        Me.lblPink.Size = New System.Drawing.Size(13, 13)
        Me.lblPink.TabIndex = 44
        '
        'lblViolet
        '
        Me.lblViolet.BackColor = System.Drawing.Color.Violet
        Me.lblViolet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblViolet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblViolet.Location = New System.Drawing.Point(580, 213)
        Me.lblViolet.Name = "lblViolet"
        Me.lblViolet.Size = New System.Drawing.Size(13, 13)
        Me.lblViolet.TabIndex = 43
        '
        'lblFuchsia
        '
        Me.lblFuchsia.BackColor = System.Drawing.Color.Fuchsia
        Me.lblFuchsia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFuchsia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFuchsia.Location = New System.Drawing.Point(561, 213)
        Me.lblFuchsia.Name = "lblFuchsia"
        Me.lblFuchsia.Size = New System.Drawing.Size(13, 13)
        Me.lblFuchsia.TabIndex = 42
        '
        'lblMediumVioletRed
        '
        Me.lblMediumVioletRed.BackColor = System.Drawing.Color.MediumVioletRed
        Me.lblMediumVioletRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMediumVioletRed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMediumVioletRed.Location = New System.Drawing.Point(542, 213)
        Me.lblMediumVioletRed.Name = "lblMediumVioletRed"
        Me.lblMediumVioletRed.Size = New System.Drawing.Size(13, 13)
        Me.lblMediumVioletRed.TabIndex = 41
        '
        'lblPurple
        '
        Me.lblPurple.BackColor = System.Drawing.Color.Purple
        Me.lblPurple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPurple.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPurple.Location = New System.Drawing.Point(523, 213)
        Me.lblPurple.Name = "lblPurple"
        Me.lblPurple.Size = New System.Drawing.Size(13, 13)
        Me.lblPurple.TabIndex = 40
        '
        'lblIndigo
        '
        Me.lblIndigo.BackColor = System.Drawing.Color.Indigo
        Me.lblIndigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIndigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIndigo.Location = New System.Drawing.Point(504, 213)
        Me.lblIndigo.Name = "lblIndigo"
        Me.lblIndigo.Size = New System.Drawing.Size(13, 13)
        Me.lblIndigo.TabIndex = 39
        '
        'lblMediumPurple
        '
        Me.lblMediumPurple.BackColor = System.Drawing.Color.MediumPurple
        Me.lblMediumPurple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMediumPurple.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMediumPurple.Location = New System.Drawing.Point(599, 195)
        Me.lblMediumPurple.Name = "lblMediumPurple"
        Me.lblMediumPurple.Size = New System.Drawing.Size(13, 13)
        Me.lblMediumPurple.TabIndex = 37
        '
        'lblPaleGreen
        '
        Me.lblPaleGreen.BackColor = System.Drawing.Color.PaleGreen
        Me.lblPaleGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPaleGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPaleGreen.Location = New System.Drawing.Point(599, 159)
        Me.lblPaleGreen.Name = "lblPaleGreen"
        Me.lblPaleGreen.Size = New System.Drawing.Size(13, 13)
        Me.lblPaleGreen.TabIndex = 37
        '
        'lblSlateBlue
        '
        Me.lblSlateBlue.BackColor = System.Drawing.Color.SlateBlue
        Me.lblSlateBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSlateBlue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSlateBlue.Location = New System.Drawing.Point(580, 195)
        Me.lblSlateBlue.Name = "lblSlateBlue"
        Me.lblSlateBlue.Size = New System.Drawing.Size(13, 13)
        Me.lblSlateBlue.TabIndex = 35
        '
        'lblPapayaWhip
        '
        Me.lblPapayaWhip.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblPapayaWhip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPapayaWhip.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPapayaWhip.Location = New System.Drawing.Point(599, 123)
        Me.lblPapayaWhip.Name = "lblPapayaWhip"
        Me.lblPapayaWhip.Size = New System.Drawing.Size(13, 13)
        Me.lblPapayaWhip.TabIndex = 26
        '
        'lblPaleTurquoise
        '
        Me.lblPaleTurquoise.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblPaleTurquoise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPaleTurquoise.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPaleTurquoise.Location = New System.Drawing.Point(599, 177)
        Me.lblPaleTurquoise.Name = "lblPaleTurquoise"
        Me.lblPaleTurquoise.Size = New System.Drawing.Size(13, 13)
        Me.lblPaleTurquoise.TabIndex = 38
        '
        'lblLightGreen
        '
        Me.lblLightGreen.BackColor = System.Drawing.Color.LightGreen
        Me.lblLightGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLightGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLightGreen.Location = New System.Drawing.Point(580, 159)
        Me.lblLightGreen.Name = "lblLightGreen"
        Me.lblLightGreen.Size = New System.Drawing.Size(13, 13)
        Me.lblLightGreen.TabIndex = 35
        '
        'lblBlue
        '
        Me.lblBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBlue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBlue.Location = New System.Drawing.Point(561, 195)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(13, 13)
        Me.lblBlue.TabIndex = 33
        '
        'lblNavajoWhite
        '
        Me.lblNavajoWhite.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblNavajoWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNavajoWhite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNavajoWhite.Location = New System.Drawing.Point(580, 123)
        Me.lblNavajoWhite.Name = "lblNavajoWhite"
        Me.lblNavajoWhite.Size = New System.Drawing.Size(13, 13)
        Me.lblNavajoWhite.TabIndex = 25
        '
        'lblAqua
        '
        Me.lblAqua.BackColor = System.Drawing.Color.Aqua
        Me.lblAqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAqua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAqua.Location = New System.Drawing.Point(580, 177)
        Me.lblAqua.Name = "lblAqua"
        Me.lblAqua.Size = New System.Drawing.Size(13, 13)
        Me.lblAqua.TabIndex = 36
        '
        'lblLightYellow
        '
        Me.lblLightYellow.BackColor = System.Drawing.Color.LightYellow
        Me.lblLightYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLightYellow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLightYellow.Location = New System.Drawing.Point(599, 141)
        Me.lblLightYellow.Name = "lblLightYellow"
        Me.lblLightYellow.Size = New System.Drawing.Size(13, 13)
        Me.lblLightYellow.TabIndex = 38
        '
        'lblMediumBlue
        '
        Me.lblMediumBlue.BackColor = System.Drawing.Color.MediumBlue
        Me.lblMediumBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMediumBlue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMediumBlue.Location = New System.Drawing.Point(542, 195)
        Me.lblMediumBlue.Name = "lblMediumBlue"
        Me.lblMediumBlue.Size = New System.Drawing.Size(13, 13)
        Me.lblMediumBlue.TabIndex = 31
        '
        'lblLime
        '
        Me.lblLime.BackColor = System.Drawing.Color.Lime
        Me.lblLime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLime.Location = New System.Drawing.Point(561, 159)
        Me.lblLime.Name = "lblLime"
        Me.lblLime.Size = New System.Drawing.Size(13, 13)
        Me.lblLime.TabIndex = 33
        '
        'lblCyan
        '
        Me.lblCyan.BackColor = System.Drawing.Color.Cyan
        Me.lblCyan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCyan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCyan.Location = New System.Drawing.Point(561, 177)
        Me.lblCyan.Name = "lblCyan"
        Me.lblCyan.Size = New System.Drawing.Size(13, 13)
        Me.lblCyan.TabIndex = 34
        '
        'lblMistyRose
        '
        Me.lblMistyRose.BackColor = System.Drawing.Color.MistyRose
        Me.lblMistyRose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMistyRose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMistyRose.Location = New System.Drawing.Point(599, 105)
        Me.lblMistyRose.Name = "lblMistyRose"
        Me.lblMistyRose.Size = New System.Drawing.Size(13, 13)
        Me.lblMistyRose.TabIndex = 26
        '
        'lblNavy
        '
        Me.lblNavy.BackColor = System.Drawing.Color.Navy
        Me.lblNavy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNavy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNavy.Location = New System.Drawing.Point(523, 195)
        Me.lblNavy.Name = "lblNavy"
        Me.lblNavy.Size = New System.Drawing.Size(13, 13)
        Me.lblNavy.TabIndex = 29
        '
        'lblPaleGoldenrod
        '
        Me.lblPaleGoldenrod.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblPaleGoldenrod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPaleGoldenrod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPaleGoldenrod.Location = New System.Drawing.Point(580, 141)
        Me.lblPaleGoldenrod.Name = "lblPaleGoldenrod"
        Me.lblPaleGoldenrod.Size = New System.Drawing.Size(13, 13)
        Me.lblPaleGoldenrod.TabIndex = 36
        '
        'lblTurquoise
        '
        Me.lblTurquoise.BackColor = System.Drawing.Color.Turquoise
        Me.lblTurquoise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTurquoise.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTurquoise.Location = New System.Drawing.Point(542, 177)
        Me.lblTurquoise.Name = "lblTurquoise"
        Me.lblTurquoise.Size = New System.Drawing.Size(13, 13)
        Me.lblTurquoise.TabIndex = 32
        '
        'lblMidnightBlue
        '
        Me.lblMidnightBlue.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblMidnightBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMidnightBlue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMidnightBlue.Location = New System.Drawing.Point(504, 195)
        Me.lblMidnightBlue.Name = "lblMidnightBlue"
        Me.lblMidnightBlue.Size = New System.Drawing.Size(13, 13)
        Me.lblMidnightBlue.TabIndex = 27
        '
        'lblOrange
        '
        Me.lblOrange.BackColor = System.Drawing.Color.Orange
        Me.lblOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOrange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOrange.Location = New System.Drawing.Point(561, 123)
        Me.lblOrange.Name = "lblOrange"
        Me.lblOrange.Size = New System.Drawing.Size(13, 13)
        Me.lblOrange.TabIndex = 24
        '
        'lblTeal
        '
        Me.lblTeal.BackColor = System.Drawing.Color.Teal
        Me.lblTeal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTeal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTeal.Location = New System.Drawing.Point(523, 177)
        Me.lblTeal.Name = "lblTeal"
        Me.lblTeal.Size = New System.Drawing.Size(13, 13)
        Me.lblTeal.TabIndex = 30
        '
        'lblLimeGreen
        '
        Me.lblLimeGreen.BackColor = System.Drawing.Color.LimeGreen
        Me.lblLimeGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLimeGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLimeGreen.Location = New System.Drawing.Point(542, 159)
        Me.lblLimeGreen.Name = "lblLimeGreen"
        Me.lblLimeGreen.Size = New System.Drawing.Size(13, 13)
        Me.lblLimeGreen.TabIndex = 31
        '
        'lblSeaGreen
        '
        Me.lblSeaGreen.BackColor = System.Drawing.Color.SeaGreen
        Me.lblSeaGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeaGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSeaGreen.Location = New System.Drawing.Point(504, 177)
        Me.lblSeaGreen.Name = "lblSeaGreen"
        Me.lblSeaGreen.Size = New System.Drawing.Size(13, 13)
        Me.lblSeaGreen.TabIndex = 28
        '
        'lblSalmon
        '
        Me.lblSalmon.BackColor = System.Drawing.Color.Salmon
        Me.lblSalmon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalmon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSalmon.Location = New System.Drawing.Point(580, 105)
        Me.lblSalmon.Name = "lblSalmon"
        Me.lblSalmon.Size = New System.Drawing.Size(13, 13)
        Me.lblSalmon.TabIndex = 25
        '
        'lblYellow
        '
        Me.lblYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYellow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblYellow.Location = New System.Drawing.Point(561, 141)
        Me.lblYellow.Name = "lblYellow"
        Me.lblYellow.Size = New System.Drawing.Size(13, 13)
        Me.lblYellow.TabIndex = 34
        '
        'lblChocolate
        '
        Me.lblChocolate.BackColor = System.Drawing.Color.Chocolate
        Me.lblChocolate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChocolate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblChocolate.Location = New System.Drawing.Point(542, 123)
        Me.lblChocolate.Name = "lblChocolate"
        Me.lblChocolate.Size = New System.Drawing.Size(13, 13)
        Me.lblChocolate.TabIndex = 23
        '
        'lblGreen
        '
        Me.lblGreen.BackColor = System.Drawing.Color.Green
        Me.lblGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGreen.Location = New System.Drawing.Point(523, 159)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(13, 13)
        Me.lblGreen.TabIndex = 29
        '
        'lblRed
        '
        Me.lblRed.BackColor = System.Drawing.Color.Red
        Me.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRed.Location = New System.Drawing.Point(561, 105)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(13, 13)
        Me.lblRed.TabIndex = 24
        '
        'lblGoldenRod
        '
        Me.lblGoldenRod.BackColor = System.Drawing.Color.Goldenrod
        Me.lblGoldenRod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGoldenRod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGoldenRod.Location = New System.Drawing.Point(542, 141)
        Me.lblGoldenRod.Name = "lblGoldenRod"
        Me.lblGoldenRod.Size = New System.Drawing.Size(13, 13)
        Me.lblGoldenRod.TabIndex = 32
        '
        'lblSienna
        '
        Me.lblSienna.BackColor = System.Drawing.Color.Sienna
        Me.lblSienna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSienna.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSienna.Location = New System.Drawing.Point(523, 123)
        Me.lblSienna.Name = "lblSienna"
        Me.lblSienna.Size = New System.Drawing.Size(13, 13)
        Me.lblSienna.TabIndex = 22
        '
        'lblDarkGreen
        '
        Me.lblDarkGreen.BackColor = System.Drawing.Color.DarkGreen
        Me.lblDarkGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDarkGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDarkGreen.Location = New System.Drawing.Point(504, 159)
        Me.lblDarkGreen.Name = "lblDarkGreen"
        Me.lblDarkGreen.Size = New System.Drawing.Size(13, 13)
        Me.lblDarkGreen.TabIndex = 27
        '
        'lblFirebrick
        '
        Me.lblFirebrick.BackColor = System.Drawing.Color.Firebrick
        Me.lblFirebrick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFirebrick.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFirebrick.Location = New System.Drawing.Point(542, 105)
        Me.lblFirebrick.Name = "lblFirebrick"
        Me.lblFirebrick.Size = New System.Drawing.Size(13, 13)
        Me.lblFirebrick.TabIndex = 23
        '
        'lblOlive
        '
        Me.lblOlive.BackColor = System.Drawing.Color.Olive
        Me.lblOlive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOlive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOlive.Location = New System.Drawing.Point(504, 141)
        Me.lblOlive.Name = "lblOlive"
        Me.lblOlive.Size = New System.Drawing.Size(13, 13)
        Me.lblOlive.TabIndex = 30
        '
        'lblGray
        '
        Me.lblGray.BackColor = System.Drawing.Color.Gray
        Me.lblGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGray.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGray.Location = New System.Drawing.Point(542, 87)
        Me.lblGray.Name = "lblGray"
        Me.lblGray.Size = New System.Drawing.Size(13, 13)
        Me.lblGray.TabIndex = 21
        '
        'lblDarkGoldenrod
        '
        Me.lblDarkGoldenrod.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.lblDarkGoldenrod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDarkGoldenrod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDarkGoldenrod.Location = New System.Drawing.Point(523, 141)
        Me.lblDarkGoldenrod.Name = "lblDarkGoldenrod"
        Me.lblDarkGoldenrod.Size = New System.Drawing.Size(13, 13)
        Me.lblDarkGoldenrod.TabIndex = 28
        '
        'lblMaroon
        '
        Me.lblMaroon.BackColor = System.Drawing.Color.Maroon
        Me.lblMaroon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaroon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMaroon.Location = New System.Drawing.Point(504, 105)
        Me.lblMaroon.Name = "lblMaroon"
        Me.lblMaroon.Size = New System.Drawing.Size(13, 13)
        Me.lblMaroon.TabIndex = 22
        '
        'lblDimGray
        '
        Me.lblDimGray.BackColor = System.Drawing.Color.DimGray
        Me.lblDimGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDimGray.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDimGray.Location = New System.Drawing.Point(523, 87)
        Me.lblDimGray.Name = "lblDimGray"
        Me.lblDimGray.Size = New System.Drawing.Size(13, 13)
        Me.lblDimGray.TabIndex = 21
        '
        'lblWhite
        '
        Me.lblWhite.BackColor = System.Drawing.Color.White
        Me.lblWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWhite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblWhite.Location = New System.Drawing.Point(599, 87)
        Me.lblWhite.Name = "lblWhite"
        Me.lblWhite.Size = New System.Drawing.Size(13, 13)
        Me.lblWhite.TabIndex = 20
        '
        'lblGainsboro
        '
        Me.lblGainsboro.BackColor = System.Drawing.Color.Gainsboro
        Me.lblGainsboro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGainsboro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGainsboro.Location = New System.Drawing.Point(580, 87)
        Me.lblGainsboro.Name = "lblGainsboro"
        Me.lblGainsboro.Size = New System.Drawing.Size(13, 13)
        Me.lblGainsboro.TabIndex = 19
        '
        'lblSilver
        '
        Me.lblSilver.BackColor = System.Drawing.Color.Silver
        Me.lblSilver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSilver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSilver.Location = New System.Drawing.Point(561, 87)
        Me.lblSilver.Name = "lblSilver"
        Me.lblSilver.Size = New System.Drawing.Size(13, 13)
        Me.lblSilver.TabIndex = 18
        '
        'lblDarkRed
        '
        Me.lblDarkRed.BackColor = System.Drawing.Color.DarkRed
        Me.lblDarkRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDarkRed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDarkRed.Location = New System.Drawing.Point(523, 105)
        Me.lblDarkRed.Name = "lblDarkRed"
        Me.lblDarkRed.Size = New System.Drawing.Size(13, 13)
        Me.lblDarkRed.TabIndex = 17
        '
        'lblSaddleBrown
        '
        Me.lblSaddleBrown.BackColor = System.Drawing.Color.SaddleBrown
        Me.lblSaddleBrown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaddleBrown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSaddleBrown.Location = New System.Drawing.Point(504, 123)
        Me.lblSaddleBrown.Name = "lblSaddleBrown"
        Me.lblSaddleBrown.Size = New System.Drawing.Size(13, 13)
        Me.lblSaddleBrown.TabIndex = 6
        '
        'cmbPenWidth
        '
        Me.cmbPenWidth.FormattingEnabled = True
        Me.cmbPenWidth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbPenWidth.Location = New System.Drawing.Point(577, 507)
        Me.cmbPenWidth.Name = "cmbPenWidth"
        Me.cmbPenWidth.Size = New System.Drawing.Size(36, 21)
        Me.cmbPenWidth.TabIndex = 16
        Me.cmbPenWidth.Text = "2"
        '
        'lblPenWidth
        '
        Me.lblPenWidth.Location = New System.Drawing.Point(500, 510)
        Me.lblPenWidth.Name = "lblPenWidth"
        Me.lblPenWidth.Size = New System.Drawing.Size(71, 13)
        Me.lblPenWidth.TabIndex = 15
        Me.lblPenWidth.Text = "Pen Width:"
        Me.lblPenWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbBrushSize
        '
        Me.cmbBrushSize.FormattingEnabled = True
        Me.cmbBrushSize.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32"})
        Me.cmbBrushSize.Location = New System.Drawing.Point(577, 480)
        Me.cmbBrushSize.Name = "cmbBrushSize"
        Me.cmbBrushSize.Size = New System.Drawing.Size(36, 21)
        Me.cmbBrushSize.TabIndex = 14
        Me.cmbBrushSize.Text = "6"
        '
        'lblBrushSize
        '
        Me.lblBrushSize.Location = New System.Drawing.Point(500, 483)
        Me.lblBrushSize.Name = "lblBrushSize"
        Me.lblBrushSize.Size = New System.Drawing.Size(71, 13)
        Me.lblBrushSize.TabIndex = 13
        Me.lblBrushSize.Text = "Brush Size:"
        Me.lblBrushSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblColorSelected
        '
        Me.lblColorSelected.AutoSize = True
        Me.lblColorSelected.Location = New System.Drawing.Point(501, 66)
        Me.lblColorSelected.Name = "lblColorSelected"
        Me.lblColorSelected.Size = New System.Drawing.Size(70, 13)
        Me.lblColorSelected.TabIndex = 12
        Me.lblColorSelected.Text = "Colour: Black"
        '
        'lblToolSelected
        '
        Me.lblToolSelected.AutoSize = True
        Me.lblToolSelected.Location = New System.Drawing.Point(501, 291)
        Me.lblToolSelected.Name = "lblToolSelected"
        Me.lblToolSelected.Size = New System.Drawing.Size(105, 13)
        Me.lblToolSelected.TabIndex = 11
        Me.lblToolSelected.Text = "Tool: None Selected"
        '
        'lblEllFill
        '
        Me.lblEllFill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEllFill.Image = CType(resources.GetObject("lblEllFill.Image"), System.Drawing.Image)
        Me.lblEllFill.Location = New System.Drawing.Point(540, 430)
        Me.lblEllFill.Name = "lblEllFill"
        Me.lblEllFill.Size = New System.Drawing.Size(36, 36)
        Me.lblEllFill.TabIndex = 10
        Me.lblEllFill.Tag = "EllipseFilled"
        '
        'LblEllOut
        '
        Me.LblEllOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblEllOut.Image = CType(resources.GetObject("LblEllOut.Image"), System.Drawing.Image)
        Me.LblEllOut.Location = New System.Drawing.Point(503, 430)
        Me.LblEllOut.Name = "LblEllOut"
        Me.LblEllOut.Size = New System.Drawing.Size(36, 36)
        Me.LblEllOut.TabIndex = 10
        Me.LblEllOut.Tag = "Ellipse"
        '
        'lblCircFill
        '
        Me.lblCircFill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCircFill.Image = CType(resources.GetObject("lblCircFill.Image"), System.Drawing.Image)
        Me.lblCircFill.Location = New System.Drawing.Point(577, 390)
        Me.lblCircFill.Name = "lblCircFill"
        Me.lblCircFill.Size = New System.Drawing.Size(36, 36)
        Me.lblCircFill.TabIndex = 10
        Me.lblCircFill.Tag = "CircFilled"
        '
        'lblCircOut
        '
        Me.lblCircOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCircOut.Image = CType(resources.GetObject("lblCircOut.Image"), System.Drawing.Image)
        Me.lblCircOut.Location = New System.Drawing.Point(540, 390)
        Me.lblCircOut.Name = "lblCircOut"
        Me.lblCircOut.Size = New System.Drawing.Size(36, 36)
        Me.lblCircOut.TabIndex = 10
        Me.lblCircOut.Tag = "Circ"
        '
        'lblRecFill
        '
        Me.lblRecFill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecFill.Image = CType(resources.GetObject("lblRecFill.Image"), System.Drawing.Image)
        Me.lblRecFill.Location = New System.Drawing.Point(503, 390)
        Me.lblRecFill.Name = "lblRecFill"
        Me.lblRecFill.Size = New System.Drawing.Size(36, 36)
        Me.lblRecFill.TabIndex = 10
        Me.lblRecFill.Tag = "RectFilled"
        '
        'lblRecOut
        '
        Me.lblRecOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecOut.Image = CType(resources.GetObject("lblRecOut.Image"), System.Drawing.Image)
        Me.lblRecOut.Location = New System.Drawing.Point(577, 350)
        Me.lblRecOut.Name = "lblRecOut"
        Me.lblRecOut.Size = New System.Drawing.Size(36, 36)
        Me.lblRecOut.TabIndex = 10
        Me.lblRecOut.Tag = "Rect"
        '
        'lblSqFill
        '
        Me.lblSqFill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSqFill.Image = CType(resources.GetObject("lblSqFill.Image"), System.Drawing.Image)
        Me.lblSqFill.Location = New System.Drawing.Point(540, 350)
        Me.lblSqFill.Name = "lblSqFill"
        Me.lblSqFill.Size = New System.Drawing.Size(36, 36)
        Me.lblSqFill.TabIndex = 10
        Me.lblSqFill.Tag = "SquareFilled"
        '
        'lblSqOut
        '
        Me.lblSqOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSqOut.Image = CType(resources.GetObject("lblSqOut.Image"), System.Drawing.Image)
        Me.lblSqOut.Location = New System.Drawing.Point(503, 350)
        Me.lblSqOut.Name = "lblSqOut"
        Me.lblSqOut.Size = New System.Drawing.Size(36, 36)
        Me.lblSqOut.TabIndex = 10
        Me.lblSqOut.Tag = "Square"
        '
        'lblText
        '
        Me.lblText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblText.Image = CType(resources.GetObject("lblText.Image"), System.Drawing.Image)
        Me.lblText.Location = New System.Drawing.Point(577, 310)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(36, 36)
        Me.lblText.TabIndex = 10
        Me.lblText.Tag = "Text"
        '
        'lblLine
        '
        Me.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLine.Image = CType(resources.GetObject("lblLine.Image"), System.Drawing.Image)
        Me.lblLine.Location = New System.Drawing.Point(540, 310)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(36, 36)
        Me.lblLine.TabIndex = 10
        Me.lblLine.Tag = "Line"
        '
        'lblBrush
        '
        Me.lblBrush.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBrush.Image = CType(resources.GetObject("lblBrush.Image"), System.Drawing.Image)
        Me.lblBrush.Location = New System.Drawing.Point(503, 310)
        Me.lblBrush.Name = "lblBrush"
        Me.lblBrush.Size = New System.Drawing.Size(36, 36)
        Me.lblBrush.TabIndex = 9
        Me.lblBrush.Tag = "Brush"
        '
        'lblColor
        '
        Me.lblColor.BackColor = System.Drawing.Color.Black
        Me.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColor.Location = New System.Drawing.Point(503, 233)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(110, 45)
        Me.lblColor.TabIndex = 8
        '
        'lblBlack
        '
        Me.lblBlack.BackColor = System.Drawing.Color.Black
        Me.lblBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBlack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBlack.Location = New System.Drawing.Point(504, 87)
        Me.lblBlack.Name = "lblBlack"
        Me.lblBlack.Size = New System.Drawing.Size(13, 13)
        Me.lblBlack.TabIndex = 5
        '
        'cmdFont
        '
        Me.cmdFont.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdFont.Location = New System.Drawing.Point(10, 12)
        Me.cmdFont.Name = "cmdFont"
        Me.cmdFont.Size = New System.Drawing.Size(97, 23)
        Me.cmdFont.TabIndex = 4
        Me.cmdFont.Text = "Format Text"
        Me.cmdFont.UseVisualStyleBackColor = True
        '
        'lblFontDetails
        '
        Me.lblFontDetails.AutoSize = True
        Me.lblFontDetails.Location = New System.Drawing.Point(420, 17)
        Me.lblFontDetails.Name = "lblFontDetails"
        Me.lblFontDetails.Size = New System.Drawing.Size(100, 13)
        Me.lblFontDetails.TabIndex = 3
        Me.lblFontDetails.Text = "(Arial 12pt, Regular)"
        '
        'txtInsertText
        '
        Me.txtInsertText.Location = New System.Drawing.Point(175, 14)
        Me.txtInsertText.Name = "txtInsertText"
        Me.txtInsertText.Size = New System.Drawing.Size(225, 20)
        Me.txtInsertText.TabIndex = 2
        '
        'lblEditText
        '
        Me.lblEditText.AutoSize = True
        Me.lblEditText.Location = New System.Drawing.Point(115, 17)
        Me.lblEditText.Name = "lblEditText"
        Me.lblEditText.Size = New System.Drawing.Size(60, 13)
        Me.lblEditText.TabIndex = 1
        Me.lblEditText.Text = "Insert Text:"
        '
        'pnlFrame
        '
        Me.pnlFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFrame.Controls.Add(Me.picCanvas)
        Me.pnlFrame.Location = New System.Drawing.Point(9, 49)
        Me.pnlFrame.Name = "pnlFrame"
        Me.pnlFrame.Size = New System.Drawing.Size(482, 482)
        Me.pnlFrame.TabIndex = 0
        '
        'picCanvas
        '
        Me.picCanvas.BackColor = System.Drawing.Color.Gray
        Me.picCanvas.Cursor = System.Windows.Forms.Cursors.Cross
        Me.picCanvas.Location = New System.Drawing.Point(0, 0)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(480, 480)
        Me.picCanvas.TabIndex = 0
        Me.picCanvas.TabStop = False
        '
        'frmDrawingBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 561)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.mnuDrawingBoard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuDrawingBoard
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(640, 600)
        Me.MinimumSize = New System.Drawing.Size(640, 600)
        Me.Name = "frmDrawingBoard"
        Me.Text = "Helios DrawingBoard 2.0"
        Me.mnuDrawingBoard.ResumeLayout(False)
        Me.mnuDrawingBoard.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.pnlFrame.ResumeLayout(False)
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuDrawingBoard As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents dlgFont As FontDialog
    Friend WithEvents sfdSavePic As SaveFileDialog
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlFrame As Panel
    Friend WithEvents picCanvas As PictureBox
    Friend WithEvents lblFontDetails As Label
    Friend WithEvents txtInsertText As TextBox
    Friend WithEvents lblEditText As Label
    Friend WithEvents cmdFont As Button
    Friend WithEvents lblBlack As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblEllFill As Label
    Friend WithEvents LblEllOut As Label
    Friend WithEvents lblCircFill As Label
    Friend WithEvents lblCircOut As Label
    Friend WithEvents lblRecFill As Label
    Friend WithEvents lblRecOut As Label
    Friend WithEvents lblSqFill As Label
    Friend WithEvents lblSqOut As Label
    Friend WithEvents lblText As Label
    Friend WithEvents lblLine As Label
    Friend WithEvents lblBrush As Label
    Friend WithEvents cmbPenWidth As ComboBox
    Friend WithEvents lblPenWidth As Label
    Friend WithEvents cmbBrushSize As ComboBox
    Friend WithEvents lblBrushSize As Label
    Friend WithEvents lblColorSelected As Label
    Friend WithEvents lblToolSelected As Label
    Friend WithEvents lblPink As Label
    Friend WithEvents lblViolet As Label
    Friend WithEvents lblFuchsia As Label
    Friend WithEvents lblMediumVioletRed As Label
    Friend WithEvents lblPurple As Label
    Friend WithEvents lblIndigo As Label
    Friend WithEvents lblMediumPurple As Label
    Friend WithEvents lblPaleGreen As Label
    Friend WithEvents lblSlateBlue As Label
    Friend WithEvents lblPapayaWhip As Label
    Friend WithEvents lblPaleTurquoise As Label
    Friend WithEvents lblLightGreen As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblNavajoWhite As Label
    Friend WithEvents lblAqua As Label
    Friend WithEvents lblLightYellow As Label
    Friend WithEvents lblMediumBlue As Label
    Friend WithEvents lblLime As Label
    Friend WithEvents lblCyan As Label
    Friend WithEvents lblMistyRose As Label
    Friend WithEvents lblNavy As Label
    Friend WithEvents lblPaleGoldenrod As Label
    Friend WithEvents lblTurquoise As Label
    Friend WithEvents lblMidnightBlue As Label
    Friend WithEvents lblOrange As Label
    Friend WithEvents lblTeal As Label
    Friend WithEvents lblLimeGreen As Label
    Friend WithEvents lblSeaGreen As Label
    Friend WithEvents lblSalmon As Label
    Friend WithEvents lblYellow As Label
    Friend WithEvents lblChocolate As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblRed As Label
    Friend WithEvents lblGoldenRod As Label
    Friend WithEvents lblSienna As Label
    Friend WithEvents lblDarkGreen As Label
    Friend WithEvents lblFirebrick As Label
    Friend WithEvents lblOlive As Label
    Friend WithEvents lblGray As Label
    Friend WithEvents lblDarkGoldenrod As Label
    Friend WithEvents lblMaroon As Label
    Friend WithEvents lblDimGray As Label
    Friend WithEvents lblWhite As Label
    Friend WithEvents lblGainsboro As Label
    Friend WithEvents lblSilver As Label
    Friend WithEvents lblDarkRed As Label
    Friend WithEvents lblSaddleBrown As Label
End Class
