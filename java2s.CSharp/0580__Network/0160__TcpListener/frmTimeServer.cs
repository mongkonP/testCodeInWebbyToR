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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/TimeServer.htm
    public partial  class frmTimeServer:Form
    {
        public frmTimeServer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTimeServer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTimeServer";
            this.Text = "frmTimeServer";
            this.Load += new System.EventHandler(this.frmTimeServer_Load);
            this.ResumeLayout(false);

        }

        private void frmTimeServer_Load(object sender, EventArgs e)
        {

        }
    }
}
