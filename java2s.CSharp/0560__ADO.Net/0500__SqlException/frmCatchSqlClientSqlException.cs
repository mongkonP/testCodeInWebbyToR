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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/CatchSqlClientSqlException.htm
    public partial  class frmCatchSqlClientSqlException:Form
    {
        public frmCatchSqlClientSqlException()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCatchSqlClientSqlException
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCatchSqlClientSqlException";
            this.Text = "frmCatchSqlClientSqlException";
            this.Load += new System.EventHandler(this.frmCatchSqlClientSqlException_Load);
            this.ResumeLayout(false);

        }

        private void frmCatchSqlClientSqlException_Load(object sender, EventArgs e)
        {

        }
    }
}
