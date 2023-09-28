using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0020__AppDomain
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/GetAppDomainCurrentDomainFriendlyName.htm
    public partial  class frmGetAppDomainCurrentDomainFriendlyName:Form
    {
        public frmGetAppDomainCurrentDomainFriendlyName()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetAppDomainCurrentDomainFriendlyName
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetAppDomainCurrentDomainFriendlyName";
            this.Text = "frmGetAppDomainCurrentDomainFriendlyName";
            this.Load += new System.EventHandler(this.frmGetAppDomainCurrentDomainFriendlyName_Load);
            this.ResumeLayout(false);

        }

        private void frmGetAppDomainCurrentDomainFriendlyName_Load(object sender, EventArgs e)
        {

        }
    }
}
