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
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Adeclarativerolebasedsecuritydemandforthecurrentprincipal.htm
    public partial  class frmAdeclarativerolebasedsecuritydemandforthecurrentprincipal:Form
    {
        public frmAdeclarativerolebasedsecuritydemandforthecurrentprincipal()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAdeclarativerolebasedsecuritydemandforthecurrentprincipal
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAdeclarativerolebasedsecuritydemandforthecurrentprincipal";
            this.Text = "frmAdeclarativerolebasedsecuritydemandforthecurrentprincipal";
            this.Load += new System.EventHandler(this.frmAdeclarativerolebasedsecuritydemandforthecurrentprincipal_Load);
            this.ResumeLayout(false);

        }

        private void frmAdeclarativerolebasedsecuritydemandforthecurrentprincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
