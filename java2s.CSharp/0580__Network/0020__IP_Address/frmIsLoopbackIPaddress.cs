using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0020__IP_Address
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/IsLoopbackIPaddress.htm
    public partial  class frmIsLoopbackIPaddress:Form
    {
        public frmIsLoopbackIPaddress()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIsLoopbackIPaddress
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIsLoopbackIPaddress";
            this.Text = "frmIsLoopbackIPaddress";
            this.Load += new System.EventHandler(this.frmIsLoopbackIPaddress_Load);
            this.ResumeLayout(false);

        }

        private void frmIsLoopbackIPaddress_Load(object sender, EventArgs e)
        {

        }
    }
}
