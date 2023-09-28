using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0285__Image
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/LoadPicturefromInternet.htm
    public partial  class frmLoadPicturefromInternet:Form
    {
        public frmLoadPicturefromInternet()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadPicturefromInternet
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadPicturefromInternet";
            this.Text = "frmLoadPicturefromInternet";
            this.Load += new System.EventHandler(this.frmLoadPicturefromInternet_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            WebRequest wReq = WebRequest.Create("https://images4.alphacoders.com/565/56576.jpg");  // using System.Net;
            WebResponse wRes = wReq.GetResponse();
            Stream strm = wRes.GetResponseStream();
            Image im = Image.FromStream(strm);
            e.Graphics.DrawImage(im, 0, 50);
            strm.Close();
        }
        private void frmLoadPicturefromInternet_Load(object sender, EventArgs e)
        {

        }
    }
}
