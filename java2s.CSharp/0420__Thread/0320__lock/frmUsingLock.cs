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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UsingLock.htm
    public partial  class frmUsingLock:Form
    {
        public frmUsingLock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingLock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingLock";
            this.Text = "frmUsingLock";
            this.Load += new System.EventHandler(this.frmUsingLock_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingLock_Load(object sender, EventArgs e)
        {

        }
    }
}
