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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/NetworkClientandStreamReader.htm
    public partial  class frmNetworkClientandStreamReader:Form
    {
        public frmNetworkClientandStreamReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNetworkClientandStreamReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNetworkClientandStreamReader";
            this.Text = "frmNetworkClientandStreamReader";
            this.Load += new System.EventHandler(this.frmNetworkClientandStreamReader_Load);
            this.ResumeLayout(false);

        }

        private void frmNetworkClientandStreamReader_Load(object sender, EventArgs e)
        {

        }
    }
}
