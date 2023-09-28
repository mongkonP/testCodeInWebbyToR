using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0580__TraceSource
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/CreateTraceSourceandtraceevents.htm
    public partial  class frmCreateTraceSourceandtraceevents:Form
    {
        public frmCreateTraceSourceandtraceevents()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateTraceSourceandtraceevents
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateTraceSourceandtraceevents";
            this.Text = "frmCreateTraceSourceandtraceevents";
            this.Load += new System.EventHandler(this.frmCreateTraceSourceandtraceevents_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateTraceSourceandtraceevents_Load(object sender, EventArgs e)
        {

        }
    }
}
