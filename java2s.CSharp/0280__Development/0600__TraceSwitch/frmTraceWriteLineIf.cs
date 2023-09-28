using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0600__TraceSwitch
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/TraceWriteLineIf.htm
    public partial  class frmTraceWriteLineIf:Form
    {
        public frmTraceWriteLineIf()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTraceWriteLineIf
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTraceWriteLineIf";
            this.Text = "frmTraceWriteLineIf";
            this.Load += new System.EventHandler(this.frmTraceWriteLineIf_Load);
            this.ResumeLayout(false);

        }

        private void frmTraceWriteLineIf_Load(object sender, EventArgs e)
        {

        }
    }
}
