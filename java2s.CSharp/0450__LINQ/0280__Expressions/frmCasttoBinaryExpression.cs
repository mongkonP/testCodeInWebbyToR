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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/CasttoBinaryExpression.htm
    public partial  class frmCasttoBinaryExpression:Form
    {
        public frmCasttoBinaryExpression()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCasttoBinaryExpression
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCasttoBinaryExpression";
            this.Text = "frmCasttoBinaryExpression";
            this.Load += new System.EventHandler(this.frmCasttoBinaryExpression_Load);
            this.ResumeLayout(false);

        }

        private void frmCasttoBinaryExpression_Load(object sender, EventArgs e)
        {

        }
    }
}
