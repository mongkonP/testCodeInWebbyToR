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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/TextureBrushbasedonImagefile.htm
    public partial  class frmTextureBrushbasedonImagefile:Form
    {
        private Image theImage;
        private Image smallImage;
        public frmTextureBrushbasedonImagefile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTextureBrushbasedonImagefile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTextureBrushbasedonImagefile";
            this.Text = "frmTextureBrushbasedonImagefile";
            this.Load += new System.EventHandler(this.frmTextureBrushbasedonImagefile_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.White, ClientRectangle);

            Brush tBrush = new TextureBrush(smallImage, new Rectangle(0, 0, smallImage.Width, smallImage.Height));
            g.FillEllipse(tBrush, ClientRectangle);
            tBrush.Dispose();
        }
        private void frmTextureBrushbasedonImagefile_Load(object sender, EventArgs e)
        {
            theImage = new Bitmap(@"Files\Image\4714998_avatar_miner_people_person_profile_icon.png");
            smallImage = new Bitmap(theImage, new Size(theImage.Width / 2, theImage.Height / 2));
        }
    }
}
