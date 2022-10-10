using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0200__shift_operator
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/TheShiftOperators.htm
    public partial  class frmTheShiftOperators:Form
    {
        public frmTheShiftOperators()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheShiftOperators
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheShiftOperators";
            this.Text = "frmTheShiftOperators";
            this.Load += new System.EventHandler(this.frmTheShiftOperators_Load);
            this.ResumeLayout(false);

        }

        private void frmTheShiftOperators_Load(object sender, EventArgs e)
        {

        }
    }
}
