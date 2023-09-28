using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0480__Asynchronous
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/AsynchronousResultsPatternExample.htm
    public partial  class frmAsynchronousResultsPatternExample:Form
    {
        public frmAsynchronousResultsPatternExample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsynchronousResultsPatternExample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsynchronousResultsPatternExample";
            this.Text = "frmAsynchronousResultsPatternExample";
            this.Load += new System.EventHandler(this.frmAsynchronousResultsPatternExample_Load);
            this.ResumeLayout(false);

        }

        private void frmAsynchronousResultsPatternExample_Load(object sender, EventArgs e)
        {

        }
    }
}
