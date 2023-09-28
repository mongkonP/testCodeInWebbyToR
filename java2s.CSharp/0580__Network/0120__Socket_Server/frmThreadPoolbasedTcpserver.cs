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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/ThreadPoolbasedTcpserver.htm
    public partial  class frmThreadPoolbasedTcpserver:Form
    {
        public frmThreadPoolbasedTcpserver()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreadPoolbasedTcpserver
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreadPoolbasedTcpserver";
            this.Text = "frmThreadPoolbasedTcpserver";
            this.Load += new System.EventHandler(this.frmThreadPoolbasedTcpserver_Load);
            this.ResumeLayout(false);

        }

        private void frmThreadPoolbasedTcpserver_Load(object sender, EventArgs e)
        {

        }
    }
}
