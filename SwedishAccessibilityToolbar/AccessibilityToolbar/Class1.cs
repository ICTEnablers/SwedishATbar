using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace AccessibilityToolbar
{
    class DropDownListColoured : ComboBox
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            e.DrawBackground();
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;

            if (e.Index >= 0)
            {
                string n = (String)((listItem)Items[e.Index]).name;
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = ((Color)((listItem)Items[e.Index]).color);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 40, rect.Y + 5,
                                rect.Width - 10, rect.Height - 10);
                e.DrawFocusRectangle();
            }
        }
    }

    class listItem
    {
        public Color color;
        public string name;
        public string toString()
        {
            return name;
        }
    }
}
