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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/LoopthroughtherowsinDataTable.htm
    public partial  class frmLoopthroughtherowsinDataTable:Form
    {
        public frmLoopthroughtherowsinDataTable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoopthroughtherowsinDataTable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoopthroughtherowsinDataTable";
            this.Text = "frmLoopthroughtherowsinDataTable";
            this.Load += new System.EventHandler(this.frmLoopthroughtherowsinDataTable_Load);
            this.ResumeLayout(false);

        }

        private void frmLoopthroughtherowsinDataTable_Load(object sender, EventArgs e)
        {

        }
    }
}
