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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/InterruptingThreads.htm
    public partial  class frmInterruptingThreads:Form
    {
        public frmInterruptingThreads()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInterruptingThreads
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInterruptingThreads";
            this.Text = "frmInterruptingThreads";
            this.Load += new System.EventHandler(this.frmInterruptingThreads_Load);
            this.ResumeLayout(false);

        }

        private void frmInterruptingThreads_Load(object sender, EventArgs e)
        {

        }
    }
}
