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
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/Compoundoperator.htm
    public partial  class frmCompoundoperator:Form
    {
        public frmCompoundoperator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCompoundoperator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCompoundoperator";
            this.Text = "frmCompoundoperator";
            this.Load += new System.EventHandler(this.frmCompoundoperator_Load);
            this.ResumeLayout(false);

        }

        private void frmCompoundoperator_Load(object sender, EventArgs e)
        {

        }
    }
}
