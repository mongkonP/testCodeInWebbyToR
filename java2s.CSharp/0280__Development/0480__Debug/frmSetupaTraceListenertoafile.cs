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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/SetupaTraceListenertoafile.htm
    public partial  class frmSetupaTraceListenertoafile:Form
    {
        public frmSetupaTraceListenertoafile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetupaTraceListenertoafile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetupaTraceListenertoafile";
            this.Text = "frmSetupaTraceListenertoafile";
            this.Load += new System.EventHandler(this.frmSetupaTraceListenertoafile_Load);
            this.ResumeLayout(false);

        }

        private void frmSetupaTraceListenertoafile_Load(object sender, EventArgs e)
        {

        }
    }
}
