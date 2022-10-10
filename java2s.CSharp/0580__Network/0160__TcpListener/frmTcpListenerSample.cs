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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/TcpListenerSample.htm
    public partial  class frmTcpListenerSample:Form
    {
        public frmTcpListenerSample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTcpListenerSample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTcpListenerSample";
            this.Text = "frmTcpListenerSample";
            this.Load += new System.EventHandler(this.frmTcpListenerSample_Load);
            this.ResumeLayout(false);

        }

        private void frmTcpListenerSample_Load(object sender, EventArgs e)
        {

        }
    }
}
