namespace AccessibilityToolbar
{
    partial class PreferencesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBarLabel = new System.Windows.Forms.Label();
            this.magnificationRateTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.isLensCheckBox = new System.Windows.Forms.CheckBox();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rulerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RulerCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.chooseColourButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.topMostCheckBox = new System.Windows.Forms.CheckBox();
            this.startupCheckBox = new System.Windows.Forms.CheckBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.cancelChangesButton = new System.Windows.Forms.Button();
            this.RestoreDefaultsButton = new System.Windows.Forms.Button();
            this.d = new AccessibilityToolbar.DropDownListColoured();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magnificationRateTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulerNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBarLabel);
            this.groupBox1.Controls.Add(this.magnificationRateTrackBar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.isLensCheckBox);
            this.groupBox1.Controls.Add(this.widthNumericUpDown);
            this.groupBox1.Controls.Add(this.heightNumericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // trackBarLabel
            // 
            resources.ApplyResources(this.trackBarLabel, "trackBarLabel");
            this.trackBarLabel.Name = "trackBarLabel";
            // 
            // magnificationRateTrackBar
            // 
            resources.ApplyResources(this.magnificationRateTrackBar, "magnificationRateTrackBar");
            this.magnificationRateTrackBar.Maximum = 6;
            this.magnificationRateTrackBar.Minimum = 1;
            this.magnificationRateTrackBar.Name = "magnificationRateTrackBar";
            this.magnificationRateTrackBar.Tag = "";
            this.magnificationRateTrackBar.Value = 1;
            this.magnificationRateTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // isLensCheckBox
            // 
            resources.ApplyResources(this.isLensCheckBox, "isLensCheckBox");
            this.isLensCheckBox.Name = "isLensCheckBox";
            this.isLensCheckBox.UseVisualStyleBackColor = true;
            // 
            // widthNumericUpDown
            // 
            resources.ApplyResources(this.widthNumericUpDown, "widthNumericUpDown");
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.widthNumericUpDown.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // heightNumericUpDown
            // 
            resources.ApplyResources(this.heightNumericUpDown, "heightNumericUpDown");
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.heightNumericUpDown.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rulerNumericUpDown);
            this.groupBox2.Controls.Add(this.RulerCheckBox);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.d);
            this.groupBox2.Controls.Add(this.chooseColourButton);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // rulerNumericUpDown
            // 
            resources.ApplyResources(this.rulerNumericUpDown, "rulerNumericUpDown");
            this.rulerNumericUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.rulerNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rulerNumericUpDown.Name = "rulerNumericUpDown";
            this.rulerNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // RulerCheckBox
            // 
            resources.ApplyResources(this.RulerCheckBox, "RulerCheckBox");
            this.RulerCheckBox.Name = "RulerCheckBox";
            this.RulerCheckBox.UseVisualStyleBackColor = true;
            this.RulerCheckBox.CheckedChanged += new System.EventHandler(this.RulerCheckBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // chooseColourButton
            // 
            resources.ApplyResources(this.chooseColourButton, "chooseColourButton");
            this.chooseColourButton.Name = "chooseColourButton";
            this.chooseColourButton.UseVisualStyleBackColor = true;
            this.chooseColourButton.Click += new System.EventHandler(this.chooseColourButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.topMostCheckBox);
            this.groupBox3.Controls.Add(this.startupCheckBox);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // topMostCheckBox
            // 
            resources.ApplyResources(this.topMostCheckBox, "topMostCheckBox");
            this.topMostCheckBox.Name = "topMostCheckBox";
            this.topMostCheckBox.UseVisualStyleBackColor = true;
            // 
            // startupCheckBox
            // 
            resources.ApplyResources(this.startupCheckBox, "startupCheckBox");
            this.startupCheckBox.Name = "startupCheckBox";
            this.startupCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveChangesButton
            // 
            resources.ApplyResources(this.saveChangesButton, "saveChangesButton");
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // cancelChangesButton
            // 
            resources.ApplyResources(this.cancelChangesButton, "cancelChangesButton");
            this.cancelChangesButton.Name = "cancelChangesButton";
            this.cancelChangesButton.UseVisualStyleBackColor = true;
            this.cancelChangesButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // RestoreDefaultsButton
            // 
            resources.ApplyResources(this.RestoreDefaultsButton, "RestoreDefaultsButton");
            this.RestoreDefaultsButton.Name = "RestoreDefaultsButton";
            this.RestoreDefaultsButton.UseVisualStyleBackColor = true;
            this.RestoreDefaultsButton.Click += new System.EventHandler(this.RestoreDefaultsButton_Click);
            // 
            // d
            // 
            this.d.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.d.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.d, "d");
            this.d.Name = "d";
            // 
            // PreferencesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RestoreDefaultsButton);
            this.Controls.Add(this.cancelChangesButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "PreferencesForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.PreferencesForm_Load);
            this.Shown += new System.EventHandler(this.PreferencesForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magnificationRateTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulerNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox topMostCheckBox;
        private System.Windows.Forms.CheckBox startupCheckBox;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button cancelChangesButton;
        private System.Windows.Forms.CheckBox isLensCheckBox;
        private System.Windows.Forms.Button RestoreDefaultsButton;
        private System.Windows.Forms.TrackBar magnificationRateTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label trackBarLabel;
        private System.Windows.Forms.Button chooseColourButton;
        private DropDownListColoured d;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown rulerNumericUpDown;
        private System.Windows.Forms.CheckBox RulerCheckBox;
    }
}