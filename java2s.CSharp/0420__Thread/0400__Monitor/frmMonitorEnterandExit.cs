using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0400__Monitor
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/MonitorEnterandExit.htm
    public partial  class frmMonitorEnterandExit:Form
    {
        public frmMonitorEnterandExit()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMonitorEnterandExit
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMonitorEnterandExit";
            this.Text = "frmMonitorEnterandExit";
            this.Load += new System.EventHandler(this.frmMonitorEnterandExit_Load);
            this.ResumeLayout(false);

        }

        private void frmMonitorEnterandExit_Load(object sender, EventArgs e)
        {

        }
    }
}
