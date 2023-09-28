using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0300__Excel
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/ExcelInteropExample.htm
    public partial  class frmExcelInteropExample:Form
    {
        public frmExcelInteropExample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExcelInteropExample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExcelInteropExample";
            this.Text = "frmExcelInteropExample";
            this.Load += new System.EventHandler(this.frmExcelInteropExample_Load);
            this.ResumeLayout(false);

        }

        private void frmExcelInteropExample_Load(object sender, EventArgs e)
        {

        }
    }
}
