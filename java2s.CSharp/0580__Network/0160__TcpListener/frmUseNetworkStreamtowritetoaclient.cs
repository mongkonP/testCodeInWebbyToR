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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UseNetworkStreamtowritetoaclient.htm
    public partial  class frmUseNetworkStreamtowritetoaclient:Form
    {
        public frmUseNetworkStreamtowritetoaclient()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseNetworkStreamtowritetoaclient
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseNetworkStreamtowritetoaclient";
            this.Text = "frmUseNetworkStreamtowritetoaclient";
            this.Load += new System.EventHandler(this.frmUseNetworkStreamtowritetoaclient_Load);
            this.ResumeLayout(false);

        }

        private void frmUseNetworkStreamtowritetoaclient_Load(object sender, EventArgs e)
        {

        }
    }
}
