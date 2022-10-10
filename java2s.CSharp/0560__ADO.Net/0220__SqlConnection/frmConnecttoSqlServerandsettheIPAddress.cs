using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0220__SqlConnection
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ConnecttoSqlServerandsettheIPAddress.htm
    public partial  class frmConnecttoSqlServerandsettheIPAddress:Form
    {
        public frmConnecttoSqlServerandsettheIPAddress()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConnecttoSqlServerandsettheIPAddress
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConnecttoSqlServerandsettheIPAddress";
            this.Text = "frmConnecttoSqlServerandsettheIPAddress";
            this.Load += new System.EventHandler(this.frmConnecttoSqlServerandsettheIPAddress_Load);
            this.ResumeLayout(false);

        }

        private void frmConnecttoSqlServerandsettheIPAddress_Load(object sender, EventArgs e)
        {

        }
    }
}
