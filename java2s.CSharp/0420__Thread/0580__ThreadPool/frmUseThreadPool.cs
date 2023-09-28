using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0580__ThreadPool
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UseThreadPool.htm
    public partial  class frmUseThreadPool:Form
    {
        public frmUseThreadPool()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseThreadPool
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseThreadPool";
            this.Text = "frmUseThreadPool";
            this.Load += new System.EventHandler(this.frmUseThreadPool_Load);
            this.ResumeLayout(false);

        }

        private void frmUseThreadPool_Load(object sender, EventArgs e)
        {

        }
    }
}
