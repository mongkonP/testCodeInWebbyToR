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
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/FileIOPermissionSecurityActionRequestRefuseWrite.htm
    public partial  class frmFileIOPermissionSecurityActionRequestRefuseWrite:Form
    {
        public frmFileIOPermissionSecurityActionRequestRefuseWrite()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFileIOPermissionSecurityActionRequestRefuseWrite
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFileIOPermissionSecurityActionRequestRefuseWrite";
            this.Text = "frmFileIOPermissionSecurityActionRequestRefuseWrite";
            this.Load += new System.EventHandler(this.frmFileIOPermissionSecurityActionRequestRefuseWrite_Load);
            this.ResumeLayout(false);

        }

        private void frmFileIOPermissionSecurityActionRequestRefuseWrite_Load(object sender, EventArgs e)
        {

        }
    }
}
