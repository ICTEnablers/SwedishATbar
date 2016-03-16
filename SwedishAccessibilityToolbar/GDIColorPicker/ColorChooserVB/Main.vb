Public Class Main
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
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents btnStandard As System.Windows.Forms.Button
  Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.btnStandard = New System.Windows.Forms.Button()
    Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
    Me.SuspendLayout()
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(8, 48)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(128, 32)
    Me.Button1.TabIndex = 0
    Me.Button1.Text = "Test Form 1"
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(160, 48)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(72, 32)
    Me.Label1.TabIndex = 1
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(8, 88)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(128, 32)
    Me.Button2.TabIndex = 2
    Me.Button2.Text = "Test Form 2"
    '
    'btnStandard
    '
    Me.btnStandard.Location = New System.Drawing.Point(8, 8)
    Me.btnStandard.Name = "btnStandard"
    Me.btnStandard.Size = New System.Drawing.Size(128, 32)
    Me.btnStandard.TabIndex = 3
    Me.btnStandard.Text = "Standard Color Dialog"
    '
    'Main
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(240, 125)
    Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnStandard, Me.Button2, Me.Label1, Me.Button1})
    Me.Name = "Main"
    Me.Text = "Demonstration"
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Dim frm As New ColorChooser1()
    frm.Color = Label1.BackColor
    If frm.ShowDialog(Me) = DialogResult.OK Then
      Label1.BackColor = frm.Color
    End If
    frm.Dispose()
  End Sub

  Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    Dim frm As New ColorChooser2()
    frm.Color = Label1.BackColor
    If frm.ShowDialog(Me) = DialogResult.OK Then
      Label1.BackColor = frm.Color
    End If
    frm.Dispose()
  End Sub

  Private Sub btnStandard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStandard.Click
    ColorDialog1.Color = Label1.BackColor
    ColorDialog1.FullOpen = True
    If ColorDialog1.ShowDialog = DialogResult.OK Then
      Label1.BackColor = ColorDialog1.Color
    End If
  End Sub
End Class
