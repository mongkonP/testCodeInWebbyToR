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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/AddTextWriterTraceListenertoDebugListener.htm
    public partial  class frmAddTextWriterTraceListenertoDebugListener:Form
    {
        public frmAddTextWriterTraceListenertoDebugListener()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddTextWriterTraceListenertoDebugListener
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddTextWriterTraceListenertoDebugListener";
            this.Text = "frmAddTextWriterTraceListenertoDebugListener";
            this.Load += new System.EventHandler(this.frmAddTextWriterTraceListenertoDebugListener_Load);
            this.ResumeLayout(false);

        }

        private void frmAddTextWriterTraceListenertoDebugListener_Load(object sender, EventArgs e)
        {

        }
    }
}
