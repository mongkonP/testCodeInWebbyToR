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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/GetSqlStatistics.htm
    public partial  class frmGetSqlStatistics:Form
    {
        public frmGetSqlStatistics()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetSqlStatistics
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetSqlStatistics";
            this.Text = "frmGetSqlStatistics";
            this.Load += new System.EventHandler(this.frmGetSqlStatistics_Load);
            this.ResumeLayout(false);

        }

        private void frmGetSqlStatistics_Load(object sender, EventArgs e)
        {

        }
    }
}
