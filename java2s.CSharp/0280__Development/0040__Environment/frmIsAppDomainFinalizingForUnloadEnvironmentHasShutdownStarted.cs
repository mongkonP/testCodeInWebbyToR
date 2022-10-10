using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0040__Environment
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/IsAppDomainFinalizingForUnloadEnvironmentHasShutdownStarted.htm
    public partial  class frmIsAppDomainFinalizingForUnloadEnvironmentHasShutdownStarted:Form
    {
        public frmIsAppDomainFinalizingForUnloadEnvironmentHasShutdownStarted()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIsAppDomainFinalizingForUnloadEnvironmentHasShutdownStarted
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIsAppDomainFinalizingForUnloadEnvironmentHasShutdownStarted";
            this.Text = "frmIsAppDomainFinalizingForUnloadEnvironmentHasShutdownStarted";
            this.Load += new System.EventHandler(this.frmIsAppDomainFinalizingForUnloadEnvironmentHasShutdownStarted_Load);
            this.ResumeLayout(false);

        }

        private void frmIsAppDomainFinalizingForUnloadEnvironmentHasShutdownStarted_Load(object sender, EventArgs e)
        {

        }
    }
}
