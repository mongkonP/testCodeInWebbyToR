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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ConnecttoSQLserver.htm
    public partial  class frmConnecttoSQLserver:Form
    {
        public frmConnecttoSQLserver()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConnecttoSQLserver
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConnecttoSQLserver";
            this.Text = "frmConnecttoSQLserver";
            this.Load += new System.EventHandler(this.frmConnecttoSQLserver_Load);
            this.ResumeLayout(false);

        }

        private void frmConnecttoSQLserver_Load(object sender, EventArgs e)
        {

        }
    }
}
