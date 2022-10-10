using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0460__SqlDataAdapter
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/FillDataSetWithSqlDataAdapter.htm
    public partial  class frmFillDataSetWithSqlDataAdapter:Form
    {
        public frmFillDataSetWithSqlDataAdapter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFillDataSetWithSqlDataAdapter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFillDataSetWithSqlDataAdapter";
            this.Text = "frmFillDataSetWithSqlDataAdapter";
            this.Load += new System.EventHandler(this.frmFillDataSetWithSqlDataAdapter_Load);
            this.ResumeLayout(false);

        }

        private void frmFillDataSetWithSqlDataAdapter_Load(object sender, EventArgs e)
        {

        }
    }
}
