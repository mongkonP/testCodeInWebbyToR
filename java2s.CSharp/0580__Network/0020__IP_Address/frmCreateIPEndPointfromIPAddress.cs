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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/CreateIPEndPointfromIPAddress.htm
    public partial  class frmCreateIPEndPointfromIPAddress:Form
    {
        public frmCreateIPEndPointfromIPAddress()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateIPEndPointfromIPAddress
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateIPEndPointfromIPAddress";
            this.Text = "frmCreateIPEndPointfromIPAddress";
            this.Load += new System.EventHandler(this.frmCreateIPEndPointfromIPAddress_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateIPEndPointfromIPAddress_Load(object sender, EventArgs e)
        {

        }
    }
}
