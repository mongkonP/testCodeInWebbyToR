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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ConciseLambdaExpression.htm
    public partial  class frmConciseLambdaExpression:Form
    {
        public frmConciseLambdaExpression()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConciseLambdaExpression
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConciseLambdaExpression";
            this.Text = "frmConciseLambdaExpression";
            this.Load += new System.EventHandler(this.frmConciseLambdaExpression_Load);
            this.ResumeLayout(false);

        }

        private void frmConciseLambdaExpression_Load(object sender, EventArgs e)
        {

        }
    }
}
