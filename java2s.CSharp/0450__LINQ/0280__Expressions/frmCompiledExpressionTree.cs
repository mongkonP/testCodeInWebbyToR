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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/CompiledExpressionTree.htm
    public partial  class frmCompiledExpressionTree:Form
    {
        public frmCompiledExpressionTree()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCompiledExpressionTree
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCompiledExpressionTree";
            this.Text = "frmCompiledExpressionTree";
            this.Load += new System.EventHandler(this.frmCompiledExpressionTree_Load);
            this.ResumeLayout(false);

        }

        private void frmCompiledExpressionTree_Load(object sender, EventArgs e)
        {

        }
    }
}
