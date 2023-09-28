using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0160__Ternary_Operator
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/Theternaryoperator.htm
    public partial  class frmTheternaryoperator:Form
    {
        public frmTheternaryoperator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheternaryoperator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheternaryoperator";
            this.Text = "frmTheternaryoperator";
            this.Load += new System.EventHandler(this.frmTheternaryoperator_Load);
            this.ResumeLayout(false);

        }

        private void frmTheternaryoperator_Load(object sender, EventArgs e)
        {

        }
    }
}
