using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0940__DataBinding_DataGrid
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/DataGriddatabinding.htm
    public partial  class frmDataGriddatabinding:Form
    {
        public frmDataGriddatabinding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataGriddatabinding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataGriddatabinding";
            this.Text = "frmDataGriddatabinding";
            this.Load += new System.EventHandler(this.frmDataGriddatabinding_Load);
            this.ResumeLayout(false);

        }

        private void frmDataGriddatabinding_Load(object sender, EventArgs e)
        {

        }
    }
}
