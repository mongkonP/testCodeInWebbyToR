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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SupporttheCancellationofaBackgroundWorkerThread.htm
    public partial  class frmSupporttheCancellationofaBackgroundWorkerThread:Form
    {
        public frmSupporttheCancellationofaBackgroundWorkerThread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSupporttheCancellationofaBackgroundWorkerThread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSupporttheCancellationofaBackgroundWorkerThread";
            this.Text = "frmSupporttheCancellationofaBackgroundWorkerThread";
            this.Load += new System.EventHandler(this.frmSupporttheCancellationofaBackgroundWorkerThread_Load);
            this.ResumeLayout(false);

        }

        private void frmSupporttheCancellationofaBackgroundWorkerThread_Load(object sender, EventArgs e)
        {

        }
    }
}
