using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0360__WebClient
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/DownloadHTMfiles.htm
    public partial  class frmDownloadHTMfiles:Form
    {
        public frmDownloadHTMfiles()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDownloadHTMfiles
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDownloadHTMfiles";
            this.Text = "frmDownloadHTMfiles";
            this.Load += new System.EventHandler(this.frmDownloadHTMfiles_Load);
            this.ResumeLayout(false);

        }

        private void frmDownloadHTMfiles_Load(object sender, EventArgs e)
        {

        }
    }
}
