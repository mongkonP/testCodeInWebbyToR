using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0320__NetworkStream
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UseNetworkStreamtoreadandwritetoaserver.htm
    public partial  class frmUseNetworkStreamtoreadandwritetoaserver:Form
    {
        public frmUseNetworkStreamtoreadandwritetoaserver()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseNetworkStreamtoreadandwritetoaserver
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseNetworkStreamtoreadandwritetoaserver";
            this.Text = "frmUseNetworkStreamtoreadandwritetoaserver";
            this.Load += new System.EventHandler(this.frmUseNetworkStreamtoreadandwritetoaserver_Load);
            this.ResumeLayout(false);

        }

        private void frmUseNetworkStreamtoreadandwritetoaserver_Load(object sender, EventArgs e)
        {

        }
    }
}
