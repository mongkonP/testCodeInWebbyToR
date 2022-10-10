using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0020__Access
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ConnectingToAccess.htm
    public partial  class frmConnectingToAccess:Form
    {
        public frmConnectingToAccess()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConnectingToAccess
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConnectingToAccess";
            this.Text = "frmConnectingToAccess";
            this.Load += new System.EventHandler(this.frmConnectingToAccess_Load);
            this.ResumeLayout(false);

        }

        private void frmConnectingToAccess_Load(object sender, EventArgs e)
        {

        }
    }
}
