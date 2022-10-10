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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Sharedresourcewithoutlock.htm
    public partial  class frmSharedresourcewithoutlock:Form
    {
        public frmSharedresourcewithoutlock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSharedresourcewithoutlock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSharedresourcewithoutlock";
            this.Text = "frmSharedresourcewithoutlock";
            this.Load += new System.EventHandler(this.frmSharedresourcewithoutlock_Load);
            this.ResumeLayout(false);

        }

        private void frmSharedresourcewithoutlock_Load(object sender, EventArgs e)
        {

        }
    }
}
