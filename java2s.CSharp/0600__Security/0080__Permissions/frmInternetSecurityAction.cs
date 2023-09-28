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
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/InternetSecurityAction.htm
    public partial  class frmInternetSecurityAction:Form
    {
        public frmInternetSecurityAction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInternetSecurityAction
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInternetSecurityAction";
            this.Text = "frmInternetSecurityAction";
            this.Load += new System.EventHandler(this.frmInternetSecurityAction_Load);
            this.ResumeLayout(false);

        }

        private void frmInternetSecurityAction_Load(object sender, EventArgs e)
        {

        }
    }
}
