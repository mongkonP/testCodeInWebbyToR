using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0560__Trace
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/UseTraceSwitch.htm
    public partial  class frmUseTraceSwitch:Form
    {
        public frmUseTraceSwitch()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseTraceSwitch
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseTraceSwitch";
            this.Text = "frmUseTraceSwitch";
            this.Load += new System.EventHandler(this.frmUseTraceSwitch_Load);
            this.ResumeLayout(false);

        }

        private void frmUseTraceSwitch_Load(object sender, EventArgs e)
        {

        }
    }
}
