using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0140__TcpClient
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UseaNetworkStreamtoreadfromaserver.htm
    public partial  class frmUseaNetworkStreamtoreadfromaserver:Form
    {
        public frmUseaNetworkStreamtoreadfromaserver()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseaNetworkStreamtoreadfromaserver
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseaNetworkStreamtoreadfromaserver";
            this.Text = "frmUseaNetworkStreamtoreadfromaserver";
            this.Load += new System.EventHandler(this.frmUseaNetworkStreamtoreadfromaserver_Load);
            this.ResumeLayout(false);

        }

        private void frmUseaNetworkStreamtoreadfromaserver_Load(object sender, EventArgs e)
        {

        }
    }
}
