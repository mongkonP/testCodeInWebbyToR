using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0040__MySql
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ODBCMySqlConnection.htm
    public partial  class frmODBCMySqlConnection:Form
    {
        public frmODBCMySqlConnection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmODBCMySqlConnection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmODBCMySqlConnection";
            this.Text = "frmODBCMySqlConnection";
            this.Load += new System.EventHandler(this.frmODBCMySqlConnection_Load);
            this.ResumeLayout(false);

        }

        private void frmODBCMySqlConnection_Load(object sender, EventArgs e)
        {

        }
    }
}
