using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0200__Udp
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/Udptimeoutoption.htm
    public partial  class frmUdptimeoutoption:Form
    {
        public frmUdptimeoutoption()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUdptimeoutoption
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUdptimeoutoption";
            this.Text = "frmUdptimeoutoption";
            this.Load += new System.EventHandler(this.frmUdptimeoutoption_Load);
            this.ResumeLayout(false);

        }

        private void frmUdptimeoutoption_Load(object sender, EventArgs e)
        {

        }
    }
}
