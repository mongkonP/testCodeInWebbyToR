using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0160__where
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/QueryUsingtheQueryExpressionSyntax.htm
    public partial  class frmQueryUsingtheQueryExpressionSyntax:Form
    {
        public frmQueryUsingtheQueryExpressionSyntax()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmQueryUsingtheQueryExpressionSyntax
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmQueryUsingtheQueryExpressionSyntax";
            this.Text = "frmQueryUsingtheQueryExpressionSyntax";
            this.Load += new System.EventHandler(this.frmQueryUsingtheQueryExpressionSyntax_Load);
            this.ResumeLayout(false);

        }

        private void frmQueryUsingtheQueryExpressionSyntax_Load(object sender, EventArgs e)
        {

        }
    }
}
