Public Class ColorChangedEventArgs
  Inherits EventArgs

  Private mRGB As ColorHandler.RGB
  Private mHSV As ColorHandler.HSV

  Sub New(ByVal RGB As ColorHandler.RGB, ByVal HSV As ColorHandler.HSV)
    mRGB = RGB
    mHSV = HSV
  End Sub

  ReadOnly Property RGB() As ColorHandler.RGB
    Get
      Return mRGB
    End Get
  End Property

  ReadOnly Property HSV() As ColorHandler.HSV
    Get
      Return mHSV
    End Get
  End Property
End Class