using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccessibilityToolbar
{
    public partial class Aboutus : Form
    {
        public Aboutus()
        {
            InitializeComponent();
        }

        private void Aboutus_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Remove(linkLabel1.Links[0]);
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, linkLabel1.Text);
            linkLabel2.Links.Remove(linkLabel2.Links[0]);
            linkLabel2.Links.Add(0, linkLabel2.Text.Length, linkLabel2.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.Links[linkLabel1.Links.IndexOf(e.Link)].Visited = true;
            string target = e.Link.LinkData.ToString();

            if (null != target)
            {
                System.Diagnostics.Process.Start(target);
            }
            else
            {
                MessageBox.Show("Item clicked: " + target);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.Links[linkLabel2.Links.IndexOf(e.Link)].Visited = true;
            string target = e.Link.LinkData.ToString();

            if (null != target)
            {
                System.Diagnostics.Process.Start(target);
            }
            else
            {
                MessageBox.Show("Item clicked: " + target);
            }
        }
    }
}
