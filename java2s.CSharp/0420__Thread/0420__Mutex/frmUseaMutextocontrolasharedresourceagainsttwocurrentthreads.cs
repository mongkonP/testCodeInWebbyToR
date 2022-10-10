using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0420__Mutex
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UseaMutextocontrolasharedresourceagainsttwocurrentthreads.htm
    public partial  class frmUseaMutextocontrolasharedresourceagainsttwocurrentthreads:Form
    {
        public frmUseaMutextocontrolasharedresourceagainsttwocurrentthreads()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseaMutextocontrolasharedresourceagainsttwocurrentthreads
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseaMutextocontrolasharedresourceagainsttwocurrentthreads";
            this.Text = "frmUseaMutextocontrolasharedresourceagainsttwocurrentthreads";
            this.Load += new System.EventHandler(this.frmUseaMutextocontrolasharedresourceagainsttwocurrentthreads_Load);
            this.ResumeLayout(false);

        }

        private void frmUseaMutextocontrolasharedresourceagainsttwocurrentthreads_Load(object sender, EventArgs e)
        {

        }
    }
}
