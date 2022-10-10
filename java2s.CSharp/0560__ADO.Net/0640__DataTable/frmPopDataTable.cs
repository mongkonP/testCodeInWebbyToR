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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/PopDataTable.htm
    public partial  class frmPopDataTable:Form
    {
        public frmPopDataTable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPopDataTable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPopDataTable";
            this.Text = "frmPopDataTable";
            this.Load += new System.EventHandler(this.frmPopDataTable_Load);
            this.ResumeLayout(false);

        }

        private void frmPopDataTable_Load(object sender, EventArgs e)
        {

        }
    }
}
