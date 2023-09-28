using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0840__ODBC
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ConnecttoSqlServerusingOdbcConnection.htm
    public partial  class frmConnecttoSqlServerusingOdbcConnection:Form
    {
        public frmConnecttoSqlServerusingOdbcConnection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConnecttoSqlServerusingOdbcConnection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConnecttoSqlServerusingOdbcConnection";
            this.Text = "frmConnecttoSqlServerusingOdbcConnection";
            this.Load += new System.EventHandler(this.frmConnecttoSqlServerusingOdbcConnection_Load);
            this.ResumeLayout(false);

        }

        private void frmConnecttoSqlServerusingOdbcConnection_Load(object sender, EventArgs e)
        {

        }
    }
}
