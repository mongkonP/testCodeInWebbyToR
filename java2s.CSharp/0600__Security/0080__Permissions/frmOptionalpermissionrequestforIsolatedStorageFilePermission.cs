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
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/OptionalpermissionrequestforIsolatedStorageFilePermission.htm
    public partial  class frmOptionalpermissionrequestforIsolatedStorageFilePermission:Form
    {
        public frmOptionalpermissionrequestforIsolatedStorageFilePermission()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOptionalpermissionrequestforIsolatedStorageFilePermission
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOptionalpermissionrequestforIsolatedStorageFilePermission";
            this.Text = "frmOptionalpermissionrequestforIsolatedStorageFilePermission";
            this.Load += new System.EventHandler(this.frmOptionalpermissionrequestforIsolatedStorageFilePermission_Load);
            this.ResumeLayout(false);

        }

        private void frmOptionalpermissionrequestforIsolatedStorageFilePermission_Load(object sender, EventArgs e)
        {

        }
    }
}
