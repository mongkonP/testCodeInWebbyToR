using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0500__SqlException
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/CatchSqlExceptionwhenopeningconnection.htm
    public partial  class frmCatchSqlExceptionwhenopeningconnection:Form
    {
        public frmCatchSqlExceptionwhenopeningconnection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCatchSqlExceptionwhenopeningconnection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCatchSqlExceptionwhenopeningconnection";
            this.Text = "frmCatchSqlExceptionwhenopeningconnection";
            this.Load += new System.EventHandler(this.frmCatchSqlExceptionwhenopeningconnection_Load);
            this.ResumeLayout(false);

        }

        private void frmCatchSqlExceptionwhenopeningconnection_Load(object sender, EventArgs e)
        {

        }
    }
}
