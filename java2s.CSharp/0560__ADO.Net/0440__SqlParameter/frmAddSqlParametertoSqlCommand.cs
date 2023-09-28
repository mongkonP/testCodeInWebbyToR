using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0440__SqlParameter
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/AddSqlParametertoSqlCommand.htm
    public partial  class frmAddSqlParametertoSqlCommand:Form
    {
        public frmAddSqlParametertoSqlCommand()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddSqlParametertoSqlCommand
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddSqlParametertoSqlCommand";
            this.Text = "frmAddSqlParametertoSqlCommand";
            this.Load += new System.EventHandler(this.frmAddSqlParametertoSqlCommand_Load);
            this.ResumeLayout(false);

        }

        private void frmAddSqlParametertoSqlCommand_Load(object sender, EventArgs e)
        {

        }
    }
}
