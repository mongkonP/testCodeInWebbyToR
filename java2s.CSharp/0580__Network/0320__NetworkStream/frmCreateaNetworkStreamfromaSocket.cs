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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/CreateaNetworkStreamfromaSocket.htm
    public partial  class frmCreateaNetworkStreamfromaSocket:Form
    {
        public frmCreateaNetworkStreamfromaSocket()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateaNetworkStreamfromaSocket
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateaNetworkStreamfromaSocket";
            this.Text = "frmCreateaNetworkStreamfromaSocket";
            this.Load += new System.EventHandler(this.frmCreateaNetworkStreamfromaSocket_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaNetworkStreamfromaSocket_Load(object sender, EventArgs e)
        {

        }
    }
}
