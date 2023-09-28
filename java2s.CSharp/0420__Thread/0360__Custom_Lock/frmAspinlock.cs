using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0360__Custom_Lock
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Aspinlock.htm
    public partial  class frmAspinlock:Form
    {
        public frmAspinlock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAspinlock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAspinlock";
            this.Text = "frmAspinlock";
            this.Load += new System.EventHandler(this.frmAspinlock_Load);
            this.ResumeLayout(false);

        }

        private void frmAspinlock_Load(object sender, EventArgs e)
        {

        }
    }
}
