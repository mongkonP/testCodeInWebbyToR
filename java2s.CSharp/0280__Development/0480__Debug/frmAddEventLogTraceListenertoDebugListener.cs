using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0480__Debug
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/AddEventLogTraceListenertoDebugListener.htm
    public partial  class frmAddEventLogTraceListenertoDebugListener:Form
    {
        public frmAddEventLogTraceListenertoDebugListener()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddEventLogTraceListenertoDebugListener
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddEventLogTraceListenertoDebugListener";
            this.Text = "frmAddEventLogTraceListenertoDebugListener";
            this.Load += new System.EventHandler(this.frmAddEventLogTraceListenertoDebugListener_Load);
            this.ResumeLayout(false);

        }

        private void frmAddEventLogTraceListenertoDebugListener_Load(object sender, EventArgs e)
        {

        }
    }
}
