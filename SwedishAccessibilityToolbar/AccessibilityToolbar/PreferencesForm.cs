using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Runtime.InteropServices;
using System.Resources;
using Microsoft.Win32;

namespace AccessibilityToolbar
{
    public partial class PreferencesForm : Form
    {
        int red;
        int green;
        int blue;

        public PreferencesForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            //Create a combobox for quick color selection-----------------------------
            d.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            //Load values from the settings repository--------------------------------
            loadSettings();
            applySettings();
        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SystemParametersInfo(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);

        private void applySettings()
        {//apply stored settings on the preferences window-----------------------------------
            TopMost = Properties.Settings.Default.alwaysOnTop;
            string cul = Properties.Settings.Default.culture;
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo(Properties.Settings.Default.culture));
            SystemParametersInfo(0x005A, 0, InputLanguage.CurrentInputLanguage.Handle, 0);

            red = Properties.Settings.Default.overlayR;
            green = Properties.Settings.Default.overlayG;
            blue = Properties.Settings.Default.overlayB;
            panel1.BackColor = Color.FromArgb(255, red, green, blue);
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            saveSettings();
            Close();
        }

        private void saveSettings()
        {
            //Run on System start-up?--------------------------------
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (startupCheckBox.Checked && key.GetValue("runonstartupATbar") == null)
            {
                key.SetValue("runonstartupATbar", Application.ExecutablePath.ToString());
            }
            else if(key.GetValue("runonstartupATbar") != null)
            {
                key.DeleteValue("runonstartupATbar");
            }
            Properties.Settings.Default.startWithSystem = startupCheckBox.Checked;
            //--------------------------------------------------------
            Properties.Settings.Default.alwaysOnTop = topMostCheckBox.Checked;
            Properties.Settings.Default.isLens = isLensCheckBox.Checked;
            Properties.Settings.Default.maxMagnifierHeight = (int)heightNumericUpDown.Value;
            Properties.Settings.Default.maxMagnifierWidth = (int)widthNumericUpDown.Value;
            Properties.Settings.Default.magnificationRate = magnificationRateTrackBar.Value;
            Properties.Settings.Default.overlayR = (byte)red;
            Properties.Settings.Default.overlayG = (byte)green;
            Properties.Settings.Default.overlayB = (byte)blue;

            Properties.Settings.Default.isRuler = RulerCheckBox.Checked;
            Properties.Settings.Default.rulerWidth = (int)rulerNumericUpDown.Value;
        }

        private void loadSettings()
        {   
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            startupCheckBox.Checked = key.GetValue("runonstartupATbar") != null;
            topMostCheckBox.Checked = Properties.Settings.Default.alwaysOnTop;
            isLensCheckBox.Checked = Properties.Settings.Default.isLens;
            heightNumericUpDown.Value = Properties.Settings.Default.maxMagnifierHeight;
            widthNumericUpDown.Value = Properties.Settings.Default.maxMagnifierWidth;
            trackBarLabel.Text = ((Properties.Settings.Default.magnificationRate + 2.0) / 2).ToString();
            magnificationRateTrackBar.Value = Properties.Settings.Default.magnificationRate;
            red = Properties.Settings.Default.overlayR;
            green = Properties.Settings.Default.overlayG;
            blue = Properties.Settings.Default.overlayB;

            rulerNumericUpDown.Value = Properties.Settings.Default.rulerWidth;
            RulerCheckBox.Checked = Properties.Settings.Default.isRuler;
        }
        
        private void RestoreDefaultsButton_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Register();
            MessageBoxManager.Yes = "نعم";
            MessageBoxManager.No = "لا";
            DialogResult dialogResult = MessageBox.Show(this, "هل أنت متأكد\\ة من رغبتك في استعادة الإعدادات الافتراضية ", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            MessageBoxManager.Unregister();
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                loadSettings();
                applySettings();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBarLabel.Text = ((magnificationRateTrackBar.Value + 2.0) / 2).ToString();
        }

        private void chooseColourButton_Click(object sender, EventArgs e)
        {
            //Create a colorwheel dialog and set its initial selected color to the current selected color-----------------------------------
            ColorChooserCSharp.ColorChooser1 chooser = new ColorChooserCSharp.ColorChooser1();
            chooser.TopMost = Properties.Settings.Default.alwaysOnTop;
            chooser.RGB = new ColorHandler.RGB((int)red, (int)green, (int)blue);
            chooser.ShowDialog();

            //Get colour results form the dialog and save them in the state and update the colour panel
            if (chooser.saveChanges)
            {
                green = chooser.RGBOUT.Green;
                red = chooser.RGBOUT.Red;
                blue = chooser.RGBOUT.Blue;
                panel1.BackColor = Color.FromArgb(255, red, green, blue);
                d.SelectedIndex = -1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (d.SelectedItem != null)
            {
                //Get the selected colour-----------
                Color color = ((listItem)d.SelectedItem).color;
                //Store the state-------------------
                red = color.R;
                green = color.G;
                blue = color.B;
                //update the color panel------------
                panel1.BackColor = Color.FromArgb(255, red, green, blue);
            }
        }

        private void PreferencesForm_Shown(object sender, EventArgs e)
        {
            //Fill the list of Colours of the combobox----------------------------------------
            ResourceManager man1 = Properties.Resources.ResourceManager;

            if (Thread.CurrentThread.CurrentUICulture.Name == "ar")
            {
                var item = new listItem { name = "أحمر", color = Color.Red };
                d.Items.Add(item);
                item = new listItem { name = "أخضر", color = Color.Green };
                d.Items.Add(item);
                item = new listItem { name = "أزرق", color = Color.Blue };
                d.Items.Add(item);
                item = new listItem { name = "أصفر", color = Color.Yellow };
                d.Items.Add(item);
                item = new listItem { name = "برتقالي", color = Color.Orange };
                d.Items.Add(item);
                d.DisplayMember = "name";
            }
            if (Thread.CurrentThread.CurrentUICulture.Name == "en")
            {
                var item = new listItem { name = "Röd", color = Color.Red };
                d.Items.Add(item);
                item = new listItem { name = "Grön", color = Color.Green };
                d.Items.Add(item);
                item = new listItem { name = "Blå", color = Color.Blue };
                d.Items.Add(item);
                item = new listItem { name = "Gul", color = Color.Yellow };
                d.Items.Add(item);
                item = new listItem { name = "Orange", color = Color.Orange };
                d.Items.Add(item);
                d.DisplayMember = "name";
            }
        }

        private void RulerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RulerCheckBox.Checked)
            {
                rulerNumericUpDown.Enabled = true;
            }
            else
            {
                rulerNumericUpDown.Enabled = false;
            }
        }
    }
}
