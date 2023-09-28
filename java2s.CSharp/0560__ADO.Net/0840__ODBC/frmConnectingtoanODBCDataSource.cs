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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ConnectingtoanODBCDataSource.htm
    public partial  class frmConnectingtoanODBCDataSource:Form
    {
        public frmConnectingtoanODBCDataSource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConnectingtoanODBCDataSource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConnectingtoanODBCDataSource";
            this.Text = "frmConnectingtoanODBCDataSource";
            this.Load += new System.EventHandler(this.frmConnectingtoanODBCDataSource_Load);
            this.ResumeLayout(false);

        }

        private void frmConnectingtoanODBCDataSource_Load(object sender, EventArgs e)
        {

        }
    }
}
