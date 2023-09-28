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
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Sandboxingprotectedoperations.htm
    public partial  class frmSandboxingprotectedoperations:Form
    {
        public frmSandboxingprotectedoperations()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSandboxingprotectedoperations
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSandboxingprotectedoperations";
            this.Text = "frmSandboxingprotectedoperations";
            this.Load += new System.EventHandler(this.frmSandboxingprotectedoperations_Load);
            this.ResumeLayout(false);

        }

        private void frmSandboxingprotectedoperations_Load(object sender, EventArgs e)
        {

        }
    }
}
