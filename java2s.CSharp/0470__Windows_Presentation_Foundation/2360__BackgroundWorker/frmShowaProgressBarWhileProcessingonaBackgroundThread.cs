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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ShowaProgressBarWhileProcessingonaBackgroundThread.htm
    public partial  class frmShowaProgressBarWhileProcessingonaBackgroundThread:Form
    {
        public frmShowaProgressBarWhileProcessingonaBackgroundThread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmShowaProgressBarWhileProcessingonaBackgroundThread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmShowaProgressBarWhileProcessingonaBackgroundThread";
            this.Text = "frmShowaProgressBarWhileProcessingonaBackgroundThread";
            this.Load += new System.EventHandler(this.frmShowaProgressBarWhileProcessingonaBackgroundThread_Load);
            this.ResumeLayout(false);

        }

        private void frmShowaProgressBarWhileProcessingonaBackgroundThread_Load(object sender, EventArgs e)
        {

        }
    }
}
