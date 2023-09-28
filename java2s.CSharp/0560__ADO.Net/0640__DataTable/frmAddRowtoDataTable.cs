using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0640__DataTable
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/AddRowtoDataTable.htm
    public partial  class frmAddRowtoDataTable:Form
    {
        public frmAddRowtoDataTable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddRowtoDataTable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddRowtoDataTable";
            this.Text = "frmAddRowtoDataTable";
            this.Load += new System.EventHandler(this.frmAddRowtoDataTable_Load);
            this.ResumeLayout(false);

        }

        private void frmAddRowtoDataTable_Load(object sender, EventArgs e)
        {

        }
    }
}
