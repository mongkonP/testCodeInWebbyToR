using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0020__IP_Address
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/IPAddressBroadcast.htm
    public partial  class frmIPAddressBroadcast:Form
    {
        public frmIPAddressBroadcast()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIPAddressBroadcast
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIPAddressBroadcast";
            this.Text = "frmIPAddressBroadcast";
            this.Load += new System.EventHandler(this.frmIPAddressBroadcast_Load);
            this.ResumeLayout(false);

        }

        private void frmIPAddressBroadcast_Load(object sender, EventArgs e)
        {

        }
    }
}
