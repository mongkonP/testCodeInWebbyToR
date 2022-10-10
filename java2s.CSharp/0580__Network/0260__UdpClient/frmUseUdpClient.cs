using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0260__UdpClient
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UseUdpClient.htm
    public partial  class frmUseUdpClient:Form
    {
        public frmUseUdpClient()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseUdpClient
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseUdpClient";
            this.Text = "frmUseUdpClient";
            this.Load += new System.EventHandler(this.frmUseUdpClient_Load);
            this.ResumeLayout(false);

        }

        private void frmUseUdpClient_Load(object sender, EventArgs e)
        {

        }
    }
}
