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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/MinworkerIOthreadsinaThreadPool.htm
    public partial  class frmMinworkerIOthreadsinaThreadPool:Form
    {
        public frmMinworkerIOthreadsinaThreadPool()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMinworkerIOthreadsinaThreadPool
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMinworkerIOthreadsinaThreadPool";
            this.Text = "frmMinworkerIOthreadsinaThreadPool";
            this.Load += new System.EventHandler(this.frmMinworkerIOthreadsinaThreadPool_Load);
            this.ResumeLayout(false);

        }

        private void frmMinworkerIOthreadsinaThreadPool_Load(object sender, EventArgs e)
        {

        }
    }
}
