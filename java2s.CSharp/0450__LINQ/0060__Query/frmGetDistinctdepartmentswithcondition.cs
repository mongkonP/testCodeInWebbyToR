using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0060__Query
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/GetDistinctdepartmentswithcondition.htm
    public partial  class frmGetDistinctdepartmentswithcondition:Form
    {
        public frmGetDistinctdepartmentswithcondition()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetDistinctdepartmentswithcondition
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetDistinctdepartmentswithcondition";
            this.Text = "frmGetDistinctdepartmentswithcondition";
            this.Load += new System.EventHandler(this.frmGetDistinctdepartmentswithcondition_Load);
            this.ResumeLayout(false);

        }

        private void frmGetDistinctdepartmentswithcondition_Load(object sender, EventArgs e)
        {

        }
    }
}
