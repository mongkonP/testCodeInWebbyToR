using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0120__Socket_Server
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/SimpleTcpserverreceivedatafromaclient.htm
    public partial  class frmSimpleTcpserverreceivedatafromaclient:Form
    {
        public frmSimpleTcpserverreceivedatafromaclient()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleTcpserverreceivedatafromaclient
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleTcpserverreceivedatafromaclient";
            this.Text = "frmSimpleTcpserverreceivedatafromaclient";
            this.Load += new System.EventHandler(this.frmSimpleTcpserverreceivedatafromaclient_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleTcpserverreceivedatafromaclient_Load(object sender, EventArgs e)
        {

        }
    }
}
