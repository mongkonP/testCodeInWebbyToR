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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/FontStyleItalic.htm
    public partial  class frmFontStyleItalic:Form
    {
        public frmFontStyleItalic()
        {
            InitializeComponent();
            Text = "Font Names";
            ResizeRedraw = true;
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFontStyleItalic
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFontStyleItalic";
            this.Text = "frmFontStyleItalic";
            this.Load += new System.EventHandler(this.frmFontStyleItalic_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs pea)
        {
            DoPage(pea.Graphics, ForeColor, ClientSize.Width, ClientSize.Height);
        }
        protected void DoPage(Graphics grfx, Color clr, int cx, int cy)
        {
            string[] astrFonts = { "Courier New", "Arial",
                                    "Times New Roman" };
            FontStyle[] afs = { FontStyle.Italic,
                                    FontStyle.Bold | FontStyle.Italic };
            Brush brush = new SolidBrush(clr);
            float y = 0;

            foreach (string strFont in astrFonts)
            {
                foreach (FontStyle fs in afs)
                {
                    Font font = new Font(strFont, 18, fs);
                    grfx.DrawString(strFont, font, brush, 0, y);
                    y += font.GetHeight(grfx);
                }
            }
        }
        private void frmFontStyleItalic_Load(object sender, EventArgs e)
        {

        }
    }
}
