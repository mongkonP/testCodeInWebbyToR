using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0540__Chat
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/TcpChat.htm
    public partial  class frmTcpChat:Form
    {
        public frmTcpChat()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTcpChat
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTcpChat";
            this.Text = "frmTcpChat";
            this.Load += new System.EventHandler(this.frmTcpChat_Load);
            this.ResumeLayout(false);

        }

        private void frmTcpChat_Load(object sender, EventArgs e)
        {

        }
    }
}
