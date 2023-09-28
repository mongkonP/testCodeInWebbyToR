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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/AsynchronousCallsIAsyncResult.htm
    public partial  class frmAsynchronousCallsIAsyncResult:Form
    {
        public frmAsynchronousCallsIAsyncResult()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsynchronousCallsIAsyncResult
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsynchronousCallsIAsyncResult";
            this.Text = "frmAsynchronousCallsIAsyncResult";
            this.Load += new System.EventHandler(this.frmAsynchronousCallsIAsyncResult_Load);
            this.ResumeLayout(false);

        }

        private void frmAsynchronousCallsIAsyncResult_Load(object sender, EventArgs e)
        {

        }
    }
}
