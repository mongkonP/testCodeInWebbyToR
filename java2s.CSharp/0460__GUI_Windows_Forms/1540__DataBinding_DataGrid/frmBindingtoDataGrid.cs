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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/BindingtoDataGrid.htm
    public partial  class frmBindingtoDataGrid:Form
    {
        public frmBindingtoDataGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindingtoDataGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindingtoDataGrid";
            this.Text = "frmBindingtoDataGrid";
            this.Load += new System.EventHandler(this.frmBindingtoDataGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmBindingtoDataGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
