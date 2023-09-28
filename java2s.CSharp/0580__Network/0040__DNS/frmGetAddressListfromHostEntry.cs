using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0040__DNS
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/GetAddressListfromHostEntry.htm
    public partial  class frmGetAddressListfromHostEntry:Form
    {
        public frmGetAddressListfromHostEntry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetAddressListfromHostEntry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetAddressListfromHostEntry";
            this.Text = "frmGetAddressListfromHostEntry";
            this.Load += new System.EventHandler(this.frmGetAddressListfromHostEntry_Load);
            this.ResumeLayout(false);

        }

        private void frmGetAddressListfromHostEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
