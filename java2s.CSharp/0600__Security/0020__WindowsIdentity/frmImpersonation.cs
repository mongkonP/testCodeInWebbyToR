using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0020__WindowsIdentity
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Impersonation.htm
    public partial  class frmImpersonation:Form
    {
        public frmImpersonation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImpersonation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImpersonation";
            this.Text = "frmImpersonation";
            this.Load += new System.EventHandler(this.frmImpersonation_Load);
            this.ResumeLayout(false);

        }

        private void frmImpersonation_Load(object sender, EventArgs e)
        {

        }
    }
}
