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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/NetworkStreamingClient.htm
    public partial  class frmNetworkStreamingClient:Form
    {
        public frmNetworkStreamingClient()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNetworkStreamingClient
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNetworkStreamingClient";
            this.Text = "frmNetworkStreamingClient";
            this.Load += new System.EventHandler(this.frmNetworkStreamingClient_Load);
            this.ResumeLayout(false);

        }

        private void frmNetworkStreamingClient_Load(object sender, EventArgs e)
        {

        }
    }
}
