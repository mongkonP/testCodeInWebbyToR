using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0980__Intersect
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/IntersectOperator.htm
    public partial  class frmIntersectOperator:Form
    {
        public frmIntersectOperator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIntersectOperator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIntersectOperator";
            this.Text = "frmIntersectOperator";
            this.Load += new System.EventHandler(this.frmIntersectOperator_Load);
            this.ResumeLayout(false);

        }

        private void frmIntersectOperator_Load(object sender, EventArgs e)
        {

        }
    }
}
