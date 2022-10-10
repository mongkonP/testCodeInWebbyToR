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
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Getthecurrentidentityanditsassociatedprincipal.htm
    public partial  class frmGetthecurrentidentityanditsassociatedprincipal:Form
    {
        public frmGetthecurrentidentityanditsassociatedprincipal()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetthecurrentidentityanditsassociatedprincipal
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetthecurrentidentityanditsassociatedprincipal";
            this.Text = "frmGetthecurrentidentityanditsassociatedprincipal";
            this.Load += new System.EventHandler(this.frmGetthecurrentidentityanditsassociatedprincipal_Load);
            this.ResumeLayout(false);

        }

        private void frmGetthecurrentidentityanditsassociatedprincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
