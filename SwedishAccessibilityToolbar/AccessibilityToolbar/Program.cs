using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using Microsoft.Win32;
using System.ComponentModel;

namespace AccessibilityToolbar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Properties.Settings.Default.culture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.culture);
            Application.CurrentCulture = new CultureInfo(Properties.Settings.Default.culture);
            
            bool createdNew;
            using (Mutex mutex = new Mutex(true, "ArabicAccessibilityToolbar", out createdNew))
            //This to prevent multiple toolbar instance from being launched in parallel
            {
                if (createdNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                }
            }
        }

        public static void refreshCulture(this Form form)
        {
            ComponentResourceManager r = new ComponentResourceManager(form.GetType());
            r.ApplyResources(form, "$this");
            foreach (Control c in form.Controls)
            {
                refreshControlCulture(c, form);
            }
        }

        private static void refreshControlCulture(Control control, Form form)
        {
            ComponentResourceManager r = new ComponentResourceManager(form.GetType());
            r.ApplyResources(control, control.Name);
            foreach (Control c in control.Controls)
            {
                refreshControlCulture(c, form);
            }
        }
    }
}
