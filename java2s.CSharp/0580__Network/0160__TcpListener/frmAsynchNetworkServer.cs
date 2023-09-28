using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0160__TcpListener
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/AsynchNetworkServer.htm
    public partial  class frmAsynchNetworkServer:Form
    {
        public frmAsynchNetworkServer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsynchNetworkServer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsynchNetworkServer";
            this.Text = "frmAsynchNetworkServer";
            this.Load += new System.EventHandler(this.frmAsynchNetworkServer_Load);
            this.ResumeLayout(false);

        }

        private void frmAsynchNetworkServer_Load(object sender, EventArgs e)
        {

        }
    }
}
