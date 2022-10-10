using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0700__DataView
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/CreateDataViewsfromDataTable.htm
    public partial  class frmCreateDataViewsfromDataTable:Form
    {
        public frmCreateDataViewsfromDataTable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateDataViewsfromDataTable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateDataViewsfromDataTable";
            this.Text = "frmCreateDataViewsfromDataTable";
            this.Load += new System.EventHandler(this.frmCreateDataViewsfromDataTable_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateDataViewsfromDataTable_Load(object sender, EventArgs e)
        {

        }
    }
}
