using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0160__TcpListener
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/CreateaSocketserverfromTcpListener.htm
    public partial  class frmCreateaSocketserverfromTcpListener:Form
    {
        public frmCreateaSocketserverfromTcpListener()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateaSocketserverfromTcpListener
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateaSocketserverfromTcpListener";
            this.Text = "frmCreateaSocketserverfromTcpListener";
            this.Load += new System.EventHandler(this.frmCreateaSocketserverfromTcpListener_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaSocketserverfromTcpListener_Load(object sender, EventArgs e)
        {

        }
    }
}
