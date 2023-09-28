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
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/Operators.htm
    public partial  class frmOperators:Form
    {
        public frmOperators()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOperators
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOperators";
            this.Text = "frmOperators";
            this.Load += new System.EventHandler(this.frmOperators_Load);
            this.ResumeLayout(false);

        }

        private void frmOperators_Load(object sender, EventArgs e)
        {

        }
    }
}
