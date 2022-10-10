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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ConnecttoSqlServerNamedInstance.htm
    public partial  class frmConnecttoSqlServerNamedInstance:Form
    {
        public frmConnecttoSqlServerNamedInstance()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConnecttoSqlServerNamedInstance
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConnecttoSqlServerNamedInstance";
            this.Text = "frmConnecttoSqlServerNamedInstance";
            this.Load += new System.EventHandler(this.frmConnecttoSqlServerNamedInstance_Load);
            this.ResumeLayout(false);

        }

        private void frmConnecttoSqlServerNamedInstance_Load(object sender, EventArgs e)
        {

        }
    }
}
