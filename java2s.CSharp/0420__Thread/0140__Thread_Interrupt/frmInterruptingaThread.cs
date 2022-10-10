using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0140__Thread_Interrupt
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/InterruptingaThread.htm
    public partial  class frmInterruptingaThread:Form
    {
        public frmInterruptingaThread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInterruptingaThread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInterruptingaThread";
            this.Text = "frmInterruptingaThread";
            this.Load += new System.EventHandler(this.frmInterruptingaThread_Load);
            this.ResumeLayout(false);

        }

        private void frmInterruptingaThread_Load(object sender, EventArgs e)
        {

        }
    }
}
