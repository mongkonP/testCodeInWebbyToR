using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0040__Thread_Start
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/threadIsAlive.htm
    public partial  class frmthreadIsAlive:Form
    {
        public frmthreadIsAlive()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmthreadIsAlive
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmthreadIsAlive";
            this.Text = "frmthreadIsAlive";
            this.Load += new System.EventHandler(this.frmthreadIsAlive_Load);
            this.ResumeLayout(false);

        }

        private void frmthreadIsAlive_Load(object sender, EventArgs e)
        {

        }
    }
}
