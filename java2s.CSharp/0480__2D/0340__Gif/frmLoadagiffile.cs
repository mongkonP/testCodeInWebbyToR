using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0340__Gif
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Loadagiffile.htm
    public partial  class frmLoadagiffile:Form
    {
        public frmLoadagiffile()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BitmapLoading_Paint);

        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadagiffile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadagiffile";
            this.Text = "frmLoadagiffile";
            this.Load += new System.EventHandler(this.frmLoadagiffile_Load);
            this.ResumeLayout(false);

        }
        private void BitmapLoading_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap b = new Bitmap(@"Files\Image\Anime - Chi's Sweet Home.gif");
            g.DrawImage(b, 10, 10, 350, 300);
        }
        private void frmLoadagiffile_Load(object sender, EventArgs e)
        {

        }
    }
}
