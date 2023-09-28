using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0300__Access_Modifier
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/AccessControldemonstratethevariousformsofaccesscontrol.htm
    public partial  class frmAccessControldemonstratethevariousformsofaccesscontrol:Form
    {
        public frmAccessControldemonstratethevariousformsofaccesscontrol()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAccessControldemonstratethevariousformsofaccesscontrol
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAccessControldemonstratethevariousformsofaccesscontrol";
            this.Text = "frmAccessControldemonstratethevariousformsofaccesscontrol";
            this.Load += new System.EventHandler(this.frmAccessControldemonstratethevariousformsofaccesscontrol_Load);
            this.ResumeLayout(false);

        }

        private void frmAccessControldemonstratethevariousformsofaccesscontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
