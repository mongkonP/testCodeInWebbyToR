using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0040__Lambda
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ListSortWithLambdaExpression.htm
    public partial  class frmListSortWithLambdaExpression:Form
    {
        public frmListSortWithLambdaExpression()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListSortWithLambdaExpression
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListSortWithLambdaExpression";
            this.Text = "frmListSortWithLambdaExpression";
            this.Load += new System.EventHandler(this.frmListSortWithLambdaExpression_Load);
            this.ResumeLayout(false);

        }

        private void frmListSortWithLambdaExpression_Load(object sender, EventArgs e)
        {

        }
    }
}
