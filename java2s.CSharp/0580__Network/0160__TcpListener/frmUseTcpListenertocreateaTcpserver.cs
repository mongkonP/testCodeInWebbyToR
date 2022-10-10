using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0160__TcpListener
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UseTcpListenertocreateaTcpserver.htm
    public partial  class frmUseTcpListenertocreateaTcpserver:Form
    {
        public frmUseTcpListenertocreateaTcpserver()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseTcpListenertocreateaTcpserver
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseTcpListenertocreateaTcpserver";
            this.Text = "frmUseTcpListenertocreateaTcpserver";
            this.Load += new System.EventHandler(this.frmUseTcpListenertocreateaTcpserver_Load);
            this.ResumeLayout(false);

        }

        private void frmUseTcpListenertocreateaTcpserver_Load(object sender, EventArgs e)
        {

        }
    }
}
