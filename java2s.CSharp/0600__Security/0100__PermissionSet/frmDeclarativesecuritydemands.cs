using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0100__PermissionSet
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Declarativesecuritydemands.htm
    public partial  class frmDeclarativesecuritydemands:Form
    {
        public frmDeclarativesecuritydemands()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeclarativesecuritydemands
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeclarativesecuritydemands";
            this.Text = "frmDeclarativesecuritydemands";
            this.Load += new System.EventHandler(this.frmDeclarativesecuritydemands_Load);
            this.ResumeLayout(false);

        }

        private void frmDeclarativesecuritydemands_Load(object sender, EventArgs e)
        {

        }
    }
}
