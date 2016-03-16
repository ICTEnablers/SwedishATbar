using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AccessibilityToolbar
{
    public partial class magnifier : Form
    {
        int defaultStyle;
        bool isLens;
        public magnifier(bool isLens)
        {
            InitializeComponent();
            this.isLens = isLens;

        }

        #region Native Methods
        //Native functions needed---------------------------------------------------------------
        [DllImport("Magnification.dll", CallingConvention = CallingConvention.ThisCall, EntryPoint = "MagShowSystemCursor")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagShowSystemCursor([MarshalAs(UnmanagedType.Bool)]bool fShowCursor);
        
        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        static extern int GetWindowLong(IntPtr hWnd, int index);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        static extern int SetWindowLong(IntPtr hWnd, int index, int val);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLayeredWindowAttributes(IntPtr hwnd, int crKey, byte bAlpha, LayeredWindowAttributeFlags dwFlags);
        [FlagsAttribute]
        [Description("Layered window flags")]
        //-----------------------------------------------------------------------------------------
        public enum LayeredWindowAttributeFlags : int
        {
            /// <summary>
            /// Use key as a transparency color
            /// </summary>
            LWA_COLORKEY = 0x00000001,
            /// <summary>
            /// Use Alpha to determine the opacity of the layered window.
            /// </summary>
            LWA_ALPHA = 0x00000002
        }

        #endregion 

        private void magnifier_Load(object sender, EventArgs e)
        {
            //Don't let the magnifier grow very large------------------------------------
            Rectangle r = Screen.PrimaryScreen.Bounds;
            MaximumSize = new Size((int)(r.Width*0.75), (int)(r.Height * 0.75));
            //Store the default style because it might be needed later to reset the settings
            defaultStyle = GetWindowLong(Handle, -20);
            //Apply settings when they change -------------------------------------------
            Properties.Settings.Default.PropertyChanged += new PropertyChangedEventHandler(settingsChanged);
            //Apply settings now for the first time -------------------------------------
            applySettings();
            //---------------------------------------------------------------------------

            if (/*Properties.Settings.Default.*/isLens)//If the magnifier is a lens make click-throughable
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                SetWindowLong(this.Handle, -20, defaultStyle | 0x80000 | 0x20);//Layered and transparent
                SetLayeredWindowAttributes(Handle, 0, 255, LayeredWindowAttributeFlags.LWA_ALPHA);
            }
            else
            {  //Otherwise, render it as toolwindow that is not click-throughable
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
                SetWindowLong(this.Handle, -20, defaultStyle | 0x80000 /*| 0x20*/);//Layered but not transparent
                //SetWindowLong(Handle, -20, defaultStyle);
                SetLayeredWindowAttributes(Handle, 0, 255, LayeredWindowAttributeFlags.LWA_ALPHA);
            }
        }


        private void settingsChanged(Object sender, PropertyChangedEventArgs args)
        {
            applySettings();
        }

        private void applySettings()
        {
            Size = new Size(Properties.Settings.Default.maxMagnifierWidth, Properties.Settings.Default.maxMagnifierHeight);
            TopMost = Properties.Settings.Default.alwaysOnTop;
        }

        private void magnifier_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PropertyChanged -= new PropertyChangedEventHandler(settingsChanged);
        }
    }
}
