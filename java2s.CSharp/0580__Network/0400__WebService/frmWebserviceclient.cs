using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0400__WebService
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/Webserviceclient.htm
    public partial  class frmWebserviceclient:Form
    {
        public frmWebserviceclient()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWebserviceclient
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWebserviceclient";
            this.Text = "frmWebserviceclient";
            this.Load += new System.EventHandler(this.frmWebserviceclient_Load);
            this.ResumeLayout(false);

        }

        private void frmWebserviceclient_Load(object sender, EventArgs e)
        {

        }
    }
}
