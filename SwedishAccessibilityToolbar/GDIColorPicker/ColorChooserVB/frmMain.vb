Public Class frmMain
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
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
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
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
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
    Me.nudRed.Location = New System.Drawing.Point(432, 296)
    Me.nudRed.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.nudRed.Name = "nudRed"
    Me.nudRed.Size = New System.Drawing.Size(48, 22)
    Me.nudRed.TabIndex = 2
    '
    'nudGreen
    '
    Me.nudGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudGreen.Location = New System.Drawing.Point(432, 320)
    Me.nudGreen.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.nudGreen.Name = "nudGreen"
    Me.nudGreen.Size = New System.Drawing.Size(48, 22)
    Me.nudGreen.TabIndex = 3
    '
    'nudBlue
    '
    Me.nudBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudBlue.Location = New System.Drawing.Point(432, 344)
    Me.nudBlue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.nudBlue.Name = "nudBlue"
    Me.nudBlue.Size = New System.Drawing.Size(48, 22)
    Me.nudBlue.TabIndex = 4
    '
    'nudHue
    '
    Me.nudHue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudHue.Location = New System.Drawing.Point(320, 296)
    Me.nudHue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.nudHue.Name = "nudHue"
    Me.nudHue.Size = New System.Drawing.Size(48, 22)
    Me.nudHue.TabIndex = 5
    '
    'nudSaturation
    '
    Me.nudSaturation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudSaturation.Location = New System.Drawing.Point(320, 320)
    Me.nudSaturation.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.nudSaturation.Name = "nudSaturation"
    Me.nudSaturation.Size = New System.Drawing.Size(48, 22)
    Me.nudSaturation.TabIndex = 6
    '
    'Label1
    '
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(376, 296)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(48, 23)
    Me.Label1.TabIndex = 7
    Me.Label1.Text = "Red:"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label2
    '
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(376, 320)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(48, 23)
    Me.Label2.TabIndex = 8
    Me.Label2.Text = "Green:"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label3
    '
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(376, 344)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(48, 23)
    Me.Label3.TabIndex = 9
    Me.Label3.Text = "Blue:"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label4
    '
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(376, 264)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(48, 24)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "Color:"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'nudBrightness
    '
    Me.nudBrightness.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudBrightness.Location = New System.Drawing.Point(320, 344)
    Me.nudBrightness.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
    Me.nudBrightness.Name = "nudBrightness"
    Me.nudBrightness.Size = New System.Drawing.Size(48, 22)
    Me.nudBrightness.TabIndex = 11
    '
    'Label5
    '
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(240, 296)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(72, 23)
    Me.Label5.TabIndex = 12
    Me.Label5.Text = "Hue:"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label6
    '
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(240, 320)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(72, 23)
    Me.Label6.TabIndex = 13
    Me.Label6.Text = "Saturation:"
    Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label7
    '
    Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(240, 344)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(72, 23)
    Me.Label7.TabIndex = 14
    Me.Label7.Text = "Brightness:"
    Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'pnlColor
    '
    Me.pnlColor.Location = New System.Drawing.Point(8, 8)
    Me.pnlColor.Name = "pnlColor"
    Me.pnlColor.Size = New System.Drawing.Size(200, 200)
    Me.pnlColor.TabIndex = 15
    Me.pnlColor.Visible = False
    '
    'pnlBrightness
    '
    Me.pnlBrightness.Location = New System.Drawing.Point(464, 8)
    Me.pnlBrightness.Name = "pnlBrightness"
    Me.pnlBrightness.Size = New System.Drawing.Size(18, 152)
    Me.pnlBrightness.TabIndex = 16
    Me.pnlBrightness.Visible = False
    '
    'pnlSelectedColor
    '
    Me.pnlSelectedColor.Location = New System.Drawing.Point(432, 264)
    Me.pnlSelectedColor.Name = "pnlSelectedColor"
    Me.pnlSelectedColor.Size = New System.Drawing.Size(48, 24)
    Me.pnlSelectedColor.TabIndex = 17
    Me.pnlSelectedColor.Visible = False
    '
    'Label8
    '
    Me.Label8.Location = New System.Drawing.Point(40, 224)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(464, 16)
    Me.Label8.TabIndex = 18
    Me.Label8.Text = "Label8"
    '
    'Label9
    '
    Me.Label9.Location = New System.Drawing.Point(32, 248)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(272, 23)
    Me.Label9.TabIndex = 19
    Me.Label9.Text = "Label9"
    '
    'frmMain
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
    Me.ClientSize = New System.Drawing.Size(584, 394)
    Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label9, Me.Label8, Me.pnlSelectedColor, Me.pnlBrightness, Me.pnlColor, Me.Label7, Me.Label6, Me.Label5, Me.nudBrightness, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.nudSaturation, Me.nudHue, Me.nudBlue, Me.nudGreen, Me.nudRed})
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Name = "frmMain"
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

  Private MyColorWheel As ColorWheel
  Private SelectedPoint As Point

  Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or _
     ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)

    Dim SelectedColorRectangle As Rectangle = New Rectangle(pnlSelectedColor.Location, pnlSelectedColor.Size)
    Dim BrightnessRectangle As Rectangle = New Rectangle(pnlBrightness.Location, pnlBrightness.Size)
    Dim ColorRectangle As Rectangle = New Rectangle(pnlColor.Location, pnlColor.Size)

    MyColorWheel = New ColorWheel(Me, ColorRectangle, BrightnessRectangle, SelectedColorRectangle)
    ' These are set in design view, as well, but they
    ' have to be set to False in order for the Paint
    ' event to be able to display their contents.
    pnlSelectedColor.Visible = False
    pnlBrightness.Visible = False
    pnlColor.Visible = False
  End Sub

  Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
    MyColorWheel.Draw(e.Graphics, SelectedPoint)
  End Sub

  Private Sub frmMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
    If e.Button = MouseButtons.Left Then
      SelectedPoint = New Point(e.X, e.Y)
      Me.Invalidate()
    End If
  End Sub

  Private Sub frmMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
    'If Not MyColorWheel.MouseEngaged Then
    SelectedPoint = New Point(e.X, e.Y)
    Me.Invalidate()
    'End If
  End Sub

  Private Sub frmMain_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
    MyColorWheel.MouseStatus = ColorWheel.MouseState.MouseUp
  End Sub

  Private Sub HandleColorChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudRed.ValueChanged, nudBlue.ValueChanged, nudGreen.ValueChanged
    Dim c As Color
    c = Color.FromArgb(255, CInt(nudRed.Value), CInt(nudGreen.Value), CInt(nudBlue.Value))
    nudHue.Value = CDec(c.GetHue())
    nudSaturation.Value = CDec(c.GetSaturation())




  End Sub
End Class
