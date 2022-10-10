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
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/IncrementandDecrement.htm
    public partial  class frmIncrementandDecrement:Form
    {
        public frmIncrementandDecrement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIncrementandDecrement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIncrementandDecrement";
            this.Text = "frmIncrementandDecrement";
            this.Load += new System.EventHandler(this.frmIncrementandDecrement_Load);
            this.ResumeLayout(false);

        }

        private void frmIncrementandDecrement_Load(object sender, EventArgs e)
        {

        }
    }
}
