using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0260__UdpClient
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/UdpClientreceiveformulticastgroup.htm
    public partial  class frmUdpClientreceiveformulticastgroup:Form
    {
        public frmUdpClientreceiveformulticastgroup()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUdpClientreceiveformulticastgroup
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUdpClientreceiveformulticastgroup";
            this.Text = "frmUdpClientreceiveformulticastgroup";
            this.Load += new System.EventHandler(this.frmUdpClientreceiveformulticastgroup_Load);
            this.ResumeLayout(false);

        }

        private void frmUdpClientreceiveformulticastgroup_Load(object sender, EventArgs e)
        {

        }
    }
}
