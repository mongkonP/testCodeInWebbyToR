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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/useTcpClienttoconnecttoaserver.htm
    public partial  class frmuseTcpClienttoconnecttoaserver:Form
    {
        public frmuseTcpClienttoconnecttoaserver()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmuseTcpClienttoconnecttoaserver
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmuseTcpClienttoconnecttoaserver";
            this.Text = "frmuseTcpClienttoconnecttoaserver";
            this.Load += new System.EventHandler(this.frmuseTcpClienttoconnecttoaserver_Load);
            this.ResumeLayout(false);

        }

        private void frmuseTcpClienttoconnecttoaserver_Load(object sender, EventArgs e)
        {

        }
    }
}
