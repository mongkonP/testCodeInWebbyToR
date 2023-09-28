using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0100__Socket_Client
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/GUIbasedTcpClient.htm
    public partial  class frmGUIbasedTcpClient:Form
    {
        public frmGUIbasedTcpClient()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGUIbasedTcpClient
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGUIbasedTcpClient";
            this.Text = "frmGUIbasedTcpClient";
            this.Load += new System.EventHandler(this.frmGUIbasedTcpClient_Load);
            this.ResumeLayout(false);

        }

        private void frmGUIbasedTcpClient_Load(object sender, EventArgs e)
        {

        }
    }
}
