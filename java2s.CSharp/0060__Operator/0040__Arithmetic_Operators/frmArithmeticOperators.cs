using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0040__Arithmetic_Operators
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/ArithmeticOperators.htm
    public partial  class frmArithmeticOperators:Form
    {
        public frmArithmeticOperators()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmArithmeticOperators
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmArithmeticOperators";
            this.Text = "frmArithmeticOperators";
            this.Load += new System.EventHandler(this.frmArithmeticOperators_Load);
            this.ResumeLayout(false);

        }

        private void frmArithmeticOperators_Load(object sender, EventArgs e)
        {

        }
    }
}
