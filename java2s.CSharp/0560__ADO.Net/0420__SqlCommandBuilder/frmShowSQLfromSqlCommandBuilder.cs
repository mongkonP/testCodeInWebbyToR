using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0420__SqlCommandBuilder
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ShowSQLfromSqlCommandBuilder.htm
    public partial  class frmShowSQLfromSqlCommandBuilder:Form
    {
        public frmShowSQLfromSqlCommandBuilder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmShowSQLfromSqlCommandBuilder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmShowSQLfromSqlCommandBuilder";
            this.Text = "frmShowSQLfromSqlCommandBuilder";
            this.Load += new System.EventHandler(this.frmShowSQLfromSqlCommandBuilder_Load);
            this.ResumeLayout(false);

        }

        private void frmShowSQLfromSqlCommandBuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
