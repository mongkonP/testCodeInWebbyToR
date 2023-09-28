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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/DataGridColumnStylesetting.htm
    public partial  class frmDataGridColumnStylesetting:Form
    {
        public frmDataGridColumnStylesetting()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataGridColumnStylesetting
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataGridColumnStylesetting";
            this.Text = "frmDataGridColumnStylesetting";
            this.Load += new System.EventHandler(this.frmDataGridColumnStylesetting_Load);
            this.ResumeLayout(false);

        }

        private void frmDataGridColumnStylesetting_Load(object sender, EventArgs e)
        {

        }
    }
}
