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
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/RefuserequestforReflectionPermission.htm
    public partial  class frmRefuserequestforReflectionPermission:Form
    {
        public frmRefuserequestforReflectionPermission()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRefuserequestforReflectionPermission
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRefuserequestforReflectionPermission";
            this.Text = "frmRefuserequestforReflectionPermission";
            this.Load += new System.EventHandler(this.frmRefuserequestforReflectionPermission_Load);
            this.ResumeLayout(false);

        }

        private void frmRefuserequestforReflectionPermission_Load(object sender, EventArgs e)
        {

        }
    }
}
