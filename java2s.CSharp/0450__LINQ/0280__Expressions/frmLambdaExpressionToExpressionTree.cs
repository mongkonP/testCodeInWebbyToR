using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0280__Expressions
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/LambdaExpressionToExpressionTree.htm
    public partial  class frmLambdaExpressionToExpressionTree:Form
    {
        public frmLambdaExpressionToExpressionTree()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLambdaExpressionToExpressionTree
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLambdaExpressionToExpressionTree";
            this.Text = "frmLambdaExpressionToExpressionTree";
            this.Load += new System.EventHandler(this.frmLambdaExpressionToExpressionTree_Load);
            this.ResumeLayout(false);

        }

        private void frmLambdaExpressionToExpressionTree_Load(object sender, EventArgs e)
        {

        }
    }
}
