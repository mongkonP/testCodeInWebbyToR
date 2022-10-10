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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/ReadcsvfromfinanceyahoocomwithTcpClient.htm
    public partial  class frmReadcsvfromfinanceyahoocomwithTcpClient:Form
    {
        public frmReadcsvfromfinanceyahoocomwithTcpClient()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadcsvfromfinanceyahoocomwithTcpClient
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadcsvfromfinanceyahoocomwithTcpClient";
            this.Text = "frmReadcsvfromfinanceyahoocomwithTcpClient";
            this.Load += new System.EventHandler(this.frmReadcsvfromfinanceyahoocomwithTcpClient_Load);
            this.ResumeLayout(false);

        }

        private void frmReadcsvfromfinanceyahoocomwithTcpClient_Load(object sender, EventArgs e)
        {

        }
    }
}
