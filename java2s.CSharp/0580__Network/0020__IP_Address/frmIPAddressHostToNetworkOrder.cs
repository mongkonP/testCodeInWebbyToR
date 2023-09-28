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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/IPAddressHostToNetworkOrder.htm
    public partial  class frmIPAddressHostToNetworkOrder:Form
    {
        public frmIPAddressHostToNetworkOrder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIPAddressHostToNetworkOrder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIPAddressHostToNetworkOrder";
            this.Text = "frmIPAddressHostToNetworkOrder";
            this.Load += new System.EventHandler(this.frmIPAddressHostToNetworkOrder_Load);
            this.ResumeLayout(false);

        }

        private void frmIPAddressHostToNetworkOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
