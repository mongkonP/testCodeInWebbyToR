using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0380__JPG
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Loadajpgfile.htm
    public partial  class frmLoadajpgfile:Form
    {
        public frmLoadajpgfile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadajpgfile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadajpgfile";
            this.Text = "frmLoadajpgfile";
            this.Load += new System.EventHandler(this.frmLoadajpgfile_Load);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BitmapLoading_Paint);
            this.ResumeLayout(false);

        }
        private void BitmapLoading_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap b = new Bitmap(@"Files\Image\4714998_avatar_miner_people_person_profile_icon.png");
            g.DrawImage(b, 10, 10, 350, 300);
        }
        private void frmLoadajpgfile_Load(object sender, EventArgs e)
        {

        }
    }
}
