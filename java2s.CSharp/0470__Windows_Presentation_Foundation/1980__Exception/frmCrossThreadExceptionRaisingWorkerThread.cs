using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1980__Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CrossThreadExceptionRaisingWorkerThread.htm
    public partial  class frmCrossThreadExceptionRaisingWorkerThread:Form
    {
        public frmCrossThreadExceptionRaisingWorkerThread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCrossThreadExceptionRaisingWorkerThread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCrossThreadExceptionRaisingWorkerThread";
            this.Text = "frmCrossThreadExceptionRaisingWorkerThread";
            this.Load += new System.EventHandler(this.frmCrossThreadExceptionRaisingWorkerThread_Load);
            this.ResumeLayout(false);

        }

        private void frmCrossThreadExceptionRaisingWorkerThread_Load(object sender, EventArgs e)
        {

        }
    }
}
