namespace AccessibilityToolbar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.keyboardButton = new System.Windows.Forms.CheckBox();
            this.narratorButton = new System.Windows.Forms.CheckBox();
            this.magnifierButton = new System.Windows.Forms.CheckBox();
            this.contrastButton = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اللغةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.العربيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyboardButton
            // 
            resources.ApplyResources(this.keyboardButton, "keyboardButton");
            this.keyboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton.Name = "keyboardButton";
            this.keyboardButton.Tag = "On-Screen Keyboard";
            this.keyboardButton.UseVisualStyleBackColor = true;
            this.keyboardButton.CheckedChanged += new System.EventHandler(this.keyboardButton_Click);
            // 
            // narratorButton
            // 
            resources.ApplyResources(this.narratorButton, "narratorButton");
            this.narratorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.narratorButton.Image = global::AccessibilityToolbar.Properties.Resources.tts;
            this.narratorButton.Name = "narratorButton";
            this.narratorButton.Tag = "Screen Reader";
            this.narratorButton.UseVisualStyleBackColor = true;
            this.narratorButton.CheckedChanged += new System.EventHandler(this.narratorButton_Click);
            // 
            // magnifierButton
            // 
            resources.ApplyResources(this.magnifierButton, "magnifierButton");
            this.magnifierButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magnifierButton.Image = global::AccessibilityToolbar.Properties.Resources.magnifier_zoom_in;
            this.magnifierButton.Name = "magnifierButton";
            this.magnifierButton.UseVisualStyleBackColor = true;
            this.magnifierButton.CheckedChanged += new System.EventHandler(this.magnifierButton_Click);
            // 
            // contrastButton
            // 
            resources.ApplyResources(this.contrastButton, "contrastButton");
            this.contrastButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contrastButton.Image = global::AccessibilityToolbar.Properties.Resources.overlay;
            this.contrastButton.Name = "contrastButton";
            this.contrastButton.Tag = "Colour Overlay";
            this.contrastButton.UseVisualStyleBackColor = true;
            this.contrastButton.CheckedChanged += new System.EventHandler(this.contrastButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.اللغةToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            resources.ApplyResources(this.preferencesToolStripMenuItem, "preferencesToolStripMenuItem");
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            resources.ApplyResources(this.userGuideToolStripMenuItem, "userGuideToolStripMenuItem");
            this.userGuideToolStripMenuItem.Click += new System.EventHandler(this.userGuideToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            resources.ApplyResources(this.aboutUsToolStripMenuItem, "aboutUsToolStripMenuItem");
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // اللغةToolStripMenuItem
            // 
            this.اللغةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.العربيةToolStripMenuItem,
            this.englishToolStripMenuItem});
            resources.ApplyResources(this.اللغةToolStripMenuItem, "اللغةToolStripMenuItem");
            this.اللغةToolStripMenuItem.Name = "اللغةToolStripMenuItem";
            this.اللغةToolStripMenuItem.Click += new System.EventHandler(this.اللغةToolStripMenuItem_Click);
            // 
            // العربيةToolStripMenuItem
            // 
            this.العربيةToolStripMenuItem.Name = "العربيةToolStripMenuItem";
            resources.ApplyResources(this.العربيةToolStripMenuItem, "العربيةToolStripMenuItem");
            this.العربيةToolStripMenuItem.Tag = "ar";
            this.العربيةToolStripMenuItem.Click += new System.EventHandler(this.العربيةToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Tag = "en";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contrastButton);
            this.Controls.Add(this.narratorButton);
            this.Controls.Add(this.keyboardButton);
            this.Controls.Add(this.magnifierButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Tag = "Accessibility ToolBar";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox magnifierButton;
        private System.Windows.Forms.CheckBox keyboardButton;
        private System.Windows.Forms.CheckBox narratorButton;
        private System.Windows.Forms.CheckBox contrastButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem اللغةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem العربيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    }
}

