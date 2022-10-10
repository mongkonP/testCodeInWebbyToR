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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/TraceAssert.htm
    public partial  class frmTraceAssert:Form
    {
        public frmTraceAssert()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTraceAssert
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTraceAssert";
            this.Text = "frmTraceAssert";
            this.Load += new System.EventHandler(this.frmTraceAssert_Load);
            this.ResumeLayout(false);

        }

        private void frmTraceAssert_Load(object sender, EventArgs e)
        {

        }
    }
}
