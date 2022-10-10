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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/DataGridRelation.htm
    public partial  class frmDataGridRelation:Form
    {
        public frmDataGridRelation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataGridRelation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataGridRelation";
            this.Text = "frmDataGridRelation";
            this.Load += new System.EventHandler(this.frmDataGridRelation_Load);
            this.ResumeLayout(false);

        }

        private void frmDataGridRelation_Load(object sender, EventArgs e)
        {

        }
    }
}
