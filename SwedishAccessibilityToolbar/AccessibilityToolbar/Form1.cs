using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Karna.Magnification;
using System.Globalization;
using System.Threading;
using System.Reflection;
using System.Runtime.InteropServices;

namespace AccessibilityToolbar
{
    public partial class Form1 : Form
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int Wow64DisableWow64FsRedirection(ref IntPtr ptr);
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int Wow64EnableWow64FsRedirection(ref IntPtr ptr);

        magnifier magnifierWindowLens = null;
        magnifier magnifierWindowDocked = null;
        Magnifier mgnLens = null;
        Magnifier mgnDocked = null;
        Overlay overlay = new Overlay();
        System.Diagnostics.Process pKeyboard = null;
        System.Diagnostics.Process pNarrtor = null;
        PreferencesForm preferencesForm = null;
        Manual manual = null;
        Aboutus aboutus = null;
        int overlayCounter = 0;

        public Form1()
        {
            //When the overlay is closed uncheck the overlay button-----------------
            overlay.FormClosing += uncheckContrast;
            //Apply settings on the toolbar when they get changed--------------------
            Properties.Settings.Default.PropertyChanged +=new PropertyChangedEventHandler(settingsChanged);
            InitializeComponent();
        }

        private void settingsChanged(Object sender, PropertyChangedEventArgs e)
        {
            applySettings();
        }

        //Magnifier------------------------------------------------------------------------------------
        private void magnifierButton_Click(object sender, EventArgs e)
        {
            startMagnifier();
        }

        private void startMagnifier()
        {
            if (magnifierButton.Checked)
            {
                if (Properties.Settings.Default.isLens)
                {
                    magnifierWindowLens = new magnifier(Properties.Settings.Default.isLens);
                    magnifierWindowLens.Show();
                    mgnLens = new Karna.Magnification.Magnifier(magnifierWindowLens, Properties.Settings.Default.isLens);
                    magnifierWindowLens.FormClosing += uncheckMagnifier;
                    mgnLens.Magnification = (float)(Properties.Settings.Default.magnificationRate + 2.0) / 2;
                }
                else
                {
                    magnifierWindowDocked = new magnifier(Properties.Settings.Default.isLens);
                    magnifierWindowDocked.Show();
                    mgnDocked = new Magnifier(magnifierWindowDocked, Properties.Settings.Default.isLens);
                    magnifierWindowDocked.FormClosing += uncheckMagnifier;
                    mgnDocked.Magnification = (float)(Properties.Settings.Default.magnificationRate + 2.0) / 2;
                }
            }
            else
            {
                if (magnifierWindowLens != null && !magnifierWindowLens.IsDisposed)
                {
                    magnifierWindowLens.Close();
                    magnifierWindowLens.Dispose();
                }
                if (magnifierWindowDocked != null && !magnifierWindowDocked.IsDisposed)
                {
                    magnifierWindowDocked.Close();
                    magnifierWindowDocked.Dispose();
                }
            }
        }

        private void uncheckMagnifier(Object sender, FormClosingEventArgs e)
        {//called when the magnifier is closed form an external actor
            magnifierButton.Checked = false;
        }

        //On-Screen keyboard--------------------------------------------------------------------------
        private void keyboardButton_Click(object sender, EventArgs e)
        {
            startKeyboard();
        }

        private void startKeyboard()
        {
            if (keyboardButton.Checked)
            {
                IntPtr val = IntPtr.Zero;
                Wow64DisableWow64FsRedirection(ref val);
                pKeyboard = System.Diagnostics.Process.Start("osk.exe");
                pKeyboard.Exited += uncheckKeyboard;
                Wow64EnableWow64FsRedirection(ref val);
                //pKeyboard.EnableRaisingEvents = true;
            }
            else
                if (pKeyboard != null)
                {
                    try
                    {
                        pKeyboard.Kill();
                    }
                    catch { }
                }
        }

        private delegate void uncheck(Object sender, EventArgs ev);

