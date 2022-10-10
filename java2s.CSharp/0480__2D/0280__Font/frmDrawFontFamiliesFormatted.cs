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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/DrawFontFamiliesFormatted.htm
    public partial  class frmDrawFontFamiliesFormatted:Form
    {
        public frmDrawFontFamiliesFormatted()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawFontFamiliesFormatted
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawFontFamiliesFormatted";
            this.Text = "frmDrawFontFamiliesFormatted";
            this.Load += new System.EventHandler(this.frmDrawFontFamiliesFormatted_Load);
            this.ResumeLayout(false);

        }

        private void frmDrawFontFamiliesFormatted_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            float y = 10;
            Font fnt;
            Graphics g = e.Graphics;
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Center;

            FontFamily[] ffArray = FontFamily.Families;
            foreach (FontFamily ff in ffArray)
            {
                if (ff.IsStyleAvailable(FontStyle.Regular))
                {
                    fnt = new Font(ff, 10);
                    Brush b = new SolidBrush(ForeColor);
                    g.DrawString(ff.Name, fnt, b, ClientSize.Width / 2, (int)y, fmt);
                    y += fnt.GetHeight();
                }
            }
        }
    }
}
