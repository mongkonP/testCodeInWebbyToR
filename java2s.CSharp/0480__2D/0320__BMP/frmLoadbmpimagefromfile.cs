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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Loadbmpimagefromfile.htm
    public partial  class frmLoadbmpimagefromfile:Form
    {
        private Image theImage;
        public frmLoadbmpimagefromfile()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Opaque, true);
            theImage = new Bitmap(@"Files\Image\4714998_avatar_miner_people_person_profile_icon.png");
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadbmpimagefromfile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadbmpimagefromfile";
            this.Text = "frmLoadbmpimagefromfile";
            this.Load += new System.EventHandler(this.frmLoadbmpimagefromfile_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadbmpimagefromfile_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawImage(theImage, ClientRectangle);
        }
    }
}
