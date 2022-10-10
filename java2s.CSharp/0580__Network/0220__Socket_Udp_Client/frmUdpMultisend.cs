using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0220__Socket_Udp_Client
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UdpMultisend.htm
    public partial  class frmUdpMultisend:Form
    {
        public frmUdpMultisend()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUdpMultisend
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUdpMultisend";
            this.Text = "frmUdpMultisend";
            this.Load += new System.EventHandler(this.frmUdpMultisend_Load);
            this.ResumeLayout(false);

        }

        private void frmUdpMultisend_Load(object sender, EventArgs e)
        {

        }
    }
}
