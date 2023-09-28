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
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/UsingthePreIncrementOperator.htm
    public partial  class frmUsingthePreIncrementOperator:Form
    {
        public frmUsingthePreIncrementOperator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingthePreIncrementOperator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingthePreIncrementOperator";
            this.Text = "frmUsingthePreIncrementOperator";
            this.Load += new System.EventHandler(this.frmUsingthePreIncrementOperator_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingthePreIncrementOperator_Load(object sender, EventArgs e)
        {

        }
    }
}
