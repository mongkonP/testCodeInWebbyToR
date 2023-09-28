using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0040__AppDomainSetup
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/Configuretheapplicationdomainsetupinformation.htm
    public partial  class frmConfiguretheapplicationdomainsetupinformation:Form
    {
        public frmConfiguretheapplicationdomainsetupinformation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConfiguretheapplicationdomainsetupinformation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConfiguretheapplicationdomainsetupinformation";
            this.Text = "frmConfiguretheapplicationdomainsetupinformation";
            this.Load += new System.EventHandler(this.frmConfiguretheapplicationdomainsetupinformation_Load);
            this.ResumeLayout(false);

        }

        private void frmConfiguretheapplicationdomainsetupinformation_Load(object sender, EventArgs e)
        {

        }
    }
}
