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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/AddDefaultTraceListenertoTrace.htm
    public partial  class frmAddDefaultTraceListenertoTrace:Form
    {
        public frmAddDefaultTraceListenertoTrace()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddDefaultTraceListenertoTrace
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddDefaultTraceListenertoTrace";
            this.Text = "frmAddDefaultTraceListenertoTrace";
            this.Load += new System.EventHandler(this.frmAddDefaultTraceListenertoTrace_Load);
            this.ResumeLayout(false);

        }

        private void frmAddDefaultTraceListenertoTrace_Load(object sender, EventArgs e)
        {

        }
    }
}
