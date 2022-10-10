using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0400__Tif
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Loadatifimagefile.htm
    public partial  class frmLoadatifimagefile:Form
    {
        public frmLoadatifimagefile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadatifimagefile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadatifimagefile";
            this.Text = "frmLoadatifimagefile";
            this.Load += new System.EventHandler(this.frmLoadatifimagefile_Load);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BitmapLoading_Paint);
            this.ResumeLayout(false);

        }
        private void BitmapLoading_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap b = new Bitmap("YourFile.tif");
            g.DrawImage(b, 10, 10, 350, 300);
        }
        private void frmLoadatifimagefile_Load(object sender, EventArgs e)
        {

        }
    }
}
