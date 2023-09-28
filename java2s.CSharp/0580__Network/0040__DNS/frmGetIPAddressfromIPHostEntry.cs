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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/GetIPAddressfromIPHostEntry.htm
    public partial  class frmGetIPAddressfromIPHostEntry:Form
    {
        public frmGetIPAddressfromIPHostEntry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetIPAddressfromIPHostEntry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetIPAddressfromIPHostEntry";
            this.Text = "frmGetIPAddressfromIPHostEntry";
            this.Load += new System.EventHandler(this.frmGetIPAddressfromIPHostEntry_Load);
            this.ResumeLayout(false);

        }

        private void frmGetIPAddressfromIPHostEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
