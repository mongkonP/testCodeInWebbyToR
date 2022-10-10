using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0140__TcpClient
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/CreateBinaryWriterandBinaryReaderfromTcpClient.htm
    public partial  class frmCreateBinaryWriterandBinaryReaderfromTcpClient:Form
    {
        public frmCreateBinaryWriterandBinaryReaderfromTcpClient()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateBinaryWriterandBinaryReaderfromTcpClient
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateBinaryWriterandBinaryReaderfromTcpClient";
            this.Text = "frmCreateBinaryWriterandBinaryReaderfromTcpClient";
            this.Load += new System.EventHandler(this.frmCreateBinaryWriterandBinaryReaderfromTcpClient_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateBinaryWriterandBinaryReaderfromTcpClient_Load(object sender, EventArgs e)
        {

        }
    }
}
