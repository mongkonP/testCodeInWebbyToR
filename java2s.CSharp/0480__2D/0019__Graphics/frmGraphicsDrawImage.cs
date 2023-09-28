using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0019__Graphics
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/GraphicsDrawImage.htm
    public partial  class frmGraphicsDrawImage:Form
    {
        public frmGraphicsDrawImage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGraphicsDrawImage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGraphicsDrawImage";
            this.Text = "frmGraphicsDrawImage";
            this.Load += new System.EventHandler(this.frmGraphicsDrawImage_Load);
            this.ResumeLayout(false);

        }

        private void frmGraphicsDrawImage_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap bmp = new Bitmap(@"\Files\Image\promotion_marketing.png");

            Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
            g.DrawImage(bmp, r, r, GraphicsUnit.Pixel);
        }
    }
}
