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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/UpdateSqlDataAdapterwithDataSet.htm
    public partial  class frmUpdateSqlDataAdapterwithDataSet:Form
    {
        public frmUpdateSqlDataAdapterwithDataSet()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUpdateSqlDataAdapterwithDataSet
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUpdateSqlDataAdapterwithDataSet";
            this.Text = "frmUpdateSqlDataAdapterwithDataSet";
            this.Load += new System.EventHandler(this.frmUpdateSqlDataAdapterwithDataSet_Load);
            this.ResumeLayout(false);

        }

        private void frmUpdateSqlDataAdapterwithDataSet_Load(object sender, EventArgs e)
        {

        }
    }
}
