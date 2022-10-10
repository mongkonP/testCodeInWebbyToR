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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ShowaContinuousProgressBarWhileProcessingonaBackgroundThread.htm
    public partial  class frmShowaContinuousProgressBarWhileProcessingonaBackgroundThread:Form
    {
        public frmShowaContinuousProgressBarWhileProcessingonaBackgroundThread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmShowaContinuousProgressBarWhileProcessingonaBackgroundThread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmShowaContinuousProgressBarWhileProcessingonaBackgroundThread";
            this.Text = "frmShowaContinuousProgressBarWhileProcessingonaBackgroundThread";
            this.Load += new System.EventHandler(this.frmShowaContinuousProgressBarWhileProcessingonaBackgroundThread_Load);
            this.ResumeLayout(false);

        }

        private void frmShowaContinuousProgressBarWhileProcessingonaBackgroundThread_Load(object sender, EventArgs e)
        {

        }
    }
}
