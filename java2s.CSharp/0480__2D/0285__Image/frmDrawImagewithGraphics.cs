using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0285__Image
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/DrawImagewithGraphics.htm
    public partial  class frmDrawImagewithGraphics:Form
    {
        public frmDrawImagewithGraphics()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawImagewithGraphics
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawImagewithGraphics";
            this.Text = "frmDrawImagewithGraphics";
            this.Load += new System.EventHandler(this.frmDrawImagewithGraphics_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap bmp = new Bitmap(@"Files\Image\promotion_marketing.png");
            g.FillRectangle(Brushes.White, this.ClientRectangle);

            Rectangle sr = new Rectangle(80, 60, 400, 400);
            Rectangle dr = new Rectangle(0, 0, 400, 400);
            g.DrawImage(bmp, dr, sr, GraphicsUnit.Pixel);
        }
        private void frmDrawImagewithGraphics_Load(object sender, EventArgs e)
        {

        }
    }
}
