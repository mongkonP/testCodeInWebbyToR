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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/LockDemo.htm
    public partial  class frmLockDemo:Form
    {
        public frmLockDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLockDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLockDemo";
            this.Text = "frmLockDemo";
            this.Load += new System.EventHandler(this.frmLockDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmLockDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
