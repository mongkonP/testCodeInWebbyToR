using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0100__Socket_Client
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/SimpleTcpClientreceivedatafromserver.htm
    public partial  class frmSimpleTcpClientreceivedatafromserver:Form
    {
        public frmSimpleTcpClientreceivedatafromserver()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleTcpClientreceivedatafromserver
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleTcpClientreceivedatafromserver";
            this.Text = "frmSimpleTcpClientreceivedatafromserver";
            this.Load += new System.EventHandler(this.frmSimpleTcpClientreceivedatafromserver_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleTcpClientreceivedatafromserver_Load(object sender, EventArgs e)
        {

        }
    }
}
