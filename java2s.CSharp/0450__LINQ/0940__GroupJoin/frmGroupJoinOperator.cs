using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0940__GroupJoin
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/GroupJoinOperator.htm
    public partial  class frmGroupJoinOperator:Form
    {
        public frmGroupJoinOperator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGroupJoinOperator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGroupJoinOperator";
            this.Text = "frmGroupJoinOperator";
            this.Load += new System.EventHandler(this.frmGroupJoinOperator_Load);
            this.ResumeLayout(false);

        }

        private void frmGroupJoinOperator_Load(object sender, EventArgs e)
        {

        }
    }
}
