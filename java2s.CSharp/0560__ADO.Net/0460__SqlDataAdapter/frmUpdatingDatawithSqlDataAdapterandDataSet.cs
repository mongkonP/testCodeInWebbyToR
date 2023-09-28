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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/UpdatingDatawithSqlDataAdapterandDataSet.htm
    public partial  class frmUpdatingDatawithSqlDataAdapterandDataSet:Form
    {
        public frmUpdatingDatawithSqlDataAdapterandDataSet()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUpdatingDatawithSqlDataAdapterandDataSet
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUpdatingDatawithSqlDataAdapterandDataSet";
            this.Text = "frmUpdatingDatawithSqlDataAdapterandDataSet";
            this.Load += new System.EventHandler(this.frmUpdatingDatawithSqlDataAdapterandDataSet_Load);
            this.ResumeLayout(false);

        }

        private void frmUpdatingDatawithSqlDataAdapterandDataSet_Load(object sender, EventArgs e)
        {

        }
    }
}
