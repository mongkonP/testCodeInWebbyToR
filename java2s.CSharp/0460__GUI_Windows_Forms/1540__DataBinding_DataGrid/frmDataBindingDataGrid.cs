using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1540__DataBinding_DataGrid
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DataBindingDataGrid.htm
    public partial  class frmDataBindingDataGrid:Form
    {
        public frmDataBindingDataGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataBindingDataGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataBindingDataGrid";
            this.Text = "frmDataBindingDataGrid";
            this.Load += new System.EventHandler(this.frmDataBindingDataGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmDataBindingDataGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
