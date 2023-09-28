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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/GUIbasedTcpServer.htm
    public partial  class frmGUIbasedTcpServer:Form
    {
        public frmGUIbasedTcpServer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGUIbasedTcpServer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGUIbasedTcpServer";
            this.Text = "frmGUIbasedTcpServer";
            this.Load += new System.EventHandler(this.frmGUIbasedTcpServer_Load);
            this.ResumeLayout(false);

        }

        private void frmGUIbasedTcpServer_Load(object sender, EventArgs e)
        {

        }
    }
}
