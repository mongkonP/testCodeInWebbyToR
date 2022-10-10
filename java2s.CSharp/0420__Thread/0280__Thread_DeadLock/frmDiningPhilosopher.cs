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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/DiningPhilosopher.htm
    public partial  class frmDiningPhilosopher:Form
    {
        public frmDiningPhilosopher()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDiningPhilosopher
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDiningPhilosopher";
            this.Text = "frmDiningPhilosopher";
            this.Load += new System.EventHandler(this.frmDiningPhilosopher_Load);
            this.ResumeLayout(false);

        }

        private void frmDiningPhilosopher_Load(object sender, EventArgs e)
        {

        }
    }
}
