using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0200__Udp
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/newUdpClient5555Receive.htm
    public partial  class frmnewUdpClient5555Receive:Form
    {
        public frmnewUdpClient5555Receive()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmnewUdpClient5555Receive
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmnewUdpClient5555Receive";
            this.Text = "frmnewUdpClient5555Receive";
            this.Load += new System.EventHandler(this.frmnewUdpClient5555Receive_Load);
            this.ResumeLayout(false);

        }

        private void frmnewUdpClient5555Receive_Load(object sender, EventArgs e)
        {

        }
    }
}
