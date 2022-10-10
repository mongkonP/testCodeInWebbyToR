using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0420__Mutex
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/HowaMutexisusedtosynchronizeaccesstoaprotectedresource.htm
    public partial  class frmHowaMutexisusedtosynchronizeaccesstoaprotectedresource:Form
    {
        public frmHowaMutexisusedtosynchronizeaccesstoaprotectedresource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHowaMutexisusedtosynchronizeaccesstoaprotectedresource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHowaMutexisusedtosynchronizeaccesstoaprotectedresource";
            this.Text = "frmHowaMutexisusedtosynchronizeaccesstoaprotectedresource";
            this.Load += new System.EventHandler(this.frmHowaMutexisusedtosynchronizeaccesstoaprotectedresource_Load);
            this.ResumeLayout(false);

        }

        private void frmHowaMutexisusedtosynchronizeaccesstoaprotectedresource_Load(object sender, EventArgs e)
        {

        }
    }
}
