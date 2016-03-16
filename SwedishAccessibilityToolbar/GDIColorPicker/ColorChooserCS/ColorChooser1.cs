using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ColorChooserCSharp
{
  /// <summary>
  /// Summary description for ColorChooser1.
  /// </summary>
  public class ColorChooser1 : System.Windows.Forms.Form
  {
    internal System.Windows.Forms.Button btnCancel;
    internal System.Windows.Forms.Button btnOK;
    internal System.Windows.Forms.Label Label3;
    internal System.Windows.Forms.NumericUpDown nudSaturation;
    internal System.Windows.Forms.Label Label7;
    internal System.Windows.Forms.NumericUpDown nudBrightness;
    internal System.Windows.Forms.NumericUpDown nudRed;
    internal System.Windows.Forms.Panel pnlColor;
    internal System.Windows.Forms.Label Label6;
    internal System.Windows.Forms.Label Label1;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.Panel pnlSelectedColor;
    internal System.Windows.Forms.Panel pnlBrightness;
    internal System.Windows.Forms.NumericUpDown nudBlue;
    internal System.Windows.Forms.Label Label4;
    internal System.Windows.Forms.NumericUpDown nudGreen;
    internal System.Windows.Forms.Label Label2;
    internal System.Windows.Forms.NumericUpDown nudHue;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;

    public ColorChooser1()
    {
      //
      // Required for Windows Form Designer support
      //
      InitializeComponent();

      //
      // TODO: Add any constructor code after InitializeComponent call
      //
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose( bool disposing )
    {
      if( disposing )
      {
        if(components != null)
        {
          components.Dispose();
        }
      }
      base.Dispose( disposing );
    }

		#region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorChooser1));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.nudSaturation = new System.Windows.Forms.NumericUpDown();
            this.Label7 = new System.Windows.Forms.Label();
            this.nudBrightness = new System.Windows.Forms.NumericUpDown();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.pnlSelectedColor = new System.Windows.Forms.Panel();
            this.pnlBrightness = new System.Windows.Forms.Panel();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.Label4 = new System.Windows.Forms.Label();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.nudHue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Name = "btnOK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // nudSaturation
            // 
            resources.ApplyResources(this.nudSaturation, "nudSaturation");
            this.nudSaturation.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudSaturation.Name = "nudSaturation";
            this.nudSaturation.TextChanged += new System.EventHandler(this.HandleTextChanged);
            this.nudSaturation.ValueChanged += new System.EventHandler(this.HandleHSVChange);
            // 
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.Name = "Label7";
            // 
            // nudBrightness
            // 
            resources.ApplyResources(this.nudBrightness, "nudBrightness");
            this.nudBrightness.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBrightness.Name = "nudBrightness";
            this.nudBrightness.TextChanged += new System.EventHandler(this.HandleTextChanged);
            this.nudBrightness.ValueChanged += new System.EventHandler(this.HandleHSVChange);
            // 
            // nudRed
            // 
            resources.ApplyResources(this.nudRed, "nudRed");
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.TextChanged += new System.EventHandler(this.HandleTextChanged);
            this.nudRed.ValueChanged += new System.EventHandler(this.HandleRGBChange);
            // 
            // pnlColor
            // 
            resources.ApplyResources(this.pnlColor, "pnlColor");
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // Label6
            // 
            resources.ApplyResources(this.Label6, "Label6");
            this.Label6.Name = "Label6";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.Name = "Label5";
            // 
            // pnlSelectedColor
            // 
            resources.ApplyResources(this.pnlSelectedColor, "pnlSelectedColor");
            this.pnlSelectedColor.Name = "pnlSelectedColor";
            // 
            // pnlBrightness
            // 
            resources.ApplyResources(this.pnlBrightness, "pnlBrightness");
            this.pnlBrightness.Name = "pnlBrightness";
            // 
            // nudBlue
            // 
            resources.ApplyResources(this.nudBlue, "nudBlue");
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.TextChanged += new System.EventHandler(this.HandleTextChanged);
            this.nudBlue.ValueChanged += new System.EventHandler(this.HandleRGBChange);
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.Name = "Label4";
            // 
            // nudGreen
            // 
            resources.ApplyResources(this.nudGreen, "nudGreen");
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.TextChanged += new System.EventHandler(this.HandleTextChanged);
            this.nudGreen.ValueChanged += new System.EventHandler(this.HandleRGBChange);
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.Name = "Label2";
            // 
            // nudHue
            // 
            resources.ApplyResources(this.nudHue, "nudHue");
            this.nudHue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudHue.Name = "nudHue";
            this.nudHue.TextChanged += new System.EventHandler(this.HandleTextChanged);
            this.nudHue.ValueChanged += new System.EventHandler(this.HandleHSVChange);
            // 
            // ColorChooser1
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.nudSaturation);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.nudBrightness);
            this.Controls.Add(this.nudRed);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.pnlSelectedColor);
            this.Controls.Add(this.pnlBrightness);
            this.Controls.Add(this.nudBlue);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.nudGreen);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.nudHue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorChooser1";
            this.Load += new System.EventHandler(this.ColorChooser1_Load);
            this.VisibleChanged += new System.EventHandler(this.ColorChooser1_VisibleChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ColorChooser1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouse);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HandleMouse);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.nudSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHue)).EndInit();
            this.ResumeLayout(false);

    }
		#endregion

    private enum ChangeStyle
    {
      MouseMove,
      RGB,
      HSV,
      None
    }

    private ChangeStyle changeType = ChangeStyle.None;
    private Point selectedPoint;

    private ColorWheel myColorWheel;
    public ColorHandler.RGB RGB;
    public ColorHandler.RGB RGBOUT;
    private ColorHandler.HSV HSV;
    private bool isInUpdate = false;

    public bool saveChanges = false;

    private void ColorChooser1_Load(object sender, System.EventArgs e)
    {
      // Turn on double-buffering, so the form looks better. 
      this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
      this.SetStyle(ControlStyles.UserPaint, true);
      this.SetStyle(ControlStyles.DoubleBuffer, true);


      // These properties are set in design view, as well, but they
      // have to be set to false in order for the Paint
      // event to be able to display their contents.
      // Never hurts to make sure they're invisible.
      pnlSelectedColor.Visible = false;
      pnlBrightness.Visible = false;
      pnlColor.Visible = false;

      // Calculate the coordinates of the three
      // required regions on the form.
      Rectangle SelectedColorRectangle =  
        new Rectangle(pnlSelectedColor.Location, pnlSelectedColor.Size);
      Rectangle BrightnessRectangle = 
        new Rectangle(pnlBrightness.Location, pnlBrightness.Size);
      Rectangle ColorRectangle = 
        new Rectangle(pnlColor.Location, pnlColor.Size);

      // Create the new ColorWheel class, indicating
      // the locations of the color wheel itself, the
      // brightness area, and the position of the selected color.
      myColorWheel = new ColorWheel(
        ColorRectangle, BrightnessRectangle, 
        SelectedColorRectangle);
      myColorWheel.ColorChanged += 
        new ColorWheel.ColorChangedEventHandler(
        this.myColorWheel_ColorChanged);

      // Set the RGB and HSV values 
      // of the NumericUpDown controls.
      SetRGB(RGB);
      HSV = ColorHandler.RGBtoHSV(RGB);
      SetHSV(HSV);
      changeType = ChangeStyle.RGB;
    }

    private void HandleMouse(object sender,  MouseEventArgs e)
    {
      // If you have the left mouse button down, 
      // then update the selectedPoint value and 
      // force a repaint of the color wheel.
      if ( e.Button == MouseButtons.Left ) 
      {
        changeType = ChangeStyle.MouseMove;
        selectedPoint = new Point(e.X, e.Y);
        this.Invalidate();
      }
    }

    private void frmMain_MouseUp( object sender,  MouseEventArgs e)
    {
      myColorWheel.SetMouseUp();
      changeType = ChangeStyle.None;
    }

    private void HandleRGBChange(object sender,  System.EventArgs e)
    {

      // If the R, G, or B values change, use this 
      // code to update the HSV values and invalidate
      // the color wheel (so it updates the pointers).
      // Check the isInUpdate flag to avoid recursive events
      // when you update the NumericUpdownControls.
      if (!isInUpdate ) 
      {
        changeType = ChangeStyle.RGB;
        RGB = new ColorHandler.RGB((int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);
        SetHSV(ColorHandler.RGBtoHSV(RGB));
        RGBOUT = RGB;
        this.Invalidate();
      }
    }

    private void HandleHSVChange(  object sender,  EventArgs e)  
    {
      // If the H, S, or V values change, use this 
      // code to update the RGB values and invalidate
      // the color wheel (so it updates the pointers).
      // Check the isInUpdate flag to avoid recursive events
      // when you update the NumericUpdownControls.
      if (! isInUpdate ) 
      {
        changeType = ChangeStyle.HSV;
        HSV = new ColorHandler.HSV((int)(nudHue.Value), (int)(nudSaturation.Value), (int)(nudBrightness.Value));
        SetRGB(ColorHandler.HSVtoRGB(HSV));
        this.Invalidate();
      }
    }

    private void SetRGB( ColorHandler.RGB RGB) 
    {
      // Update the RGB values on the form, but don't trigger
      // the ValueChanged event of the form. The isInUpdate
      // variable ensures that the event procedures
      // exit without doing anything.
      isInUpdate = true;
      RefreshValue(nudRed, RGB.Red);
      RefreshValue(nudBlue, RGB.Blue);
      RefreshValue(nudGreen, RGB.Green);
      RGBOUT = RGB;
      isInUpdate = false;
    }

    private void SetHSV(ColorHandler.HSV HSV) 
    {
      // Update the HSV values on the form, but don't trigger
      // the ValueChanged event of the form. The isInUpdate
      // variable ensures that the event procedures
      // exit without doing anything.
      isInUpdate = true;
      RefreshValue(nudHue, HSV.Hue);
      RefreshValue(nudSaturation, HSV.Saturation);
      RefreshValue(nudBrightness, HSV.value);
      isInUpdate = false;
    }

    private void HandleTextChanged(object sender, System.EventArgs e)
    {
      // This step works around a bug -- unless you actively
      // retrieve the value, the min and max settings for the 
      // control aren't honored when you type text. This may
      // be fixed in the 1.1 version, but in VS.NET 1.0, this 
      // step is required.
      Decimal x = ((NumericUpDown)sender).Value;
    }

    private void RefreshValue(  NumericUpDown nud,  int value) 
    {
      // Update the value of the NumericUpDown control, 
      // if the value is different than the current value.
      // Refresh the control, causing an immediate repaint.
      if ( nud.Value != value ) 
      {
        nud.Value = value;
        nud.Refresh();
      }
    }

    public Color Color  
    {
      // Get or set the color to be
      // displayed in the color wheel.
      get 
      {
        return myColorWheel.Color;
      }

      set 
      {
        // Indicate the color change type. Either RGB or HSV
        // will cause the color wheel to update the position
        // of the pointer.
        changeType = ChangeStyle.RGB;
        RGB = new ColorHandler.RGB(value.R, value.G, value.B);
        HSV = ColorHandler.RGBtoHSV(RGB);
      }
    }

    private void myColorWheel_ColorChanged(object sender,  ColorChangedEventArgs e)  
    {
      SetRGB(e.RGB);
      SetHSV(e.HSV);
    }

    private void ColorChooser1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
    {
      // Depending on the circumstances, force a repaint
      // of the color wheel passing different information.
      switch (changeType)
      {
        case ChangeStyle.HSV:
          myColorWheel.Draw(e.Graphics, HSV);
          break;
        case ChangeStyle.MouseMove:
        case ChangeStyle.None:
          myColorWheel.Draw(e.Graphics, selectedPoint);
          break;
        case ChangeStyle.RGB:
          myColorWheel.Draw(e.Graphics, RGB);
          break;
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
        saveChanges = true;
    }

    private void Label3_Click(object sender, EventArgs e)
    {
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        saveChanges = false;
    }

    private void ColorChooser1_VisibleChanged(object sender, EventArgs e)
    {
        if (Visible)
            saveChanges = false;
    }
  }
}