        private void uncheckKeyboard(Object sender, EventArgs e)
        {//called when the on-screen keyboard is closed form an external actor
            if (keyboardButton.InvokeRequired)
            {
                uncheck u = new uncheck(uncheckKeyboard);
                try
                {
                    this.Invoke(u, new object[] { sender, e });
                }
                catch (Exception ex)
                {
                    Exception exep = ex;
                }
            }
            else
                keyboardButton.Checked = false;
        }

        //Overlay------------------------------------------------------------------------
        private void contrastButton_Click(object sender, EventArgs e)
        {
            startContrast();
        }

        private void startContrast()
        {
            overlayCounter++;
            if (contrastButton.Checked)
            {
                overlay.Show();
                if (overlayCounter == 10)
                {
                    overlayCounter = 0;
                    System.GC.Collect();
                }
            }
            else
            {
                if (overlay != null)
                {
                    overlay.Hide();
                }
            }
        }

        private void uncheckContrast(Object sender, FormClosingEventArgs e)
        {//called when the overlay is closed form an external actor
            contrastButton.Checked = false;
        }

        //Narrator-------------------------------------------------------------------------------------
        private void narratorButton_Click(object sender, EventArgs e)
        {
            startNarrator();
        }

        private void startNarrator()
        {
            if (narratorButton.Checked)
            {
                pNarrtor = System.Diagnostics.Process.Start("narrator");
                pNarrtor.Exited += uncheckNarrator;
                pNarrtor.EnableRaisingEvents = true;
            }
            else
                if (pNarrtor != null)
                {
                    try
                    {
                        pNarrtor.Kill();
                    }
                    catch { }
                }
        }

        private void uncheckNarrator(Object sender, EventArgs e)
        {//called when the narrator is closed form an external actor------------------
            if (narratorButton.InvokeRequired)
            {
                uncheck u = new uncheck(uncheckNarrator);
                this.Invoke(u, new object[] { sender, e });
            }
            else
                narratorButton.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Apply the related settings to the form when it loads---------------------
            applySettings();
            Properties.Settings.Default.Reload();
        }

        private void applySettings()
        {
            if (magnifierWindowLens != null && !magnifierWindowLens.IsDisposed && !Properties.Settings.Default.isLens)
            {
                if (mgnLens.isLens != Properties.Settings.Default.isLens)
                {
                    bool magIsOn = magnifierButton.Checked;
                    magnifierWindowLens.Close();
                    magnifierWindowLens.Dispose();
                    magnifierButton.Checked = magIsOn;
                }
            }

            if (magnifierWindowDocked != null && !magnifierWindowDocked.IsDisposed && Properties.Settings.Default.isLens)
            {
                if (mgnDocked.isLens != Properties.Settings.Default.isLens)
                {
                    bool magIsOn = magnifierButton.Checked;
                    magnifierWindowDocked.Close();
                    magnifierWindowDocked.Dispose();
                    magnifierButton.Checked = magIsOn;
                }
            }

            if (magnifierWindowDocked != null && !magnifierWindowDocked.IsDisposed)
            {
                mgnDocked.Magnification = (float)(Properties.Settings.Default.magnificationRate + 2.0) / 2;
            }

            if (magnifierWindowLens != null && !magnifierWindowLens.IsDisposed)
            {
                mgnLens.Magnification = (float)(Properties.Settings.Default.magnificationRate + 2.0) / 2;
            }

            TopMost = Properties.Settings.Default.alwaysOnTop;
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save preferences-----------------------------------------------------------------------------
            Properties.Settings.Default.Save();

            //Close all sub-windows before closing the application (on-screen keyboard, narrator, overlay and magnifier)-------------
            if (magnifierWindowLens != null && !magnifierWindowLens.IsDisposed)
            {
                magnifierWindowLens.FormClosing -= uncheckMagnifier;
                magnifierWindowLens.Close();
            }
            if (magnifierWindowDocked != null && !magnifierWindowDocked.IsDisposed)
            {
                magnifierWindowDocked.FormClosing -= uncheckMagnifier;
                magnifierWindowDocked.Close();
            }

            if (overlay != null)
            {
                overlay.FormClosing -= uncheckContrast;
                overlay.Close();
            }

            if (pKeyboard != null)
                try
                {
                    pKeyboard.Exited -= uncheckKeyboard;
                    pKeyboard.Kill();
                }
                catch { }
            if (pNarrtor != null)
                try
                {
                    pNarrtor.Exited -= uncheckNarrator;
                    pNarrtor.Kill();
                }
                catch { }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (preferencesForm == null || preferencesForm.IsDisposed)
            {
                preferencesForm = new PreferencesForm();
                preferencesForm.Show();
            }
            else
            {
                preferencesForm.Focus();
            }
        }

        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            switch (keys)
            {
                case(Keys.Control | Keys.K):
                    keyboardButton.Checked = !keyboardButton.Checked;
                    //startKeyboard();
                    return true;
                case (Keys.Control | Keys.M):
                    magnifierButton.Checked = !magnifierButton.Checked;
                    //startMagnifier();
                    return true;
                case (Keys.Control | Keys.G):
                    contrastButton.Checked = !contrastButton.Checked;
                    //startContrast();
                    return true;
                case (Keys.Control | Keys.R):
                    narratorButton.Checked = !narratorButton.Checked;
                    //startNarrator();
                    return true;
            }

