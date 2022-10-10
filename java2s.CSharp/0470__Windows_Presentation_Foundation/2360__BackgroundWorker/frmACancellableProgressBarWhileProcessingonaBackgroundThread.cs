using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2360__BackgroundWorker
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ACancellableProgressBarWhileProcessingonaBackgroundThread.htm
    public partial  class frmACancellableProgressBarWhileProcessingonaBackgroundThread:Form
    {
        public frmACancellableProgressBarWhileProcessingonaBackgroundThread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmACancellableProgressBarWhileProcessingonaBackgroundThread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmACancellableProgressBarWhileProcessingonaBackgroundThread";
            this.Text = "frmACancellableProgressBarWhileProcessingonaBackgroundThread";
            this.Load += new System.EventHandler(this.frmACancellableProgressBarWhileProcessingonaBackgroundThread_Load);
            this.ResumeLayout(false);

        }

        private void frmACancellableProgressBarWhileProcessingonaBackgroundThread_Load(object sender, EventArgs e)
        {

        }
    }
}
