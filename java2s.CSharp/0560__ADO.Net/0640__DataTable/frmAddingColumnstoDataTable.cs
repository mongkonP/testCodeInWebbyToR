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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/AddingColumnstoDataTable.htm
    public partial  class frmAddingColumnstoDataTable:Form
    {
        public frmAddingColumnstoDataTable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddingColumnstoDataTable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddingColumnstoDataTable";
            this.Text = "frmAddingColumnstoDataTable";
            this.Load += new System.EventHandler(this.frmAddingColumnstoDataTable_Load);
            this.ResumeLayout(false);

        }

        private void frmAddingColumnstoDataTable_Load(object sender, EventArgs e)
        {

        }
    }
}
