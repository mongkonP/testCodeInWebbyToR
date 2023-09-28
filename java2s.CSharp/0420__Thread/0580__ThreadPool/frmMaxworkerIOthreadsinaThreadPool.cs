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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/MaxworkerIOthreadsinaThreadPool.htm
    public partial  class frmMaxworkerIOthreadsinaThreadPool:Form
    {
        public frmMaxworkerIOthreadsinaThreadPool()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMaxworkerIOthreadsinaThreadPool
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMaxworkerIOthreadsinaThreadPool";
            this.Text = "frmMaxworkerIOthreadsinaThreadPool";
            this.Load += new System.EventHandler(this.frmMaxworkerIOthreadsinaThreadPool_Load);
            this.ResumeLayout(false);

        }

        private void frmMaxworkerIOthreadsinaThreadPool_Load(object sender, EventArgs e)
        {

        }
    }
}
