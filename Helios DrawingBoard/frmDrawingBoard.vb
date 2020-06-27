Public Class frmDrawingBoard
    Dim G As Drawing.Graphics
    Dim drawFlag As Boolean = False
    Dim xDown, yDown, xUp, yUp As Integer
    Dim intL, intR, intT, intB, intW, intH As Integer
    Dim clrSelected As Color = Color.Black
    Dim intToolSelected As Integer = 0
    Dim intBrushSize As Integer = 6

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        pnlMain.Enabled = True
        picCanvas.BackColor = Color.White
        bmpPic = New Bitmap(picCanvas.Width, picCanvas.Height)
        picCanvas.Image = bmpPic
        G = Graphics.FromImage(bmpPic)
        picCanvas.DrawToBitmap(bmpPic, picCanvas.ClientRectangle)
    End Sub

    Dim intPenWidth As Integer = 2
    Dim intFontSize As Integer = 12
    Dim strText As String

    Private Sub cmbBrushSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBrushSize.SelectedIndexChanged

    End Sub

    Dim strFont As String = "Arial"
    Dim styFontStyle As FontStyle

    Private Sub cmdFont_Click(sender As Object, e As EventArgs) Handles cmdFont.Click
        dlgFont.ShowDialog()
        strFont = dlgFont.Font.Name
        styFontStyle = dlgFont.Font.Style
        intFontSize = dlgFont.Font.Size
        lblFontDetails.Text = "(" & strFont & " " & intFontSize & "pt, " & strFontStyleArray(styFontStyle) & ")"
    End Sub

    Dim strFontStyleArray() As String = {"Regular", "Bold", "Italic", "Bold Italic", "Unknown",
  "Unknown", "Unknown", "Unknown", "Regular Strikeout", "Bold Strikeout",
    "Italic Strikeout", "Bold Italic Strikeout", "Regular Underline Strikeout",
      "Bold Underline Strikeout", "Italic Underline Strikeout",
        "Bold Italic Underline Strikeout"}
    Dim bmpPic As Bitmap

    Private Sub lblPalette_Click(sender As Object, e As EventArgs) _
  Handles lblBlack.Click, lblDimGray.Click, lblGray.Click, lblSilver.Click, lblGainsboro.Click, lblWhite.Click, lblMaroon.Click, lblDarkRed.Click, lblFirebrick.Click, lblRed.Click, lblSalmon.Click, lblMistyRose.Click, lblSaddleBrown.Click, lblSienna.Click, lblChocolate.Click, lblOrange.Click, lblNavajoWhite.Click, lblPapayaWhip.Click, lblOlive.Click, lblDarkGoldenrod.Click, lblGoldenRod.Click, lblYellow.Click, lblPaleGoldenrod.Click, lblLightYellow.Click, lblDarkGreen.Click, lblGreen.Click, lblLimeGreen.Click, lblLime.Click, lblLightGreen.Click, lblPaleGreen.Click, lblSeaGreen.Click, lblTeal.Click, lblTurquoise.Click, lblCyan.Click, lblAqua.Click, lblPaleTurquoise.Click, lblMidnightBlue.Click, lblNavy.Click, lblMediumBlue.Click, lblBlue.Click, lblSlateBlue.Click, lblMediumPurple.Click, lblIndigo.Click, lblPurple.Click, lblMediumVioletRed.Click, lblFuchsia.Click, lblViolet.Click, lblPink.Click
        lblColor.BackColor = sender.BackColor
        clrSelected = sender.BackColor
        Select Case clrSelected
            Case Color.Black
                lblColorSelected.Text = "Colour: Black"
            Case Color.DimGray
                lblColorSelected.Text = "Colour: Dim Grey"
            Case Color.Gray
                lblColorSelected.Text = "Colour: Grey"
            Case Color.Silver
                lblColorSelected.Text = "Colour: Silver"
            Case Color.Gainsboro
                lblColorSelected.Text = "Colour: Gainsboro"
            Case Color.White
                lblColorSelected.Text = "Colour: White"
            Case Color.Maroon
                lblColorSelected.Text = "Colour: Maroon"
            Case Color.DarkRed
                lblColorSelected.Text = "Colour: Dark Red"
            Case Color.Firebrick
                lblColorSelected.Text = "Colour: Firebrick"
            Case Color.Red
                lblColorSelected.Text = "Colour: Red"
            Case Color.Salmon
                lblColorSelected.Text = "Colour: Salmon"
            Case Color.MistyRose
                lblColorSelected.Text = "Colour: Misty Rose"
            Case Color.SaddleBrown
                lblColorSelected.Text = "Colour: Saddle Brown"
            Case Color.Sienna
                lblColorSelected.Text = "Colour: Sienna"
            Case Color.Chocolate
                lblColorSelected.Text = "Colour: Chocolate"
            Case Color.Orange
                lblColorSelected.Text = "Colour: Orange"
            Case Color.NavajoWhite
                lblColorSelected.Text = "Colour: Navajo White"
            Case Color.PapayaWhip
                lblColorSelected.Text = "Colour: Papaya Whip"
            Case Color.Olive
                lblColorSelected.Text = "Colour: Olive"
            Case Color.DarkGoldenrod
                lblColorSelected.Text = "Colour: Dark Goldenrod"
            Case Color.Goldenrod
                lblColorSelected.Text = "Colour: Goldenrod"
            Case Color.Yellow
                lblColorSelected.Text = "Colour: Yellow"
            Case Color.PaleGoldenrod
                lblColorSelected.Text = "Colour: Pale Goldenrod"
            Case Color.LightYellow
                lblColorSelected.Text = "Colour: Light Yellow"
            Case Color.DarkGreen
                lblColorSelected.Text = "Colour: Dark Green"
            Case Color.Green
                lblColorSelected.Text = "Colour: Green"
            Case Color.LimeGreen
                lblColorSelected.Text = "Colour: Dark Lime"
            Case Color.Lime
                lblColorSelected.Text = "Colour: Lime"
            Case Color.LightGreen
                lblColorSelected.Text = "Colour: Light Green"
            Case Color.PaleGreen
                lblColorSelected.Text = "Colour: Pale Green"
            Case Color.SeaGreen
                lblColorSelected.Text = "Colour: Sea Green"
            Case Color.Teal
                lblColorSelected.Text = "Colour: Teal"
            Case Color.Turquoise
                lblColorSelected.Text = "Colour: Turquoise"
            Case Color.Cyan
                lblColorSelected.Text = "Colour: Cyan"
            Case Color.Aqua
                lblColorSelected.Text = "Colour: Aqua"
            Case Color.PaleTurquoise
                lblColorSelected.Text = "Colour: Pale Turquoise"
            Case Color.MidnightBlue
                lblColorSelected.Text = "Colour: Midnight Blue"
            Case Color.Navy
                lblColorSelected.Text = "Colour: Navy"
            Case Color.MediumBlue
                lblColorSelected.Text = "Colour: Medium Blue"
            Case Color.Blue
                lblColorSelected.Text = "Colour: Blue"
            Case Color.SlateBlue
                lblColorSelected.Text = "Colour: Slate Blue"
            Case Color.MediumPurple
                lblColorSelected.Text = "Colour: Light Blue"
            Case Color.Indigo
                lblColorSelected.Text = "Colour: Indigo"
            Case Color.Purple
                lblColorSelected.Text = "Colour: Purple"
            Case Color.MediumVioletRed
                lblColorSelected.Text = "Colour: Mauve"
            Case Color.Fuchsia
                lblColorSelected.Text = "Colour: Fuchsia"
            Case Color.Violet
                lblColorSelected.Text = "Colour: Violet"
            Case Color.Pink
                lblColorSelected.Text = "Colour: Pink"
        End Select
    End Sub

    Private Sub lblTool_Click(sender As Object, e As EventArgs) _
  Handles lblBrush.Click, lblLine.Click, lblText.Click, lblSqOut.Click,
    lblSqFill.Click, lblRecOut.Click, lblRecFill.Click, lblCircOut.Click,
      lblCircFill.Click, LblEllOut.Click, lblEllFill.Click
        resetTools()
        Select Case sender.Tag
            Case "Brush"
                intToolSelected = 1
                lblBrush.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Brush"
            Case "Line"
                intToolSelected = 2
                lblLine.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Line"
            Case "Text"
                intToolSelected = 3
                lblText.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Text"
            Case "Square"
                intToolSelected = 4
                lblSqOut.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Square Outlined"
            Case "SquareFilled"
                intToolSelected = 5
                lblSqFill.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Square Filled"
            Case "Rect"
                intToolSelected = 6
                lblRecOut.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Rectangle Outlined"
            Case "RectFilled"
                intToolSelected = 7
                lblRecFill.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Rectangle Filled"
            Case "Circ"
                intToolSelected = 8
                lblCircOut.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Circle Outlined"
            Case "CircFilled"
                intToolSelected = 9
                lblCircFill.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Circle Filled"
            Case "Ellipse"
                intToolSelected = 10
                LblEllOut.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Ellipse Outlined"
            Case "EllipseFilled"
                intToolSelected = 11
                lblEllFill.BorderStyle = BorderStyle.FixedSingle
                lblToolSelected.Text = "Tool: Ellipse Filled"
        End Select
    End Sub

    Sub resetTools()
        lblBrush.BorderStyle = BorderStyle.Fixed3D
        lblLine.BorderStyle = BorderStyle.Fixed3D
        lblText.BorderStyle = BorderStyle.Fixed3D
        lblSqOut.BorderStyle = BorderStyle.Fixed3D
        lblSqFill.BorderStyle = BorderStyle.Fixed3D
        lblRecOut.BorderStyle = BorderStyle.Fixed3D
        lblRecFill.BorderStyle = BorderStyle.Fixed3D
        lblCircFill.BorderStyle = BorderStyle.Fixed3D
        lblCircFill.BorderStyle = BorderStyle.Fixed3D
        LblEllOut.BorderStyle = BorderStyle.Fixed3D
        lblEllFill.BorderStyle = BorderStyle.Fixed3D
    End Sub


    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub cmbBrushSize_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbBrushSize.SelectedValueChanged
        intBrushSize = CInt(cmbBrushSize.Text)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        sfdSavePic.Filter = "Bitmap |*.bmp"
        If sfdSavePic.ShowDialog = DialogResult.OK Then
            picCanvas.Image.Save(sfdSavePic.FileName, Drawing.Imaging.ImageFormat.Bmp)
            MsgBox("File saved.")
        End If
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        End
    End Sub

    Private Sub frmDrawingBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbPenWidth_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPenWidth.SelectedValueChanged
        intPenWidth = CInt(cmbPenWidth.Text)
    End Sub

    Private Sub picCanvas_MouseDown(sender As Object, e As MouseEventArgs) Handles picCanvas.MouseDown
        drawFlag = True
        xDown = e.X
        yDown = e.Y
    End Sub

    Private Sub picCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles picCanvas.MouseMove
        If intToolSelected = 1 And drawFlag = True Then
            xDown = e.X
            yDown = e.Y
            G.FillEllipse(New SolidBrush(clrSelected), xDown, yDown, intBrushSize, intBrushSize)
            picCanvas.Refresh()
        End If
    End Sub

    Sub dimSquare()
        If xUp < 0 Then xUp = 0
        If xUp > 480 Then xUp = 480
        If yUp < 0 Then yUp = 0
        If yUp > 480 Then yUp = 480
        intW = Math.Abs(xUp - xDown)
        intH = Math.Abs(yUp - yDown)
        If intW > intH Then intW = intH
        If xUp < xDown Then intL = xDown - intW Else intL = xDown
        If yUp < yDown Then intT = yDown - intW Else intT = yDown
    End Sub

    Sub dimRectangle()
        If xUp < 0 Then xUp = 0
        If xUp > 480 Then xUp = 480
        If yUp < 0 Then yUp = 0
        If yUp > 480 Then yUp = 480
        intW = Math.Abs(xUp - xDown)
        intH = Math.Abs(yUp - yDown)
        If xUp < xDown Then intL = xDown - intW Else intL = xDown
        If yUp < yDown Then intT = yDown - intH Else intT = yDown
    End Sub

    Sub dimCircle()
        If xUp < 0 Then xUp = 0
        If xUp > 480 Then xUp = 480
        If yUp < 0 Then yUp = 0
        If yUp > 480 Then yUp = 480
        intW = Math.Abs(xUp - xDown)
        intH = Math.Abs(yUp - yDown)
        If intW < intH Then intW = intH
        intL = xDown - intW
        intT = yDown - intW
        intW *= 2
    End Sub

    Sub dimEllipse()
        If xUp < 0 Then xUp = 0
        If xUp > 480 Then xUp = 480
        If yUp < 0 Then yUp = 0
        If yUp > 480 Then yUp = 480
        intW = Math.Abs(xUp - xDown)
        intH = Math.Abs(yUp - yDown)
        intL = xDown - intW
        intT = yDown - intH
        intW *= 2
        intH *= 2
    End Sub

    Private Sub picCanvas_MouseUp(sender As Object, e As MouseEventArgs) Handles picCanvas.MouseUp
        Dim brushFill As SolidBrush = New Drawing.SolidBrush(clrSelected)
        Dim penLine As New Pen(clrSelected, intPenWidth)

        drawFlag = False
        xUp = e.X
        yUp = e.Y

        Select Case intToolSelected
            Case 2
                G.DrawLine(penLine, xDown, yDown, xUp, yUp)
            Case 3
                strText = txtInsertText.Text
                G.DrawString(strText, New System.Drawing.Font(strFont, intFontSize, styFontStyle),
                brushFill, xUp, yUp)
            Case 4
                dimSquare()
                G.DrawRectangle(penLine, intL, intT, intW, intW)
            Case 5
                dimSquare()
                G.FillRectangle(brushFill, intL, intT, intW, intW)
            Case 6
                dimRectangle()
                G.DrawRectangle(penLine, intL, intT, intW, intH)
            Case 7
                dimRectangle()
                G.FillRectangle(brushFill, intL, intT, intW, intH)
            Case 8
                dimCircle()
                G.DrawEllipse(penLine, intL, intT, intW, intW)
            Case 9
                dimCircle()
                G.FillEllipse(brushFill, intL, intT, intW, intW)
            Case 10
                dimEllipse()
                G.DrawEllipse(penLine, intL, intT, intW, intH)
            Case 11
                dimEllipse()
                G.FillEllipse(brushFill, intL, intT, intW, intH)
        End Select
        picCanvas.Refresh()
    End Sub
End Class
