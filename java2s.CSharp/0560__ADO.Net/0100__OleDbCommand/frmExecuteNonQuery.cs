using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0100__OleDbCommand
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ExecuteNonQuery.htm
    public partial  class frmExecuteNonQuery:Form
    {
        public frmExecuteNonQuery()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExecuteNonQuery
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExecuteNonQuery";
            this.Text = "frmExecuteNonQuery";
            this.Load += new System.EventHandler(this.frmExecuteNonQuery_Load);
            this.ResumeLayout(false);

        }

        private void frmExecuteNonQuery_Load(object sender, EventArgs e)
        {

        }
    }
}
