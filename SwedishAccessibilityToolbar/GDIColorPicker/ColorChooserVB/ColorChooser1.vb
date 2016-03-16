Public Class ColorChooser1
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
  Friend WithEvents nudRed As System.Windows.Forms.NumericUpDown
  Friend WithEvents nudGreen As System.Windows.Forms.NumericUpDown
  Friend WithEvents nudBlue As System.Windows.Forms.NumericUpDown
  Friend WithEvents nudHue As System.Windows.Forms.NumericUpDown
  Friend WithEvents nudSaturation As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents nudBrightness As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents pnlColor As System.Windows.Forms.Panel
  Friend WithEvents pnlBrightness As System.Windows.Forms.Panel
  Friend WithEvents pnlSelectedColor As System.Windows.Forms.Panel
  Friend WithEvents btnOK As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.nudRed = New System.Windows.Forms.NumericUpDown()
    Me.nudGreen = New System.Windows.Forms.NumericUpDown()
    Me.nudBlue = New System.Windows.Forms.NumericUpDown()
    Me.nudHue = New System.Windows.Forms.NumericUpDown()
    Me.nudSaturation = New System.Windows.Forms.NumericUpDown()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.nudBrightness = New System.Windows.Forms.NumericUpDown()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.pnlColor = New System.Windows.Forms.Panel()
    Me.pnlBrightness = New System.Windows.Forms.Panel()
    Me.pnlSelectedColor = New System.Windows.Forms.Panel()
    Me.btnOK = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    CType(Me.nudRed, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudGreen, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudBlue, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudHue, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudSaturation, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudBrightness, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'nudRed
    '
    Me.nudRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudRed.Location = New System.Drawing.Point(208, 240)
    Me.nudRed.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.nudRed.Name = "nudRed"
    Me.nudRed.Size = New System.Drawing.Size(48, 22)
    Me.nudRed.TabIndex = 2
    '
    'nudGreen
    '
    Me.nudGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudGreen.Location = New System.Drawing.Point(208, 264)
    Me.nudGreen.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.nudGreen.Name = "nudGreen"
    Me.nudGreen.Size = New System.Drawing.Size(48, 22)
    Me.nudGreen.TabIndex = 3
    '
    'nudBlue
    '
    Me.nudBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudBlue.Location = New System.Drawing.Point(208, 288)
    Me.nudBlue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.nudBlue.Name = "nudBlue"
    Me.nudBlue.Size = New System.Drawing.Size(48, 22)
    Me.nudBlue.TabIndex = 4
    '
    'nudHue
    '
    Me.nudHue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudHue.Location = New System.Drawing.Point(96, 240)
    Me.nudHue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.nudHue.Name = "nudHue"
    Me.nudHue.Size = New System.Drawing.Size(48, 22)
    Me.nudHue.TabIndex = 5
    '
    'nudSaturation
    '
    Me.nudSaturation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudSaturation.Location = New System.Drawing.Point(96, 264)
    Me.nudSaturation.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.nudSaturation.Name = "nudSaturation"
    Me.nudSaturation.Size = New System.Drawing.Size(48, 22)
    Me.nudSaturation.TabIndex = 6
    '
    'Label1
    '
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(152, 240)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(48, 23)
    Me.Label1.TabIndex = 7
    Me.Label1.Text = "Red:"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label2
    '
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(152, 264)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(48, 23)
    Me.Label2.TabIndex = 8
    Me.Label2.Text = "Green:"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label3
    '
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(152, 288)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(48, 23)
    Me.Label3.TabIndex = 9
    Me.Label3.Text = "Blue:"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label4
    '
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(152, 208)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(48, 24)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "Color:"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'nudBrightness
    '
    Me.nudBrightness.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudBrightness.Location = New System.Drawing.Point(96, 288)
    Me.nudBrightness.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.nudBrightness.Name = "nudBrightness"
    Me.nudBrightness.Size = New System.Drawing.Size(48, 22)
    Me.nudBrightness.TabIndex = 11
    '
    'Label5
    '
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(16, 240)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(72, 23)
    Me.Label5.TabIndex = 12
    Me.Label5.Text = "Hue:"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label6
    '
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(16, 264)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(72, 23)
    Me.Label6.TabIndex = 13
    Me.Label6.Text = "Saturation:"
    Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label7
    '
    Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(16, 288)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(72, 23)
    Me.Label7.TabIndex = 14
    Me.Label7.Text = "Brightness:"
    Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'pnlColor
    '
    Me.pnlColor.Location = New System.Drawing.Point(8, 16)
    Me.pnlColor.Name = "pnlColor"
    Me.pnlColor.Size = New System.Drawing.Size(176, 176)
    Me.pnlColor.TabIndex = 15
    Me.pnlColor.Visible = False
    '
    'pnlBrightness
    '
    Me.pnlBrightness.Location = New System.Drawing.Point(208, 16)
    Me.pnlBrightness.Name = "pnlBrightness"
    Me.pnlBrightness.Size = New System.Drawing.Size(16, 176)
    Me.pnlBrightness.TabIndex = 16
    Me.pnlBrightness.Visible = False
    '
    'pnlSelectedColor
    '
    Me.pnlSelectedColor.Location = New System.Drawing.Point(208, 208)
    Me.pnlSelectedColor.Name = "pnlSelectedColor"
    Me.pnlSelectedColor.Size = New System.Drawing.Size(48, 24)
    Me.pnlSelectedColor.TabIndex = 17
    Me.pnlSelectedColor.Visible = False
    '
    'btnOK
    '
    Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnOK.Location = New System.Drawing.Point(120, 328)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(64, 24)
    Me.btnOK.TabIndex = 18
    Me.btnOK.Text = "OK"
    '
    'btnCancel
    '
    Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancel.Location = New System.Drawing.Point(192, 328)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(64, 24)
    Me.btnCancel.TabIndex = 19
    Me.btnCancel.Text = "Cancel"
    '
    'ColorChooser
    '
    Me.AcceptButton = Me.btnOK
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
    Me.CancelButton = Me.btnCancel
    Me.ClientSize = New System.Drawing.Size(266, 359)
    Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCancel, Me.btnOK, Me.Label3, Me.nudSaturation, Me.Label7, Me.nudBrightness, Me.nudRed, Me.pnlColor, Me.Label6, Me.Label1, Me.Label5, Me.pnlSelectedColor, Me.pnlBrightness, Me.nudBlue, Me.Label4, Me.nudGreen, Me.Label2, Me.nudHue})
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "ColorChooser"
    Me.Text = "Select Color"
    CType(Me.nudRed, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudGreen, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudBlue, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudHue, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudSaturation, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudBrightness, System.ComponentModel.ISupportInitialize).EndInit()
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
  Private isInUpdate As Boolean = False

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
     New Rectangle(pnlSelectedColor.Location, _
     pnlSelectedColor.Size)
    Dim BrightnessRectangle As Rectangle = _
     New Rectangle(pnlBrightness.Location, _
     pnlBrightness.Size)
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

  Private Sub HandleRGBChange( _
   ByVal sender As System.Object, ByVal e As System.EventArgs) _
   Handles nudRed.ValueChanged, nudBlue.ValueChanged, nudGreen.ValueChanged

    ' If the R, G, or B values change, use this 
    ' code to update the HSV values and invalidate
    ' the color wheel (so it updates the pointers).
    ' Check the isInUpdate flag to avoid recursive events
    ' when you update the NumericUpdownControls.
    If Not isInUpdate Then
      changeType = ChangeStyle.RGB
      RGB = New ColorHandler.RGB(CInt(nudRed.Value), _
       CInt(nudGreen.Value), CInt(nudBlue.Value))
      SetHSV(ColorHandler.RGBtoHSV(RGB))
      Me.Invalidate()
    End If
  End Sub

  Private Sub HandleHSVChange( _
   ByVal sender As System.Object, ByVal e As System.EventArgs) _
   Handles nudHue.ValueChanged, nudSaturation.ValueChanged, _
   nudBrightness.ValueChanged
    ' If the H, S, or V values change, use this 
    ' code to update the RGB values and invalidate
    ' the color wheel (so it updates the pointers).
    ' Check the isInUpdate flag to avoid recursive events
    ' when you update the NumericUpdownControls.
    If Not isInUpdate Then
      changeType = ChangeStyle.HSV
      HSV = New ColorHandler.HSV(CInt(nudHue.Value), _
       CInt(nudSaturation.Value), CInt(nudBrightness.Value))
      SetRGB(ColorHandler.HSVtoRGB(HSV))
      Me.Invalidate()
    End If
  End Sub

  Private Sub SetRGB(ByVal RGB As ColorHandler.RGB)
    ' Update the RGB values on the form, but don't trigger
    ' the ValueChanged event of the form. The isInUpdate
    ' variable ensures that the event procedures
    ' exit without doing anything.
    isInUpdate = True
    RefreshValue(nudRed, RGB.Red)
    RefreshValue(nudBlue, RGB.Blue)
    RefreshValue(nudGreen, RGB.Green)
    isInUpdate = False
  End Sub

  Private Sub SetHSV(ByVal HSV As ColorHandler.HSV)
    ' Update the HSV values on the form, but don't trigger
    ' the ValueChanged event of the form. The isInUpdate
    ' variable ensures that the event procedures
    ' exit without doing anything.
    isInUpdate = True
    RefreshValue(nudHue, HSV.Hue)
    RefreshValue(nudSaturation, HSV.Saturation)
    RefreshValue(nudBrightness, HSV.Value)
    isInUpdate = False
  End Sub

  Private Sub HandleTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
   Handles nudRed.TextChanged, nudBlue.TextChanged, nudGreen.TextChanged, _
   nudHue.TextChanged, nudSaturation.TextChanged, nudBrightness.TextChanged
    ' This step works around a bug -- unless you actively
    ' retrieve the Value, the min and max settings for the 
    ' control aren't honored when you type text. This may
    ' be fixed in the 1.1 version, but in VS.NET 1.0, this 
    ' step is required.
    Dim x As Decimal = DirectCast(sender, NumericUpDown).Value
  End Sub

  Private Sub RefreshValue( _
   ByVal nud As NumericUpDown, ByVal Value As Integer)
    ' Update the value of the NumericUpDown control, 
    ' if the value is different than the current value.
    ' Refresh the control, causing an immediate repaint.
    If nud.Value <> Value Then
      nud.Value = Value
      nud.Refresh()
    End If
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

  Private Sub ColorChooser1_Paint( _
   ByVal sender As Object, _
   ByVal e As PaintEventArgs) Handles MyBase.Paint
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
