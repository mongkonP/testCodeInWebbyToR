using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0140__TcpClient
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/CreateNetworkStreamfromTcpClient.htm
    public partial  class frmCreateNetworkStreamfromTcpClient:Form
    {
        public frmCreateNetworkStreamfromTcpClient()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateNetworkStreamfromTcpClient
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateNetworkStreamfromTcpClient";
            this.Text = "frmCreateNetworkStreamfromTcpClient";
            this.Load += new System.EventHandler(this.frmCreateNetworkStreamfromTcpClient_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateNetworkStreamfromTcpClient_Load(object sender, EventArgs e)
        {

        }
    }
}
