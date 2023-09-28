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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/TcpserveruseStreamWriterandStreamReadertoreadandwritetoaclient.htm
    public partial  class frmTcpserveruseStreamWriterandStreamReadertoreadandwritetoaclient:Form
    {
        public frmTcpserveruseStreamWriterandStreamReadertoreadandwritetoaclient()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTcpserveruseStreamWriterandStreamReadertoreadandwritetoaclient
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTcpserveruseStreamWriterandStreamReadertoreadandwritetoaclient";
            this.Text = "frmTcpserveruseStreamWriterandStreamReadertoreadandwritetoaclient";
            this.Load += new System.EventHandler(this.frmTcpserveruseStreamWriterandStreamReadertoreadandwritetoaclient_Load);
            this.ResumeLayout(false);

        }

        private void frmTcpserveruseStreamWriterandStreamReadertoreadandwritetoaclient_Load(object sender, EventArgs e)
        {

        }
    }
}
