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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Tracetoafile.htm
    public partial  class frmTracetoafile:Form
    {
        public frmTracetoafile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTracetoafile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTracetoafile";
            this.Text = "frmTracetoafile";
            this.Load += new System.EventHandler(this.frmTracetoafile_Load);
            this.ResumeLayout(false);

        }

        private void frmTracetoafile_Load(object sender, EventArgs e)
        {

        }
    }
}
