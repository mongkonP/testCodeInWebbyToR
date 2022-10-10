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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/TableCreateRowDelete.htm
    public partial  class frmTableCreateRowDelete:Form
    {
        public frmTableCreateRowDelete()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTableCreateRowDelete
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTableCreateRowDelete";
            this.Text = "frmTableCreateRowDelete";
            this.Load += new System.EventHandler(this.frmTableCreateRowDelete_Load);
            this.ResumeLayout(false);

        }

        private void frmTableCreateRowDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
