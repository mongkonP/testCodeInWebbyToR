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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/TextureBrushfordrawingstring.htm
    public partial  class frmTextureBrushfordrawingstring:Form
    {
        private Image theImage;
        public frmTextureBrushfordrawingstring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTextureBrushfordrawingstring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTextureBrushfordrawingstring";
            this.Text = "frmTextureBrushfordrawingstring";
            this.Load += new System.EventHandler(this.frmTextureBrushfordrawingstring_Load);
            this.ResumeLayout(false);

        }
       
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.White, ClientRectangle);

            Brush tBrush = new TextureBrush(theImage, new Rectangle(0, 0, theImage.Width, theImage.Height));
            Font trFont = new Font("Times New Roman", 32, FontStyle.Bold | FontStyle.Italic);
            g.DrawString("Hello from Beginning Visual C#", trFont, tBrush, ClientRectangle);
            tBrush.Dispose();
            trFont.Dispose();
        }
        private void frmTextureBrushfordrawingstring_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.Opaque, true);
            theImage = new Bitmap(@"Files\Image\promotion_marketing.png");
        }
    }
}
