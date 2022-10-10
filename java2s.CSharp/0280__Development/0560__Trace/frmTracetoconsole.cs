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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/TracetorichTextBox1.htm
    public partial  class frmTracetorichTextBox1:Form
    {
        public frmTracetorichTextBox1()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTracetorichTextBox1
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTracetorichTextBox1";
            this.Text = "frmTracetorichTextBox1";
            this.Load += new System.EventHandler(this.frmTracetorichTextBox1_Load);
            this.ResumeLayout(false);

        }

        private void frmTracetorichTextBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
