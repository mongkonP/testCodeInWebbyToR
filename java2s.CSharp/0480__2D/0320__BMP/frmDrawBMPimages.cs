using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0320__BMP
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/DrawBMPimages.htm
    public partial class frmDrawBMPimages : Form
    {
        private System.ComponentModel.Container components = null;

        private Bitmap bMapImageA = new Bitmap(@"\Files\Image\3561841_emoji_expression_glared_shocked_surprised_icon.png");
        private Bitmap bMapImageB = new Bitmap(@"Files\Image\3561842_emoji_emoticon_expression_shame_smiley_icon.png");
        private Bitmap bMapImageC = new Bitmap(@"Files\Image\3561853_emoji_emoticon_happy_laugh_icon.png");

        private Rectangle rectA = new Rectangle(10, 10, 90, 90);
        private Rectangle rectB = new Rectangle(10, 110, 90, 90);
        private Rectangle rectC = new Rectangle(10, 210, 90, 90);

        private bool isImageClicked = false;
        private int imageClickedIndex;
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        public frmDrawBMPimages()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawBMPimages
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawBMPimages";
            this.Text = "frmDrawBMPimages";
            this.Load += new System.EventHandler(this.frmDrawBMPimages_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(376, 361);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageDraw_MouseUp);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ImageDraw_Paint);
            this.ResumeLayout(false);

        }

        private void frmDrawBMPimages_Load(object sender, EventArgs e)
        {

        }
        private void ImageDraw_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point mousePt = new Point(e.X, e.Y);

            if (rectA.Contains(mousePt))
            {
                isImageClicked = true;
                imageClickedIndex = 0;
            }
            else if (rectB.Contains(mousePt))
            {
                isImageClicked = true;
                imageClickedIndex = 1;
            }
            else if (rectC.Contains(mousePt))
            {
                isImageClicked = true;
                imageClickedIndex = 2;
            }
            else  // Not in any shape, set defaults.
            {
                isImageClicked = false;
            }
            Invalidate();
        }

        private void ImageDraw_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawImage(bMapImageA, rectA);
            g.DrawImage(bMapImageB, rectB);
            g.DrawImage(bMapImageC, rectC);

            if (isImageClicked == true)
            {
                Pen outline = new Pen(Color.Purple, 5);

                switch (imageClickedIndex)
                {
                    case 0:
                        g.DrawRectangle(outline, rectA);
                        break;

                    case 1:
                        g.DrawRectangle(outline, rectB);
                        break;

                    case 2:
                        g.DrawRectangle(outline, rectC);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
