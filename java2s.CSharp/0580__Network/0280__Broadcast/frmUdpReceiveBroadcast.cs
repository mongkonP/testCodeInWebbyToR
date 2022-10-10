using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0280__Broadcast
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UdpReceiveBroadcast.htm
    public partial  class frmUdpReceiveBroadcast:Form
    {
        public frmUdpReceiveBroadcast()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUdpReceiveBroadcast
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUdpReceiveBroadcast";
            this.Text = "frmUdpReceiveBroadcast";
            this.Load += new System.EventHandler(this.frmUdpReceiveBroadcast_Load);
            this.ResumeLayout(false);

        }

        private void frmUdpReceiveBroadcast_Load(object sender, EventArgs e)
        {

        }
    }
}
