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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/SimpleUdpserver.htm
    public partial  class frmSimpleUdpserver:Form
    {
        public frmSimpleUdpserver()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleUdpserver
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleUdpserver";
            this.Text = "frmSimpleUdpserver";
            this.Load += new System.EventHandler(this.frmSimpleUdpserver_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleUdpserver_Load(object sender, EventArgs e)
        {

        }
    }
}
