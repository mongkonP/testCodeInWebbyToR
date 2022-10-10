using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0140__OleDbCommandBuilder
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/InsertDataandreloadtoDataGrid.htm
    public partial  class frmInsertDataandreloadtoDataGrid:Form
    {
        public frmInsertDataandreloadtoDataGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInsertDataandreloadtoDataGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInsertDataandreloadtoDataGrid";
            this.Text = "frmInsertDataandreloadtoDataGrid";
            this.Load += new System.EventHandler(this.frmInsertDataandreloadtoDataGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmInsertDataandreloadtoDataGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
