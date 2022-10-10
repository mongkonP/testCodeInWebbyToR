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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/AddrichTextBox1TraceListenertoTrace.htm
    public partial  class frmAddrichTextBox1TraceListenertoTrace:Form
    {
        public frmAddrichTextBox1TraceListenertoTrace()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddrichTextBox1TraceListenertoTrace
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddrichTextBox1TraceListenertoTrace";
            this.Text = "frmAddrichTextBox1TraceListenertoTrace";
            this.Load += new System.EventHandler(this.frmAddrichTextBox1TraceListenertoTrace_Load);
            this.ResumeLayout(false);

        }

        private void frmAddrichTextBox1TraceListenertoTrace_Load(object sender, EventArgs e)
        {

        }
    }
}
