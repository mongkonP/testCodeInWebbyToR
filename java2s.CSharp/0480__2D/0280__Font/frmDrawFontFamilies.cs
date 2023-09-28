using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0280__Font
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/DrawFontFamilies.htm
    public partial  class frmDrawFontFamilies:Form
    {
        public frmDrawFontFamilies()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawFontFamilies
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawFontFamilies";
            this.Text = "frmDrawFontFamilies";
            this.Load += new System.EventHandler(this.frmDrawFontFamilies_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            float x = 10;
            float y = 10;
            Font fnt;
            Graphics g = e.Graphics;

            FontFamily[] ffArray = FontFamily.Families;
            foreach (FontFamily ff in ffArray)
            {
                if (ff.IsStyleAvailable(FontStyle.Regular))
                {
                    fnt = new Font(ff, 10);
                    g.DrawString(ff.Name, fnt, Brushes.Black, x, y);
                    Brush b = new SolidBrush(ForeColor);
                    g.DrawString(ff.Name, fnt, b, x, y);

                    y += fnt.GetHeight();
                }
            }
        }
        private void frmDrawFontFamilies_Load(object sender, EventArgs e)
        {

        }
    }
}
