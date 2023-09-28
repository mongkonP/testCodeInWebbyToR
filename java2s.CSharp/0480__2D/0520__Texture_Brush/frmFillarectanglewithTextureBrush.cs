using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0520__Texture_Brush
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/FillarectanglewithTextureBrush.htm
    public partial  class frmFillarectanglewithTextureBrush:Form
    {
        private System.ComponentModel.Container components = null;
        private Brush brush;
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

        public frmFillarectanglewithTextureBrush()
        {
            InitializeComponent();
            try
            {
                Image img = new Bitmap(@"Files\Image\3561853_emoji_emoticon_happy_laugh_icon.png");
                brush = new TextureBrush(img);
            }
            catch (Exception e)
            { MessageBox.Show(e.Message); }

        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFillarectanglewithTextureBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFillarectanglewithTextureBrush";
            this.Text = "frmFillarectanglewithTextureBrush";
            this.Load += new System.EventHandler(this.frmFillarectanglewithTextureBrush_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Resize += new System.EventHandler(this.RectangleTextureFill_Resize);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RectangleTextureFill_Paint);
            this.ResumeLayout(false);

        }
        private void RectangleTextureFill_Resize(object sender, System.EventArgs e)
        {
            Invalidate();
        }

        private void RectangleTextureFill_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = ClientRectangle;

            g.FillRectangle(brush, r);
        }
        private void frmFillarectanglewithTextureBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
