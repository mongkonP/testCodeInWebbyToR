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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/GetIPaddressfromhostname.htm
    public partial  class frmGetIPaddressfromhostname:Form
    {
        public frmGetIPaddressfromhostname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetIPaddressfromhostname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetIPaddressfromhostname";
            this.Text = "frmGetIPaddressfromhostname";
            this.Load += new System.EventHandler(this.frmGetIPaddressfromhostname_Load);
            this.ResumeLayout(false);

        }

        private void frmGetIPaddressfromhostname_Load(object sender, EventArgs e)
        {

        }
    }
}
