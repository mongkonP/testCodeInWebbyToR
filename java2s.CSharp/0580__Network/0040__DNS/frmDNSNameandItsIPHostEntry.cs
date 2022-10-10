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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/DNSNameandItsIPHostEntry.htm
    public partial  class frmDNSNameandItsIPHostEntry:Form
    {
        public frmDNSNameandItsIPHostEntry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDNSNameandItsIPHostEntry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDNSNameandItsIPHostEntry";
            this.Text = "frmDNSNameandItsIPHostEntry";
            this.Load += new System.EventHandler(this.frmDNSNameandItsIPHostEntry_Load);
            this.ResumeLayout(false);

        }

        private void frmDNSNameandItsIPHostEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
