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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UsingThreadPoolInsteadofInstantiatingThreadsExplicitly.htm
    public partial  class frmUsingThreadPoolInsteadofInstantiatingThreadsExplicitly:Form
    {
        public frmUsingThreadPoolInsteadofInstantiatingThreadsExplicitly()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingThreadPoolInsteadofInstantiatingThreadsExplicitly
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingThreadPoolInsteadofInstantiatingThreadsExplicitly";
            this.Text = "frmUsingThreadPoolInsteadofInstantiatingThreadsExplicitly";
            this.Load += new System.EventHandler(this.frmUsingThreadPoolInsteadofInstantiatingThreadsExplicitly_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingThreadPoolInsteadofInstantiatingThreadsExplicitly_Load(object sender, EventArgs e)
        {

        }
    }
}
