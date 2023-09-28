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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/SimpleTcpserversenddatatotheclient.htm
    public partial  class frmSimpleTcpserversenddatatotheclient:Form
    {
        public frmSimpleTcpserversenddatatotheclient()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleTcpserversenddatatotheclient
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleTcpserversenddatatotheclient";
            this.Text = "frmSimpleTcpserversenddatatotheclient";
            this.Load += new System.EventHandler(this.frmSimpleTcpserversenddatatotheclient_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleTcpserversenddatatotheclient_Load(object sender, EventArgs e)
        {

        }
    }
}
