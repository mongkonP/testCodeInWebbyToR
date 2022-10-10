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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/SimpleTcpClientsenddatatotheserver.htm
    public partial  class frmSimpleTcpClientsenddatatotheserver:Form
    {
        public frmSimpleTcpClientsenddatatotheserver()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleTcpClientsenddatatotheserver
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleTcpClientsenddatatotheserver";
            this.Text = "frmSimpleTcpClientsenddatatotheserver";
            this.Load += new System.EventHandler(this.frmSimpleTcpClientsenddatatotheserver_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleTcpClientsenddatatotheserver_Load(object sender, EventArgs e)
        {

        }
    }
}
