using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0220__Socket_Udp_Client
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/Udpclientsetup.htm
    public partial  class frmUdpclientsetup:Form
    {
        public frmUdpclientsetup()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUdpclientsetup
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUdpclientsetup";
            this.Text = "frmUdpclientsetup";
            this.Load += new System.EventHandler(this.frmUdpclientsetup_Load);
            this.ResumeLayout(false);

        }

        private void frmUdpclientsetup_Load(object sender, EventArgs e)
        {

        }
    }
}
