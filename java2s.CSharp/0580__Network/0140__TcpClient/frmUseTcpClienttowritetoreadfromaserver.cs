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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UseTcpClienttowritetoreadfromaserver.htm
    public partial  class frmUseTcpClienttowritetoreadfromaserver:Form
    {
        public frmUseTcpClienttowritetoreadfromaserver()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseTcpClienttowritetoreadfromaserver
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseTcpClienttowritetoreadfromaserver";
            this.Text = "frmUseTcpClienttowritetoreadfromaserver";
            this.Load += new System.EventHandler(this.frmUseTcpClienttowritetoreadfromaserver_Load);
            this.ResumeLayout(false);

        }

        private void frmUseTcpClienttowritetoreadfromaserver_Load(object sender, EventArgs e)
        {

        }
    }
}
