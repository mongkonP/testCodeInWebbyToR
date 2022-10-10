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
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/TheOperator.htm
    public partial  class frmTheOperator:Form
    {
        public frmTheOperator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheOperator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheOperator";
            this.Text = "frmTheOperator";
            this.Load += new System.EventHandler(this.frmTheOperator_Load);
            this.ResumeLayout(false);

        }

        private void frmTheOperator_Load(object sender, EventArgs e)
        {

        }
    }
}
