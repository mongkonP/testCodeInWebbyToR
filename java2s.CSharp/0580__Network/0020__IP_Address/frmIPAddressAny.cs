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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/IPAddressAny.htm
    public partial  class frmIPAddressAny:Form
    {
        public frmIPAddressAny()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIPAddressAny
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIPAddressAny";
            this.Text = "frmIPAddressAny";
            this.Load += new System.EventHandler(this.frmIPAddressAny_Load);
            this.ResumeLayout(false);

        }

        private void frmIPAddressAny_Load(object sender, EventArgs e)
        {

        }
    }
}
