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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/DownloadstringfromawebsiteusingtheWebClient.htm
    public partial  class frmDownloadstringfromawebsiteusingtheWebClient:Form
    {
        public frmDownloadstringfromawebsiteusingtheWebClient()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDownloadstringfromawebsiteusingtheWebClient
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDownloadstringfromawebsiteusingtheWebClient";
            this.Text = "frmDownloadstringfromawebsiteusingtheWebClient";
            this.Load += new System.EventHandler(this.frmDownloadstringfromawebsiteusingtheWebClient_Load);
            this.ResumeLayout(false);

        }

        private void frmDownloadstringfromawebsiteusingtheWebClient_Load(object sender, EventArgs e)
        {

        }
    }
}
