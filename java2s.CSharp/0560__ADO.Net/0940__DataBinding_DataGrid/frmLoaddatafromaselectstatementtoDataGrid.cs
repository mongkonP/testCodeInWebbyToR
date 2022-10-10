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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/LoaddatafromaselectstatementtoDataGrid.htm
    public partial  class frmLoaddatafromaselectstatementtoDataGrid:Form
    {
        public frmLoaddatafromaselectstatementtoDataGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoaddatafromaselectstatementtoDataGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoaddatafromaselectstatementtoDataGrid";
            this.Text = "frmLoaddatafromaselectstatementtoDataGrid";
            this.Load += new System.EventHandler(this.frmLoaddatafromaselectstatementtoDataGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmLoaddatafromaselectstatementtoDataGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
