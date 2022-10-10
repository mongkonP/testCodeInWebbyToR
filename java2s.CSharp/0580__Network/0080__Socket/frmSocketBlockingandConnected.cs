using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0080__Socket
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/SocketBlockingandConnected.htm
    public partial  class frmSocketBlockingandConnected:Form
    {
        public frmSocketBlockingandConnected()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSocketBlockingandConnected
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSocketBlockingandConnected";
            this.Text = "frmSocketBlockingandConnected";
            this.Load += new System.EventHandler(this.frmSocketBlockingandConnected_Load);
            this.ResumeLayout(false);

        }

        private void frmSocketBlockingandConnected_Load(object sender, EventArgs e)
        {

        }
    }
}
