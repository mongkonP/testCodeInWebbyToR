using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0680__DataTableMapping
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/DataTableMappingandDataGrid.htm
    public partial  class frmDataTableMappingandDataGrid:Form
    {
        public frmDataTableMappingandDataGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataTableMappingandDataGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataTableMappingandDataGrid";
            this.Text = "frmDataTableMappingandDataGrid";
            this.Load += new System.EventHandler(this.frmDataTableMappingandDataGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmDataTableMappingandDataGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
