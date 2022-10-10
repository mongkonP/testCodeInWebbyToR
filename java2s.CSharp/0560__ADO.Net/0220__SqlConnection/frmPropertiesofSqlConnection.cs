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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/PropertiesofSqlConnection.htm
    public partial  class frmPropertiesofSqlConnection:Form
    {
        public frmPropertiesofSqlConnection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPropertiesofSqlConnection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPropertiesofSqlConnection";
            this.Text = "frmPropertiesofSqlConnection";
            this.Load += new System.EventHandler(this.frmPropertiesofSqlConnection_Load);
            this.ResumeLayout(false);

        }

        private void frmPropertiesofSqlConnection_Load(object sender, EventArgs e)
        {

        }
    }
}
