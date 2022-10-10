using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0600__Distinct
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/GetDistinctdepartments.htm
    public partial  class frmGetDistinctdepartments:Form
    {
        public frmGetDistinctdepartments()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetDistinctdepartments
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetDistinctdepartments";
            this.Text = "frmGetDistinctdepartments";
            this.Load += new System.EventHandler(this.frmGetDistinctdepartments_Load);
            this.ResumeLayout(false);

        }

        private void frmGetDistinctdepartments_Load(object sender, EventArgs e)
        {

        }
    }
}
