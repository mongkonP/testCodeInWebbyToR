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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/AppendcolumnstoDataTable.htm
    public partial  class frmAppendcolumnstoDataTable:Form
    {
        public frmAppendcolumnstoDataTable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAppendcolumnstoDataTable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAppendcolumnstoDataTable";
            this.Text = "frmAppendcolumnstoDataTable";
            this.Load += new System.EventHandler(this.frmAppendcolumnstoDataTable_Load);
            this.ResumeLayout(false);

        }

        private void frmAppendcolumnstoDataTable_Load(object sender, EventArgs e)
        {

        }
    }
}
