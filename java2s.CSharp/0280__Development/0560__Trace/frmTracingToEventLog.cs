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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/TracingToEventLog.htm
    public partial  class frmTracingToEventLog:Form
    {
        public frmTracingToEventLog()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTracingToEventLog
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTracingToEventLog";
            this.Text = "frmTracingToEventLog";
            this.Load += new System.EventHandler(this.frmTracingToEventLog_Load);
            this.ResumeLayout(false);

        }

        private void frmTracingToEventLog_Load(object sender, EventArgs e)
        {

        }
    }
}
