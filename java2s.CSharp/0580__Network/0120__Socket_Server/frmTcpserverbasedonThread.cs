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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/TcpserverbasedonThread.htm
    public partial  class frmTcpserverbasedonThread:Form
    {
        public frmTcpserverbasedonThread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTcpserverbasedonThread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTcpserverbasedonThread";
            this.Text = "frmTcpserverbasedonThread";
            this.Load += new System.EventHandler(this.frmTcpserverbasedonThread_Load);
            this.ResumeLayout(false);

        }

        private void frmTcpserverbasedonThread_Load(object sender, EventArgs e)
        {

        }
    }
}
