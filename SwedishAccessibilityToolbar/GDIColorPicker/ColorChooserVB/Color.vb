Imports System.Drawing

Public Class ColorHandler
  Private clr As Color
  Private Const HLSMAX As Integer = 240
  Private Const RGBMAX As Integer = 255

  Public Sub New(ByVal Color As Color)
    clr = Color
  End Sub

  Private Shared Function HueToRGB(ByVal n1 As Integer, ByVal n2 As Integer, ByVal H As Integer) As Integer
    ' TODO: Fix this up to use MOD
    If H <= 0 Then
      H += HLSMAX
    End If

    If H > HLSMAX Then
      H -= HLSMAX
    ElseIf H < (HLSMAX / 6) Then
      Return CType((n1 + (((n2 - n1) * H + (HLSMAX / 12)) / (HLSMAX / 6))), Integer)
    ElseIf H < (HLSMAX / 2) Then
      Return n2
    ElseIf H < ((HLSMAX * 2) / 3) Then
      Return CType((n1 + (((n2 - n1) * (((HLSMAX * 2) / 3) - H) + (HLSMAX / 12)) / (HLSMAX / 6))), Integer)
    Else
      Return n1
    End If
  End Function

  Public Shared Function GetRGB(ByVal H As Integer, ByVal L As Integer, ByVal S As Integer) As Color
    Dim R As Integer
    Dim G As Integer
    Dim B As Integer

    Dim intTemp1 As Integer
    Dim intTemp2 As Integer

    If S = 0 Then
      Dim intResult As Integer = CType((L * RGBMAX) / HLSMAX, Integer)
      R = intResult
      G = intResult
      B = intResult
    Else
      If L <= (HLSMAX / 2) Then
        intTemp2 = CType((L * (HLSMAX + S) + (HLSMAX / 2)) / HLSMAX, Integer)
      Else
        intTemp2 = CType(L + S - ((L * S) + (HLSMAX / 2)) / HLSMAX, Integer)
      End If
      intTemp1 = 2 * L - intTemp2

      R = CType((HueToRGB(intTemp1, intTemp2, CType(H + (HLSMAX / 3), Integer)) * RGBMAX + (HLSMAX / 2)) / HLSMAX, Integer)
      G = CType((HueToRGB(intTemp1, intTemp2, H) * RGBMAX + (HLSMAX / 2)) / HLSMAX, Integer)
      B = CType((HueToRGB(intTemp1, intTemp2, CType(H - (HLSMAX / 3), Integer)) * RGBMAX + (HLSMAX / 2)) / HLSMAX, Integer)
    End If
    Return Color.FromArgb(L, R, G, B)
  End Function
End Class
