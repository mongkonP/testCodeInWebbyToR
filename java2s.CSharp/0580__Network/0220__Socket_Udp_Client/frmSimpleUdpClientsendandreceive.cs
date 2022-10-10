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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/SimpleUdpClientsendandreceive.htm
    public partial  class frmSimpleUdpClientsendandreceive:Form
    {
        public frmSimpleUdpClientsendandreceive()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleUdpClientsendandreceive
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleUdpClientsendandreceive";
            this.Text = "frmSimpleUdpClientsendandreceive";
            this.Load += new System.EventHandler(this.frmSimpleUdpClientsendandreceive_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleUdpClientsendandreceive_Load(object sender, EventArgs e)
        {

        }
    }
}
