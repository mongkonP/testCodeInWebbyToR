using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0320__SqlCommand
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ExecuteScalarwithSqlCommand.htm
    public partial  class frmExecuteScalarwithSqlCommand:Form
    {
        public frmExecuteScalarwithSqlCommand()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExecuteScalarwithSqlCommand
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExecuteScalarwithSqlCommand";
            this.Text = "frmExecuteScalarwithSqlCommand";
            this.Load += new System.EventHandler(this.frmExecuteScalarwithSqlCommand_Load);
            this.ResumeLayout(false);

        }

        private void frmExecuteScalarwithSqlCommand_Load(object sender, EventArgs e)
        {

        }
    }
}
