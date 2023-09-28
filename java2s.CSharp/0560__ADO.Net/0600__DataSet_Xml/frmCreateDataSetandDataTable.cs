using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0600__DataSet_Xml
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/CreateDataSetandDataTable.htm
    public partial  class frmCreateDataSetandDataTable:Form
    {
        public frmCreateDataSetandDataTable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateDataSetandDataTable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateDataSetandDataTable";
            this.Text = "frmCreateDataSetandDataTable";
            this.Load += new System.EventHandler(this.frmCreateDataSetandDataTable_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateDataSetandDataTable_Load(object sender, EventArgs e)
        {

        }
    }
}
