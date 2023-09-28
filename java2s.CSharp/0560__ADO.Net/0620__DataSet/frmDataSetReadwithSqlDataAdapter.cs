using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0620__DataSet
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/DataSetReadwithSqlDataAdapter.htm
    public partial  class frmDataSetReadwithSqlDataAdapter:Form
    {
        public frmDataSetReadwithSqlDataAdapter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataSetReadwithSqlDataAdapter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataSetReadwithSqlDataAdapter";
            this.Text = "frmDataSetReadwithSqlDataAdapter";
            this.Load += new System.EventHandler(this.frmDataSetReadwithSqlDataAdapter_Load);
            this.ResumeLayout(false);

        }

        private void frmDataSetReadwithSqlDataAdapter_Load(object sender, EventArgs e)
        {

        }
    }
}
