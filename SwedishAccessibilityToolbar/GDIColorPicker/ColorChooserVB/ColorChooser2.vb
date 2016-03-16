Public Class ColorChooser2
  Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

  Public Sub New()
    MyBase.New()

    'This call is required by the Windows Form Designer.
    InitializeComponent()

    'Add any initialization after the InitializeComponent() call

  End Sub

  'Form overrides dispose to clean up the component list.
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing Then
      If Not (components Is Nothing) Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents pnlColor As System.Windows.Forms.Panel
  Friend WithEvents pnlBrightness As System.Windows.Forms.Panel
  Friend WithEvents pnlSelectedColor As System.Windows.Forms.Panel
  Friend WithEvents btnOK As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents hsbHue As System.Windows.Forms.HScrollBar
  Friend WithEvents hsbSaturation As System.Windows.Forms.HScrollBar
  Friend WithEvents hsbBrightness As System.Windows.Forms.HScrollBar
  Friend WithEvents hsbRed As System.Windows.Forms.HScrollBar
  Friend WithEvents hsbGreen As System.Windows.Forms.HScrollBar
  Friend WithEvents hsbBlue As System.Windows.Forms.HScrollBar
  Friend WithEvents lblHue As System.Windows.Forms.Label
  Friend WithEvents lblSaturation As System.Windows.Forms.Label
  Friend WithEvents lblBrightness As System.Windows.Forms.Label
  Friend WithEvents lblBlue As System.Windows.Forms.Label
  Friend WithEvents lblGreen As System.Windows.Forms.Label
  Friend WithEvents lblRed As System.Windows.Forms.Label
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.pnlColor = New System.Windows.Forms.Panel()
    Me.pnlBrightness = New System.Windows.Forms.Panel()
    Me.pnlSelectedColor = New System.Windows.Forms.Panel()
    Me.btnOK = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.hsbHue = New System.Windows.Forms.HScrollBar()
    Me.hsbSaturation = New System.Windows.Forms.HScrollBar()
    Me.hsbBrightness = New System.Windows.Forms.HScrollBar()
    Me.hsbRed = New System.Windows.Forms.HScrollBar()
    Me.hsbGreen = New System.Windows.Forms.HScrollBar()
    Me.hsbBlue = New System.Windows.Forms.HScrollBar()
    Me.lblHue = New System.Windows.Forms.Label()
    Me.lblSaturation = New System.Windows.Forms.Label()
    Me.lblBrightness = New System.Windows.Forms.Label()
    Me.lblBlue = New System.Windows.Forms.Label()
    Me.lblGreen = New System.Windows.Forms.Label()
    Me.lblRed = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(8, 312)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(72, 18)
    Me.Label1.TabIndex = 7
    Me.Label1.Text = "Red"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label2
    '
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(8, 336)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(72, 18)
    Me.Label2.TabIndex = 8
    Me.Label2.Text = "Green"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label3
    '
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(8, 360)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(72, 18)
    Me.Label3.TabIndex = 9
    Me.Label3.Text = "Blue"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label5
    '
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(8, 232)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(72, 18)
    Me.Label5.TabIndex = 12
    Me.Label5.Text = "Hue"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label6
    '
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(8, 256)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(72, 18)
    Me.Label6.TabIndex = 13
    Me.Label6.Text = "Saturation"
    Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label7
    '
    Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(8, 280)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(72, 18)
    Me.Label7.TabIndex = 14
    Me.Label7.Text = "Brightness"
    Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'pnlColor
    '
    Me.pnlColor.Location = New System.Drawing.Point(8, 8)
    Me.pnlColor.Name = "pnlColor"
    Me.pnlColor.Size = New System.Drawing.Size(224, 216)
    Me.pnlColor.TabIndex = 15
    Me.pnlColor.Visible = False
    '
    'pnlBrightness
    '
    Me.pnlBrightness.Location = New System.Drawing.Point(240, 8)
    Me.pnlBrightness.Name = "pnlBrightness"
    Me.pnlBrightness.Size = New System.Drawing.Size(24, 216)
    Me.pnlBrightness.TabIndex = 16
    Me.pnlBrightness.Visible = False
    '
    'pnlSelectedColor
    '
    Me.pnlSelectedColor.Location = New System.Drawing.Point(296, 72)
    Me.pnlSelectedColor.Name = "pnlSelectedColor"
    Me.pnlSelectedColor.Size = New System.Drawing.Size(64, 24)
    Me.pnlSelectedColor.TabIndex = 17
    Me.pnlSelectedColor.Visible = False
    '
    'btnOK
    '
    Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnOK.Location = New System.Drawing.Point(296, 8)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(64, 24)
    Me.btnOK.TabIndex = 18
    Me.btnOK.Text = "OK"
    '
    'btnCancel
    '
    Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancel.Location = New System.Drawing.Point(296, 40)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(64, 24)
    Me.btnCancel.TabIndex = 19
    Me.btnCancel.Text = "Cancel"
    '
    'hsbHue
    '
    Me.hsbHue.LargeChange = 1
    Me.hsbHue.Location = New System.Drawing.Point(80, 232)
    Me.hsbHue.Maximum = 255
    Me.hsbHue.Name = "hsbHue"
    Me.hsbHue.Size = New System.Drawing.Size(224, 18)
    Me.hsbHue.TabIndex = 20
    '
    'hsbSaturation
    '
    Me.hsbSaturation.LargeChange = 1
    Me.hsbSaturation.Location = New System.Drawing.Point(80, 256)
    Me.hsbSaturation.Maximum = 255
    Me.hsbSaturation.Name = "hsbSaturation"
    Me.hsbSaturation.Size = New System.Drawing.Size(224, 18)
    Me.hsbSaturation.TabIndex = 21
    '
    'hsbBrightness
    '
    Me.hsbBrightness.LargeChange = 1
    Me.hsbBrightness.Location = New System.Drawing.Point(80, 280)
    Me.hsbBrightness.Maximum = 255
    Me.hsbBrightness.Name = "hsbBrightness"
    Me.hsbBrightness.Size = New System.Drawing.Size(224, 18)
    Me.hsbBrightness.TabIndex = 22
    '
    'hsbRed
    '
    Me.hsbRed.LargeChange = 1
    Me.hsbRed.Location = New System.Drawing.Point(80, 312)
    Me.hsbRed.Maximum = 255
    Me.hsbRed.Name = "hsbRed"
    Me.hsbRed.Size = New System.Drawing.Size(224, 18)
    Me.hsbRed.TabIndex = 23
    '
    'hsbGreen
    '
    Me.hsbGreen.LargeChange = 1
    Me.hsbGreen.Location = New System.Drawing.Point(80, 336)
    Me.hsbGreen.Maximum = 255
    Me.hsbGreen.Name = "hsbGreen"
    Me.hsbGreen.Size = New System.Drawing.Size(224, 18)
    Me.hsbGreen.TabIndex = 24
    '
    'hsbBlue
    '
    Me.hsbBlue.LargeChange = 1
    Me.hsbBlue.Location = New System.Drawing.Point(80, 360)
    Me.hsbBlue.Maximum = 255
    Me.hsbBlue.Name = "hsbBlue"
    Me.hsbBlue.Size = New System.Drawing.Size(224, 18)
    Me.hsbBlue.TabIndex = 25
    '
    'lblHue
    '
    Me.lblHue.Location = New System.Drawing.Point(312, 232)
    Me.lblHue.Name = "lblHue"
    Me.lblHue.Size = New System.Drawing.Size(40, 23)
    Me.lblHue.TabIndex = 26
    Me.lblHue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblSaturation
    '
    Me.lblSaturation.Location = New System.Drawing.Point(312, 256)
    Me.lblSaturation.Name = "lblSaturation"
    Me.lblSaturation.Size = New System.Drawing.Size(40, 23)
    Me.lblSaturation.TabIndex = 27
    Me.lblSaturation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblBrightness
    '
    Me.lblBrightness.Location = New System.Drawing.Point(312, 280)
    Me.lblBrightness.Name = "lblBrightness"
    Me.lblBrightness.Size = New System.Drawing.Size(40, 23)
    Me.lblBrightness.TabIndex = 28
    Me.lblBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblBlue
    '
    Me.lblBlue.Location = New System.Drawing.Point(312, 360)
    Me.lblBlue.Name = "lblBlue"
    Me.lblBlue.Size = New System.Drawing.Size(40, 23)
    Me.lblBlue.TabIndex = 31
    Me.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblGreen
    '
    Me.lblGreen.Location = New System.Drawing.Point(312, 336)
    Me.lblGreen.Name = "lblGreen"
    Me.lblGreen.Size = New System.Drawing.Size(40, 23)
    Me.lblGreen.TabIndex = 30
    Me.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblRed
    '
    Me.lblRed.Location = New System.Drawing.Point(312, 312)
    Me.lblRed.Name = "lblRed"
    Me.lblRed.Size = New System.Drawing.Size(40, 23)
    Me.lblRed.TabIndex = 29
    Me.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ColorChooser2
    '
    Me.AcceptButton = Me.btnOK
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
    Me.CancelButton = Me.btnCancel
    Me.ClientSize = New System.Drawing.Size(370, 388)
    Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblBlue, Me.lblGreen, Me.lblRed, Me.lblBrightness, Me.lblSaturation, Me.lblHue, Me.hsbBlue, Me.hsbGreen, Me.hsbRed, Me.hsbBrightness, Me.hsbSaturation, Me.hsbHue, Me.btnCancel, Me.btnOK, Me.Label3, Me.Label7, Me.pnlColor, Me.Label6, Me.Label1, Me.Label5, Me.pnlSelectedColor, Me.pnlBrightness, Me.Label2})
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "ColorChooser2"
    Me.Text = "Select Color"
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private Enum ChangeStyle
    MouseMove
    RGB
    HSV
    None
  End Enum

  Private changeType As ChangeStyle = ChangeStyle.None
  Private selectedPoint As Point
  Private WithEvents myColorWheel As ColorWheel

  Private RGB As ColorHandler.RGB
  Private HSV As ColorHandler.HSV

  Private Sub frmMain_Load( _
   ByVal sender As System.Object, ByVal e As System.EventArgs) _
   Handles MyBase.Load

    ' Turn on double-buffering, so the form looks better. 
    Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
    Me.SetStyle(ControlStyles.UserPaint, True)
    Me.SetStyle(ControlStyles.DoubleBuffer, True)

    ' These properties are set in design view, as well, but they
    ' have to be set to False in order for the Paint
    ' event to be able to display their contents.
    ' Never hurts to make sure they're invisible.
    pnlSelectedColor.Visible = False
    pnlBrightness.Visible = False
    pnlColor.Visible = False

    ' Calculate the coordinates of the three
    ' required regions on the form.
    Dim SelectedColorRectangle As Rectangle = _
     New Rectangle(pnlSelectedColor.Location, pnlSelectedColor.Size)
    Dim BrightnessRectangle As Rectangle = _
     New Rectangle(pnlBrightness.Location, pnlBrightness.Size)
    Dim ColorRectangle As Rectangle = _
     New Rectangle(pnlColor.Location, pnlColor.Size)

    ' Create the new ColorWheel class, indicating
    ' the locations of the color wheel itself, the
    ' brightness area, and the position of the selected color.
    myColorWheel = New ColorWheel( _
     ColorRectangle, BrightnessRectangle, _
     SelectedColorRectangle)

    ' Set the RGB and HSV values 
    ' of the NumericUpDown controls.
    SetRGB(RGB)
    SetHSV(HSV)
  End Sub

  Private Sub HandleMouse( _
   ByVal sender As Object, ByVal e As MouseEventArgs) _
   Handles MyBase.MouseMove, MyBase.MouseDown

    ' If you have the left mouse button down, 
    ' then update the selectedPoint value and 
    ' force a repaint of the color wheel.
    If e.Button = MouseButtons.Left Then
      changeType = ChangeStyle.MouseMove
      selectedPoint = New Point(e.X, e.Y)
      Me.Invalidate()
    End If
  End Sub

  Private Sub frmMain_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
    myColorWheel.SetMouseUp()
    changeType = ChangeStyle.None
  End Sub

  Private Sub SetRGBLabels(ByVal RGB As ColorHandler.RGB)
    RefreshText(lblRed, RGB.Red)
    RefreshText(lblBlue, RGB.Blue)
    RefreshText(lblGreen, RGB.Green)
  End Sub

  Private Sub SetHSVLabels(ByVal HSV As ColorHandler.HSV)
    RefreshText(lblHue, HSV.Hue)
    RefreshText(lblSaturation, HSV.Saturation)
    RefreshText(lblBrightness, HSV.Value)
  End Sub

  Private Sub SetRGB(ByVal RGB As ColorHandler.RGB)
    ' Update the RGB values on the form.
    RefreshValue(hsbRed, RGB.Red)
    RefreshValue(hsbBlue, RGB.Blue)
    RefreshValue(hsbGreen, RGB.Green)
    SetRGBLabels(RGB)
  End Sub

  Private Sub SetHSV(ByVal HSV As ColorHandler.HSV)
    ' Update the HSV values on the form.
    RefreshValue(hsbHue, HSV.Hue)
    RefreshValue(hsbSaturation, HSV.Saturation)
    RefreshValue(hsbBrightness, HSV.Value)
    SetHSVLabels(HSV)
  End Sub

  Private Sub RefreshValue( _
   ByVal hsb As HScrollBar, ByVal Value As Integer)
    hsb.Value = Value
  End Sub

  Private Sub RefreshText( _
   ByVal lbl As Label, ByVal Value As Integer)
    lbl.Text = Value.ToString
  End Sub

  Public Property Color() As Color
    ' Get or set the color to be
    ' displayed in the color wheel.
    Get
      Return myColorWheel.Color
    End Get

    Set(ByVal Value As Color)
      ' Indicate the color change type. Either RGB or HSV
      ' will cause the color wheel to update the position
      ' of the pointer.
      changeType = ChangeStyle.RGB
      RGB = New ColorHandler.RGB(Value.R, Value.G, Value.B)
      HSV = ColorHandler.RGBtoHSV(RGB)
    End Set
  End Property

  Private Sub myColorWheel_ColorChanged( _
   ByVal sender As Object, ByVal e As ColorChangedEventArgs) _
   Handles myColorWheel.ColorChanged
    SetRGB(e.RGB)
    SetHSV(e.HSV)
  End Sub

  Private Sub HandleHSVScroll(ByVal sender As Object, ByVal e As ScrollEventArgs) _
   Handles hsbHue.Scroll, hsbSaturation.Scroll, hsbBrightness.Scroll
    ' If the H, S, or V values change, use this 
    ' code to update the RGB values and invalidate
    ' the color wheel (so it updates the pointers).
    ' Check the isInUpdate flag to avoid recursive events
    ' when you update the NumericUpdownControls.
    changeType = ChangeStyle.HSV
    HSV = New ColorHandler.HSV(CInt(hsbHue.Value), _
     CInt(hsbSaturation.Value), CInt(hsbBrightness.Value))
    SetRGB(ColorHandler.HSVtoRGB(HSV))
    SetHSVLabels(HSV)
    Me.Invalidate()
  End Sub

  Private Sub HandleRGBScroll(ByVal sender As Object, ByVal e As ScrollEventArgs) _
   Handles hsbRed.Scroll, hsbBlue.Scroll, hsbGreen.Scroll
    ' If the R, G, or B values change, use this 
    ' code to update the HSV values and invalidate
    ' the color wheel (so it updates the pointers).
    ' Check the isInUpdate flag to avoid recursive events
    ' when you update the NumericUpdownControls.
    changeType = ChangeStyle.RGB
    RGB = New ColorHandler.RGB(CInt(hsbRed.Value), _
     CInt(hsbGreen.Value), CInt(hsbBlue.Value))
    SetHSV(ColorHandler.RGBtoHSV(RGB))
    SetRGBLabels(RGB)
    Me.Invalidate()
  End Sub

  Private Sub ColorChooser2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
    ' Depending on the circumstances, force a repaint
    ' of the color wheel passing different information.
    Select Case changeType
      Case ChangeStyle.HSV
        myColorWheel.Draw(e.Graphics, HSV)
      Case ChangeStyle.MouseMove, ChangeStyle.None
        myColorWheel.Draw(e.Graphics, selectedPoint)
      Case ChangeStyle.RGB
        myColorWheel.Draw(e.Graphics, RGB)
    End Select
  End Sub
End Class
