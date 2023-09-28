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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/LoaddatainDataTabletoDataGrid.htm
    public partial  class frmLoaddatainDataTabletoDataGrid:Form
    {
        public frmLoaddatainDataTabletoDataGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoaddatainDataTabletoDataGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoaddatainDataTabletoDataGrid";
            this.Text = "frmLoaddatainDataTabletoDataGrid";
            this.Load += new System.EventHandler(this.frmLoaddatainDataTabletoDataGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmLoaddatainDataTabletoDataGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
