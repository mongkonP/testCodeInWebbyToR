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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/GetFontHeight.htm
    public partial  class frmGetFontHeight:Form
    {
        public frmGetFontHeight()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetFontHeight
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetFontHeight";
            this.Text = "frmGetFontHeight";
            this.Load += new System.EventHandler(this.frmGetFontHeight_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs pea)
        {
            DoPage(pea.Graphics, ForeColor, ClientSize.Width, ClientSize.Height);
        }
        protected void DoPage(Graphics grfx, Color clr, int cx, int cy)
        {
            Brush brush = new SolidBrush(clr);
            float y = 0;
            Font font;
            string strFamily = "Times New Roman";

            font = new Font(strFamily, 24);
            grfx.DrawString("No GraphicsUnit, 24 points", font, brush, 0, y);
            y += font.GetHeight(grfx);

            font = new Font(strFamily, 24, GraphicsUnit.Point);
            grfx.DrawString("GraphicsUnit.Point, 24 units", font, brush, 0, y);


        }
        private void frmGetFontHeight_Load(object sender, EventArgs e)
        {

        }
    }
}
