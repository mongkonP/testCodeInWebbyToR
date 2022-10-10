using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0040__DNS
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/GetHostbyIPaddress.htm
    public partial  class frmGetHostbyIPaddress:Form
    {
        public frmGetHostbyIPaddress()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetHostbyIPaddress
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetHostbyIPaddress";
            this.Text = "frmGetHostbyIPaddress";
            this.Load += new System.EventHandler(this.frmGetHostbyIPaddress_Load);
            this.ResumeLayout(false);

        }

        private void frmGetHostbyIPaddress_Load(object sender, EventArgs e)
        {

        }
    }
}
