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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/TracingToDebugger.htm
    public partial  class frmTracingToDebugger:Form
    {
        public frmTracingToDebugger()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTracingToDebugger
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTracingToDebugger";
            this.Text = "frmTracingToDebugger";
            this.Load += new System.EventHandler(this.frmTracingToDebugger_Load);
            this.ResumeLayout(false);

        }

        private void frmTracingToDebugger_Load(object sender, EventArgs e)
        {

        }
    }
}
