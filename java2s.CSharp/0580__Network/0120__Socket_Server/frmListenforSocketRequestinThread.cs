using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0120__Socket_Server
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/ListenforSocketRequestinThread.htm
    public partial  class frmListenforSocketRequestinThread:Form
    {
        public frmListenforSocketRequestinThread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListenforSocketRequestinThread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListenforSocketRequestinThread";
            this.Text = "frmListenforSocketRequestinThread";
            this.Load += new System.EventHandler(this.frmListenforSocketRequestinThread_Load);
            this.ResumeLayout(false);

        }

        private void frmListenforSocketRequestinThread_Load(object sender, EventArgs e)
        {

        }
    }
}
