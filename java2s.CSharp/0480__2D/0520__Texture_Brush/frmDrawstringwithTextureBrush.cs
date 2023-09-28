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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/DrawstringwithTextureBrush.htm
    public partial  class frmDrawstringwithTextureBrush:Form
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

        public frmDrawstringwithTextureBrush()
        {
            InitializeComponent();
            try
            {
                Image img = new Bitmap(@"Files\Image\3561842_emoji_emoticon_expression_shame_smiley_icon.png");
                brush = new TextureBrush(img);
            }
            catch (Exception e)
            { MessageBox.Show(e.Message); }
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawstringwithTextureBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawstringwithTextureBrush";
            this.Text = "frmDrawstringwithTextureBrush";
            this.Load += new System.EventHandler(this.frmDrawstringwithTextureBrush_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Resize += new System.EventHandler(this.StringTextureFill_Resize);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.StringTextureFill_Paint);
            this.ResumeLayout(false);

        }
        private void StringTextureFill_Resize(object sender, System.EventArgs e)
        {
            Invalidate();
        }

        private void StringTextureFill_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = ClientRectangle;

            g.DrawString("Bitmaps as brushes!",
              new Font("Arial", 60,
              FontStyle.Bold | FontStyle.Italic),
              brush,
              r);

        }
        private void frmDrawstringwithTextureBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
