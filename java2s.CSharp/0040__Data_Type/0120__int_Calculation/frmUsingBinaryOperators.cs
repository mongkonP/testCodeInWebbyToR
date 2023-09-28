using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0120__int_Calculation
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/UsingBinaryOperators.htm
    public partial  class frmUsingBinaryOperators:Form
    {
        public frmUsingBinaryOperators()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingBinaryOperators
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingBinaryOperators";
            this.Text = "frmUsingBinaryOperators";
            this.Load += new System.EventHandler(this.frmUsingBinaryOperators_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingBinaryOperators_Load(object sender, EventArgs e)
        {

        }
    }
}
