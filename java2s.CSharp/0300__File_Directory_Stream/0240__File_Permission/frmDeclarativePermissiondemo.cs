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
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/DeclarativePermissiondemo.htm
    public partial  class frmDeclarativePermissiondemo:Form
    {
        public frmDeclarativePermissiondemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeclarativePermissiondemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeclarativePermissiondemo";
            this.Text = "frmDeclarativePermissiondemo";
            this.Load += new System.EventHandler(this.frmDeclarativePermissiondemo_Load);
            this.ResumeLayout(false);

        }

        private void frmDeclarativePermissiondemo_Load(object sender, EventArgs e)
        {

        }
    }
}
