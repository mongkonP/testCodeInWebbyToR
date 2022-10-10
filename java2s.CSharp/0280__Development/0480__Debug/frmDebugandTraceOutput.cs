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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/DebugandTraceOutput.htm
    public partial  class frmDebugandTraceOutput:Form
    {
        public frmDebugandTraceOutput()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDebugandTraceOutput
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDebugandTraceOutput";
            this.Text = "frmDebugandTraceOutput";
            this.Load += new System.EventHandler(this.frmDebugandTraceOutput_Load);
            this.ResumeLayout(false);

        }

        private void frmDebugandTraceOutput_Load(object sender, EventArgs e)
        {

        }
    }
}
