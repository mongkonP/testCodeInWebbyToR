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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UdpMultireceive.htm
    public partial  class frmUdpMultireceive:Form
    {
        public frmUdpMultireceive()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUdpMultireceive
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUdpMultireceive";
            this.Text = "frmUdpMultireceive";
            this.Load += new System.EventHandler(this.frmUdpMultireceive_Load);
            this.ResumeLayout(false);

        }

        private void frmUdpMultireceive_Load(object sender, EventArgs e)
        {

        }
    }
}
