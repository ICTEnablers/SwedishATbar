Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class ColorWheel
  Implements IDisposable

  ' These resources should be disposed
  ' of when you're done with them.
  Private g As Graphics
  Private colorRegion As Region
  Private brightnessRegion As Region
  Private colorImage As Bitmap

  Public Event ColorChanged(ByVal sender As Object, ByVal e As ColorChangedEventArgs)

  ' Keep track of the current mouse state. 
  Public Enum MouseState
    MouseUp
    ClickOnColor
    DragInColor
    ClickOnBrightness
    DragInBrightness
    ClickOutsideRegion
    DragOutsideRegion
  End Enum
  Private currentState As MouseState = MouseState.MouseUp

  ' The code needs to convert back and forth between 
  ' degrees and radians. There are 2*PI radians in a 
  ' full circle, and 360 degrees. This constant allows
  ' you to convert back and forth.
  Private Const DEGREES_PER_RADIAN As Double = 180.0 / Math.PI

  ' COLOR_COUNT represents the number of distinct colors
  ' used to create the circular gradient. Its value 
  ' is somewhat arbitrary -- change this to 6, for 
  ' example, to see what happens. 1536 (6 * 256) seems 
  ' a good compromise -- it's enought to get a full 
  ' range of colors, but it doesn't overwhelm the processor
  ' attempting to generate the image. The color wheel
  ' contains 6 sections, and each section displays 
  ' 256 colors. Seems like a reasonable compromise.
  Private Const COLOR_COUNT As Integer = 6 * 256

  Private centerPoint As Point
  Private radius As Integer

  Private colorRectangle As Rectangle
  Private brightnessRectangle As Rectangle
  Private selectedColorRectangle As Rectangle
  Private brightnessX As Integer
  Private brightnessScaling As Double

  ' selectedColor is the actual value selected
  ' by the user. fullColor is the same color, 
  ' with its brightness set to 255.
  Private selectedColor As Color = Color.White
  Private fullColor As Color = selectedColor

  Private RGB As ColorHandler.RGB
  Private HSV As ColorHandler.HSV

  ' Locations for the two "pointers" on the form.
  Private colorPoint As Point
  Private brightnessPoint As Point

  Private brightness As Integer
  Private brightnessMin As Integer
  Private brightnessMax As Integer

  Protected Overridable Sub OnColorChanged( _
   ByVal RGB As ColorHandler.RGB, ByVal HSV As ColorHandler.HSV)
    Dim e As New ColorChangedEventArgs(RGB, HSV)
    RaiseEvent ColorChanged(Me, e)
  End Sub

  Public ReadOnly Property Color() As Color
    Get
      Return selectedColor
    End Get
  End Property

  Private Sub Dispose() Implements IDisposable.Dispose
    ' Dispose of graphic resources
    If Not colorImage Is Nothing Then
      colorImage.Dispose()
    End If
    If Not colorRegion Is Nothing Then
      colorRegion.Dispose()
    End If
    If Not brightnessRegion Is Nothing Then
      brightnessRegion.Dispose()
    End If
    If Not g Is Nothing Then
      g.Dispose()
    End If
  End Sub

  Public Sub New( _
   ByVal colorRectangle As Rectangle, _
   ByVal brightnessRectangle As Rectangle, _
   ByVal selectedColorRectangle As Rectangle)

    ' Caller must provide locations for color wheel
    ' (colorRectangle), brightness "strip" (brightnessRectangle)
    ' and location to display selected color (selectedColorRectangle).

    Dim path As GraphicsPath

    Try
      ' Store away locations for later use. 
      Me.colorRectangle = colorRectangle
      Me.brightnessRectangle = brightnessRectangle
      Me.selectedColorRectangle = selectedColorRectangle

      ' Calculate the center of the circle.
      ' Start with the location, then offset
      ' the point by the radius.
      ' Use the smaller of the width and height of
      ' the colorRectangle value.
      Me.radius = Math.Min( _
       colorRectangle.Width, colorRectangle.Height) \ 2
      Me.centerPoint = colorRectangle.Location
      Me.centerPoint.Offset(radius, radius)

      ' Start the pointer in the center.
      Me.colorPoint = Me.centerPoint

      ' Create a region corresponding to the color circle.
      ' Code uses this later to determine if a specified
      ' point is within the region, using the IsVisible 
      ' method.
      path = New GraphicsPath()
      path.AddEllipse(colorRectangle)
      colorRegion = New Region(path)

      ' Set the range for the brightness selector.
      Me.brightnessMin = Me.brightnessRectangle.Top
      Me.brightnessMax = Me.brightnessRectangle.Bottom

      ' Create a region corresponding to the
      ' brightness rectangle, with a little extra 
      ' "breathing room". 
      With brightnessRectangle
        path = New GraphicsPath()
        path.AddRectangle( _
         New Rectangle(.Left, .Top - 10, _
         .Width + 10, .Height + 20))
      End With
      ' Create region corresponding to brightness
      ' rectangle. Later code uses this to 
      ' determine if a specified point is within
      ' the region, using the IsVisible method.
      brightnessRegion = New Region(path)

      ' Set the location for the brightness indicator "marker".
      ' Also calculate the scaling factor, scaling the height
      ' to be between 0 and 255. 
      brightnessX = brightnessRectangle.Left + _
       brightnessRectangle.Width
      brightnessScaling = 255 / _
       (brightnessMax - brightnessMin)

      ' Calculate the location of the brightness
      ' pointer. Assume it's at the highest position.
      brightnessPoint = _
       New Point(brightnessX, brightnessMax)

      ' Create the bitmap that contains the circular gradient.
      CreateGradient()

    Finally
      If Not path Is Nothing Then
        path.Dispose()
      End If
    End Try
  End Sub

  Public Sub SetMouseUp()
    ' Indicate that the user has
    ' released the mouse.
    currentState = MouseState.MouseUp
  End Sub

  Public Overloads Sub Draw(ByVal g As Graphics, _
   ByVal HSV As ColorHandler.HSV)
    ' Given HSV values, update the screen.
    Me.g = g
    Me.HSV = HSV
    CalcCoordsAndUpdate(Me.HSV)
    UpdateDisplay()
  End Sub

  Public Overloads Sub Draw(ByVal g As Graphics, _
   ByVal RGB As ColorHandler.RGB)
    ' Given RGB values, calculate HSV and then update the screen.
    Me.g = g
    Me.HSV = ColorHandler.RGBtoHSV(RGB)
    CalcCoordsAndUpdate(Me.HSV)
    UpdateDisplay()
  End Sub

  Public Overloads Sub Draw(ByVal g As Graphics, ByVal mousePoint As Point)
    ' You've moved the mouse. 
    ' Now update the screen to match.

    Dim distance As Double
    Dim degrees As Integer
    Dim delta As Point
    Dim newColorPoint As Point
    Dim newBrightnessPoint As Point
    Dim newPoint As Point

    ' Keep track of the previous color pointer point, 
    ' so you can put the mouse there in case the 
    ' user has clicked outside the circle.
    newColorPoint = colorPoint
    newBrightnessPoint = brightnessPoint

    ' Store this away for later use.
    Me.g = g

    If currentState = MouseState.MouseUp Then
      If Not mousePoint.IsEmpty Then
        If colorRegion.IsVisible(mousePoint) Then
          ' Is the mouse point within the color circle?
          ' If so, you just clicked on the color wheel.
          currentState = MouseState.ClickOnColor
        ElseIf brightnessRegion.IsVisible(mousePoint) Then
          ' Is the mouse point within the brightness area?
          ' You clicked on the brightness area.
          currentState = MouseState.ClickOnBrightness
        Else
          ' Clicked outside the color and the brightness
          ' regions. In that case, just put the 
          ' pointers back where they were.
          currentState = MouseState.ClickOutsideRegion
        End If
      End If
    End If

    Select Case currentState
      Case MouseState.ClickOnBrightness, MouseState.DragInBrightness
        ' Calculate new color information
        ' based on the brightness, which may have changed.
        newPoint = mousePoint
        If newPoint.Y < brightnessMin Then
          newPoint.Y = brightnessMin
        ElseIf newPoint.Y > brightnessMax Then
          newPoint.Y = brightnessMax
        End If
        newBrightnessPoint = New Point(brightnessX, newPoint.Y)
        brightness = CInt((brightnessMax - newPoint.Y) * brightnessScaling)
        HSV.Value = brightness
        RGB = ColorHandler.HSVtoRGB(HSV)

      Case MouseState.ClickOnColor, MouseState.DragInColor
        ' Calculate new color information
        ' based on selected color, which may have changed.
        newColorPoint = mousePoint

        ' Calculate x and y distance from the center,
        ' and then calculate the angle corresponding to the
        ' new location.
        delta = New Point( _
         mousePoint.X - centerPoint.X, _
         mousePoint.Y - centerPoint.Y)
        degrees = CalcDegrees(delta)

        ' Calculate distance from the center to the new point 
        ' as a fraction of the radius. Use your old friend, 
        ' the Pythagorean theorem, to calculate this value.
        distance = Math.Sqrt( _
         delta.X * delta.X + delta.Y * delta.Y) / radius

        If currentState = MouseState.DragInColor Then
          If distance > 1 Then
            ' Mouse is down, and outside the circle, but you 
            ' were previously dragging in the color circle. 
            ' What to do?
            ' In that case, move the point to the edge of the 
            ' circle at the correct angle.
            distance = 1
            newColorPoint = GetPoint(degrees, radius, centerPoint)
          End If
        End If

        ' Calculate the new HSV and RGB values.
        HSV.Hue = CInt(degrees * 255 / 360)
        HSV.Saturation = CInt(distance * 255)
        HSV.Value = brightness
        RGB = ColorHandler.HSVtoRGB(HSV)
        fullColor = ColorHandler.HSVtoColor( _
         HSV.Hue, HSV.Saturation, 255)
    End Select
    selectedColor = ColorHandler.HSVtoColor(HSV)

    ' Raise an event back to the parent form,
    ' so the form can update any UI it's using 
    ' to display selected color values.
    OnColorChanged(RGB, HSV)

    ' On the way out, set the new state.
    Select Case currentState
      Case MouseState.ClickOnBrightness
        currentState = MouseState.DragInBrightness
      Case MouseState.ClickOnColor
        currentState = MouseState.DragInColor
      Case MouseState.ClickOutsideRegion
        currentState = MouseState.DragOutsideRegion
    End Select

    ' Store away the current points for next time.
    colorPoint = newColorPoint
    brightnessPoint = newBrightnessPoint

    ' Draw the gradients and points. 
    UpdateDisplay()
  End Sub

  Private Function CalcBrightnessPoint(ByVal brightness As Integer) As Point
    ' Take the value for brightness (0 to 255), scale to the 
    ' scaling used in the brightness bar, then add the value 
    ' to the bottom of the bar. Return the correct point at which 
    ' to display the brightness pointer.
    Return New Point( _
     brightnessX, _
     CInt(brightnessMax - brightness / brightnessScaling))
  End Function

  Private Sub UpdateDisplay()
    ' Update the gradients, and place the 
    ' pointers correctly based on colors and 
    ' brightness.

    Dim selectedBrush As Brush

    Try
      ' Draw the "selected color" rectangle.
      selectedBrush = New SolidBrush(selectedColor)

      ' Draw the saved color wheel image.
      g.DrawImage(colorImage, colorRectangle)

      g.FillRectangle( _
       selectedBrush, selectedColorRectangle)

      ' Draw the "brightness" rectangle.
      DrawLinearGradient(fullColor)
      ' Draw the two pointers.
      DrawColorPointer(colorPoint)
      DrawBrightnessPointer(brightnessPoint)

    Finally
      If Not selectedBrush Is Nothing Then
        selectedBrush.Dispose()
      End If
    End Try
  End Sub

  Private Sub CalcCoordsAndUpdate(ByVal HSV As ColorHandler.HSV)
    ' Convert color to real-world coordinates and then calculate
    ' the various points. HSV.Hue represents the degrees (0 to 360), 
    ' HSV.Saturation represents the radius. 
    ' This procedure doesn't draw anything--it simply 
    ' updates class-level variables. The UpdateDisplay
    ' procedure uses these values to update the screen.

    ' Given the angle (HSV.Hue), and distance from 
    ' the center (HSV.Saturation), and the center, 
    ' calculate the point corresponding to 
    ' the selected color, on the color wheel.
    colorPoint = GetPoint( _
     HSV.Hue / 255 * 360, _
     HSV.Saturation / 255 * radius, _
     centerPoint)

    ' Given the brightness (HSV.Value), calculate the 
    ' point corresponding to the brightness indicator.
    brightnessPoint = CalcBrightnessPoint(HSV.Value)

    ' Store information about the selected color.
    brightness = HSV.Value
    selectedColor = ColorHandler.HSVtoColor(HSV)
    RGB = ColorHandler.HSVtoRGB(HSV)

    ' The full color is the same as HSV, except that the 
    ' brightness is set to full (255). This is the top-most
    ' color in the brightness gradient.
    fullColor = ColorHandler.HSVtoColor(HSV.Hue, HSV.Saturation, 255)
  End Sub

  Private Sub DrawLinearGradient(ByVal TopColor As Color)
    ' Given the top color, draw a linear gradient
    ' ranging from black to the top color. Use the 
    ' brightness rectangle as the area to fill.
    Dim lgb As LinearGradientBrush
    Try
      lgb = New LinearGradientBrush( _
       brightnessRectangle, TopColor, _
        Color.Black, LinearGradientMode.Vertical)
      g.FillRectangle(lgb, brightnessRectangle)
    Finally
      If Not lgb Is Nothing Then
        lgb.Dispose()
      End If
    End Try
  End Sub

  Private Function CalcDegrees(ByVal pt As Point) As Integer
    Dim degrees As Integer

    If pt.X = 0 Then
      ' The point is on the y-axis. Determine whether 
      ' it's above or below the x-axis, and return the 
      ' corresponding angle. Note that the orientation of the
      ' y-coordinate is backwards. That is, A positive Y value 
      ' indicates a point BELOW the x-axis.
      If pt.Y > 0 Then
        degrees = 270
      Else
        degrees = 90
      End If
    Else
      ' This value needs to be multiplied
      ' by -1 because the y-coordinate
      ' is opposite from the normal direction here.
      ' That is, a y-coordinate that's "higher" on 
      ' the form has a lower y-value, in this coordinate
      ' system. So everything's off by a factor of -1 when
      ' performing the ratio calculations.
      degrees = CInt(-Math.Atan(pt.Y / pt.X) * DEGREES_PER_RADIAN)

      ' If the x-coordinate of the selected point
      ' is to the left of the center of the circle, you 
      ' need to add 180 degrees to the angle. ArcTan only
      ' gives you a value on the right-hand side of the circle.
      If pt.X < 0 Then
        degrees += 180
      End If

      ' Ensure that the return value is 
      ' between 0 and 360.
      degrees = (degrees + 360) Mod 360
    End If
    Return degrees
  End Function

  Private Sub CreateGradient()
    Dim newGraphics As Graphics
    Dim pgb As PathGradientBrush

    Try
      ' Create a new PathGradientBrush, supplying
      ' an array of points created by calling
      ' the GetPoints method.
      pgb = New PathGradientBrush( _
       GetPoints(radius, New Point(radius, radius)))

      ' Set the various properties. Note the SurroundColors
      ' property, which contains an array of points, 
      ' in a one-to-one relationship with the points
      ' that created the gradient.
      pgb.CenterColor = Color.White
      pgb.CenterPoint = New PointF(radius, radius)
      pgb.SurroundColors = GetColors()

      ' Create a new bitmap containing
      ' the color wheel gradient, so the 
      ' code only needs to do all this 
      ' work once. Later code uses the bitmap
      ' rather than recreating the gradient.
      colorImage = New Bitmap( _
       colorRectangle.Width, colorRectangle.Height, _
       PixelFormat.Format32bppArgb)

      newGraphics = Graphics.FromImage(colorImage)
      newGraphics.FillEllipse(pgb, 0, 0, _
       colorRectangle.Width, colorRectangle.Height)

    Finally
      If Not pgb Is Nothing Then
        pgb.Dispose()
      End If
      If Not newGraphics Is Nothing Then
        newGraphics.Dispose()
      End If
    End Try
  End Sub

  Private Function GetColors() As Color()
    ' Create an array of COLOR_COUNT
    ' colors, looping through all the 
    ' hues between 0 and 255, broken
    ' into COLOR_COUNT intervals. HSV is
    ' particularly well-suited for this, 
    ' because the only value that changes
    ' as you create colors is the Hue.
    Dim Colors(COLOR_COUNT - 1) As Color

    Dim i As Integer
    For i = 0 To COLOR_COUNT - 1
      Colors(i) = ColorHandler.HSVtoColor( _
       i * 255 \ COLOR_COUNT, 255, 255)
    Next
    Return Colors
  End Function

  Private Function GetPoints( _
   ByVal radius As Double, ByVal centerPoint As Point) _
   As Point()

    ' Generate the array of points that describe
    ' the locations of the COLOR_COUNT colors to be 
    ' displayed on the color wheel.
    Dim Points(COLOR_COUNT - 1) As Point

    Dim i As Integer
    For i = 0 To COLOR_COUNT - 1
      Points(i) = GetPoint( _
       i * 360 / COLOR_COUNT, radius, centerPoint)
    Next
    Return Points
  End Function

  Private Function GetPoint( _
   ByVal degrees As Double, _
   ByVal radius As Double, _
   ByVal centerPoint As Point) As Point

    ' Given the center of a circle and its radius, along
    ' with the angle corresponding to the point, 
    ' find the coordinates.  In other words, convert 
    ' from polar to rectangular coordinates.
    Dim radians As Double = degrees / DEGREES_PER_RADIAN

    Return New Point( _
     CInt(centerPoint.X + _
      Math.Floor(radius * Math.Cos(radians))), _
     CInt(centerPoint.Y - _
      Math.Floor(radius * Math.Sin(radians))))
  End Function

  Private Sub DrawColorPointer(ByVal pt As Point)
    ' Given a point, draw the color selector. 
    ' The constant SIZE represents half
    ' the width -- the square will be twice
    ' this value in width and height.
    Const SIZE As Integer = 3
    g.DrawRectangle(Pens.Black, _
     pt.X - SIZE, pt.Y - SIZE, _
     SIZE * 2, SIZE * 2)
  End Sub

  Private Sub DrawBrightnessPointer(ByVal pt As Point)
    ' Draw a triangle for the 
    ' brightness indicator that "points"
    ' at the provided point.
    Const HEIGHT As Integer = 10
    Const WIDTH As Integer = 7

    Dim Points(2) As Point
    Points(0) = pt
    Points(1) = New Point(pt.X + WIDTH, pt.Y + HEIGHT \ 2)
    Points(2) = New Point(pt.X + WIDTH, pt.Y - HEIGHT \ 2)
    g.FillPolygon(Brushes.Black, Points)
  End Sub
End Class

