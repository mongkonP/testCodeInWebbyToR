using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0060__Prefix_Postfix_Operator
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/UsingthePostIncrementOperator.htm
    public partial  class frmUsingthePostIncrementOperator:Form
    {
        public frmUsingthePostIncrementOperator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingthePostIncrementOperator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingthePostIncrementOperator";
            this.Text = "frmUsingthePostIncrementOperator";
            this.Load += new System.EventHandler(this.frmUsingthePostIncrementOperator_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingthePostIncrementOperator_Load(object sender, EventArgs e)
        {

        }
    }
}
