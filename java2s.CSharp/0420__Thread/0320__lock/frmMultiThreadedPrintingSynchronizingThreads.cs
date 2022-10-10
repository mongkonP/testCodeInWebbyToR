using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0320__lock
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/MultiThreadedPrintingSynchronizingThreads.htm
    public partial  class frmMultiThreadedPrintingSynchronizingThreads:Form
    {
        public frmMultiThreadedPrintingSynchronizingThreads()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMultiThreadedPrintingSynchronizingThreads
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMultiThreadedPrintingSynchronizingThreads";
            this.Text = "frmMultiThreadedPrintingSynchronizingThreads";
            this.Load += new System.EventHandler(this.frmMultiThreadedPrintingSynchronizingThreads_Load);
            this.ResumeLayout(false);

        }

        private void frmMultiThreadedPrintingSynchronizingThreads_Load(object sender, EventArgs e)
        {

        }
    }
}
