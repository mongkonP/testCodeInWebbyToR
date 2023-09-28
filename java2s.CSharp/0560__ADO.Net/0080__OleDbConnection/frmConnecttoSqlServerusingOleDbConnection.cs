using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0080__OleDbConnection
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ConnecttoSqlServerusingOleDbConnection.htm
    public partial  class frmConnecttoSqlServerusingOleDbConnection:Form
    {
        public frmConnecttoSqlServerusingOleDbConnection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConnecttoSqlServerusingOleDbConnection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConnecttoSqlServerusingOleDbConnection";
            this.Text = "frmConnecttoSqlServerusingOleDbConnection";
            this.Load += new System.EventHandler(this.frmConnecttoSqlServerusingOleDbConnection_Load);
            this.ResumeLayout(false);

        }

        private void frmConnecttoSqlServerusingOleDbConnection_Load(object sender, EventArgs e)
        {

        }
    }
}
