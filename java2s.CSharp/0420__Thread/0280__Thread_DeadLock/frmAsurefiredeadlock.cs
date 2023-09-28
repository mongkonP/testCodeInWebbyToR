using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0280__Thread_DeadLock
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Asurefiredeadlock.htm
    public partial  class frmAsurefiredeadlock:Form
    {
        public frmAsurefiredeadlock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsurefiredeadlock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsurefiredeadlock";
            this.Text = "frmAsurefiredeadlock";
            this.Load += new System.EventHandler(this.frmAsurefiredeadlock_Load);
            this.ResumeLayout(false);

        }

        private void frmAsurefiredeadlock_Load(object sender, EventArgs e)
        {

        }
    }
}
