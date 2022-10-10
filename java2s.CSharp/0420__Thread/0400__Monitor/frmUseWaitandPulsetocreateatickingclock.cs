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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UseWaitandPulsetocreateatickingclock.htm
    public partial  class frmUseWaitandPulsetocreateatickingclock:Form
    {
        public frmUseWaitandPulsetocreateatickingclock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseWaitandPulsetocreateatickingclock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseWaitandPulsetocreateatickingclock";
            this.Text = "frmUseWaitandPulsetocreateatickingclock";
            this.Load += new System.EventHandler(this.frmUseWaitandPulsetocreateatickingclock_Load);
            this.ResumeLayout(false);

        }

        private void frmUseWaitandPulsetocreateatickingclock_Load(object sender, EventArgs e)
        {

        }
    }
}
