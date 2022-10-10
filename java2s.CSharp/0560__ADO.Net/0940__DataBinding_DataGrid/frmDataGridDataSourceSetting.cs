using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0940__DataBinding_DataGrid
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/DataGridDataSourceSetting.htm
    public partial  class frmDataGridDataSourceSetting:Form
    {
        public frmDataGridDataSourceSetting()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataGridDataSourceSetting
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataGridDataSourceSetting";
            this.Text = "frmDataGridDataSourceSetting";
            this.Load += new System.EventHandler(this.frmDataGridDataSourceSetting_Load);
            this.ResumeLayout(false);

        }

        private void frmDataGridDataSourceSetting_Load(object sender, EventArgs e)
        {

        }
    }
}
