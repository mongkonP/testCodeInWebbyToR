using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0920__DataGrid
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/BindingDataSettoDataGrid.htm
    public partial  class frmBindingDataSettoDataGrid:Form
    {
        public frmBindingDataSettoDataGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindingDataSettoDataGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindingDataSettoDataGrid";
            this.Text = "frmBindingDataSettoDataGrid";
            this.Load += new System.EventHandler(this.frmBindingDataSettoDataGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmBindingDataSettoDataGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
