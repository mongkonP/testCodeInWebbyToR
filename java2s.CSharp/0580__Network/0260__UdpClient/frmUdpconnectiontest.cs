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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/Udpconnectiontest.htm
    public partial  class frmUdpconnectiontest:Form
    {
        public frmUdpconnectiontest()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUdpconnectiontest
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUdpconnectiontest";
            this.Text = "frmUdpconnectiontest";
            this.Load += new System.EventHandler(this.frmUdpconnectiontest_Load);
            this.ResumeLayout(false);

        }

        private void frmUdpconnectiontest_Load(object sender, EventArgs e)
        {

        }
    }
}
