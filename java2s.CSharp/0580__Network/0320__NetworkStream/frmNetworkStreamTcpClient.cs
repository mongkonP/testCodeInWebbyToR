using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0320__NetworkStream
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/NetworkStreamTcpClient.htm
    public partial  class frmNetworkStreamTcpClient:Form
    {
        public frmNetworkStreamTcpClient()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNetworkStreamTcpClient
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNetworkStreamTcpClient";
            this.Text = "frmNetworkStreamTcpClient";
            this.Load += new System.EventHandler(this.frmNetworkStreamTcpClient_Load);
            this.ResumeLayout(false);

        }

        private void frmNetworkStreamTcpClient_Load(object sender, EventArgs e)
        {

        }
    }
}
