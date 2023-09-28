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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/DownloadData.htm
    public partial  class frmDownloadData:Form
    {
        public frmDownloadData()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDownloadData
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDownloadData";
            this.Text = "frmDownloadData";
            this.Load += new System.EventHandler(this.frmDownloadData_Load);
            this.ResumeLayout(false);

        }

        private void frmDownloadData_Load(object sender, EventArgs e)
        {

        }
    }
}
