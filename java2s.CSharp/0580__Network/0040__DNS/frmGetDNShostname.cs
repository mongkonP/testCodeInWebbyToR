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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/GetDNShostname.htm
    public partial  class frmGetDNShostname:Form
    {
        public frmGetDNShostname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetDNShostname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetDNShostname";
            this.Text = "frmGetDNShostname";
            this.Load += new System.EventHandler(this.frmGetDNShostname_Load);
            this.ResumeLayout(false);

        }

        private void frmGetDNShostname_Load(object sender, EventArgs e)
        {

        }
    }
}
