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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/NetworkClientwithTcpClientandNetworkStream.htm
    public partial  class frmNetworkClientwithTcpClientandNetworkStream:Form
    {
        public frmNetworkClientwithTcpClientandNetworkStream()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNetworkClientwithTcpClientandNetworkStream
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNetworkClientwithTcpClientandNetworkStream";
            this.Text = "frmNetworkClientwithTcpClientandNetworkStream";
            this.Load += new System.EventHandler(this.frmNetworkClientwithTcpClientandNetworkStream_Load);
            this.ResumeLayout(false);

        }

        private void frmNetworkClientwithTcpClientandNetworkStream_Load(object sender, EventArgs e)
        {

        }
    }
}
