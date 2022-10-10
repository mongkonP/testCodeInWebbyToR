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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/UseLINQtogetEmployeesintheITdepartmentfromatree.htm
    public partial  class frmUseLINQtogetEmployeesintheITdepartmentfromatree:Form
    {
        public frmUseLINQtogetEmployeesintheITdepartmentfromatree()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseLINQtogetEmployeesintheITdepartmentfromatree
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseLINQtogetEmployeesintheITdepartmentfromatree";
            this.Text = "frmUseLINQtogetEmployeesintheITdepartmentfromatree";
            this.Load += new System.EventHandler(this.frmUseLINQtogetEmployeesintheITdepartmentfromatree_Load);
            this.ResumeLayout(false);

        }

        private void frmUseLINQtogetEmployeesintheITdepartmentfromatree_Load(object sender, EventArgs e)
        {

        }
    }
}
