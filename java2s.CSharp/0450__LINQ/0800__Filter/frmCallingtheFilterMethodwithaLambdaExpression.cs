using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0800__Filter
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/CallingtheFilterMethodwithaLambdaExpression.htm
    public partial  class frmCallingtheFilterMethodwithaLambdaExpression:Form
    {
        public frmCallingtheFilterMethodwithaLambdaExpression()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCallingtheFilterMethodwithaLambdaExpression
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCallingtheFilterMethodwithaLambdaExpression";
            this.Text = "frmCallingtheFilterMethodwithaLambdaExpression";
            this.Load += new System.EventHandler(this.frmCallingtheFilterMethodwithaLambdaExpression_Load);
            this.ResumeLayout(false);

        }

        private void frmCallingtheFilterMethodwithaLambdaExpression_Load(object sender, EventArgs e)
        {

        }
    }
}
