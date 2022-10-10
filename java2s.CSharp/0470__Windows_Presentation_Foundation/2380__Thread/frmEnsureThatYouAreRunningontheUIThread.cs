using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2380__Thread
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EnsureThatYouAreRunningontheUIThread.htm
    public partial  class frmEnsureThatYouAreRunningontheUIThread:Form
    {
        public frmEnsureThatYouAreRunningontheUIThread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEnsureThatYouAreRunningontheUIThread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEnsureThatYouAreRunningontheUIThread";
            this.Text = "frmEnsureThatYouAreRunningontheUIThread";
            this.Load += new System.EventHandler(this.frmEnsureThatYouAreRunningontheUIThread_Load);
            this.ResumeLayout(false);

        }

        private void frmEnsureThatYouAreRunningontheUIThread_Load(object sender, EventArgs e)
        {

        }
    }
}
