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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/SleepInteruptThreads.htm
    public partial  class frmSleepInteruptThreads:Form
    {
        public frmSleepInteruptThreads()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSleepInteruptThreads
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSleepInteruptThreads";
            this.Text = "frmSleepInteruptThreads";
            this.Load += new System.EventHandler(this.frmSleepInteruptThreads_Load);
            this.ResumeLayout(false);

        }

        private void frmSleepInteruptThreads_Load(object sender, EventArgs e)
        {

        }
    }
}
