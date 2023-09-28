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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/DownloadFile.htm
    public partial  class frmDownloadFile:Form
    {
        public frmDownloadFile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDownloadFile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDownloadFile";
            this.Text = "frmDownloadFile";
            this.Load += new System.EventHandler(this.frmDownloadFile_Load);
            this.ResumeLayout(false);

        }

        private void frmDownloadFile_Load(object sender, EventArgs e)
        {

        }
    }
}
