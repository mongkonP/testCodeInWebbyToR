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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ModifyDataTable.htm
    public partial  class frmModifyDataTable:Form
    {
        public frmModifyDataTable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmModifyDataTable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmModifyDataTable";
            this.Text = "frmModifyDataTable";
            this.Load += new System.EventHandler(this.frmModifyDataTable_Load);
            this.ResumeLayout(false);

        }

        private void frmModifyDataTable_Load(object sender, EventArgs e)
        {

        }
    }
}
