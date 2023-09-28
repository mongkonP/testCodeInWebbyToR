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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/SQLStoredProcedure.htm
    public partial  class frmSQLStoredProcedure:Form
    {
        public frmSQLStoredProcedure()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSQLStoredProcedure
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSQLStoredProcedure";
            this.Text = "frmSQLStoredProcedure";
            this.Load += new System.EventHandler(this.frmSQLStoredProcedure_Load);
            this.ResumeLayout(false);

        }

        private void frmSQLStoredProcedure_Load(object sender, EventArgs e)
        {

        }
    }
}
