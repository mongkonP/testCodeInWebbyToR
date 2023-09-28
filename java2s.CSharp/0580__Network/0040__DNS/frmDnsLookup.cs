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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/DnsLookup.htm
    public partial  class frmDnsLookup:Form
    {
        public frmDnsLookup()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDnsLookup
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDnsLookup";
            this.Text = "frmDnsLookup";
            this.Load += new System.EventHandler(this.frmDnsLookup_Load);
            this.ResumeLayout(false);

        }

        private void frmDnsLookup_Load(object sender, EventArgs e)
        {

        }
    }
}
