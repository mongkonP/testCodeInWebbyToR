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
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/HandleAppDomainEventDomainUnloadandProcessExit.htm
    public partial  class frmHandleAppDomainEventDomainUnloadandProcessExit:Form
    {
        public frmHandleAppDomainEventDomainUnloadandProcessExit()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHandleAppDomainEventDomainUnloadandProcessExit
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHandleAppDomainEventDomainUnloadandProcessExit";
            this.Text = "frmHandleAppDomainEventDomainUnloadandProcessExit";
            this.Load += new System.EventHandler(this.frmHandleAppDomainEventDomainUnloadandProcessExit_Load);
            this.ResumeLayout(false);

        }

        private void frmHandleAppDomainEventDomainUnloadandProcessExit_Load(object sender, EventArgs e)
        {

        }
    }
}
