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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Usethesystemthreadpool.htm
    public partial  class frmUsethesystemthreadpool:Form
    {
        public frmUsethesystemthreadpool()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsethesystemthreadpool
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsethesystemthreadpool";
            this.Text = "frmUsethesystemthreadpool";
            this.Load += new System.EventHandler(this.frmUsethesystemthreadpool_Load);
            this.ResumeLayout(false);

        }

        private void frmUsethesystemthreadpool_Load(object sender, EventArgs e)
        {

        }
    }
}