            return base.ProcessCmdKey(ref message, keys);
        }

        private void العربيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("ar");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");
            //Application.CurrentCulture = new CultureInfo("ar");
            Properties.Settings.Default.culture = "ar";
            //Properties.Settings.Default.Save();
            //if (preferencesForm != null && !preferencesForm.IsDisposed)
            //    preferencesForm.refreshCulture();
            //refreshCulture();

            ToolStrip s = ((ToolStripMenuItem)sender).GetCurrentParent();

            foreach (ToolStripMenuItem i in s.Items)
            {
                i.Checked = false;
            }
            ((ToolStripMenuItem)sender).Checked = true;
        }

        public void refreshCulture()
        {
            ComponentResourceManager r = new ComponentResourceManager(this.GetType());
            r.ApplyResources(this, "$this");
            foreach (Control c in this.Controls)
            {
                refreshControlCulture(c);
            }
            r.ApplyResources(menuStrip1, "menuStrip1");
            foreach (ToolStripItem i in menuStrip1.Items)
            {
                r.ApplyResources(i, i.Name);
                foreach (ToolStripItem ii in ((ToolStripDropDownItem)i).DropDownItems)
                {
                    r.ApplyResources(ii, ii.Name);
                }
            }
        }

        private void refreshControlCulture(Control control)
        {
            ComponentResourceManager r = new ComponentResourceManager(this.GetType());
            r.ApplyResources(control, control.Name);
            foreach (Control c in control.Controls)
            {
                refreshControlCulture(c);
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            //Application.CurrentCulture = new CultureInfo("en");
            Properties.Settings.Default.culture = "en";
            //Properties.Settings.Default.Save();
            //if (preferencesForm != null && !preferencesForm.IsDisposed)
            //    preferencesForm.refreshCulture();
            //refreshCulture();

            ToolStrip s = ((ToolStripMenuItem)sender).GetCurrentParent();

            foreach (ToolStripMenuItem i in s.Items)
            {
                i.Checked = false;
            }
            ((ToolStripMenuItem)sender).Checked = true;
        }

        private void اللغةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem d = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem i in d.DropDown.Items)
            {
                if ((String)i.Tag == Properties.Settings.Default.culture)
                    i.Checked = true;
            }
        }

        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(manual != null && !manual.IsDisposed))
            {
                manual = new Manual();
                manual.TopMost = true;
                manual.Show();
            }
            else
            {
                manual.Focus();
            }
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(aboutus != null && !aboutus.IsDisposed))
            {
                aboutus = new Aboutus();
                aboutus.TopMost = true;
                aboutus.Show();
            }
            else
            {
                aboutus.Focus();
            }
        }
    }
}
