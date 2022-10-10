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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/ThrowexceptionbetweenMonitorEnterandMontorExit.htm
    public partial  class frmThrowexceptionbetweenMonitorEnterandMontorExit:Form
    {
        public frmThrowexceptionbetweenMonitorEnterandMontorExit()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThrowexceptionbetweenMonitorEnterandMontorExit
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThrowexceptionbetweenMonitorEnterandMontorExit";
            this.Text = "frmThrowexceptionbetweenMonitorEnterandMontorExit";
            this.Load += new System.EventHandler(this.frmThrowexceptionbetweenMonitorEnterandMontorExit_Load);
            this.ResumeLayout(false);

        }

        private void frmThrowexceptionbetweenMonitorEnterandMontorExit_Load(object sender, EventArgs e)
        {

        }
    }
}
