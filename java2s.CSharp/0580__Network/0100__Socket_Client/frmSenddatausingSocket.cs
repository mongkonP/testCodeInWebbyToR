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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/SenddatausingSocket.htm
    public partial  class frmSenddatausingSocket:Form
    {
        public frmSenddatausingSocket()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSenddatausingSocket
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSenddatausingSocket";
            this.Text = "frmSenddatausingSocket";
            this.Load += new System.EventHandler(this.frmSenddatausingSocket_Load);
            this.ResumeLayout(false);

        }

        private void frmSenddatausingSocket_Load(object sender, EventArgs e)
        {

        }
    }
}
