using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0100__Thread_Abort
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Stoppingathread.htm
    public partial  class frmStoppingathread:Form
    {
        public frmStoppingathread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStoppingathread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStoppingathread";
            this.Text = "frmStoppingathread";
            this.Load += new System.EventHandler(this.frmStoppingathread_Load);
            this.ResumeLayout(false);

        }

        private void frmStoppingathread_Load(object sender, EventArgs e)
        {

        }
    }
}
