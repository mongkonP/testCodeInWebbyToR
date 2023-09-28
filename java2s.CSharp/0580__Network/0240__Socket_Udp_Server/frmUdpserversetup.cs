using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0240__Socket_Udp_Server
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/Udpserversetup.htm
    public partial  class frmUdpserversetup:Form
    {
        public frmUdpserversetup()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUdpserversetup
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUdpserversetup";
            this.Text = "frmUdpserversetup";
            this.Load += new System.EventHandler(this.frmUdpserversetup_Load);
            this.ResumeLayout(false);

        }

        private void frmUdpserversetup_Load(object sender, EventArgs e)
        {

        }
    }
}
