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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Excelworkbookeventhandlers.htm
    public partial  class frmExcelworkbookeventhandlers:Form
    {
        public frmExcelworkbookeventhandlers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExcelworkbookeventhandlers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExcelworkbookeventhandlers";
            this.Text = "frmExcelworkbookeventhandlers";
            this.Load += new System.EventHandler(this.frmExcelworkbookeventhandlers_Load);
            this.ResumeLayout(false);

        }

        private void frmExcelworkbookeventhandlers_Load(object sender, EventArgs e)
        {

        }
    }
}
