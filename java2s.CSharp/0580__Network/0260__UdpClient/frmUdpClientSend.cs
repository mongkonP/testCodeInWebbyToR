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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UdpClientSend.htm
    public partial  class frmUdpClientSend:Form
    {
        public frmUdpClientSend()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUdpClientSend
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUdpClientSend";
            this.Text = "frmUdpClientSend";
            this.Load += new System.EventHandler(this.frmUdpClientSend_Load);
            this.ResumeLayout(false);

        }

        private void frmUdpClientSend_Load(object sender, EventArgs e)
        {

        }
    }
}
