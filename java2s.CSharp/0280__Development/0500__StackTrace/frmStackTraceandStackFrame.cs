using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0500__StackTrace
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/StackTraceandStackFrame.htm
    public partial  class frmStackTraceandStackFrame:Form
    {
        public frmStackTraceandStackFrame()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStackTraceandStackFrame
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStackTraceandStackFrame";
            this.Text = "frmStackTraceandStackFrame";
            this.Load += new System.EventHandler(this.frmStackTraceandStackFrame_Load);
            this.ResumeLayout(false);

        }

        private void frmStackTraceandStackFrame_Load(object sender, EventArgs e)
        {

        }
    }
}
