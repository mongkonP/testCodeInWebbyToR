using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0420__ArrayList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/SortArrayListusingthedefaultcomparerandacustomcomparerthatreversesthesortorder.htm
    public partial  class frmSortArrayListusingthedefaultcomparerandacustomcomparerthatreversesthesortorder:Form
    {
        public frmSortArrayListusingthedefaultcomparerandacustomcomparerthatreversesthesortorder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSortArrayListusingthedefaultcomparerandacustomcomparerthatreversesthesortorder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSortArrayListusingthedefaultcomparerandacustomcomparerthatreversesthesortorder";
            this.Text = "frmSortArrayListusingthedefaultcomparerandacustomcomparerthatreversesthesortorder";
            this.Load += new System.EventHandler(this.frmSortArrayListusingthedefaultcomparerandacustomcomparerthatreversesthesortorder_Load);
            this.ResumeLayout(false);

        }

        private void frmSortArrayListusingthedefaultcomparerandacustomcomparerthatreversesthesortorder_Load(object sender, EventArgs e)
        {

        }
    }
}
