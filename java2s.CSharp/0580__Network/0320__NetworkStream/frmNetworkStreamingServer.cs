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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/NetworkStreamingServer.htm
    public partial  class frmNetworkStreamingServer:Form
    {
        public frmNetworkStreamingServer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNetworkStreamingServer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNetworkStreamingServer";
            this.Text = "frmNetworkStreamingServer";
            this.Load += new System.EventHandler(this.frmNetworkStreamingServer_Load);
            this.ResumeLayout(false);

        }

        private void frmNetworkStreamingServer_Load(object sender, EventArgs e)
        {

        }
    }
}
