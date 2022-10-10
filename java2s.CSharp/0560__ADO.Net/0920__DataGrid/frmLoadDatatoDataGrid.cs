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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/LoadDatatoDataGrid.htm
    public partial  class frmLoadDatatoDataGrid:Form
    {
        public frmLoadDatatoDataGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadDatatoDataGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadDatatoDataGrid";
            this.Text = "frmLoadDatatoDataGrid";
            this.Load += new System.EventHandler(this.frmLoadDatatoDataGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadDatatoDataGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
