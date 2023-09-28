using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0080__Permissions
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/CreatePrincipalPermissionforAdministrators.htm
    public partial  class frmCreatePrincipalPermissionforAdministrators:Form
    {
        public frmCreatePrincipalPermissionforAdministrators()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatePrincipalPermissionforAdministrators
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatePrincipalPermissionforAdministrators";
            this.Text = "frmCreatePrincipalPermissionforAdministrators";
            this.Load += new System.EventHandler(this.frmCreatePrincipalPermissionforAdministrators_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatePrincipalPermissionforAdministrators_Load(object sender, EventArgs e)
        {

        }
    }
}
