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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ShowtheconnectionpropertiesforSqlConnection.htm
    public partial  class frmShowtheconnectionpropertiesforSqlConnection:Form
    {
        public frmShowtheconnectionpropertiesforSqlConnection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmShowtheconnectionpropertiesforSqlConnection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmShowtheconnectionpropertiesforSqlConnection";
            this.Text = "frmShowtheconnectionpropertiesforSqlConnection";
            this.Load += new System.EventHandler(this.frmShowtheconnectionpropertiesforSqlConnection_Load);
            this.ResumeLayout(false);

        }

        private void frmShowtheconnectionpropertiesforSqlConnection_Load(object sender, EventArgs e)
        {

        }
    }
}
