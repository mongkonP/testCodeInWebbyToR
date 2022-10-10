using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0240__File_Permission
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Permissionsets.htm
    public partial  class frmPermissionsets:Form
    {
        public frmPermissionsets()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPermissionsets
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPermissionsets";
            this.Text = "frmPermissionsets";
            this.Load += new System.EventHandler(this.frmPermissionsets_Load);
            this.ResumeLayout(false);

        }

        private void frmPermissionsets_Load(object sender, EventArgs e)
        {

        }
    }
}
