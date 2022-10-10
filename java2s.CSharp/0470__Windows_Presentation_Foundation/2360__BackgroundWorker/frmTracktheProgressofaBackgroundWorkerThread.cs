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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TracktheProgressofaBackgroundWorkerThread.htm
    public partial  class frmTracktheProgressofaBackgroundWorkerThread:Form
    {
        public frmTracktheProgressofaBackgroundWorkerThread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTracktheProgressofaBackgroundWorkerThread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTracktheProgressofaBackgroundWorkerThread";
            this.Text = "frmTracktheProgressofaBackgroundWorkerThread";
            this.Load += new System.EventHandler(this.frmTracktheProgressofaBackgroundWorkerThread_Load);
            this.ResumeLayout(false);

        }

        private void frmTracktheProgressofaBackgroundWorkerThread_Load(object sender, EventArgs e)
        {

        }
    }
}
