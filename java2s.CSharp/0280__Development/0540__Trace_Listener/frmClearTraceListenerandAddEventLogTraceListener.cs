using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0540__Trace_Listener
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/ClearTraceListenerandAddEventLogTraceListener.htm
    public partial  class frmClearTraceListenerandAddEventLogTraceListener:Form
    {
        public frmClearTraceListenerandAddEventLogTraceListener()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClearTraceListenerandAddEventLogTraceListener
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClearTraceListenerandAddEventLogTraceListener";
            this.Text = "frmClearTraceListenerandAddEventLogTraceListener";
            this.Load += new System.EventHandler(this.frmClearTraceListenerandAddEventLogTraceListener_Load);
            this.ResumeLayout(false);

        }

        private void frmClearTraceListenerandAddEventLogTraceListener_Load(object sender, EventArgs e)
        {

        }
    }
}
