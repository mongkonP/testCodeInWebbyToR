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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/AddingaColumntoaChildDataTableThatDisplaysDatafromtheParentTable.htm
    public partial  class frmAddingaColumntoaChildDataTableThatDisplaysDatafromtheParentTable:Form
    {
        public frmAddingaColumntoaChildDataTableThatDisplaysDatafromtheParentTable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddingaColumntoaChildDataTableThatDisplaysDatafromtheParentTable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddingaColumntoaChildDataTableThatDisplaysDatafromtheParentTable";
            this.Text = "frmAddingaColumntoaChildDataTableThatDisplaysDatafromtheParentTable";
            this.Load += new System.EventHandler(this.frmAddingaColumntoaChildDataTableThatDisplaysDatafromtheParentTable_Load);
            this.ResumeLayout(false);

        }

        private void frmAddingaColumntoaChildDataTableThatDisplaysDatafromtheParentTable_Load(object sender, EventArgs e)
        {

        }
    }
}
