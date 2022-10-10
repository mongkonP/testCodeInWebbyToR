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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/IPAddressNone.htm
    public partial  class frmIPAddressNone:Form
    {
        public frmIPAddressNone()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIPAddressNone
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIPAddressNone";
            this.Text = "frmIPAddressNone";
            this.Load += new System.EventHandler(this.frmIPAddressNone_Load);
            this.ResumeLayout(false);

        }

        private void frmIPAddressNone_Load(object sender, EventArgs e)
        {

        }
    }
}
